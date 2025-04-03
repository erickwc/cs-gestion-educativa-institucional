using Actividad.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CS_Proyecto.CapaDatos
{
    internal class CD_DatosInactivos
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable AlumnosInactivosPreview()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from AlumnosInactivosPreview order by IdAlumno desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable DocentesInactivosFondos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from DocentesInactivosPreview order by IdDocentes desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable UsuariosInactivosPreview()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from UsuariosInactivosPreview order by IdUsuario desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable AlumnosInactivosVista()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from AlumnosInactivosVista order by IdAlumno desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable DocentesInactivosVista()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from DocentesInactivosVista order by IdDocentes desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable UsuariosInactivosVista()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from UsuariosInactivosVista order by ID desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarAlumnosInactivos(string datobusqueda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarAlumnosInactivosVista";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", datobusqueda);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarDocentesInactivos(string datobusqueda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarDocentesInactivosVista";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", datobusqueda);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarUsuariosInactivos(string datobusqueda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarUsuariosInactivosVista";
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
