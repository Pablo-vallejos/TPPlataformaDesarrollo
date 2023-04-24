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
        public List<Sala> Salas;
        public List<Pelicula> Peliculas;
        public Usuario UsuarioActual;

        //constructor
        public Cine(Usuario UsuarioActual)
        {
            Usuarios = new List<Usuario>();
            Funciones = new List<Funcion>();
            Salas = new List<Sala>();
            Peliculas = new List<Pelicula>();
            this.UsuarioActual = UsuarioActual;
        }


        //////////////////////////////////////////
        /// METODOS
        /////////////////////////////////////////

        public void CargarCredito(int IdUsuario, Double importe)
        {
            if (UsuarioActual.ID == IdUsuario)
            {
                UsuarioActual.Credito = UsuarioActual.Credito + importe;
                Console.WriteLine("Se cargo credito");

                return;
            }
        }

        public void ComprarEntrada(int IdUsuario, int IdFuncion, int Cant)
        {
            Usuario usuario = Usuarios.Find(u => u.ID == IdUsuario);
            Funcion funcion = Funciones.Find(f => f.ID == IdFuncion);

            if (usuario == null || funcion == null)
            {
                Console.WriteLine("No se encontro la funcion o el usuario");
                return;
            }

            if (usuario.Credito < (funcion.Costo * Cant))
            {
                Console.WriteLine("No hay suficiente credito");
            }

            Sala sala = funcion.MiSala;
            if (sala.Capacidad < funcion.CantClientes + Cant)
            {
                Console.WriteLine("No hay espacio en la sala");
                return;
            }

            usuario.Credito = usuario.Credito - (Cant * funcion.Costo);
            funcion.CantClientes = funcion.CantClientes + Cant;
            usuario.MisFunciones.Add(funcion);
            funcion.Clientes.Add(usuario);

            Console.WriteLine("La compra se realizo exitosamente");
            return;
        }

        public void DevolverEntrada(int IdUsuario, int Cant)
        {

        }

        public bool IniciarSesion(string Mail, string Password)
        {

            // Buscar el usuario por email
            Usuario usuario = Usuarios.Find(u => u.Mail == Mail);
            //verifico la pass
            if (usuario != null && usuario.Password == Password)
            {
                if (usuario.EsAdmin == false)               // verifica el admin
                {
                    Console.WriteLine("No puede iniciar como admin");
                    return false;
                }

                if (usuario.Bloqueado == true)
                {
                    Console.WriteLine("El usuario esta bloqueado");
                    return false;
                }

                UsuarioActual = usuario;
                return true;
            }
            else
            {
                usuario.IntentosFallidos++;

                if (usuario.IntentosFallidos > 2)
                {
                    usuario.Bloqueado = true;
                    Console.WriteLine("Se bloqueo el usuario");

                }
                return false;
            }


        }
        public void CerrarSesion()
        {
            UsuarioActual = null;
        }

        public List<Funcion> MostrarFunciones()
        {
            DateTime fechaActual = DateTime.Now;

            List<Funcion> funcionesDisponibles = new();

            foreach (Funcion funcion in Funciones)
            {
                if (funcion.CantClientes < funcion.MiSala.Capacidad && funcion.Fecha < fechaActual)
                {
                    funcionesDisponibles.Add(funcion);
                }

            }

            return funcionesDisponibles;
        }

        public List<Sala> MostrarSalas()
        {
            return Salas;
        }

        public List<Pelicula> MostrarPeliculas()
        {
            return Peliculas;
        }

        public List<Funcion> BuscarFuncion(string Ubicacion, DateTime fecha, Double Costo, string Pelicula)
        {
            List<Funcion> funcionesEncontradas = new();
            foreach (Funcion funcion in Funciones)
            {
                if (funcion.MiSala.Ubicacion == Ubicacion && funcion.Fecha == fecha && funcion.Costo == Costo && funcion.MiPelicula.Nombre == Pelicula)
                {
                    funcionesEncontradas.Add(funcion);
                }
            }

            return funcionesEncontradas;
        }



    }
}