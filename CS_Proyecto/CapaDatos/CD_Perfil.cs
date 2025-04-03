using Actividad.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Proyecto.CapaNegocio;

namespace CS_Proyecto.CapaDatos
{
    internal class CD_Perfil
    {
        private Conexion conexion = new Conexion();

        SqlCommand comando = new SqlCommand();

        public void ModificarPerfil(int IdUsuario, string Nombres, string Apellidos, string Genero, string Dui, string NombreUsuario, string Contrasena, byte[] imagen, string correo, int IdRol, int IdTipoEstado)
        {
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            comando.Parameters.AddWithValue("@Nombres", Nombres);
            comando.Parameters.AddWithValue("@Apellidos", Apellidos);
            comando.Parameters.AddWithValue("@Genero", Genero);
            comando.Parameters.AddWithValue("@Dui", Dui);
            comando.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
            comando.Parameters.AddWithValue("@Contrasena", Contrasena);
            if (imagen != null && imagen.Length > 0)
            {
                comando.Parameters.AddWithValue("@Imagen", imagen);
            }
            else
            {
                comando.Parameters.Add("@Imagen", SqlDbType.VarBinary, -1).Value = DBNull.Value;
            }
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@IdRol", IdRol);
            comando.Parameters.AddWithValue("@IdTipoEstado", IdTipoEstado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarPerfil(string Contraseña, string NombreUsuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_EncriptarContraseña";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Contrasena", Contraseña);
            comando.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }
}
