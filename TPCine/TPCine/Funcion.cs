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
    
        //constructor
        public Funcion (int ID, Sala MiSala, Pelicula MiPelicula, DateTime Fecha, int CantClientes, Double costo) {
            this.ID = ID;
            this.MiSala = MiSala;
            this.MiPelicula = MiPelicula;
            this.Fecha = Fecha;
            this.CantClientes = CantClientes;
            this.Costo  = costo;
            Clientes = new List<Usuario> ();
        }

        public void AgregarUsuario (Usuario usuario)
        {
            Clientes.Add(usuario);
        }

        public void EliminarUsuario(Usuario usuario)
        {
            Clientes.Remove(usuario);
        }
    }
}
