using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using titovar.Modelo;

namespace titovar.Controllers
{
    internal class ProductoController
    {
        private List<Producto> productos;
        private ProductoDAO productoDAO;

        public void CrearProducto(int  id, string nombre, string descripcion, decimal precio, decimal costo)
        {
            productos.Add(new Producto(id, nombre, descripcion, costo, precio)); 
        }
        public void ModificarProducto(int id, string nombre, string descripcion, decimal precio, decimal costo)
        {
            foreach (Producto item in productos)
            {
                if (item.GetId().Equals(id))
                {
                    item.setNombre(nombre);
                    item.setDescripcion(descripcion);
                    item.setCosto(costo);
                    item.setPrecio(precio);

                } 
            }
        }

        public void EliminarProducto(int Id)
        {
          foreach(Producto item in productos)
            {
                if(item.GetId().Equals(Id))
                {
                    productos.Remove(item);
                }
            }
        }

    }
}
