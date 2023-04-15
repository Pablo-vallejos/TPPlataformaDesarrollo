using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TPCine
{
    public class Cine

    {
        public List<Usuario> Usuarios;
        public List<Funcion> Funciones;
        public List<Sala> Sala;
        public List<Pelicula> Peliculas;
        public Usuario UsuarioActual;

        //////////////////////////////////////////
        /// METODOS
        /////////////////////////////////////////

        public CargarCredito(int IdUsuario, Double importe) { }

        public ComprarEntrada(int IdUsuario, int IdFuncion, int Cant) { }

        public DevolverEntrada(int IdUsuario, int Cant) { }

        public IniciarSesion(string Mail, string Password) { }

        public CerrarSesion() { }

        public List<Funcion> MostrarFunciones() { }
        
        public List<Sala> MostrarSalas() { }

        public List<Pelicula> MostrarPeliculas() { }

        public List<Funcion> BuscarFuncion(string Ubicacion, Date fecha, Double Costo, string Pelicula) { }

        
    }



}
