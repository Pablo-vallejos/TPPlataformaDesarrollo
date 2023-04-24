using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCine
{
    public class Usuario
    {
        public int ID { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public int IntentosFallidos { get; set; }
        public bool Bloqueado { get; set; }
        public List<Funcion> MisFunciones { get; set; }
        public Double Credito { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool EsAdmin { get; set; }

        //constructor
        public Usuario(int ID, int DNI, string Nombre, string Apellido, string Mail, string Password, int IntentosFallidos, 
            bool Bloqueado, Double Credito, DateTime FechaNacimiento, bool EsAdmin) { 
            this.ID = ID;
            this.DNI = DNI;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Mail = Mail;
            this.Password = Password;
            this.IntentosFallidos = IntentosFallidos;
            this.Bloqueado  = Bloqueado;
            this.Credito = Credito;
            this.FechaNacimiento = FechaNacimiento;
            this.EsAdmin = EsAdmin;
            MisFunciones = new List<Funcion>();
        }

        public void AgregarFuncion(Funcion funcion) {
            MisFunciones.Add(funcion);
        }

        public void EliminarFuncion(Funcion funcion) {
            MisFunciones.Remove(funcion);
        }
    }
}
