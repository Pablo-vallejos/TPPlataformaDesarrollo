using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCine
{
    public class Sala
    {
        public int ID { get; set; }
        public string Ubicacion { get; set; }
        public int Capacidad { get; set; }
        public List<Funcion> MisFunciones { get; set; }
        
    }
}
