using Actividad.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using CS_Proyecto.Atributos;
using CS_Proyecto.CapaNegocio;
using Microsoft.SqlServer.Server;

namespace CS_Proyecto.CapaDatos
{
    internal class CD_Empleados
    {

        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarCargosRegistrados()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select IdTipoDocente, TipoDocente 'Cargos' from TipoDocente order by IdTipoDocente desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();  
            return tabla;

        }

        public DataTable MostrarCargosParaRegistroEmpleado()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TipoDocente";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarNivelDeEstudioDocente()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select  IdNivelEstudioDocente, TipoNivel 'Niveles' from NivelEstudioDocente order by  IdNivelEstudioDocente desc\r\n";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarNivelDeEstudioParaRegistroDocente()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select  * from NivelEstudioDocente";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarEspecialidadesParaRegistro()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select  * from EspecialidadDocentes";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarMaterias() {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Materias";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarMateriasMantenimiento()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select IdMaterias, TipoMaterias 'Materias' from Materias order by IdMaterias desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarMateriasParaCompletarRegistro()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select IdMaterias, TipoMaterias 'Materias' from Materias order by IdMaterias desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarMateriasAgregadasDocentes(int dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarMateriasAgregadasDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarCargosParaCompletarRegistro()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select IdTipoDocente, TipoDocente 'Cargos' from TipoDocente order by IdTipoDocente desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable MostrarEspecialidadesParaCompletarRegistro()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select IdEspecialidadDocentes, TipoEspecialidad 'Especialidades' from EspecialidadDocentes order by IdEspecialidadDocentes desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarCargosAgregadosDocentes(int dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarCargosAgregadosDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarEspecialidadesAgregadosDocentes(int dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarEspecialidadesAgregadosDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }



        public DataTable AgregarMateriasDocentes(int IdMateria, int IdDocente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarMateriasDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdDocentes", IdDocente);
            comando.Parameters.AddWithValue("@IdMaterias", IdMateria);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable QuitarMateriasDocentes(int dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_EliminarAgregarMateriasDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdDocenteMaterias", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable AgregarCargosDocentes(int IdCargo, int IdDocente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarDocentesCargos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdDocentes", IdDocente);
            comando.Parameters.AddWithValue("@IdCargo", IdCargo);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable QuitarCargosDocentes(int dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_EliminarDocentesCargos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdDocenteCargos", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarEspecialidades()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select IdEspecialidadDocentes, TipoEspecialidad 'Especialidad' from EspecialidadDocentes order by IdEspecialidadDocentes desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable AgregarEspecialidadesDocentes(int IdCargo, int IdDocente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarEspecialidadesDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdDocentes", IdDocente);
            comando.Parameters.AddWithValue("@EspecialidadDocentes", IdCargo);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable EliminarEspecialidadesDocentes(int IdDocente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_EliminarEspecialidadesDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdDocenteEspecialidades", IdDocente);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarEstadoDocente() {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TipoEstado";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarEstadisticaDocentes()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from ConsultarDocentesAgregados";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarEstadisticaEditarDocentes()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from EditarDocentesEstadistica";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable BuscarDocentePorNombreOApellido(string dato) {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_BuscarDocentePorNombreOApellido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarDocentePorDUI(string dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_BuscarDocentePorDUI";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarNivelDeEstudio(string dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_BuscarNivelDeEstudio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarCargoDocente(string dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_BuscarCargoDocente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarAfeccionesDocente(int dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_mostrarAfeccionesDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable mostrarAfeccionesDocente(int dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_mostrarAfeccionesEditarDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarMedicamentosDocentes(int dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_mostrarMedicamentosDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarMedicamentosEditarDocentes(int dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_mostrarMedicamentosEditarDocente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public void TotalDeDocentesActivos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_DocentesActivos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Dashboard_Docente.CantidadTotalDeDocentes = leer.GetInt32(0);
                }
                leer.Close();
                conexion.CerrarConexion();
            }
            else
            {
                conexion.CerrarConexion();
            }

        }

        public void TotalDeMateriasRegistradas() {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_cantidadDeMaterias";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Dashboard_Docente.CantidadDeMaterias = leer.GetInt32(0);
                }
                leer.Close();
                conexion.CerrarConexion();
            }
            else
            {
                conexion.CerrarConexion();
            }
        }

        public void TotalDeEspecialidadesRegistradas() {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_cantidadDeEspecialidadesDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Dashboard_Docente.CantidadDeEspecialidades = leer.GetInt32(0);
                }
                leer.Close();
                conexion.CerrarConexion();
            }
            else
            {
                conexion.CerrarConexion();
            }
        }

        public void TotalDeNivelesDeEstudio() {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_cantidadDeNivelesDeEstudio";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Dashboard_Docente.CantidadTotalDeNivelesDeEstudio = leer.GetInt32(0);
                }
                leer.Close();
            }

            conexion.CerrarConexion();
        }

        public void TotalDeTiposDocente()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_cantidadTiposDocente";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Dashboard_Docente.CantidadDeTiposDocente = leer.GetInt32(0);
                }
                leer.Close();
            }

            conexion.CerrarConexion();
        }

        public void AlergiasDocente(int IdDocente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_mostrarDetallesMedicosEditarDocente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", IdDocente);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Empleado.MostrarAlergias = leer.IsDBNull(0) ? "No Agregado" : leer.GetString(0);
                }
                leer.Close();
            }

            conexion.CerrarConexion();
        }


        public void insertarNivelDeEstudio(string NombreNivelDeEstudio) {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarNivelEstudioDocente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TipoNivel", NombreNivelDeEstudio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void modificarNivelDeEstudio(string NombreNivelDeEstudio, int IdNivelDeEstudio) {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarNivelEstudioDocente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TipoNivel", NombreNivelDeEstudio);
            comando.Parameters.AddWithValue("@IdNivelEstudioDocente", IdNivelDeEstudio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void insertarTipoDocente(string tipoDocente) {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarTipoDocente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TipoDocente", tipoDocente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void modificarTipoDocente(string tipoDocente, int idTipo) {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarTipoDocente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TipoDocente", tipoDocente);
            comando.Parameters.AddWithValue("@IdTipoDocente", idTipo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void insertarEspecialidadDocente(string especialidad) {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarEspecialidadDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TipoEspecialidad", especialidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void modificarEspecialidadDocente(string Especialidad, int idEspecialidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarEspecialidadesDocente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TipoEspecialidad", Especialidad);
            comando.Parameters.AddWithValue("@IdEspecialidadDocentes", idEspecialidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void insertarMateria(string Materia)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarMaterias";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TipoMaterias", Materia);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void modificarMateria(string Materia, int idMateria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarMaterias";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TipoMaterias", Materia);
            comando.Parameters.AddWithValue("@IdMaterias", idMateria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void insertarAfeccionesDocente(string Afeccion, string Tipo, string Procedimiento, int IdDocente) {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarInformacionMedicaDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreAfeccion", (object)Afeccion ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Tipo", (object)Tipo ?? DBNull.Value);
            comando.Parameters.AddWithValue("@ProcedimientoMedico", (object)Procedimiento ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdDocentes", IdDocente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void modificarAfeccionesDocente(string Afeccion, string Tipo, string Procedimiento, int IdAfeccion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarInformacionMedicaDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreAfeccion", (object)Afeccion ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Tipo", (object)Tipo ?? DBNull.Value);
            comando.Parameters.AddWithValue("@ProcedimientoMedico", (object)Procedimiento ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdAfeccion", IdAfeccion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void eliminarAfeccionesDocente(int IdAfeccion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_eliminarAfecciones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdInformacionMedicaDocente", IdAfeccion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void insertarMedicamentos(string NombreMedicamento, string Dosis, string Frecuencia, int IdDocente) {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarMedicamentosDocente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreMedicamento", (object)NombreMedicamento ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Dosis", (object)Dosis ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Frecuencia", (object)Frecuencia ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdDocentes", IdDocente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void modificarMedicamentos(string NombreMedicamento, string Dosis, string Frecuencia, int IdDocente, int IdMedicamento)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarMedicamentosDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreMedicamento", (object)NombreMedicamento ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Dosis", (object)Dosis ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Frecuencia", (object)Frecuencia ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdDocentes", IdDocente);
            comando.Parameters.AddWithValue("@IdDetalleMedicamento", IdMedicamento);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void eliminarMedicamentosDocente(int IdMedicamento)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_eliminarMedicamentos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdDetalleMedicamentosDocente", IdMedicamento);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void insertarDetallesMedicos(string Alergias, int idDocentes) {
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarDetallesMedicosDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Alergias", (object)Alergias ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdDocentes", idDocentes);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        
        }

        public void modificarDetallesMedicos(string Alergias, int idDocente) {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarDetallesMedicosDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Alergias", (object)Alergias ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdDocentes", idDocente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void insertarDocente(
            string NombreCompleto,
            string NombreCompletoDUI, 
            string NombreCompletoNIT,
            string Conyuge,
            string EstadoCivil,
            string Jubilado,
            string Direccion,
            int IdNivelEstudio,
          
            string NIP,
            string NIT,
            string DUI,
            string ISSS,
            string NUP,
            string AFP,
            int IdTipoEstado,
            string TelefonoMovilPrincipalDocente,
            string TelefonoMovilSecundarioDocente,
            string TelefonoCasa,
            string TelefonoOficina,
            string TelefonoMovilEmergencia,
            string TelefonoMovilEmergenciaSecundario
            ) {
            int ultimoId = 0;
            comando.Connection = conexion.AbrirConexion();
            string ContarId = "select max(IdDocentes) from Docentes";
            SqlCommand selectCmd = new SqlCommand(ContarId, conexion.AbrirConexion());

            object UltimoIdExistente = selectCmd.ExecuteScalar();
            if (UltimoIdExistente != null && UltimoIdExistente != DBNull.Value)
            {
                ultimoId = Convert.ToInt32(UltimoIdExistente);
            }

            int IdDocente = ultimoId + 1;

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreCompletoDUI", NombreCompletoDUI);
            comando.Parameters.AddWithValue("@NombreCompletoNIT", NombreCompletoNIT);
            comando.Parameters.AddWithValue("@Conyuge", (object)Conyuge ?? DBNull.Value);
            comando.Parameters.AddWithValue("@EstadoCivil",EstadoCivil);
            comando.Parameters.AddWithValue("@Docente",NombreCompleto);
            comando.Parameters.AddWithValue("@Jubilado",Jubilado);
            comando.Parameters.AddWithValue("@Direccion",Direccion);
            comando.Parameters.AddWithValue("@IdNivelEstudioDocente", IdNivelEstudio);
            comando.Parameters.AddWithValue("@NIP",NIP);
            comando.Parameters.AddWithValue("@NIT",NIT);
            comando.Parameters.AddWithValue("@NUP",NUP);
            comando.Parameters.AddWithValue("@DUI",DUI);
            comando.Parameters.AddWithValue("@ISSS", ISSS);
            comando.Parameters.AddWithValue("@AFP", AFP);
            comando.Parameters.AddWithValue("@IdTipoEstado", IdTipoEstado);
            comando.Parameters.AddWithValue("@TelMovilPrincipalDocente", TelefonoMovilPrincipalDocente);
            comando.Parameters.AddWithValue("@TelMovilSecundarioDocente", (object)TelefonoMovilSecundarioDocente ?? DBNull.Value);
            comando.Parameters.AddWithValue("@TelCasa", TelefonoCasa);
            comando.Parameters.AddWithValue("@TelOficina", TelefonoOficina);
            comando.Parameters.AddWithValue("@TelMovilEmergencia", TelefonoMovilEmergencia);
            comando.Parameters.AddWithValue("@TelMovilEmergenciaSecundario", (object)TelefonoMovilEmergenciaSecundario ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdDocentes", IdDocente);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            Atributos_Empleado.IdDocente = IdDocente;
        }



        public bool ConsultarRegistroCompletoDelDocente(int IdDocente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_MostrarRegistroCompletoDocente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", IdDocente);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Empleado.NombreCompletoDUI = leer.GetString(2);
                    Atributos_Empleado.NombreCompletoNIT = leer.GetString(3);
                    Atributos_Empleado.Conyuge = leer.IsDBNull(4) ? String.Empty : leer.GetString(4);
                    Atributos_Empleado.EstadoCivil = leer.GetString(5);
                    Atributos_Empleado.NombreCompleto = leer.GetString(6);
                    Atributos_Empleado.Jubilado = leer.GetString(7);
                    Atributos_Empleado.Direccion = leer.GetString(8);
                    Atributos_Empleado.IdNivelDeEstudio = leer.GetInt32(9);
                    Atributos_Empleado.NIP = leer.GetString(14);
                    Atributos_Empleado.NIT = leer.GetString(15);
                    Atributos_Empleado.DUI = leer.GetString(16);
                    Atributos_Empleado.NumeroDeISSS = leer.GetString(17);
                    Atributos_Empleado.NUP = leer.GetString(18);
                    Atributos_Empleado.AFP = leer.GetString(19);
                    Atributos_Empleado.IdEstado = leer.GetInt32(20);
                    Atributos_Empleado.TelefonoMovilPrincipal = leer.GetString(23);
                    Atributos_Empleado.TelefonoMovilSecundario = leer.IsDBNull(24) ? String.Empty : leer.GetString(24);
                    Atributos_Empleado.TelefonoCasa = leer.GetString(25);
                    Atributos_Empleado.TelefonoDeOficina = leer.GetString(26);
                    Atributos_Empleado.TelefonoEmergencia = leer.GetString(29);
                    Atributos_Empleado.TelefonoDeEmergenciaSecundario = leer.IsDBNull(30) ? String.Empty : leer.GetString(30);
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

        public bool ConsultarInformacionMedicaDocente(string NombreDocente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_MostrarInformacionMedicaPorNombre";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", NombreDocente);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Empleado.IdDocente = leer.GetInt32(0);
                    Atributos_Empleado.MostrarAlergias = leer.IsDBNull(1) ? "No registrado" : leer.GetString(1);
                    Atributos_Empleado.MostrarNombreDocente = leer.GetString(2);
                    Atributos_Empleado.MostrarTelPrincipal = leer.GetString(3);
                    Atributos_Empleado.MostrarTelSecundario = leer.IsDBNull(4) ? "No registrado" : leer.GetString(4);
                    Atributos_Empleado.MostrarTelEmergenciaPrincipal = leer.GetString(5);
                    Atributos_Empleado.MostrarTelEmergenciaSecundario = leer.IsDBNull(6) ? "No registrado" : leer.GetString(6) ;
                    Atributos_Empleado.MostrarCargoDocente = leer.GetString(7);
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

        public bool ConsultarInformacionMedicaPorDUI(string DUI)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_MostrarInformacionMedicaPorDUI";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", DUI);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Empleado.IdDocente = leer.GetInt32(0);
                    Atributos_Empleado.MostrarAlergias = leer.IsDBNull(1) ? "No registrado" : leer.GetString(1);
                    Atributos_Empleado.MostrarNombreDocente = leer.GetString(2);
                    Atributos_Empleado.MostrarTelPrincipal = leer.GetString(3);
                    Atributos_Empleado.MostrarTelSecundario = leer.IsDBNull(4) ? "No registrado" : leer.GetString(4);
                    Atributos_Empleado.MostrarTelEmergenciaPrincipal = leer.GetString(5);
                    Atributos_Empleado.MostrarTelEmergenciaSecundario = leer.IsDBNull(6) ? "No registrado" : leer.GetString(6);
                    Atributos_Empleado.MostrarCargoDocente = leer.GetString(7);
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


        public void modificarDocente(
            string NombreCompleto,
            string NombreCompletoDUI,
            string NombreCompletoNIT,
            string Conyuge,
            string EstadoCivil,
            string Jubilado,
            string Direccion,
            int IdNivelEstudio,
       
            string NIP,
            string NIT,
            string DUI,
            string ISSS,
            string NUP,
            string AFP,
            int IdTipoEstado,
            string TelefonoMovilPrincipalDocente,
            string TelefonoMovilSecundarioDocente,
            string TelefonoCasa,
            string TelefonoOficina,
            string TelefonoMovilEmergencia,
            string TelefonoMovilEmergenciaSecundario,
            int idDocente
            )
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarDocentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreCompletoDUI", NombreCompletoDUI);
            comando.Parameters.AddWithValue("@NombreCompletoNIT", NombreCompletoNIT);
            comando.Parameters.AddWithValue("@Conyuge", Conyuge);
            comando.Parameters.AddWithValue("@EstadoCivil", EstadoCivil);
            comando.Parameters.AddWithValue("@Docente", NombreCompleto);
            comando.Parameters.AddWithValue("@Jubilado", Jubilado);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@IdNivelEstudioDocente", IdNivelEstudio);
           
            comando.Parameters.AddWithValue("@NIP", NIP);
            comando.Parameters.AddWithValue("@NIT", NIT);
            comando.Parameters.AddWithValue("@NUP", NUP);
            comando.Parameters.AddWithValue("@DUI", DUI);
            comando.Parameters.AddWithValue("@ISSS", ISSS);
            comando.Parameters.AddWithValue("@AFP", AFP);
            comando.Parameters.AddWithValue("@IdTipoEstado", IdTipoEstado);
            comando.Parameters.AddWithValue("@TelMovilPrincipalDocente", TelefonoMovilPrincipalDocente);
            comando.Parameters.AddWithValue("@TelMovilSecundarioDocente", TelefonoMovilSecundarioDocente);
            comando.Parameters.AddWithValue("@TelCasa", TelefonoCasa);
            comando.Parameters.AddWithValue("@TelOficina", TelefonoOficina);
            comando.Parameters.AddWithValue("@TelMovilEmergencia", TelefonoMovilEmergencia);
            comando.Parameters.AddWithValue("@TelMovilEmergenciaSecundario", TelefonoMovilEmergenciaSecundario);
            comando.Parameters.AddWithValue("@IdDocentes", idDocente);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable BuscarCargos(string dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_BuscarCargoDocente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarMaterias(string dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_BuscarMaterias";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarNivelesEstudio(string dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_BuscarNivelesEstudio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarEspecialidades(string dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_BuscarEspecialidades";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public bool BuscarNivelesEstudioVentana(string dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarNivelesEstudioVentana";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
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

        public bool BuscarCargosVentana(string dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarCargosVentana";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
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

        public bool BuscarEspecialidadesDocenteVentana(string dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarEspecialidadDocenteVentana";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
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

    }

}
