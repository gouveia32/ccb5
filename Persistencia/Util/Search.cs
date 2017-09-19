using Persistencia.DAO;
using Persistencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Util
{
    public class Search
    {
        public List<PessoaFisica> PessoaFisica(string valor)
        {
            List<PessoaFisica> pessoas = new List<PessoaFisica>();

            foreach (PessoaFisica pessoafisica in new PessoaFisicaDAO().Listar())
            {
                if (pessoafisica.Nome.ToLower().Contains(valor) || pessoafisica.CPF.ToLower().Contains(valor) || pessoafisica.RG.ToLower().Contains(valor))
                {
                    pessoas.Add(pessoafisica);
                }
            }

            return pessoas;
        }

        public List<Empregado> Empregado(string valor)
        {
            List<Empregado> empregados = new List<Empregado>();

            foreach (Empregado empregado in new EmpregadoDAO().Listar())
            {
                if (empregado.Nome.ToLower().Contains(valor))
                {
                    empregados.Add(empregado);
                }
            }
            return empregados;
        }

        public List<PessoaJuridica> PessoaJuridica(string valor)
        {
            List<PessoaJuridica> pessoas = new List<PessoaJuridica>();

            foreach (PessoaJuridica pessoajuridica in new PessoaJuridicaDAO().Listar())
            {
                if (pessoajuridica.NomeFantasia.ToLower().Contains(valor) || pessoajuridica.CNPJ.ToLower().Contains(valor) || pessoajuridica.RazaoSocial.ToLower().Contains(valor))
                {
                    pessoas.Add(pessoajuridica);
                }
            }

            return pessoas;
        }
    }
}
