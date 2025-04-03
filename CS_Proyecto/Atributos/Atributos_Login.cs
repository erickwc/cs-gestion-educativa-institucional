using Actividad.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Proyecto.CapaNegocio
{

    public static class Atributos_Login
    {
       
        public static int IdUsuario { get; set; }
        public static string Nombres { get; set; }
        public static string Apellidos { get; set; }
        public static string Genero { get; set; }
        public static string Dui { get; set; }
        public static string Usuario { get; set; }
        public static string Contraseña { get; set; }
        public static byte[] Imagen { get; set; }
        public static string Correo { get; set; }
        public static string Rol { get; set; }
        public static string Estado { get; set; }
        public static int IdRol { get; set; }
        public static int IdEstado { get; set; }

    }
}
