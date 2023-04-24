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

        //CONSTRUCTOR

        public Sala(int ID, string Ubicacion, int Capacidad)
        {
            this.ID = ID;
            this.Ubicacion = Ubicacion;
            this.Capacidad = Capacidad;
            MisFunciones = new List<Funcion>();
        }

        public void AgregarFuncion(Funcion funcion) {
            MisFunciones.Add(funcion);
        }

        public void EliminarFuncion(Funcion funcion)
        {
            MisFunciones.Remove(funcion);
        }

    }

}
