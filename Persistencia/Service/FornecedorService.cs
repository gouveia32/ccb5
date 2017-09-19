using Persistencia.DAO;
using Persistencia.Modelo;
using System;
using System.Collections.Generic;
using System.Transactions;
using System.Windows.Forms;

namespace Persistencia.Service
{
    public class FornecedorService
    {
        private FornecedorDAO fornecedorDAO;
        public FornecedorService()
        {
            fornecedorDAO = new FornecedorDAO();
        }
        public long Inserir(string nomefantasia, string razaosocial, string cnpj, string inscestadual, string cep,
        string logradouro, string bairro, string n, string cidade, string estado, string email, string telefone,
        string celular)
        {
            if (nomefantasia == "")
            {
                MessageBox.Show("Verifique o campo: Nome Fantasia.");
            }
            else if (razaosocial == "")
            {
                MessageBox.Show("Verifique o campo: Razao Social.");
            }
            else if (cnpj == "")
            {
                MessageBox.Show("Verifique o campo: CNPJ.");
            }
            else if (inscestadual == "")
            {
                MessageBox.Show("Verifique o campo: Inscrição Estadual");
            }
            else if (cep == "")
            {
                MessageBox.Show("Verifique o campo: CEP");
            }
            else if (logradouro == "")
            {
                MessageBox.Show("Verifique o campo: Logradouro");
            }
            else if (n == "")
            {
                MessageBox.Show("Verifique o campo: Número");
            }
            else if (cidade == "")
            {
                MessageBox.Show("Verifique o campo: Cidade");
            }
            else if (estado == "")
            {
                MessageBox.Show("Verifique o campo: Estado");
            }
            else if (email == "")
            {
                MessageBox.Show("Verifique o campo: E-mail");
            }
            else if (telefone == "")
            {
                MessageBox.Show("Verifique o campo: Telefone");
            }
            else if (celular == "")
            {
                MessageBox.Show("Verifique o campo: Celular");
            } else
            {
                long id_fornecedor = -1;

                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        Endereco endereco = new Endereco();
                        TelefoneFornecedor telefoneF = new TelefoneFornecedor();
                        Fornecedor fornecedor = new Fornecedor();

                        endereco.CEP = cep;
                        endereco.Logradouro = logradouro;
                        endereco.Bairro = bairro;
                        endereco.Numero = n;
                        endereco.Cidade = cidade;
                        endereco.Estado = estado;

                        telefoneF.Telefone = telefone + ":" + celular;

                        fornecedor.NomeFantasia = nomefantasia;
                        fornecedor.RazaoSocial = razaosocial;
                        fornecedor.CNPJ = cnpj;
                        fornecedor.InscricaoEstadual = inscestadual;
                        fornecedor.Email = email;

                        long id_endereco = new EnderecoDAO().Inserir(endereco);
                        fornecedor.CodigoEndereco = id_endereco;
                        id_fornecedor = new FornecedorDAO().Inserir(fornecedor);
                        telefoneF.CodigoFornecedor = id_fornecedor;
                        new TelefoneFornecedorDAO().Inserir(telefoneF);
                        transaction.Complete();
                    }
                    catch (Exception ex)
                    {
                        return -1;
                    }

                    return id_fornecedor;
                }
            }

            return -1;
        }

        public bool Atualizar(long CodigoFornecedor, string nomefantasia, string razaosocial, string cnpj, string inscestadual, string cep,
       string logradouro, string bairro, string n, string cidade, string estado, string email, string telefone,
       string celular)
        {
            if (nomefantasia == "")
            {
                MessageBox.Show("Verifique o campo: Nome Fantasia.");
            }
            else if (razaosocial == "")
            {
                MessageBox.Show("Verifique o campo: Razao Social.");
            }
            else if (cnpj == "")
            {
                MessageBox.Show("Verifique o campo: CNPJ.");
            }
            else if (inscestadual == "")
            {
                MessageBox.Show("Verifique o campo: Inscrição Estadual");
            }
            else if (cep == "")
            {
                MessageBox.Show("Verifique o campo: CEP");
            }
            else if (logradouro == "")
            {
                MessageBox.Show("Verifique o campo: Logradouro");
            }
            else if (n == "")
            {
                MessageBox.Show("Verifique o campo: Número");
            }
            else if (cidade == "")
            {
                MessageBox.Show("Verifique o campo: Cidade");
            }
            else if (estado == "")
            {
                MessageBox.Show("Verifique o campo: Estado");
            }
            else if (email == "")
            {
                MessageBox.Show("Verifique o campo: E-mail");
            }
            else if (telefone == "")
            {
                MessageBox.Show("Verifique o campo: Telefone");
            }
            else if (celular == "")
            {
                MessageBox.Show("Verifique o campo: Celular");
            } else
            {
                bool atualizar = false;

                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        Fornecedor f = new Fornecedor();
                        Endereco end = new Endereco();
                        TelefoneFornecedor tel = new TelefoneFornecedor();

                        f.CodigoFornecedor = CodigoFornecedor;
                        f.NomeFantasia = nomefantasia;
                        f.RazaoSocial = razaosocial;
                        f.CNPJ = cnpj;
                        f.InscricaoEstadual = inscestadual;
                        f.Email = email;

                        Fornecedor fornecedor = new FornecedorDAO().Buscar(CodigoFornecedor);
                        end.CodigoEndereco = fornecedor.CodigoEndereco;
                        end.CEP = cep;
                        end.Logradouro = logradouro;
                        end.Bairro = bairro;
                        end.Numero = n;
                        end.Cidade = cidade;
                        end.Estado = estado;

                        tel.CodigoFornecedor = CodigoFornecedor;
                        tel.Telefone = telefone + ":" + celular;

                        new FornecedorDAO().Atualizar(f);
                        new EnderecoDAO().Atualizar(end);
                        new TelefoneFornecedorDAO().Atualizar(tel);
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
        public bool Remover(long CodigoFornecedor)
        {
            if (CodigoFornecedor != 0)
            {
                bool remover = false;

                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        Fornecedor f = new Fornecedor();

                        f.CodigoFornecedor = CodigoFornecedor;
                        f.Status = 9;

                        new FornecedorDAO().Remover(f);

                        TelefoneFornecedor tel = new TelefoneFornecedor();

                        tel.CodigoFornecedor = CodigoFornecedor;
                        tel.Status = 9;

                        new TelefoneFornecedorDAO().Remover(tel);

                        Endereco end = new Endereco();

                        Fornecedor fornecedor = new FornecedorDAO().Buscar(CodigoFornecedor);
                        end.CodigoEndereco = fornecedor.CodigoEndereco;
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
        public List<Fornecedor> Buscar(string buscar)
        {
            if(buscar == "Digite Nome Fantasia,Razão Social,CNPJ.") {
                buscar = "";
            }
            List<Fornecedor> fornecedores = new FornecedorDAO().BuscarFornecedor(buscar);
            return fornecedores;

        }

        public List<Fornecedor> Listar()
        {
            List<Fornecedor> fornecedores = new FornecedorDAO().Listar();
            return fornecedores;
        }
        public Fornecedor BuscarFornecedor(long codigofornecedor)
        {
            Fornecedor fornecedor = new FornecedorDAO().Buscar(codigofornecedor);
            return fornecedor;
        }
        public TelefoneFornecedor BuscarTelefone(long codigofornecedor)
        {
            TelefoneFornecedor telefone = new TelefoneFornecedorDAO().Buscar(codigofornecedor);
            return telefone;
        }

        public Endereco BuscarEndereco(long codigoendereco)
        {
            Endereco endereco = new EnderecoDAO().Buscar(codigoendereco);
            return endereco;
        }
       
    }
}