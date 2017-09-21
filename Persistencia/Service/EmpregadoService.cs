using Persistencia.DAO;
using Persistencia.Modelo;
using System;
using System.Collections.Generic;
using System.Transactions;
using System.Windows.Forms;

namespace Persistencia.Service
{
    public class EmpregadoService
    {
        private EmpregadoDAO empregadoDAO;
        public EmpregadoService()
        {
            empregadoDAO = new EmpregadoDAO();
        }
        public long Inserir(string nome, string cep, string DataNascimento, string DataAdmissao, string DataDemissao,
        string logradouro, string bairro, string n, string cidade, string estado, string email, string telefone,
        string celular)
        {
            if (nome == "")
            {
                MessageBox.Show("Verifique o campo: Nome .");
            }
            else
            {
                long id_empregado = -1;

                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        Endereco endereco = new Endereco();
                        TelefoneEmpregado telefoneE = new TelefoneEmpregado();
                        Empregado empregado = new Empregado();

                        endereco.CEP = cep;
                        endereco.Logradouro = logradouro;
                        endereco.Bairro = bairro;
                        endereco.Numero = n;
                        endereco.Cidade = cidade;
                        endereco.Estado = estado;

                        telefoneE.Telefone = telefone + ":" + celular;

                        empregado.Email = email;

                        long id_endereco = new EnderecoDAO().Inserir(endereco);
                        empregado.EnderecoId = id_endereco;
                        empregado.Nome = nome;
                        empregado.Email = email;
                        empregado.DataNascimento = DataNascimento;
                        empregado.DataAdmissao = DataAdmissao;
                        empregado.DataDemissao = DataDemissao;

                        id_empregado = new EmpregadoDAO().Inserir(empregado);
                        telefoneE.EmpregadoId = id_empregado;
                        new TelefoneEmpregadoDAO().Inserir(telefoneE);
                        transaction.Complete();
                    }
                    catch (Exception ex)
                    {
                        return -1;
                    }

                    return id_empregado;
                }
            }

            return -1;
        }

        public bool Atualizar(long Id, string nome, string cep, DateTime DataNascimento, DateTime DataAdmissao, DateTime DataDemissao,
        string logradouro, string bairro, string n, string cidade, string estado, string email, string telefone,
       string celular)
        {
            if (nome == "")
            {
                MessageBox.Show("Verifique o campo: Nome.");
            }
            else if (telefone == "")
            {
                MessageBox.Show("Verifique o campo: Telefone");
            }
            else
            {
                bool atualizar = false;

                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        Empregado e = new Empregado();
                        Endereco end = new Endereco();
                        TelefoneEmpregado tel = new TelefoneEmpregado();

                        e.Id = Id;
                        e.Nome = nome;
                        e.DataNascimento = DataNascimento.ToString();
                        e.DataAdmissao = DataAdmissao.ToString();
                        e.DataDemissao = DataDemissao.ToString();
                        e.Email = email;

                        Empregado empregado = new EmpregadoDAO().Buscar(Id);
                        end.Id = empregado.EnderecoId;
                        end.CEP = cep;
                        end.Logradouro = logradouro;
                        end.Bairro = bairro;
                        end.Numero = n;
                        end.Cidade = cidade;
                        end.Estado = estado;

                        tel.EmpregadoId = Id;
                        tel.Telefone = telefone + ":" + celular;

                        new EmpregadoDAO().Atualizar(e);
                        new EnderecoDAO().Atualizar(end);
                        new TelefoneEmpregadoDAO().Atualizar(tel);
                        atualizar = true;
                        transaction.Complete();
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }

                    return atualizar;
                }
            }
            return false;

        }
        public bool Remover(long Id)
        {
            if (Id != 0)
            {
                bool remover = false;

                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        Empregado f = new Empregado();

                        f.Id = Id;
                        f.Status = 9;

                        new EmpregadoDAO().Remover(f);

                        TelefoneEmpregado tel = new TelefoneEmpregado();

                        tel.EmpregadoId = Id;
                        tel.Status = 9;

                        new TelefoneEmpregadoDAO().Remover(tel);

                        Endereco end = new Endereco();

                        Empregado empregado = new EmpregadoDAO().Buscar(Id);
                        end.Id = empregado.EnderecoId;
                        end.Status = 9;

                        new EnderecoDAO().Remover(end);
                        remover = true;
                        transaction.Complete();
                    }
                    catch (Exception ex)
                    {

                    }

                    return remover;
                }
            }

            return false;
        }
        public List<Empregado> Buscar(string buscar)
        {
            if (buscar == "Digite Nome Fantasia,Razão Social,CNPJ.")
            {
                buscar = "";
            }
            List<Empregado> empregadoes = new EmpregadoDAO().BuscarEmpregado(buscar);
            return empregadoes;

        }

        public List<Empregado> Listar()
        {
            List<Empregado> empregadoes = new EmpregadoDAO().Listar();
            return empregadoes;
        }
        public Empregado BuscarEmpregado(long codigoempregado)
        {
            Empregado empregado = new EmpregadoDAO().Buscar(codigoempregado);
            return empregado;
        }
        public TelefoneEmpregado BuscarTelefone(long codigoempregado)
        {
            TelefoneEmpregado telefone = new TelefoneEmpregadoDAO().Buscar(codigoempregado);
            return telefone;
        }

        public Endereco BuscarEndereco(long codigoendereco)
        {
            Endereco endereco = new EnderecoDAO().Buscar(codigoendereco);
            return endereco;
        }

    }
}