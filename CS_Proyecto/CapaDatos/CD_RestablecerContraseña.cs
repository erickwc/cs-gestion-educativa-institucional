using Actividad.CapaDatos;
using CS_Proyecto.Atributos;
using System.Data;
using System.Data.SqlClient;

namespace CS_Proyecto.CapaDatos
{
    internal class CD_RestablecerContraseña
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public bool ConsultarCorreoUsuario(string usuarioCorreo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_leerCorreoUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", usuarioCorreo);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_RecuperarContraseña.Usuario = leer.GetString(0);
                    Atributos_RecuperarContraseña.Correo = leer.GetString(1);
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

        public bool LeerToken(string token)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_leerToken";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", token);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    
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


        public void InsertarTokenTemporal(string Correo, string Token)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarRestablecerContraseña";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Usuario", Correo);
            comando.Parameters.AddWithValue("@Token", Token);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarTokenTemporal(string Usuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_EliminarToken";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", Usuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarContraseña(string Contraseña, string Usuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_modificarContraseña";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NuevaContraseña", Contraseña);
            comando.Parameters.AddWithValue("@Usuario", Usuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
