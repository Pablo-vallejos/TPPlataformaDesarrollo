using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TPCine
{
    public class Pelicula
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Sinopsis { get; set; }
        public string Poster { get; set; }
        public List<Funcion> MisFunciones { get; set; }
        public int Duracion { get; set; }

    }
}
