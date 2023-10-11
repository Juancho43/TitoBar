using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titovar.Modelo
{
    internal class Pedido
    {
        private int Id { get; set; }
        private List<Item> DetallePedido {  get; set; }
        private DateTime FechaApertura {  get; set; }

        private DateTime FechaCierre { get; set; }

        public Pedido()
        {

        }

        public void agregarItem(Producto producto, int cantidad)
        {

        }

        public void eliminarItem(Item item)
        {

        }

        public void modificarItem(int cantidad, Producto producto)
        {

        }

        public List<Item> verDetalle()
        {
            return DetallePedido;
        }


        public float calcularTotal()
        {
            return 0;
        }







    }
}
