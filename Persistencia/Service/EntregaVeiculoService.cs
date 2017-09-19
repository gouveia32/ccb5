using Persistencia.DAO;
using Persistencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persistencia.Service
{
    public class EntregaVeiculoService
    {
        private ReservaDAO reservaDAO;

        public EntregaVeiculoService()
        {
            reservaDAO = new ReservaDAO();
        }

        public bool verificaChecklist(String status)
        {
            if (status == "Realizado")
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public Reserva buscarReserva(long codReserva)
        {
            Reserva reserva = new ReservaDAO().Buscar(codReserva);
            return reserva;
        }

        public bool devolucao(Reserva reserva, Veiculo veiculo, DateTime DataEntrega)
        {
            bool resultado = false;

            if (reserva != null)
            {
                try
                {
                    veiculo.Status = 1;
                    new VeiculoDAO().Atualizar(veiculo);
                    reserva.DataEntrega = DataEntrega.ToString();
                    reserva.Status = 1;
                    new ReservaDAO().Atualizar(reserva);
                    resultado =  true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um erro " + ex);
                    resultado = false;
                }

            }

            return resultado;
        }
    }
}
