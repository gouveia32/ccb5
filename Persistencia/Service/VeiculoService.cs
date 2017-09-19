using Persistencia.DAO;
using Persistencia.Modelo;
using Persistencia.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Persistencia.Service
{
    public class VeiculoService
    {
        private VeiculoDAO veiculoDAO;
        public VeiculoService()
        {
            veiculoDAO = new VeiculoDAO();
        }

        public Veiculo BuscarVeiculo(long codigoVeiculo)
        {
            Veiculo veiculo = new VeiculoDAO().Buscar(codigoVeiculo);
            return veiculo;
        }

        public List<Veiculo> Listar()
        {
            List<Veiculo> veiculos = new VeiculoDAO().Listar();
            return veiculos;
        }

        public List<Veiculo> ListarReserva()
        {
            List<Veiculo> veiculos = new VeiculoDAO().ListarReserva();
            return veiculos;
        }

        public Documento BuscarDocumento(long codigoVeiculo)
        {
            Documento documentoVeiculo = new DocumentoDAO().Buscar(codigoVeiculo);
            return documentoVeiculo;
        }

        public VeiculoTemFornecedor VeiculoTemFornecedor(long codigo)
        {
            VeiculoTemFornecedor veiculofornecedor = new VeiculoTemFornecedorDAO().Buscar(codigo);

            return veiculofornecedor;
            
        }

        public List<Veiculo> Pesquisar(string busca)
        {
            if (busca == "Digite Marca ou Modelo.")
            {
                busca = "";
            }
            return new VeiculoDAO().Pesquisar(busca);
        }

        public bool Atualizar(long codVeiculo, long codCategoria, long codFornecedor, String marca, String modelo, String km, String AnoFabricacao, bool vidro, bool trava, bool automatico, int quantidadePortas, bool direcao, bool ar, String cor, String combustivel, String tanque, long categoria, String placa, String renavam, String chassi, String mesDataLicenciamento, String anoDataLicenciamento)
        {

            if (codCategoria == -1 || codCategoria == 0)
            {
                MessageBox.Show("Verifique o campo: Categoria");
            }
            else if (codFornecedor == -1 || codFornecedor == 0)
            {
                MessageBox.Show("Verifique o campo: Fornecedor");
            }
            else if (marca == "")
            {
                MessageBox.Show("Verifique o campo: marca");
            }
            else if (modelo == "")
            {
                MessageBox.Show("Verifique o campo: modelo");
            }
            else if (km == "")
            {
                MessageBox.Show("Verifique o campo: KM");
            }
            else if (AnoFabricacao == "")
            {
                MessageBox.Show("Verifique o campo: Ano de Fabricação");
            }

            else if (cor == "")
            {
                MessageBox.Show("Verifique o campo: Cor");
            }

            else if (combustivel == "")
            {
                MessageBox.Show("Verifique o campo: combustível");
            }

            else if (tanque == "")
            {
                MessageBox.Show("Verifique o campo: tanque");
            }

            else if (placa == "")
            {
                MessageBox.Show("Verifique o campo: Placa");
            }

            else if (renavam == "")
            {
                MessageBox.Show("Verifique o campo: Renavam");
            }

            else if (chassi == "")
            {
                MessageBox.Show("Verifique o campo: Chassi");
            }

            else if (mesDataLicenciamento == "")
            {
                MessageBox.Show("Verifique o campo: Mês Licenciamento");
            }
            else if (anoDataLicenciamento == "")
            {
                MessageBox.Show("Verifique o campo: Ano Licenciamento");
            }
            else
            {
                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {

                        Veiculo veiculo = new Veiculo();
                        Documento documento = new Documento();
                        VeiculoTemFornecedor veiculoFornecedor = new VeiculoTemFornecedor();

                        //Veiculo
                        veiculo.CodigoVeiculo = codVeiculo;
                        veiculo.Marca = marca;
                        veiculo.Modelo = modelo;
                        veiculo.KM = km;
                        veiculo.AnoFabricacao = AnoFabricacao;
                        veiculo.VidroEletrico = vidro;
                        veiculo.TravaEletrica = trava;
                        veiculo.Automatico = automatico;
                        veiculo.QuantidadePortas = quantidadePortas;
                        veiculo.DirecaoHidraulica = direcao;
                        veiculo.ArCondicionado = ar;
                        veiculo.Cor = cor;
                        veiculo.CodigoCategoria = categoria;
                        veiculo.Combustivel = combustivel;
                        veiculo.Tanque = tanque;
                        veiculo.Status = 1;

                        //Documento
                        documento.Placa = placa;
                        documento.Renavam = renavam;
                        documento.CodigoVeiculo = codVeiculo;
                        documento.MesDataLicenciamento = mesDataLicenciamento;
                        documento.AnoDataLicenciamento = anoDataLicenciamento;
                        documento.Chassi = chassi;
                        documento.Status = 1;
                        Documento documentoCod = new DocumentoDAO().Buscar(codVeiculo);
                        documento.CodigoDocumento = documentoCod.CodigoDocumento;

                        //VeiculoTemFornecedor
                        VeiculoTemFornecedor docCodigo = new VeiculoTemFornecedorDAO().Buscar(codVeiculo);
                        veiculoFornecedor.CodigoVeiculoTemFornecedor = docCodigo.CodigoVeiculoTemFornecedor;
                        veiculoFornecedor.CodigoFornecedor = codFornecedor;
                        veiculoFornecedor.CodigoVeiculo = codVeiculo;
                        veiculoFornecedor.Status = 1;

                        new VeiculoDAO().Atualizar(veiculo);
                        new DocumentoDAO().Atualizar(documento);
                        new VeiculoTemFornecedorDAO().Atualizar(veiculoFornecedor);

                        transaction.Complete();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Houve um erro " + ex);
                        return false;
                    }
                }
            }
            return false;
        }

        public bool Remover(long CodigoVeiculo)
        {
            if (CodigoVeiculo != 0)
            {

                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        Veiculo veiculo = new Veiculo();

                        veiculo.CodigoVeiculo = CodigoVeiculo;
                        veiculo.Status = 9;

                        new VeiculoDAO().Remover(veiculo);

                        VeiculoTemFornecedor veiculoTemFornecedor = new VeiculoTemFornecedor();

                        veiculoTemFornecedor.CodigoVeiculo = CodigoVeiculo;
                        veiculoTemFornecedor.Status = 9;

                        new VeiculoTemFornecedorDAO().Remover(veiculoTemFornecedor);

                        Documento documento = new Documento();

                        documento.CodigoVeiculo = CodigoVeiculo;
                        documento.Status = 9;

                        new DocumentoDAO().Remover(documento);

                        transaction.Complete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }

                    return true;
                }
            }

            return false;
        }

        public long Inserir(String marca, String modelo, String km, String AnoFabricacao, bool vidro, bool trava, bool automatico, int quantidadePortas, bool direcao, bool ar, String cor, String combustivel, String tanque, long categoria, String placa, String renavam, String chassi, String mesDataLicenciamento, String anoDataLicenciamento, long fornecedor)
        {

            if(marca == "")
            {
                MessageBox.Show("Verifique o campo: marca");

            } else if (modelo == "")
            {
                MessageBox.Show("Verifique o campo: modelo");

            } else if (km == "") {

                MessageBox.Show("Verifique o campo: km");

            } else if (AnoFabricacao == "")
            {
                MessageBox.Show("Verifique o campo: AnoFabricacao");

            } else if (cor == "")
            {
                MessageBox.Show("Verifique o campo: cor");

            } else if (combustivel == "")
            {
                MessageBox.Show("Verifique o campo: combustivel");
            }
            else if (tanque == "")
            {
                MessageBox.Show("Verifique o campo: tanque");
            }
            else if (categoria == 0 || categoria == -1)
            {
                MessageBox.Show("Verifique o campo: categoria");
            }
            else if (placa == "")
            {
                MessageBox.Show("Verifique o campo: placa");
            }
            else if (renavam == "")
            {
                MessageBox.Show("Verifique o campo: renavam");
            }
            else if (chassi == "")
            {
                MessageBox.Show("Verifique o campo: chassi");

            } else if (mesDataLicenciamento == "")
            {
                MessageBox.Show("Verifique o campo: mesDataLicenciamento");

            } else if (anoDataLicenciamento == "")
            {
                MessageBox.Show("Verifique o campo: anoDataLicenciamento");

            } else if (fornecedor == 0 || fornecedor == -1)
            {
                MessageBox.Show("Verifique o campo: fornecedor");

            } else { 
            
                long id_veiculo = -1;

                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        Veiculo veiculo = new Veiculo();
                        Documento documento = new Documento();
                        VeiculoTemFornecedor veiculoFornecedor = new VeiculoTemFornecedor();

                        //Veiculo
                        veiculo.Marca = marca;
                        veiculo.Modelo = modelo;
                        veiculo.KM = km;
                        veiculo.AnoFabricacao = AnoFabricacao;
                        veiculo.VidroEletrico = vidro;
                        veiculo.TravaEletrica = trava;
                        veiculo.Automatico = automatico;
                        veiculo.QuantidadePortas = quantidadePortas;
                        veiculo.DirecaoHidraulica = direcao;
                        veiculo.ArCondicionado = ar;
                        veiculo.Cor = cor;
                        veiculo.CodigoCategoria = categoria;
                        veiculo.Combustivel = combustivel;
                        veiculo.Tanque = tanque;
                        veiculo.Status = 1;

                        id_veiculo = veiculoDAO.Inserir(veiculo);

                        //Documento
                        documento.Placa = placa;
                        documento.Renavam = renavam;
                        documento.CodigoVeiculo = id_veiculo;
                        documento.MesDataLicenciamento = mesDataLicenciamento;
                        documento.AnoDataLicenciamento = anoDataLicenciamento;
                        documento.Chassi = chassi;
                        documento.Status = 1;

                        long id_documento = new DocumentoDAO().Inserir(documento);

                        //VeiculoTemFornecedor
                        veiculoFornecedor.CodigoFornecedor = fornecedor;
                        veiculoFornecedor.CodigoVeiculo = id_veiculo;
                        veiculoFornecedor.Status = 1;

                        long idVeiculoTemFornecedor = new VeiculoTemFornecedorDAO().Inserir(veiculoFornecedor);

                        transaction.Complete();

                    }

                    catch (TransactionException)
                    {

                    }
                }
                return id_veiculo;
            }

            return -1;

        }

    }
}
