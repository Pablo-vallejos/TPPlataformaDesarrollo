using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCine
{
    public class Funcion
    {
        public int ID { get; set; }
        public Sala MiSala { get; set; }
        public Pelicula MiPelicula { get; set; }     
        public DateTime Fecha { get; set; }
        public int CantClientes { get; set; }
        public Double Costo { get; set; }
        public List<Usuario> Clientes { get; set; }

    }
}
