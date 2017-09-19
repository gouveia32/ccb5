using Persistencia.DAO;
using Persistencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Persistencia.Service
{
    public class ClienteService
    {
        private ClienteDAO clienteDAO;
        private EnderecoDAO enderecoDAO;
        private PessoaFisicaDAO pFisicaDAO;
        private PessoaJuridicaDAO pJuridicaDAO;
        private TelefoneClienteDAO telefoneClienteDAO;
        private TelefoneFornecedorDAO telefoneFornecedorDAO;
        public ClienteService()

        {
            clienteDAO = new ClienteDAO();
            enderecoDAO = new EnderecoDAO();
            pFisicaDAO = new PessoaFisicaDAO();
            pJuridicaDAO = new PessoaJuridicaDAO();
            telefoneClienteDAO = new TelefoneClienteDAO();
            telefoneFornecedorDAO = new TelefoneFornecedorDAO();
        }

        public List<Cliente> Listar()
        {
            List<Cliente> clientes = new ClienteDAO().Listar();
            clientes.Reverse();
            return clientes;
        }

        public List<PessoaFisica> ListarPessoaFisica()
        {
            List<PessoaFisica> clientes = new PessoaFisicaDAO().Listar();
            return clientes;
        }

        public List<PessoaJuridica> ListarPessoaJuridica()
        {
            List<PessoaJuridica> clientes = new PessoaJuridicaDAO().Listar();
            return clientes;
        }

        public Cliente Buscar(long codCliente)
        {
            Cliente cliente = new ClienteDAO().Buscar(codCliente);
            return cliente;
        }

        public Endereco BuscarEndereco(long codEndereco)
        {
            Endereco endereco = new EnderecoDAO().Buscar(codEndereco);
            return endereco;
        }

        public TelefoneCliente BuscarTelefoneCliente(long cod)
        {
            TelefoneCliente telefoneCliente = new TelefoneClienteDAO().BuscarTelefoneCliente(cod);
            return telefoneCliente;
        }

        public TelefoneCliente BuscarTelefoneFornecedor(long cod)
        {
            TelefoneCliente telefoneFornecedor = new TelefoneClienteDAO().BuscarTelefoneFornecedor(cod);
            return telefoneFornecedor;
        }

        public PessoaFisica BuscarPessoaFisica(long codCliente)
        {
            PessoaFisica pessoaFisica = new PessoaFisicaDAO().BuscarPorCliente(codCliente);

            return pessoaFisica;
        }

        public PessoaJuridica BuscarPessoaJuridica(long codCliente)
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridicaDAO().BuscarPorCliente(codCliente);

            return pessoaJuridica;
        }

        public long Inserir(bool pessoaFisica, bool pessoaJuridica, String nomeFantasia, String razaoSocial, String cnpj, String InscEstadual, String nome, String rg, String cnh, string passaporte, string cpf, string naturalidade, string dataNascimento, string cep, string bairro, string telefone, string email, string logradouro, string numero, string cidade, string estado)
        {

            long id_endereco = -1;
            long id_cliente = -1;
            long id_pessoaFisica = -1;
            long id_pessoaJuridica = -1;
            long id_telefoneCliente = -1;
            long id_telefoneFornecedor = -1;

            if (pessoaFisica == true)
            {
                if (nome == "")
                {
                    MessageBox.Show("Verifique o campo: Nome");
                }
                else if (rg == "")
                {
                    MessageBox.Show("Verifique o campo: RG");
                }
                else if (cnh == "")
                {
                    MessageBox.Show("Verifique o campo: CNH");
                }
                else if (cpf == "")
                {
                    MessageBox.Show("Verifique o campo: CPF");
                }
                else if (naturalidade == "")
                {
                    MessageBox.Show("Verifique o campo: Naturalidade");
                }
                else if (dataNascimento == "")
                {
                    MessageBox.Show("Verifique o campo: Data Nascimento");
                }
                else if (cep == "")
                {
                    MessageBox.Show("Verifique o campo: CEP");
                }
                else if (bairro == "")
                {
                    MessageBox.Show("Verifique o campo: Bairro");
                }
                else if (telefone == "")
                {
                    MessageBox.Show("Verifique o campo: Telefone");
                }
                else if (email == "")
                {
                    MessageBox.Show("Verifique o campo: E-Mail");
                }
                else if (logradouro == "")
                {
                    MessageBox.Show("Verifique o campo: Logradouro");
                }
                else if (numero == "")
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
                 else
                {
                    using (TransactionScope transaction = new TransactionScope())
                    {
                        try
                        {
                            Cliente cliente = new Cliente();
                            PessoaFisica pFisica = new PessoaFisica();
                            Endereco endereco = new Endereco();
                            TelefoneCliente telefoneCliente = new TelefoneCliente();

                            endereco.Bairro = bairro;
                            endereco.CEP = cep;
                            endereco.Cidade = cidade;
                            endereco.Estado = estado;
                            endereco.Logradouro = logradouro;
                            endereco.Numero = numero;
                            endereco.Status = 1;

                            id_endereco = enderecoDAO.Inserir(endereco);

                            cliente.CodigoEndereco = id_endereco;
                            cliente.Email = email;
                            cliente.Status = 1;

                            id_cliente = clienteDAO.Inserir(cliente);

                            pFisica.CNH = cnh;
                            pFisica.CodigoCliente = id_cliente;
                            pFisica.CPF = cpf;
                            pFisica.DataNascimento = dataNascimento;
                            pFisica.Naturalidade = naturalidade;
                            pFisica.Nome = nome;
                            pFisica.Passaporte = passaporte;
                            pFisica.RG = rg;
                            pFisica.Status = 1;

                            id_pessoaFisica = pFisicaDAO.Inserir(pFisica);

                            telefoneCliente.CodigoCliente = pFisica.CodigoCliente;
                            telefoneCliente.Telefone = telefone;

                            telefoneCliente.Status = 1;

                            id_telefoneCliente = telefoneClienteDAO.Inserir(telefoneCliente);

                            transaction.Complete();
                        }
                        catch (TransactionException)
                        {
                            return -1;
                        }
                    }


                }
            }
            else if (pessoaJuridica == true)
            {
                if (nomeFantasia == "")
                {
                    MessageBox.Show("Verifique o campo: Nome Fantasia");
                }
                else if (razaoSocial == "")
                {
                    MessageBox.Show("Verifique o campo: Razao Social");
                }
                else if (cnpj == "")
                {
                    MessageBox.Show("Verifique o campo: CNPJ");
                }
                else if (InscEstadual == "")
                {
                    MessageBox.Show("Verifique o campo: Inscrição Estadual");
                }
                else if (cep == "")
                {
                    MessageBox.Show("Verifique o campo: CEP");
                }
                else if (bairro == "")
                {
                    MessageBox.Show("Verifique o campo: Bairro");
                }
                else if (telefone == "")
                {
                    MessageBox.Show("Verifique o campo: Telefone");
                }
                else if (email == "")
                {
                    MessageBox.Show("Verifique o campo: E-mail");
                }
                else if (logradouro == "")
                {
                    MessageBox.Show("Verifique o campo: Logradouro");
                }
                else if (numero == "")
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
                } else
                {
                    using (TransactionScope transaction = new TransactionScope())
                    {
                        try
                        {
                            Cliente cliente = new Cliente();
                            PessoaJuridica pJuridica = new PessoaJuridica();
                            Endereco endereco = new Endereco();
                            TelefoneFornecedor telefoneFornecedor = new TelefoneFornecedor();


                            endereco.Bairro = bairro;
                            endereco.CEP = cep;
                            endereco.Cidade = cidade;
                            endereco.Estado = estado;
                            endereco.Logradouro = logradouro;
                            endereco.Numero = numero;
                            endereco.Status = 1;

                            id_endereco = enderecoDAO.Inserir(endereco);

                            cliente.CodigoEndereco = id_endereco;
                            cliente.Email = email;
                            cliente.Status = 1;

                            id_cliente = clienteDAO.Inserir(cliente);

                            pJuridica.CNPJ = cnpj;
                            pJuridica.CodigoCliente = id_cliente;
                            pJuridica.InscricaoEstadual = InscEstadual;
                            pJuridica.NomeFantasia = nomeFantasia;
                            pJuridica.RazaoSocial = razaoSocial;
                            pJuridica.Status = 1;

                            id_pessoaJuridica = pJuridicaDAO.Inserir(pJuridica);

                            telefoneFornecedor.CodigoFornecedor = pJuridica.CodigoCliente;
                            telefoneFornecedor.Telefone = telefone;
                            telefoneFornecedor.Status = 1;

                            id_telefoneFornecedor = telefoneClienteDAO.InserirTelefoneFornecedor(telefoneFornecedor);

                            transaction.Complete();
                        }
                        catch (TransactionException)
                        {

                        }
                    }

                }
            }

            return id_cliente;

        }

        public bool Atualizar(long codigoCliente, bool pessoaFisica, bool pessoaJuridica, string cpf, string rg, string cnh, string naturalidade, string passaporte, string dataNascimento, string nome, string telefone, string inscricaoEstadual, string cnpj, string razaoSocial, string nomeFantasia, string email, string estado, string cep, string bairro, string cidade, string logradouro, string numero)
        {
            if ((pessoaFisica == true) && (codigoCliente != 0))
            {
                if (nome == "")
                {
                    MessageBox.Show("Verifique o campo: Nome");
                }
                else if (rg == "")
                {
                    MessageBox.Show("Verifique o campo: RG");
                }
                else if (cnh == "")
                {
                    MessageBox.Show("Verifique o campo: CNH");
                }
                
                else if (cpf == "")
                {
                    MessageBox.Show("Verifique o campo: CPF");
                }
                else if (naturalidade == "")
                {
                    MessageBox.Show("Verifique o campo: Naturalidade");
                }
                else if (dataNascimento == "")
                {
                    MessageBox.Show("Verifique o campo: Data de Nascimento");
                }
                else if (cep == "")
                {
                    MessageBox.Show("Verifique o campo: CEP");
                }
                else if (bairro == "")
                {
                    MessageBox.Show("Verifique o campo: Bairro");
                }
                else if (telefone == "")
                {
                    MessageBox.Show("Verifique o campo: Telefone");
                }
                else if (email == "")
                {
                    MessageBox.Show("Verifique o campo: E-mail");
                }
                else if (logradouro == "")
                {
                    MessageBox.Show("Verifique o campo: Logradouro");
                }
                else if (numero == "")
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
                } else
                {
                    using (TransactionScope transaction = new TransactionScope())
                    {
                        try
                        {

                            Cliente cliente = new Cliente();
                            PessoaFisica pFisica = new PessoaFisica();
                            Endereco endereco = new Endereco();
                            TelefoneCliente telefoneCliente = new TelefoneCliente();

                            cliente.CodigoCliente = codigoCliente;

                            pFisica.CNH = cnh;
                            pFisica.CodigoCliente = cliente.CodigoCliente;
                            pFisica.CPF = cpf;
                            pFisica.DataNascimento = dataNascimento;
                            pFisica.Naturalidade = naturalidade;
                            pFisica.Nome = nome;
                            pFisica.Passaporte = passaporte;
                            pFisica.RG = rg;
                            pFisica.Status = 1;

                            endereco.Bairro = bairro;
                            endereco.CEP = cep;
                            endereco.Cidade = cidade;
                            endereco.Estado = estado;
                            endereco.Logradouro = logradouro;
                            endereco.Numero = numero;
                            endereco.Status = 1;

                            Cliente clienteCodEnd = new ClienteDAO().Buscar(cliente.CodigoCliente);
                            endereco.CodigoEndereco = clienteCodEnd.CodigoEndereco;

                            telefoneCliente.CodigoCliente = cliente.CodigoCliente;
                            telefoneCliente.Telefone = telefone;
                            telefoneCliente.Status = 1;

                            new PessoaFisicaDAO().AtualizarPorCliente(pFisica);
                            new EnderecoDAO().Atualizar(endereco);
                            new TelefoneClienteDAO().AtualizarPessoaFisica(telefoneCliente);

                            transaction.Complete();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Houve um erro " + ex);
                        }
                    }
                    return true;
                }

                return false;

            }
            else if ((pessoaJuridica == true) && (codigoCliente != 0))
            {
                if (nomeFantasia == "")
                {
                    MessageBox.Show("Verifique o campo: Nome Fantasia");
                }
                else if (razaoSocial == "")
                {
                    MessageBox.Show("Verifique o campo: Razao Social");
                }
                else if (cnpj == "")
                {
                    MessageBox.Show("Verifique o campo: CNPJ");
                }
                else if (inscricaoEstadual == "")
                {
                    MessageBox.Show("Verifique o campo: Inscricao Estadual");
                }
                else if (cep == "" && cep == " - ")
                {
                    MessageBox.Show("Verifique o campo: CEP");
                }
                else if (bairro == "")
                {
                    MessageBox.Show("Verifique o campo: Bairro");
                }
                else if (telefone == "")
                {
                    MessageBox.Show("Verifique o campo: Telefone");
                }
                else if (email == "")
                {
                    MessageBox.Show("Verifique o campo: E-mail");
                }
                else if (logradouro == "")
                {
                    MessageBox.Show("Verifique o campo: Logradouro");
                }
                else if (numero == "")
                {
                    MessageBox.Show("Verifique o campo: Numero");
                }
                else if (cidade == "")
                {
                    MessageBox.Show("Verifique o campo: Cidade");
                }
                else if (estado == "")
                {
                    MessageBox.Show("Verifique o campo: Estado");
                } else
                {
                    using (TransactionScope transaction = new TransactionScope())
                    {
                        try
                        {

                            Cliente cliente = new Cliente();
                            PessoaJuridica pJuridica = new PessoaJuridica();
                            Endereco endereco = new Endereco();
                            TelefoneFornecedor telefoneFornecedor = new TelefoneFornecedor();

                            cliente.CodigoCliente = codigoCliente;
                            
                            pJuridica.CNPJ = cnpj;
                            pJuridica.CodigoCliente = cliente.CodigoCliente;
                            pJuridica.InscricaoEstadual = inscricaoEstadual;
                            pJuridica.NomeFantasia = nomeFantasia;
                            pJuridica.RazaoSocial = razaoSocial;
                            pJuridica.Status = 1;
                            
                            endereco.Bairro = bairro;
                            endereco.CEP = cep;
                            endereco.Cidade = cidade;
                            endereco.Estado = estado;
                            endereco.Logradouro = logradouro;
                            endereco.Numero = numero;
                            endereco.Status = 1;
                            
                            Cliente clienteCodEnd = new ClienteDAO().Buscar(cliente.CodigoCliente);
                            endereco.CodigoEndereco = clienteCodEnd.CodigoEndereco;
                            
                            cliente.CodigoEndereco = endereco.CodigoEndereco;
                            cliente.Email = email;
                            cliente.Status = 1;
                            
                            telefoneFornecedor.CodigoFornecedor = pJuridica.CodigoCliente;
                            telefoneFornecedor.Telefone = telefone;
                            telefoneFornecedor.Status = 1;
                            
                            new PessoaJuridicaDAO().AtualizarPorCliente(pJuridica);
                            new EnderecoDAO().Atualizar(endereco);
                            new TelefoneClienteDAO().AtualizarPessoaJuridica(telefoneFornecedor);
                            
                            transaction.Complete();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Houve um erro " + ex);
                        }
                    }
                    return true;
                }
       
            }
            return false;
        }

        public bool Remover(long codigoCliente)
{

           if (codigoCliente != 0)
            {

                 using (TransactionScope transaction = new TransactionScope())
                 {
                   try
                     {
                         Cliente cliente = new Cliente();
 
                         cliente.CodigoCliente = codigoCliente;
                        cliente.Status = 9;

                        string tipoPessoa = TipoDePessoa(codigoCliente);
 
                         if (tipoPessoa == "PF")
                         {
                             PessoaFisicaDAO pessoaFisicaDAO = new PessoaFisicaDAO();
                             PessoaFisica pessoaFisica = pessoaFisicaDAO.BuscarPorCliente(codigoCliente);
 
                             pessoaFisica.Status = 9;
 
                            pessoaFisicaDAO.Remover(pessoaFisica);
 
                         } else if (tipoPessoa == "PJ")
                         {
                             PessoaJuridicaDAO pessoaJuridicaDAO = new PessoaJuridicaDAO();
                             PessoaJuridica pessoaJuridica = pessoaJuridicaDAO.BuscarPorCliente(codigoCliente);
 
                             pessoaJuridica.Status = 9;
 
                             pessoaJuridicaDAO.Remover(pessoaJuridica);
                         }
 
                         clienteDAO.Remover(cliente);
 
                         transaction.Complete();
                    }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Erro: " + ex);
                     }
 
                }
 
 
                 return true;
             }
             else
             {
                 return false;
             }
 
            
         }
 
         public string TipoDePessoa(long codigoCliente)
         {
             if (codigoCliente != 0)
             {
 
                 if (new PessoaFisicaDAO().BuscarPorClienteTipo(codigoCliente) == true)
                 {
                     return "PF";
                }
                 else if (new PessoaJuridicaDAO().BuscarPorClienteTipo(codigoCliente) == true)
                {
                     return "PJ";
                 }
                 else
                 {
                     return "";
                 }
    
             }
             else
             {
                 return "";
             }
         }
      }
  }