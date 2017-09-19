using Persistencia.DAO;
using Persistencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Persistencia.Service
{
    public class CheckListService
    {
        private CheckListDAO checklistdao;
        private ItemConformidadeDAO itemConforme;
        private VeiculoTemCheckListDAO veiculoCheckList;

        public CheckListService()
        {
            checklistdao = new CheckListDAO();
            itemConforme = new ItemConformidadeDAO();
            veiculoCheckList = new VeiculoTemCheckListDAO();
        }

        public long Inserir(long codigo_veiculo, string observação, int status_check, string data, string[] item)
        {
            long cod_check = -1;

            if (!Verificar(codigo_veiculo))
            {
                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        cod_check = checklistdao.Inserir(new CheckList()
                        {
                            Observacao = observação,
                            Status = status_check
                        });

                        foreach (string value in item)
                        {
                            itemConforme.Inserir(new ItemConformidade()
                            {
                                CodigoCheckList = cod_check,
                                Item = value
                            });
                        }

                        veiculoCheckList.Inserir(new VeiculoTemCheckList()
                        {
                            CodigoCheckList = cod_check,
                            CodigoVeiculo = codigo_veiculo,
                            DataChecagem = data
                        });

                        transaction.Complete();
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            else
            {
                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        cod_check = veiculoCheckList.Buscar(codigo_veiculo).CodigoCheckList;
                        itemConforme.Remover(cod_check);

                        checklistdao.Atualizar(new CheckList()
                        {
                            CodigoCheckList = cod_check,
                            Observacao = observação,
                            Status = status_check
                        });

                        foreach (string value in item)
                        {
                            itemConforme.Inserir(new ItemConformidade()
                            {
                                CodigoCheckList = cod_check,
                                Item = value
                            });
                        }

                        veiculoCheckList.Atualizar(new VeiculoTemCheckList()
                        {
                            CodigoVeiculo = codigo_veiculo,
                            CodigoCheckList = cod_check,
                            DataChecagem = data
                        });

                        transaction.Complete();
                    }
                    catch (Exception)
                    {

                    }
                }
            }

            return cod_check;
        }

        public Dictionary<long, object> Buscar(long cod)
        {
            Dictionary<long, object> result = new Dictionary<long, object>();
            result[0] = veiculoCheckList.Buscar(cod);
            result[1] = checklistdao.Buscar(((VeiculoTemCheckList)result[0]).CodigoCheckList);
            result[2] = itemConforme.Buscar(((CheckList)result[1]).CodigoCheckList);

            return result;
        }

        public bool Verificar(long cod)
        {
            return veiculoCheckList.Verificar(cod);
        }
    }
}
