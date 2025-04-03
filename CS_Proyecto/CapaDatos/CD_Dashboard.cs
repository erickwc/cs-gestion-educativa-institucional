using Actividad.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Atributos;
using System.Reflection.Emit;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;

namespace CS_Proyecto.CapaDatos
{
    public class CD_Dashboard
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable TablaEstadistica()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from EstadisticaGeneral ORDER BY IdSecciones DESC";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable UltimoEmpleadoRegistrado()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from UltimosDocentesRegistrado order by IdDocentes desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public void TotalDeAlumnosActivos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_TotalDeAlumnosActuales";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Dashboard.CantidadTotalDeAlumnosActivos = leer.GetInt32(0);
                }
                leer.Close();
                conexion.CerrarConexion();
            }
            else
            {
                conexion.CerrarConexion();
            }

        }

        public void EstadisticaGeneros(Chart grafica)
        {
            ArrayList TipoGenero = new ArrayList();
            ArrayList CantidadGenero = new ArrayList();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TotalDeGenerosAlumnosActuales";
            leer = comando.ExecuteReader();
            
            while (leer.Read())
            {
                TipoGenero.Add(leer.GetString(0));
                CantidadGenero.Add(leer.GetInt32(1));
            }
            grafica.Series[0].Points.DataBindXY(TipoGenero, CantidadGenero);
            leer.Close();
            conexion.CerrarConexion()
        ;
        }

        public void TotalDeAlumnosMasculinos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_TotalDeGenerosMasculinos";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Dashboard.CantidadTotalDeAlumnosMasculinos = leer.GetInt32(1);
                }
                leer.Close();
                conexion.CerrarConexion();
            }
            else
            {
                conexion.CerrarConexion();
            }

        }

        public void TotalDeAlumnasFemeninas()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_TotalDeGenerosFemenino";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Dashboard.CantidadTotalDeAlumnosFemeninos = leer.GetInt32(1);
                }
                leer.Close();
                conexion.CerrarConexion();
            }
            else
            {
                conexion.CerrarConexion();
            }

        }

        public DataTable BuscarSeccionPorEspecialidad(string datobusqueda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarEnEstadisticaGeneral";
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
