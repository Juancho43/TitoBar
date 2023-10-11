using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using titovar.Modelo;
namespace titovar.Controllers
{
    internal class SalonController
    {
        private List<Mesa> Mesas {  get; set; }

        public SalonController()
        {
            Mesas = new List<Mesa>();
        }
        public void crearMesa(String id)
        {
            Mesas.Add(new Mesa(id));
        }

        public List<Mesa> listarMesas() { return Mesas; }

    }
}
