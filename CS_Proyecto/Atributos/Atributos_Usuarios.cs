using CS_Proyecto.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Proyecto.Atributos
{
    internal class Atributos_Usuarios
    {
        public static int IdUsuario { get; set; }
        public static string Nombres { get; set; }
        public static string Apellidos { get; set; }
        public static string Genero { get; set; }
        public static string Dui { get; set; }
        public static string NombreUsuario { get; set; }
        public static string ValidarNombreUsuario { get; set; }
        public static string Contrasena { get; set; }
        public static string ValidarContrasena { get; set; }
        public static string ContraseñaNoCoincide { get; set; }
        public static string ValidarLongitudContraseña { get; set; }
        public static byte[] Imagen { get; set; }
        public static string Correo { get; set; }
        public static int  Privilegio { get; set; }
        public static int Estado { get; set; }
        public static int IdEstado { get; set; }
        public static int IdRol { get; set; }
        public static int Usuariostotales { get; set; }
        public static int UsuariosActivos { get; set; }
        public static int UsuariosInactivos { get; set; }

        public static string EstadoFormulario { get; set; }


    }
}
