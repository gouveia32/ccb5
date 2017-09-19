using Persistencia.DAO;
using Persistencia.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Persistencia.Service
{

    public class CategoriaService
    {
        private CategoriaDAO categoriaDAO;
        public CategoriaService()
        {
            categoriaDAO = new CategoriaDAO();
        }
        public long Inserir(string nome, string valor)
        {
                    long id_categoria = -1;
            if (nome != "" && valor != "")
            {
                Categoria categoria = new Categoria();

                categoria.Nome = nome;
                categoria.Valor = decimal.Parse(valor);
                categoria.Status = 1;
                id_categoria = new CategoriaDAO().Inserir(categoria);
                return id_categoria;
            } 
        return -1;
        }
        public bool Atualizar(long codcategoria, string nome, string valor)
        {
            bool atualizar = false;
            if (nome != "" && valor != "")
            {
                Categoria categoria = new Categoria();
                categoria.CodigoCategoria = codcategoria;
                categoria.Nome = nome;
                categoria.Valor = Decimal.Parse(valor);
                new CategoriaDAO().Atualizar(categoria);
                atualizar = true;
                return atualizar;
            }
            return atualizar; 
        }
        public bool Remover(long codcategoria)
        {
            bool remover = false;
            if (codcategoria != 0)
            {
                Categoria categoria = new Categoria();

                categoria.CodigoCategoria = codcategoria;
                categoria.Status = 9;

                new CategoriaDAO().Remover(categoria);
                remover = true;
                return remover;
            }
          else  return remover;
        }

        public Categoria Buscar(long codcategoria)
        {
            Categoria categoria = new CategoriaDAO().Buscar(codcategoria);
            return categoria;
        }
        public List<Categoria> Pesquisar(string busca)
        {
            if (busca == "Digite Nome,Valor.")
            {
                busca = "";
            }
            List<Categoria> categorias = new CategoriaDAO().Pesquisar(busca);
            return categorias;
        }

        public List<Categoria> Listar()
        {
            List<Categoria> categorias = new CategoriaDAO().Listar();
            return categorias;
        }
    }
}
    

