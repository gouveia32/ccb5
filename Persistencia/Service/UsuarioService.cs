using MySql.Data.MySqlClient;
using Persistencia.DAO;
using Persistencia.Interface;
using Persistencia.Modelo;
using Persistencia.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Persistencia.Service
{
    public class UsuarioService
    {
        private UsuarioDAO userDAO;

        public UsuarioService()
        {
            userDAO = new UsuarioDAO();
        }

        public long Inserir(string nome, string rg, string cpf, string login, string senha)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                long id_user = -1;
                try
                {
                    
                    if (nome != "" && rg != "" && cpf != "" && login != "" && senha != "")
                    {
                        if (new Validation().ValidateCPF(cpf))
                        {
                            Permissao permissao = new Permissao();
                            permissao.Tipo = 0;
                            permissao.Descricao = "Comum";

                            Usuario user = new Usuario();
                            user.Nome = nome;
                            user.RG = rg;
                            user.CPF = cpf;
                            user.Login = login;
                            user.Senha = senha;
                            user.CodigoPermissao = new PermissaoDAO().Inserir(permissao);
                            id_user = userDAO.Inserir(user);
                        }
                    }
                    
                    transaction.Complete();
                    return id_user;
                }

                catch (TransactionException ex)
                {

                    
                }
                return id_user;            }
        }

        public bool Atualizar(long codpermissao,long cod_user, string nome, string rg, string cpf, string login, string senha, string combopermissao)
        {
            bool atualizar = false;
            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    if (nome != "" && rg != "" && cpf != "" && login != "" && senha != "" && combopermissao != "")
                    {
                        if (new Validation().ValidateCPF(cpf))
                        {
                            Permissao permissao = new Permissao();
                            permissao.CodigoPermissao = codpermissao;
                            permissao.Status = 1;
                            permissao.Tipo = (combopermissao == "Administrador") ? 1 : 0;
                            permissao.Descricao = (permissao.Tipo == 1) ? "Administrador" : "Comum";

                            Usuario user = new Usuario();
                            user.CodigoUsuario = cod_user;
                            user.Nome = nome;
                            user.RG = rg;
                            user.CPF = cpf;
                            user.Login = login;
                            user.Senha = senha;
                            user.CodigoPermissao = codpermissao;
                            new PermissaoDAO().Atualizar(permissao);
                            new UsuarioDAO().Atualizar(user);
                            atualizar = true;
                            transaction.Complete();
                            return atualizar;
                            
                        }
                        
                    }
                }
                catch (TransactionException)
                {
                }
            }

            return atualizar;
        }

        public bool Remover(long cod_user)
        {
            bool remover = false;
            Usuario user = new Usuario();
            user.CodigoUsuario = cod_user;
            user.Status = 9;
            if (userDAO.Remover(user))
            {
                remover = true;
                return remover;
            }
            return remover;
        }

        public bool Inativar(long cod_user)
        {
            Usuario user = new Usuario();
            user.CodigoUsuario = cod_user;
            user.Status = 2;
            return userDAO.Remover(user);
        }

        public bool Ativar(long cod_user)
        {
            Usuario user = new Usuario();
            user.CodigoUsuario = cod_user;
            user.Status = 1;
            return userDAO.Remover(user);
        }

        public bool Autenticar(string login, string senha)
        {
            foreach (Usuario user in Listar())
                if (user.Login.Equals(login) && user.Senha.Equals(senha))
                    return true;
            return false;
        }

        public Usuario Busca(long id)
        {
            foreach (Usuario user in Listar())
                if (user.CodigoUsuario.Equals(id))
                    return user;
            return null;
        }

        public Permissao BuscarPermissao(long id)
        {
            foreach (Permissao permissao in ListarPermissao())
                if (permissao.CodigoPermissao.Equals(id))
                    return permissao;
            return null;
        }

        public List<Usuario> Listar()
        {
            return userDAO.Listar();
        }

        public List<Usuario> Pesquisar(string busca)
        {
            if (busca == "Digite Nome,Usuário,CPF,RG.")
            {
                busca = "";
            }
            return new UsuarioDAO().Pesquisar(busca);
        }

        public List<Permissao> ListarPermissao()
        {
            PermissaoDAO permissaoDao = new PermissaoDAO();
            return permissaoDao.Listar();
        }

        public Usuario BuscaNome(string nome)
        {
          return new UsuarioDAO().BuscarNome(nome);
        }
    }
}