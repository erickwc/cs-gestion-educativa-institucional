using Actividad.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Guna.UI2.HtmlRenderer.Adapters.RGraphicsPath;
using System.Drawing;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Atributos;
using System.Reflection.Emit;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace CS_Proyecto.CapaDatos
{
    internal class CD_Usuariuos
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void InsetarUsuarios
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
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombres", nombres);
            comando.Parameters.AddWithValue("@Apellidos", apellidos);
            comando.Parameters.AddWithValue("@Genero", genero);
            comando.Parameters.AddWithValue("@Dui", dui);
            comando.Parameters.AddWithValue("@NombreUsuario", usuario);
            comando.Parameters.AddWithValue("@Contrasena", contrasena);
            if (imagen != null && imagen.Length > 0)
            {
                comando.Parameters.AddWithValue("@Imagen", imagen);
            }
            else
            {
                comando.Parameters.Add("@Imagen", SqlDbType.VarBinary, -1).Value = DBNull.Value;
            }
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@IdRol", idrol);
            comando.Parameters.AddWithValue("@IdTipoEstado", idTipoEstado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

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
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombres", nombres);
            comando.Parameters.AddWithValue("@Apellidos", apellidos);
            comando.Parameters.AddWithValue("@Genero", genero);
            comando.Parameters.AddWithValue("@Dui", dui);
            comando.Parameters.AddWithValue("@NombreUsuario", usuario);
            comando.Parameters.AddWithValue("@Contrasena", contrasena);
            if (imagen != null && imagen.Length > 0)
            {
                comando.Parameters.AddWithValue("@Imagen", imagen);
            }
            else
            {
                comando.Parameters.Add("@Imagen", SqlDbType.VarBinary, -1).Value = DBNull.Value;
            }
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@IdRol", idrol);
            comando.Parameters.AddWithValue("@IdTipoEstado", idTipoEstado);
            comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public DataTable MostrarUsuariosActuales()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select*from UsuariosRegistrado";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable EditarUsuariosActuales()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select*from EditarUsuarioVista";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarPrivilegios()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select*from Privilegios";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable MostrarEstado()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select*from TipoEstados";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable MostrarUsuariosInactivos()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select*from UsuariosInactivo";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable NombresEspecialidades()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select*from EspecialidadesNombres";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void UsuariosActuales()
        {
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ActualesUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                comando.Parameters.Clear();

                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        Atributos_Usuarios.Usuariostotales = leer.GetInt32(0);

                    }
                    leer.Close();
                    conexion.CerrarConexion();


                }
                else
                {
                    conexion.CerrarConexion();

                }

            }
        }

        public void UsuariosActivos()
        {
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ActivosUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                comando.Parameters.Clear();

                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        Atributos_Usuarios.UsuariosActivos = leer.GetInt32(0);

                    }
                    leer.Close();
                    conexion.CerrarConexion();


                }
                else
                {
                    conexion.CerrarConexion();

                }

            }

        }
        public void UsuariosInactivos()
        {
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "InactivosUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                comando.Parameters.Clear();

                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        Atributos_Usuarios.UsuariosInactivos = leer.GetInt32(0);

                    }
                    leer.Close();
                    conexion.CerrarConexion();


                }
                else
                {
                    conexion.CerrarConexion();

                }

            }

        }
        public void MostrarDatoUsuario(int idusuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrardatosUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dato", idusuario);

            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Usuarios.IdUsuario = leer.GetInt32(0);
                    Atributos_Usuarios.Nombres = leer.GetString(1);
                    Atributos_Usuarios.Apellidos = leer.GetString(2);
                    Atributos_Usuarios.Genero = leer.GetString(3);
                    Atributos_Usuarios.Dui = leer.GetString(4);
                    Atributos_Usuarios.NombreUsuario = leer.GetString(5);
                    Atributos_Usuarios.Contrasena = leer.GetString(6);
                    Atributos_Usuarios.ValidarContrasena = leer.GetString(6);
                    Atributos_Usuarios.Imagen = leer.IsDBNull(7) ? new byte[0] : (byte[])leer.GetValue(7);
                    Atributos_Usuarios.Correo = leer.GetString(8);
                    Atributos_Usuarios.IdRol = leer.GetInt32(9);
                    Atributos_Usuarios.IdEstado = leer.GetInt32(10);
                }
                leer.Close();
                conexion.CerrarConexion();
                ;

            }
            else
            {
                conexion.CerrarConexion();
                ;
            }

        }

        public bool ConsultarNombreUsuario(string Usuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ConsultarNombreUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", Usuario);

            object result = comando.ExecuteScalar();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            if (result != null && result != DBNull.Value)
            {
                int count = Convert.ToInt32(result);

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false; 
                }
            }
            else
            {
                return false;
            }
        }

        public DataTable BuscarUsuario(string datobusqueda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", datobusqueda);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
