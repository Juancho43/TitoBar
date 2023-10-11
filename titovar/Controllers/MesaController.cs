using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using titovar.Modelo;

namespace titovar.Controllers
{
    internal class MesaController
    {
        public SalonController salonController;
        private static MesaController _instancia;
        private List<Pedido> pedidos;
        private PedidoDAO pedidoDAO;

        private MesaController()
        {   }

        public static MesaController GetInstancia()
        {
            if(_instancia == null)
            {
                _instancia = new MesaController();
            }
            return _instancia;
        }
    }
}
