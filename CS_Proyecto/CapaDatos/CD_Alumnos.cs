using Actividad.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Proyecto.CapaNegocio;
using System.Windows.Forms;

namespace CS_Proyecto.CapaDatos
{
    internal class CD_Alumnos
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void insertarAlumno(
            string nombres,
            string apellidos,
            string nie,
            string Genero,
            string FechaNacimiento,
            string LugarNacimiento,
            string PartidaNacimiento,
            string EducacionInicial,
            string SeccionInicial,
            string AnioInicial,
            int IdInstitucion,
            int IdNacionalidad,
            string RepitiendoAnio,
            string Direccion,
            string Canton,
            string Caserio,
            int IdMunicipio,
            int IdDepartamento,
            int IdZonaResidencia,
            string EmailAlumno,
            string NumeroMiembrosFamiliares,
            string DependenciaFamiliar,
            string DependenciaEconomica,
            string LugarTrabajo,
            string Cargo,
            string EsquemaVacunacion,
            string ProcesoAcademico,
            string PoseeInternet,
            int IdTipoConexion,
            int IdEstabilidad,
            int IdProveedorPrincipal,
            string RecursosTecnologicos,
            string ResponsablePrincipal,
            string ParentescoResponsablePrincipal,
            string DuiResponsablePrincipal,
            string GeneroResponsablePrincipal,
            string EmailResponsablePrincipal,
            string LugarTrabajoResponsablePrincipal,
            string PoliticamenteExpuesto,
            string ResponsableSecundario,
            string ParentescoResponsableSecundario,
            string LugarTrabajoResponsableSecundario,
            string DuiResponsableSecundario,
            string TelefonoMovilPrincipalAlumno,
            string TelefonoMovilSecundarioAlumno,
            string TelMovilPrincipalResponsablePrincipal,
            string TelMovilSecundarioResponsablePrincipal,
            string NumeroTrabajoPrincipal,
            string NumeroTrabajoSecundario,
            string TelMovilPrincipalResponsableSecundario,
            string TelMovilSecundarioResponsableSecundario,
            string TelFijoPrincipal,
            string TelFijoSecundario
            )
        {
            int ultimoId = 0;
            comando.Connection = conexion.AbrirConexion();
            string ContarId = "select max(IdAlumno) from Alumno";
            SqlCommand selectCmd = new SqlCommand(ContarId, conexion.AbrirConexion());

            object UltimoIdExistente = selectCmd.ExecuteScalar();
            if (UltimoIdExistente != null && UltimoIdExistente != DBNull.Value)
            {
                ultimoId = Convert.ToInt32(UltimoIdExistente);
            }

            int IdAlumno = ultimoId + 1;


            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarAlumnos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombres", nombres);
            comando.Parameters.AddWithValue("@Apellidos", apellidos);
            comando.Parameters.AddWithValue("@NIE", (object)nie ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Genero", Genero);
            comando.Parameters.AddWithValue("@FechaNacimineto", FechaNacimiento);
            comando.Parameters.AddWithValue("@LugarNacimiento", LugarNacimiento);
            comando.Parameters.AddWithValue("@Partida", PartidaNacimiento);
            comando.Parameters.AddWithValue("@Educinicial", EducacionInicial);
            comando.Parameters.AddWithValue("@SeccionInicial", SeccionInicial);
            comando.Parameters.AddWithValue("@AnioInicial", AnioInicial);
            comando.Parameters.AddWithValue("@IdInstProcedencia", IdInstitucion);
            comando.Parameters.AddWithValue("@IdNacionalidad", IdNacionalidad);
            comando.Parameters.AddWithValue("@RepitiendoAño", RepitiendoAnio);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@Canton", Canton);
            comando.Parameters.AddWithValue("@Caserio", Caserio);
            comando.Parameters.AddWithValue("@IdMunicipio", IdMunicipio);
            comando.Parameters.AddWithValue("@IdDepartamento", IdDepartamento);
            comando.Parameters.AddWithValue("@IdZonaResidencia", IdZonaResidencia);
            comando.Parameters.AddWithValue("@EmailAlumno", EmailAlumno);
            comando.Parameters.AddWithValue("@NumMiembrosFamilia", NumeroMiembrosFamiliares);
            comando.Parameters.AddWithValue("@DependeciaFamiliar", DependenciaFamiliar);
            comando.Parameters.AddWithValue("@DependenciaEconomica", DependenciaEconomica);
            comando.Parameters.AddWithValue("@LugarDeTrabajo", LugarTrabajo);
            comando.Parameters.AddWithValue("@Cargo", Cargo);
            comando.Parameters.AddWithValue("@EsquemaVacunacion", EsquemaVacunacion);
            comando.Parameters.AddWithValue("@ProcesoAcademico", ProcesoAcademico);
            comando.Parameters.AddWithValue("@PoseeInternet", PoseeInternet);
            comando.Parameters.AddWithValue("@IdTipoConexion", IdTipoConexion);
            comando.Parameters.AddWithValue("@IdEstabilidad", IdEstabilidad);
            comando.Parameters.AddWithValue("@IdProveedorPrincipal", IdProveedorPrincipal);
            comando.Parameters.AddWithValue("@RecursosTecnologicos", RecursosTecnologicos);
            comando.Parameters.AddWithValue("@NombreCompletoResponsablePrincipal", ResponsablePrincipal);
            comando.Parameters.AddWithValue("@ParentescoResponsablePrincipal", ParentescoResponsablePrincipal);
            comando.Parameters.AddWithValue("@DUIResponsablePrincipal", DuiResponsablePrincipal);
            comando.Parameters.AddWithValue("@GeneroResponsablePrincipal", GeneroResponsablePrincipal);
            comando.Parameters.AddWithValue("@EmailResponsablePrincipal", (object)EmailResponsablePrincipal ?? DBNull.Value);
            comando.Parameters.AddWithValue("@LugarTrabajoResponsablePrincipal", LugarTrabajoResponsablePrincipal);
            comando.Parameters.AddWithValue("@PoliticamenteExpuesto", PoliticamenteExpuesto);
            comando.Parameters.AddWithValue("@NombreCompletoResponsableSecundario", ResponsableSecundario);
            comando.Parameters.AddWithValue("@ParentescoResponsableSecundario", ParentescoResponsableSecundario);
            comando.Parameters.AddWithValue("@LugarTrabajoResponsableSecundario", LugarTrabajoResponsableSecundario);
            comando.Parameters.AddWithValue("@DUIResponsableSecundario", DuiResponsableSecundario);
            comando.Parameters.AddWithValue("@TelMovilPrincipalAlumno", TelefonoMovilPrincipalAlumno);
            comando.Parameters.AddWithValue("@TelMovilSecundarioAlumno", (object)TelefonoMovilSecundarioAlumno ?? DBNull.Value);
            comando.Parameters.AddWithValue("@TelMovilPrincipalResponsablePrincipal", TelMovilPrincipalResponsablePrincipal);
            comando.Parameters.AddWithValue("@TelMovilSecundarioResponsablePrincipal", (object)TelMovilSecundarioResponsablePrincipal ?? DBNull.Value);
            comando.Parameters.AddWithValue("@NumeroTrabajoPrincipal", NumeroTrabajoPrincipal);
            comando.Parameters.AddWithValue("@NumeroTrabajoSecundario", (object)NumeroTrabajoSecundario ?? DBNull.Value);
            comando.Parameters.AddWithValue("@TelMovilPrincipalResponsableSecundario", TelMovilPrincipalResponsableSecundario);
            comando.Parameters.AddWithValue("@TelMovilSecundarioResponsableSecundario", (object)TelMovilSecundarioResponsableSecundario ?? DBNull.Value);
            comando.Parameters.AddWithValue("@TelFijoPrincipal", (object)TelFijoPrincipal ?? DBNull.Value);
            comando.Parameters.AddWithValue("@TelFijoSecundario", (object)TelFijoSecundario ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdAlumno", IdAlumno);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            Atributos_Alumno.IdAlumno = IdAlumno;
        }

        public DataTable MostrarInstituciones()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from InstitucionesRegistradas";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarInstitucionesMantenimiento()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select IdInstProcedencia 'IdInst', NombreInst 'Instituciones' from InstitucionesRegistradas";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarNacionalidades()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from NacionalidadesRegistradas";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarNacionalidadesMantenimiento()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select IdNacionalidad, NombreNacionalidad as 'Nacionalidades' from NacionalidadesRegistradas order by  IdNacionalidad desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarDepartamentos()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from DepartamentosRegistrados";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarMunicipios(string Departamento)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Municipio where Departamento='" + Departamento + "'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarZonasResidencia()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from ZonasResidenciaRegistradas";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarTiposConexion()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TipoConexionesRegistradas";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarEstabilidades()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from EstabilidadesRegistradas";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarPRoveedoresInternet()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from ProveedoresRegistrados";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarRecursosTecnologicos()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from RecursosTecnologicosRegistrados";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void InsertarMedicamento(string NombreMedicamento, string Dosis, string Frecuencia, int IdAlumno)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarMedicamentosAlumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreMedicamento", (object)NombreMedicamento ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Dosis", (object)Dosis ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Frecuencia", (object)Frecuencia ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdAlumno", IdAlumno);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarMedicamento(string NombreMedicamento, string Dosis, string Frecuencia, int IdMedicamento)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarMedicamentosAlumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreMedicamento", (object)NombreMedicamento ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Dosis", (object)Dosis ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Frecuencia", (object)Frecuencia ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdDetalleMedicamentosAlumno", IdMedicamento);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarMedicamento(int IdMedicamento)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_EliminarMedicamentosAlumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdDetalleMedicamentosAlumno", IdMedicamento);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void InsertarInfecciones(string NombreAfeccion, string Tipo, string Procedimiento, int IdAlumno)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarInformacionMedicaAlumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreAfeccion", (object)NombreAfeccion ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Tipo", (object)Tipo ?? DBNull.Value);
            comando.Parameters.AddWithValue("@ProcedimientoMedico", (object)Procedimiento ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdAlumno", IdAlumno);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarInfecciones(string NombreAfeccion, string Tipo, string Procedimiento, int IdAfeccion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarInformacionMedicaAlumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreAfeccion", (object)NombreAfeccion ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Tipo", (object)Tipo ?? DBNull.Value);
            comando.Parameters.AddWithValue("@ProcedimientoMedico", (object)Procedimiento ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdInformacionMedicaAlumno", IdAfeccion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarAfecciones(int IdAfeccion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_EliminarInformacionMedicaAlumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdInformacionMedicaAlumno", IdAfeccion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void InsertarDetallesMedicos(string PermiteActividadFisica, string Alergias, int IdAlumno)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarDetallesMedicosAlumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@PermiteActividadFisica", (object)PermiteActividadFisica ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Alergias", (object)Alergias ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdAlumno", IdAlumno);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarDetallesMedicos(string PermiteActividadFisica, string Alergias, int IdAlumno)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarDetallesMedicosAlumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@PermiteActividadFisica", (object)PermiteActividadFisica ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Alergias", (object)Alergias ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdAlumno", IdAlumno);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable MostrarUltimoAlumnoRegistrado()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM UltimoAlumnoRegistrado ORDER BY Id DESC";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;

        }

        public void InsertaComprobanteAlumno(double CantidadCancelada, double CantidadRestante, int TipoPago, int TipoPagoMatricula, int Seccion, int Especialidad, int Estado, string Talonario, int IdAlumno)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarComprobanteDePagoConIdentificacion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CantidadCancelada", CantidadCancelada);
            comando.Parameters.AddWithValue("@CantidadPendiente", CantidadRestante);
            comando.Parameters.AddWithValue("@IdTipoPago", TipoPago);
            comando.Parameters.AddWithValue("@IdTipoPagoMatricula", TipoPagoMatricula);
            comando.Parameters.AddWithValue("@IdSecciones", Seccion);
            comando.Parameters.AddWithValue("@IdEspecialidades", Especialidad);
            comando.Parameters.AddWithValue("@IdTipoEstado", Estado);
            comando.Parameters.AddWithValue("@NumeroDeTalonario", Talonario);
            comando.Parameters.AddWithValue("@IdAlumno", IdAlumno);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable MostrarTiposDePago()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TiposDePagoRegistrados";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarTiposDePagatricula()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TipoPagoMatricula";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarEspecialidadesAlumnoRegistradas()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from EspecialidadesDeAlumnosRegistradas";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarSeccionesRegistradas()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from SeccionesAlumnosRegistrados";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrasTiposEstado()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TipoEstadosRegistrados";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;

        }

        //Ventanas Funcionales
        public void InsertarInstituciones(string NombreInstitucion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarInstProcedencia";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreInst", NombreInstitucion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarInstituciones(string NombreInstitucion, int IdInts)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarInstProcedencia";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdInstProcedencia", IdInts);
            comando.Parameters.AddWithValue("@NombreInst", NombreInstitucion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void InsertarNacionalidad(string Nacionalidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarNacionalidad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreNacionalidad", Nacionalidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarNacionalidad(string Nacionalidad, int IdNac)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarNacionalidad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdNacionalidad", IdNac);
            comando.Parameters.AddWithValue("@NombreNacionalidad", Nacionalidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void InsertarNieTemporal(string NieTemporal, int IdAlumno)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarNieTemporal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NumeroNie", NieTemporal);
            comando.Parameters.AddWithValue("@IdAlumno", IdAlumno);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //Consultas
        public DataTable ConsultarUltimoAlumnoParteMatriculaUno(string datobusqueda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_buscarAlumnoPorNombresYApellidos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", datobusqueda);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ConsultarUltimoAlumnoParteMatriculaDos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from AlumnosRegistrados order by IdAlumno desc";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ConsultarUltimoAlumnoParteMatriculaDos(string datobusqueda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_BuscarAlumnoRegistradoMatriculaParteDosPorNombresYApellidos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", datobusqueda);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        //Consultar Informacion Medica

        public bool ConsultarInformacionMedicaAlumno(string Dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ConsultarInformacionMedicaAlumnos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", Dato);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Alumno.MostrarNombresAlumno = leer.GetString(0);
                    Atributos_Alumno.MostrarApellidosAlumno = leer.GetString(1);
                    Atributos_Alumno.MostrarSeccionAlumno = leer.IsDBNull(2) ? "No Establecido" : leer.GetString(2);
                    Atributos_Alumno.MostrarAlergias = leer.IsDBNull(3) ? "No Posee" : leer.GetString(3);
                    Atributos_Alumno.MostrarPermiteActividadFisica = leer.IsDBNull(4) ? "No Establecido" : leer.GetString(4);
                    Atributos_Alumno.MostrarRespPrincipal = leer.GetString(5);
                    Atributos_Alumno.MostrarTelPrincipalResPrincipal = leer.GetString(6);
                    Atributos_Alumno.MostrarRespSecundario = leer.GetString(7);
                    Atributos_Alumno.MostrarTelSecundarioResSecundario = leer.GetString(8);
                    Atributos_Alumno.MostrarTelSecundarioResPrincipal = leer.IsDBNull(9) ? "No Posee" : leer.GetString(9);

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

        public DataTable ConsultarMedicamentosAlumno(string datobusqueda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ConsultarMedicamentosAlumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", datobusqueda);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable ConsultarAfeccionesAlumno(string datobusqueda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ConsultarAfeccionesAlumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", datobusqueda);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public bool ConsultarRegistroCompletoDelAlumno(int IdAlumno)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_MostrarRegistroCompletoDeAlumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", IdAlumno);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Alumno.Nombres = leer.GetString(3);
                    Atributos_Alumno.Apellidos = leer.GetString(4);
                    Atributos_Alumno.NIE = leer.IsDBNull(5) ? String.Empty : leer.GetString(5);
                    Atributos_Alumno.Genero = leer.GetString(6);
                    Atributos_Alumno.FechaNacimiento = leer.GetString(7);
                    Atributos_Alumno.LugarNacimiento = leer.GetString(8);
                    Atributos_Alumno.Partida = leer.GetString(9);
                    Atributos_Alumno.EducacionInicial = leer.GetString(10);
                    Atributos_Alumno.SeccionInicial = leer.GetString(11);
                    Atributos_Alumno.AnioInicial = leer.GetString(12);
                    Atributos_Alumno.IdInstitucionProcedencia = leer.GetInt32(13);
                    Atributos_Alumno.IdNacionalidad = leer.GetInt32(14);
                    Atributos_Alumno.RepitiendoAnio = leer.GetString(15);
                    Atributos_Alumno.Direccion = leer.GetString(18);
                    Atributos_Alumno.Canton = leer.GetString(19);
                    Atributos_Alumno.Caserio = leer.GetString(20);
                    Atributos_Alumno.IdMunicipio = leer.GetInt32(21);
                    Atributos_Alumno.IdDepartamento = leer.GetInt32(22);
                    Atributos_Alumno.IdZonaResidencia = leer.GetInt32(23);
                    Atributos_Alumno.EmailAumno = leer.GetString(24);
                    Atributos_Alumno.NumeroMiembrosFamilia = leer.GetString(27);
                    Atributos_Alumno.DependenciaFamiliar = leer.GetString(28);
                    Atributos_Alumno.DependenciaEconomica = leer.GetString(29);
                    Atributos_Alumno.LugarTrabajo = leer.GetString(30);
                    Atributos_Alumno.Cargo = leer.GetString(31);
                    Atributos_Alumno.EsquemaVacunacion = leer.GetString(34);
                    Atributos_Alumno.ProcesoAcademico = leer.GetString(35);
                    Atributos_Alumno.PoseeInternet = leer.GetString(36);
                    Atributos_Alumno.IdTipoConexion = leer.GetInt32(37);
                    Atributos_Alumno.IdEstabilidad = leer.GetInt32(38);
                    Atributos_Alumno.IdProveedorPrincipal = leer.GetInt32(39);
                    Atributos_Alumno.RecursosTecnologicos = leer.GetString(40);
                    Atributos_Alumno.ResponsablePrincipal = leer.GetString(43);
                    Atributos_Alumno.ParentescoResponsablePrincipal = leer.GetString(44);
                    Atributos_Alumno.DuiResponsablePrincipal = leer.GetString(45);
                    Atributos_Alumno.GeneroResponsablePrincipal = leer.GetString(46);
                    Atributos_Alumno.EmailResponsablePrincipal = leer.IsDBNull(47) ? String.Empty : leer.GetString(47);
                    Atributos_Alumno.LugarTrabajoResponsablePrincipal = leer.GetString(48);
                    Atributos_Alumno.PoliticamenteExpuesto = leer.GetString(49);
                    Atributos_Alumno.ResponsableSecundario = leer.GetString(52);
                    Atributos_Alumno.ParentescoResponsableSecundario = leer.GetString(53);
                    Atributos_Alumno.LugarTrabajoResponsableSecundario = leer.GetString(54);
                    Atributos_Alumno.DuiResponsableSecundario = leer.GetString(55);
                    Atributos_Alumno.TelMovilPrincipalAlumno = leer.GetString(66);
                    Atributos_Alumno.TelMovilSecundarioAlumno = leer.IsDBNull(67) ? String.Empty : leer.GetString(67);
                    Atributos_Alumno.TelMovilPrincipalResponsablePrincipal = leer.GetString(58);
                    Atributos_Alumno.TelMovilSecundarioResponsablePrincipal = leer.IsDBNull(59) ? String.Empty : leer.GetString(59);
                    Atributos_Alumno.NumeroTrabajoPrincipal = leer.IsDBNull(70) ? String.Empty : leer.GetString(70);
                    Atributos_Alumno.NumeroTrabajoSecundario = leer.IsDBNull(71) ? String.Empty : leer.GetString(71);
                    Atributos_Alumno.TelMovilPrincipalResponsableSecundario = leer.GetString(62);
                    Atributos_Alumno.TelMovilSecundarioResponsableSecundario = leer.IsDBNull(63) ? String.Empty : leer.GetString(63);
                    Atributos_Alumno.TelFijoPrincipal = leer.IsDBNull(74) ? String.Empty : leer.GetString(74);
                    Atributos_Alumno.TelFijoSecundario = leer.IsDBNull(75) ? String.Empty : leer.GetString(75);
                    Atributos_Alumno.CantidadCancelada = leer.IsDBNull(79) ? 0.00 : leer.GetDouble(79);
                    Atributos_Alumno.CantidadPendiente = leer.IsDBNull(80) ? 0.00 : leer.GetDouble(80);
                    Atributos_Alumno.IdTipoPago = leer.IsDBNull(81) ? -1 : leer.GetInt32(81);
                    Atributos_Alumno.IdTipoPagoMatricula = leer.IsDBNull(82) ? -1 : leer.GetInt32(82);
                    Atributos_Alumno.IdSecciones = leer.IsDBNull(85) ? -1 : leer.GetInt32(85);
                    Atributos_Alumno.IdEspecialidades = leer.IsDBNull(86) ? -1 : leer.GetInt32(86);
                    Atributos_Alumno.IdTipoEstado = leer.IsDBNull(87) ? -1 : leer.GetInt32(87);
                    Atributos_Alumno.NumeroDeTalonario = leer.IsDBNull(88) ? String.Empty : leer.GetString(88);
                    Atributos_Alumno.NieTemporal = leer.IsDBNull(91) ? String.Empty : leer.GetString(91);
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


        public void ModificarAlumno(
           string nombres,
            string apellidos,
            string nie,
            string Genero,
            string FechaNacimiento,
            string LugarNacimiento,
            string PartidaNacimiento,
            string EducacionInicial,
            string SeccionInicial,
            string AnioInicial,
            int IdInstitucion,
            int IdNacionalidad,
            string RepitiendoAnio,
            string Direccion,
            string Canton,
            string Caserio,
            int IdMunicipio,
            int IdDepartamento,
            int IdZonaResidencia,
            string EmailAlumno,
            string NumeroMiembrosFamiliares,
            string DependenciaFamiliar,
            string DependenciaEconomica,
            string LugarTrabajo,
            string Cargo,
            string EsquemaVacunacion,
            string ProcesoAcademico,
            string PoseeInternet,
            int IdTipoConexion,
            int IdEstabilidad,
            int IdProveedorPrincipal,
            string RecursosTecnologicos,
            string ResponsablePrincipal,
            string ParentescoResponsablePrincipal,
            string DuiResponsablePrincipal,
            string GeneroResponsablePrincipal,
            string EmailResponsablePrincipal,
            string LugarTrabajoResponsablePrincipal,
            string PoliticamenteExpuesto,
            string ResponsableSecundario,
            string ParentescoResponsableSecundario,
            string LugarTrabajoResponsableSecundario,
            string DuiResponsableSecundario,
            string TelefonoMovilPrincipalAlumno,
            string TelefonoMovilSecundarioAlumno,
            string TelMovilPrincipalResponsablePrincipal,
            string TelMovilSecundarioResponsablePrincipal,
            string NumeroTrabajoPrincipal,
            string NumeroTrabajoSecundario,
            string TelMovilPrincipalResponsableSecundario,
            string TelMovilSecundarioResponsableSecundario,
            string TelFijoPrincipal,
            string TelFijoSecundario,
            double CantidadCancelada,
            double CantidadRestante,
            int TipoPago,
            int TipoPagoMatricula,
            int Seccion,
            int Especialidad,
            int Estado,
            string Talonario
           

            )
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarAlumnos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.AddWithValue("@Nombres", nombres);
            comando.Parameters.AddWithValue("@Apellidos", apellidos);
            comando.Parameters.AddWithValue("@NIE", (object)nie ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Genero", Genero);
            comando.Parameters.AddWithValue("@FechaNacimineto", FechaNacimiento);
            comando.Parameters.AddWithValue("@LugarNacimiento", LugarNacimiento);
            comando.Parameters.AddWithValue("@Partida", PartidaNacimiento);
            comando.Parameters.AddWithValue("@Educinicial", EducacionInicial);
            comando.Parameters.AddWithValue("@SeccionInicial", SeccionInicial);
            comando.Parameters.AddWithValue("@AnioInicial", AnioInicial);
            comando.Parameters.AddWithValue("@IdInstProcedencia", IdInstitucion);
            comando.Parameters.AddWithValue("@IdNacionalidad", IdNacionalidad);
            comando.Parameters.AddWithValue("@RepitiendoAño", RepitiendoAnio);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@Canton", Canton);
            comando.Parameters.AddWithValue("@Caserio", Caserio);
            comando.Parameters.AddWithValue("@IdMunicipio", IdMunicipio);
            comando.Parameters.AddWithValue("@IdDepartamento", IdDepartamento);
            comando.Parameters.AddWithValue("@IdZonaResidencia", IdZonaResidencia);
            comando.Parameters.AddWithValue("@EmailAlumno", EmailAlumno);
            comando.Parameters.AddWithValue("@NumMiembrosFamilia", NumeroMiembrosFamiliares);
            comando.Parameters.AddWithValue("@DependeciaFamiliar", DependenciaFamiliar);
            comando.Parameters.AddWithValue("@DependenciaEconomica", DependenciaEconomica);
            comando.Parameters.AddWithValue("@LugarDeTrabajo", LugarTrabajo);
            comando.Parameters.AddWithValue("@Cargo", Cargo);
            comando.Parameters.AddWithValue("@EsquemaVacunacion", EsquemaVacunacion);
            comando.Parameters.AddWithValue("@ProcesoAcademico", ProcesoAcademico);
            comando.Parameters.AddWithValue("@PoseeInternet", PoseeInternet);
            comando.Parameters.AddWithValue("@IdTipoConexion", IdTipoConexion);
            comando.Parameters.AddWithValue("@IdEstabilidad", IdEstabilidad);
            comando.Parameters.AddWithValue("@IdProveedorPrincipal", IdProveedorPrincipal);
            comando.Parameters.AddWithValue("@RecursosTecnologicos", RecursosTecnologicos);
            comando.Parameters.AddWithValue("@NombreCompletoResponsablePrincipal", ResponsablePrincipal);
            comando.Parameters.AddWithValue("@ParentescoResponsablePrincipal", ParentescoResponsablePrincipal);
            comando.Parameters.AddWithValue("@DUIResponsablePrincipal", DuiResponsablePrincipal);
            comando.Parameters.AddWithValue("@GeneroResponsablePrincipal", GeneroResponsablePrincipal);
            comando.Parameters.AddWithValue("@EmailResponsablePrincipal", (object)EmailResponsablePrincipal ?? DBNull.Value);
            comando.Parameters.AddWithValue("@LugarTrabajoResponsablePrincipal", LugarTrabajoResponsablePrincipal);
            comando.Parameters.AddWithValue("@PoliticamenteExpuesto", PoliticamenteExpuesto);
            comando.Parameters.AddWithValue("@NombreCompletoResponsableSecundario", ResponsableSecundario);
            comando.Parameters.AddWithValue("@ParentescoResponsableSecundario", ParentescoResponsableSecundario);
            comando.Parameters.AddWithValue("@LugarTrabajoResponsableSecundario", LugarTrabajoResponsableSecundario);
            comando.Parameters.AddWithValue("@DUIResponsableSecundario", DuiResponsableSecundario);
            comando.Parameters.AddWithValue("@TelMovilPrincipalAlumno", TelefonoMovilPrincipalAlumno);
            comando.Parameters.AddWithValue("@TelMovilSecundarioAlumno", (object)TelefonoMovilSecundarioAlumno ?? DBNull.Value);
            comando.Parameters.AddWithValue("@TelMovilPrincipalResponsablePrincipal", TelMovilPrincipalResponsablePrincipal);
            comando.Parameters.AddWithValue("@TelMovilSecundarioResponsablePrincipal", (object)TelMovilSecundarioResponsablePrincipal ?? DBNull.Value);
            comando.Parameters.AddWithValue("@NumeroTrabajoPrincipal", NumeroTrabajoPrincipal);
            comando.Parameters.AddWithValue("@NumeroTrabajoSecundario", (object)NumeroTrabajoSecundario ?? DBNull.Value);
            comando.Parameters.AddWithValue("@TelMovilPrincipalResponsableSecundario", TelMovilPrincipalResponsableSecundario);
            comando.Parameters.AddWithValue("@TelMovilSecundarioResponsableSecundario", (object)TelMovilSecundarioResponsableSecundario ?? DBNull.Value);
            comando.Parameters.AddWithValue("@TelFijoPrincipal", (object)TelFijoPrincipal ?? DBNull.Value);
            comando.Parameters.AddWithValue("@TelFijoSecundario", (object)TelFijoSecundario ?? DBNull.Value);
            comando.Parameters.AddWithValue("@CantidadCancelada", CantidadCancelada);
            comando.Parameters.AddWithValue("@CantidadPendiente", CantidadRestante);
            comando.Parameters.AddWithValue("@IdTipoPago", TipoPago);
            comando.Parameters.AddWithValue("@IdTipoPagoMatricula", TipoPagoMatricula);
            comando.Parameters.AddWithValue("@IdSecciones", Seccion);
            comando.Parameters.AddWithValue("@IdEspecialidades", Especialidad);
            comando.Parameters.AddWithValue("@IdTipoEstado", Estado);
            comando.Parameters.AddWithValue("@NumeroDeTalonario", Talonario);
            comando.Parameters.AddWithValue("@IdAlumno", Atributos_Alumno.IdAlumno);
            comando.Parameters.AddWithValue("@IdResponsablePrincipal", Atributos_Alumno.IdAlumno);
            comando.Parameters.AddWithValue("@IdResponsableSecundario", Atributos_Alumno.IdAlumno);
           

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable ConsultarMedicamentosAlumnoPorId(int datobusqueda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ConsultarMedicamentosAlumnoPorId";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", datobusqueda);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ConsultarAfeccionesAlumnoPorId(int datobusqueda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ConsultarAfeccionesAlumnoPorId";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", datobusqueda);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public bool ConsultarDetallesMedicosAlumnoPorId(int datobusqueda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ConsultarDetallesMedicosAlumnoPorId";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", datobusqueda);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Alumno.MostrarPermiteActividadFisica = leer.IsDBNull(3) ? "No Establecido" : leer.GetString(3);
                    Atributos_Alumno.MostrarAlergias = leer.IsDBNull(4) ? "No Posee" : leer.GetString(4);
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

        public void ModificarNieTemporal(string NieTemporal, int IdAlumno)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarNieTemporal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NumeroNie", (object)NieTemporal ?? DBNull.Value);
            comando.Parameters.AddWithValue("@IdAlumno", IdAlumno);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public DataTable MostrarAlumnosEnLetraPago()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from AlumnosEnLetraPago";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ConsultarAlumnosEnLetraPago(string datobusqueda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_BuscarAlumnoEnLetraPago";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", datobusqueda);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public bool CantidadAlumnosEnLetraPago()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CantidadDeAlumnosEnLetraPago";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Alumno.AlumnosEnLetraDePago = leer.IsDBNull(0) ? 0 : leer.GetInt32(0);
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

        public DataTable MostrarAlumnosConNieTemporal()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from AlumnosConNieTemporal";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ConsultarAlumnosConNieTemporal(string datobusqueda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ConsultarAlumnosConNieTemporal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", datobusqueda);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public bool CantidadAlumnosConNieTemporal()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CantidadDeAlumnosConNieTemporal";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Alumno.AlumnosConNieTemporal = leer.IsDBNull(0) ? 0 : leer.GetInt32(0);
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

        public DataTable BuscarNacionalidades(string dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarNacionalidades";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarInstituciones(string dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarInstitucionesProcedencia";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public bool BuscarInstitucionesVentana(string dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarInstitucionesProcedenciaVentana";
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

        public bool BuscarNacionalidadesVentana(string dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarNacionalidadesVentana";
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



        public void InactivarAlumnos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InactivarAlumnos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public List<string> ObtenerCorreosAdministradores()
        {
            List<string> correos = new List<string>();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select Correo from Usuario where IdRol = 1";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    correos.Add(leer.GetString(0));
                }
                leer.Close();
                conexion.CerrarConexion();

                Atributos_Alumno.CorreosAdmins = correos;
            }
            else
            {
                leer.Close();
                conexion.CerrarConexion();
            }

            return correos;
        }




        public bool ObtenerUltimoNieTemporal()
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "obtenerUltimoNieTemporal";

                // Iniciar transacción
                using (SqlTransaction transaccion = comando.Connection.BeginTransaction())
                {
                    comando.Transaction = transaccion;

                    leer = comando.ExecuteReader();

                    if (leer.HasRows && leer.Read())
                    {
                        string ultimoNieTemporal = leer.IsDBNull(0) ? "900000" : leer.GetString(0);

                        int nuevoNieTemporal = int.Parse(ultimoNieTemporal) + 1;
                        Atributos_Alumno.NieTemporal = nuevoNieTemporal.ToString();

                        comando.CommandText = "UPDATE NieTemporal SET NumeroNie = @NuevoNieTemporal";
                        comando.Parameters.AddWithValue("@NuevoNieTemporal", Atributos_Alumno.NieTemporal);
                        comando.ExecuteNonQuery();

                        transaccion.Commit();

                        leer.Close();
                        conexion.CerrarConexion();
                        return true;
                    }
                    else
                    {
                        transaccion.Rollback();
                        conexion.CerrarConexion();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }


        public DataTable MostrarTipoPagoMatriculas()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from PrecioTipoMatricula ORDER BY IdTipoPagoMatricula DESC";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void InsertarTipoPagoMatriculas(string Matricula, double precio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarTipoPagoMatricula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Matricula);
            comando.Parameters.AddWithValue("@Precio", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarTipoPagoMatriculas(string Matricula, double precio, int Id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarTipoPagoMatricula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", Id);
            comando.Parameters.AddWithValue("@Nombre", Matricula);
            comando.Parameters.AddWithValue("@Precio", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }



        public DataTable MostrarFormasDePago()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select IdTipoPago, NombreTipoPago 'Formas de pago' from TipoPago\r\n";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void InsertarFormasDePago(string tipo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_AgregarTipoPago";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreTipoPago", tipo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarFormasDePago(string tipo, int Id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ModificarTipoPago";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdTipoPago", Id);
            comando.Parameters.AddWithValue("@NombreTipoPago", tipo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public bool SaberPrecioMatricula(string Dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarPrecioTipoPagoMatricula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", Dato);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Alumno.PrecioMatriculaSegunTipo = leer.GetDouble(0);
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


        public List<string> ObtenerCorreoAlumnoResponsable(int Dato)
        {
            List<string> correosinscripcion = new List<string>();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ObtenerCorreoAlumnoResponsable";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", Dato);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    //correosinscripcion.Add(leer.GetString(0));
                    correosinscripcion.Add(leer.GetString(1));
                    Atributos_Alumno.AlumnoInscrito = leer.IsDBNull(2) ? "" : leer.GetString(2);
                    Atributos_Alumno.ResponsableInscrito = leer.IsDBNull(3) ? "" : leer.GetString(3);
                }
                leer.Close();
                conexion.CerrarConexion();

                Atributos_Alumno.CorreosInscripcionAlumnoResponsable = correosinscripcion;
            }
            else
            {
                leer.Close();
                conexion.CerrarConexion();
            }

            return correosinscripcion;
        }

    }
}
