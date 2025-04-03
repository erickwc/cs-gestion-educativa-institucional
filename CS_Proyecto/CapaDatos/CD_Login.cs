using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actividad.CapaDatos;
using CS_Proyecto.CapaNegocio;
using BCrypt.Net;

namespace CS_Proyecto.CapaDatos
{
    internal class CD_Login
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public bool ConsultarUsuario(string usuario, string contraseña)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ConsultarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Login.IdUsuario = leer.GetInt32(0);
                    Atributos_Login.Nombres = leer.GetString(1);
                    Atributos_Login.Apellidos = leer.GetString(2);
                    Atributos_Login.Genero = leer.GetString(3);
                    Atributos_Login.Dui = leer.GetString(4);
                    Atributos_Login.Usuario = leer.GetString(5);
                    Atributos_Login.Contraseña = leer.GetString(6);
                    Atributos_Login.Imagen = leer.IsDBNull(7) ? new byte[0] : (byte[])leer.GetValue(7);
                    Atributos_Login.Correo = leer.GetString(8);
                    Atributos_Login.Rol = leer.GetString(9);
                    Atributos_Login.Estado = leer.GetString(10);
                    Atributos_Login.IdRol = leer.GetInt32(11);
                    Atributos_Login.IdEstado = leer.GetInt32(12);
                }
                leer.Close();
                conexion.CerrarConexion();
                return true;
                
            } 
            else
            {
                conexion.CerrarConexion();
                return false;
            }
            
        }

        public bool ConsultarUsuarioEncriptado(string usuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ConsultarUsuariosContraseñaEncriptadas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", usuario);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Login.IdUsuario = leer.GetInt32(0);
                    Atributos_Login.Nombres = leer.GetString(1);
                    Atributos_Login.Apellidos = leer.GetString(2);
                    Atributos_Login.Genero = leer.GetString(3);
                    Atributos_Login.Dui = leer.GetString(4);
                    Atributos_Login.Usuario = leer.GetString(5);
                    Atributos_Login.Contraseña = leer.GetString(6); // Cambio aquí
                    Atributos_Login.Imagen = leer.IsDBNull(7) ? new byte[0] : (byte[])leer.GetValue(7);
                    Atributos_Login.Correo = leer.GetString(8);
                    Atributos_Login.Rol = leer.GetString(9);
                    Atributos_Login.Estado = leer.GetString(10);
                    Atributos_Login.IdRol = leer.GetInt32(11);
                    Atributos_Login.IdEstado = leer.GetInt32(12);
                }
                leer.Close();
                conexion.CerrarConexion();
                return true;
            }
            else
            {
                conexion.CerrarConexion();
                return false;
            }
        }

    }
}
