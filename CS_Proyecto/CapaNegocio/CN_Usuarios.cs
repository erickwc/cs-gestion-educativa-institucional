using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actividad.CapaDatos;
using CS_Proyecto.CapaDatos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CS_Proyecto.CapaNegocio
{
    internal class CN_Usuarios
    {
        CD_Usuariuos cD_USUARIOS = new CD_Usuariuos();
        public void InsertarUsuario
        (
            string nombres,
            string apellidos,
            string genero,
            string dui,
            string usuario,
            string contrasena,
            byte[] imagen,
            string correo,
            int idrol,
            int idTipoEstado

        ) 
        {
            cD_USUARIOS.InsetarUsuarios(
                 nombres,
                 apellidos,
                 genero,
                 dui,
                 usuario,
                 contrasena,
                 imagen,
                 correo,
                 idrol,
                 idTipoEstado
                );

        }

        public void ModificarUsuario
      (

          string nombres,
          string apellidos,
          string genero,
          string dui,
          string usuario,
          string contrasena,
          byte[] imagen,
          string correo,
          int idrol,
         int idTipoEstado,
         int idUsuario

      )
        {
            cD_USUARIOS.ModificarUsuario(
                 nombres,
                 apellidos,
                 genero,
                 dui,
                 usuario,
                 contrasena,
                 imagen,
                 correo,
                 idrol,
                 idTipoEstado,
                 idUsuario
                );

        }
        public DataTable MostrarUsuarioRegistrado()
        {
            DataTable tabla = new DataTable();
            tabla = cD_USUARIOS.MostrarUsuariosActuales();
            return tabla;

        }

        public DataTable EditarUsuarioRegistrado()
        {
            DataTable tabla = new DataTable();
            tabla = cD_USUARIOS.EditarUsuariosActuales();
            return tabla;

        }

        public DataTable MostrarUsuariosInactivos()
        {
            DataTable tabla = new DataTable();
            tabla = cD_USUARIOS.MostrarUsuariosInactivos();
            return tabla;

        }
        public void UsuariosActuales()
        {
            cD_USUARIOS.UsuariosActuales();
        }
        public void UsuariosActivos()
        {
            cD_USUARIOS.UsuariosActivos();
        }
        public void UsuariosInactivos()
        {
            cD_USUARIOS.UsuariosInactivos();
        }
        public void MostrarDatoUsuario(int idusuario)
        {
            cD_USUARIOS.MostrarDatoUsuario(idusuario);
        }

        public bool ConsultarNombreExistente(string Usuario)
        {
         return cD_USUARIOS.ConsultarNombreUsuario(Usuario);
        }

        public DataTable BuscarUsuario(string dato)
        {
            return cD_USUARIOS.BuscarUsuario(dato);
        }
    }
}
