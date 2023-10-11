using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titovar.Modelo
{
    internal class ProductoNoElaborado : Producto 
    {
        private int Stock {  get; set; }

        public int agregarStock(int cantidad)
        {
            return 0;
        }

        public int retirarStock(int cantidad)
        {
            return 0;
        }




    }
}
