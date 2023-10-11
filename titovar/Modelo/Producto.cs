using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titovar.Modelo
{
    internal class Producto
    {
        private int Id { get; set; }
        private string Nombre { get; set; }
        private string Descripcion { get; set; }
        private decimal Costo { get; set; }
        private decimal Precio { get; set; }

        public int GetId()
        {
            return Id;
        }
        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public void setDescripcion(string descripcion)
        {
            Descripcion = descripcion;
        }
        public string getDescripcion()
        {
            return Descripcion;
        }

        public void setCosto(decimal costo)
        {
            Costo = costo;
        }
        public decimal getCosto()
        {
            return Costo;
        }
        public void setPrecio(decimal precio)
        {
            Precio = precio;
        }
        public decimal getPrecio()
        {
            return Precio;
        }


        public Producto() {
            Nombre = "Nombre";
            Descripcion = "Descripcion";
        }
        public Producto(int id, string nombre, string descripcion, decimal costo, decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Costo = costo;
            Precio = precio;
        }
        }
    }




