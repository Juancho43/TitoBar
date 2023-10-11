using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titovar.Modelo
{
     class Mesa
    {
        private string Id { get; set; }
        private Pedido OPedido {  get; set; }

        public Mesa()
        {

        }
        public Mesa(string Id)
        {
            this.Id = Id;
        }


        public void agregarPedido(Pedido pedido)
        {

        }
        public void cerrarPedido(Pedido pedido)
        {

        }

        public Pedido verPedido()
        {
            return new Pedido();
        }
    }
}
