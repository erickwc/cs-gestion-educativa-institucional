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

namespace CS_Proyecto.CapaDatos
{
        internal class CD_secciones
        {
            private Conexion conexion = new Conexion();
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();

        public DataTable mostrarEspecialidadesActuales()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from EspecialidadesRegistradas order by IdEspecialidades desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable mostrarEspecialidadesRegistro()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from EspecialidadesRegistradas";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable MostrarTipoSeccion()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TipoSeccionRegistradas";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarTipoSeccionFormularioSeccion()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select IdTipoSeccion, TipoSecciones 'Tipo de Secciones' from TipoSeccionRegistradas order by IdTipoSeccion desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarDocenteSeccion()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from DocenteSeccionRegistradas";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarSeccion(string SeccionAbreviacion, int IdEspecialidades, int IdDocentes, int IdTipoSeccion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarSecciones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@SeccionAbreviacion", SeccionAbreviacion);
            comando.Parameters.AddWithValue("@IdEspecialidades", IdEspecialidades);
            comando.Parameters.AddWithValue("@IdDocentes", IdDocentes);
            comando.Parameters.AddWithValue("@IdTipoSeccion", IdTipoSeccion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void InsertarEspecialidad(string Nombre, string Duracion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarEspecialidades";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Duracion", Duracion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarSecciones(int IdSecciones, string SeccionAbreviacion, int IdEspecialidades, int IdDocentes, int IdTipoSeccion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarSecciones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdSecciones", IdSecciones);
            comando.Parameters.AddWithValue("@SeccionAbreviacion", SeccionAbreviacion);
            comando.Parameters.AddWithValue("@IdEspecialidades", IdEspecialidades);
            comando.Parameters.AddWithValue("@IdDocentes", IdDocentes);
            comando.Parameters.AddWithValue("@IdTipoSeccion", IdTipoSeccion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarEspecialidad(int IdEspecialidades, string Nombre, string Duracion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarEspecialidades";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdEspecialidades", IdEspecialidades);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Duracion", Duracion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable mostrarSeccionesActuales()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from SeccionesIngresadas order by IdSecciones desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

    

        public DataTable MostrarEspecialidades()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from EspecialidadesNombres";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public bool mostrarDatoSeccion(int IdSeccion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarDatoSeccion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dato", IdSeccion);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_seccion.IdEspecialidades = leer.GetInt32(2);
                    Atributos_seccion.SeccionAbreviacion = leer.GetString(1);
                    Atributos_seccion.IdTipoSeccion = leer.GetInt32(4);
                    Atributos_seccion.IdSecciones = leer.GetInt32(0);
                    Atributos_seccion.IdDocentes = leer.GetInt32(3);
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

        public DataTable BuscadorSeccion(string dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_bucadorSecciones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void CantidadSeccionesActuales()
        {
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_NumeroSeccionesActuales";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                comando.Parameters.Clear();

                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        Atributos_seccion.CantidadSecciones = leer.GetInt32(0);

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

        public void CantidadEspecialidadesActuales()
        {
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_NumeroEspecialidadesActuales";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                comando.Parameters.Clear();

                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        Atributos_seccion.CantidadEspecialidades = leer.GetInt32(0);

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

        public void InsertarTipoSeccion(string Tipo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarTipoSeccion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TipoSecciones", Tipo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarTipoSeccion(int IdTipo, string Tipo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarTipoSeccion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TipoSecciones", Tipo);
            comando.Parameters.AddWithValue("@IdTipoSeccion", IdTipo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable BuscadorTipoSeccion(string dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarTipoSeccion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }



    }
}
