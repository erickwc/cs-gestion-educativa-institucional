using Actividad.CapaDatos;
using CS_Proyecto.Atributos;
using CS_Proyecto.CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Proyecto.CapaDatos
{
    internal class CD_reportes
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public DataTable UsuariosActivos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from r_UsuariosActivos";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable UsuariosInactivos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from r_UsuariosInactivos";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable UsuariosRolAdministradores()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from r_UsuariosAdministradores";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable UsuariosRolUsuarios()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from r_UsuariosSecundarios";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }


        //EMPLEADOS

        public DataTable EmpleadosRegistradosActivosInactivos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from r_docentesActivosInactivos";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable EmpleadosActivos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from r_docentesActivos";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable EmpleadosInactivos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from r_docentesInactivos";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarEmpleadosSujetoACargo(string Dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "r_docentessujetoACargo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", Dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarEmpleadosSujetoAEspecialidad(string Dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "r_docentesSujetoaEspecialidad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", Dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarEmpleadosSujetoNivelesEstudio(string Dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "r_docentesSujetoaNivelEstudio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", Dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarCargos()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from r_CargosDocente";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarEspecialidades()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from r_Especialidades";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarNivelesEstudio()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from r_Nivelesdeestudio";
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

        //secciones

        public DataTable EstadisticaGeneral()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from EstadisticaGeneral";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable EstadisticaGeneralSujetoATipo(string Dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarEstadisticaGeneralPorTipo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", Dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable EstadisticaGeneralSujetoAEspecialidad(string Dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarEstadisticaGeneralPorEspecialidad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", Dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable TipoSecciones()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from TipoSeccion";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable TipoEspecialidades()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Especialidades";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


        //Alumnos

        public DataTable AlumnosInactivos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from r_AlumnosInactivos";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable AlumnosActivos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from r_AlumnosActivos";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable AlumnosConNieTemporal()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from r_AlumnosConNieTemporal";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable AlumnosConLetraPago()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from r_AlumnosConLetraPago";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable AlumnosSujetoATipo(string Dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "r_AlumnosSujetoTipoSeccion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", Dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable AlumnosSujetoASeccion(string Dato)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "r_alumnosSujetoSeccion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", Dato);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable AlumnosMatriculadosGeneral()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from alumnosMatriculadosGeneral";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable AlumnosMatriculadosActivos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from alumnosMatriculadosActivos";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable AlumnosMatriculadosInactivos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from alumnosMatriculadosInactivos";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //ALUMNO INDIVIDUAL

        public bool ConsultarRegistroCompletoDelAlumnoReporte(int IdAlumno)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_MostrarRegistroCompletoDeAlumnoParaReporte";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", IdAlumno);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Reportes.Nombres = leer.GetString(3);
                    Atributos_Reportes.Apellidos = leer.GetString(4);
                    Atributos_Reportes.NIE = leer.IsDBNull(5) ? String.Empty : leer.GetString(5);
                    Atributos_Reportes.Genero = leer.GetString(6);
                    Atributos_Reportes.FechaNacimiento = leer.GetString(7);
                    Atributos_Reportes.LugarNacimiento = leer.GetString(8);
                    Atributos_Reportes.Partida = leer.GetString(9);
                    Atributos_Reportes.EducacionInicial = leer.GetString(10);
                    Atributos_Reportes.SeccionInicial = leer.GetString(11);
                    Atributos_Reportes.AnioInicial = leer.GetString(12);
                    Atributos_Reportes.InstitucionProcedencia = leer.GetString(18);
                    Atributos_Reportes.Nacionalidad = leer.GetString(20);
                    Atributos_Reportes.RepitiendoAnio = leer.GetString(15);
                    Atributos_Reportes.Direccion = leer.GetString(22);
                    Atributos_Reportes.Canton = leer.GetString(23);
                    Atributos_Reportes.Caserio = leer.GetString(24);
                    Atributos_Reportes.Municipio = leer.GetString(31);
                    Atributos_Reportes.Departamento = leer.GetString(32);
                    Atributos_Reportes.ZonaResidencia = leer.GetString(36);
                    Atributos_Reportes.EmailAumno = leer.GetString(28);
                    Atributos_Reportes.NumeroMiembrosFamilia = leer.GetString(38);
                    Atributos_Reportes.DependenciaFamiliar = leer.GetString(39);
                    Atributos_Reportes.DependenciaEconomica = leer.GetString(40);
                    Atributos_Reportes.LugarTrabajo = leer.GetString(41);
                    Atributos_Reportes.Cargo = leer.GetString(42);
                    Atributos_Reportes.EsquemaVacunacion = leer.GetString(45);
                    Atributos_Reportes.ProcesoAcademico = leer.GetString(46);
                    Atributos_Reportes.PoseeInternet = leer.GetString(47);
                    Atributos_Reportes.TipoConexion = leer.GetString(54);
                    Atributos_Reportes.Estabilidad = leer.GetString(56);
                    Atributos_Reportes.ProveedorPrincipal = leer.GetString(58);
                    Atributos_Reportes.RecursosTecnologicos = leer.GetString(51);
                    Atributos_Reportes.ResponsablePrincipal = leer.GetString(60);
                    Atributos_Reportes.ParentescoResponsablePrincipal = leer.GetString(61);
                    Atributos_Reportes.DuiResponsablePrincipal = leer.GetString(62);
                    Atributos_Reportes.GeneroResponsablePrincipal = leer.GetString(63);
                    Atributos_Reportes.EmailResponsablePrincipal = leer.IsDBNull(64) ? "N/A" : leer.GetString(64);
                    Atributos_Reportes.LugarTrabajoResponsablePrincipal = leer.GetString(65);
                    Atributos_Reportes.PoliticamenteExpuesto = leer.GetString(66);
                    Atributos_Reportes.ResponsableSecundario = leer.GetString(69);
                    Atributos_Reportes.ParentescoResponsableSecundario = leer.GetString(70);
                    Atributos_Reportes.LugarTrabajoResponsableSecundario = leer.GetString(71);
                    Atributos_Reportes.DuiResponsableSecundario = leer.GetString(72);
                    Atributos_Reportes.TelMovilPrincipalAlumno = leer.GetString(83);
                    Atributos_Reportes.TelMovilSecundarioAlumno = leer.IsDBNull(84) ? "N/A" : leer.GetString(84);
                    Atributos_Reportes.TelMovilPrincipalResponsablePrincipal = leer.GetString(75);
                    Atributos_Reportes.TelMovilSecundarioResponsablePrincipal = leer.IsDBNull(76) ? "N/A" : leer.GetString(76);
                    Atributos_Reportes.NumeroTrabajoPrincipal = leer.IsDBNull(87) ? "N/A" : leer.GetString(87);
                    Atributos_Reportes.NumeroTrabajoSecundario = leer.IsDBNull(88) ? "N/A" : leer.GetString(88);
                    Atributos_Reportes.TelMovilPrincipalResponsableSecundario = leer.GetString(79);
                    Atributos_Reportes.TelMovilSecundarioResponsableSecundario = leer.IsDBNull(80) ? "N/A" : leer.GetString(80);
                    Atributos_Reportes.TelFijoPrincipal = leer.IsDBNull(91) ? "N/A" : leer.GetString(91);
                    Atributos_Reportes.TelFijoSecundario = leer.IsDBNull(92) ? "N/A" : leer.GetString(92);
                    Atributos_Reportes.CantidadCancelada = leer.IsDBNull(96) ? 00.0 : leer.GetDouble(96);
                    Atributos_Reportes.CantidadPendiente = leer.IsDBNull(97) ? 63.0 : leer.GetDouble(97);
                    Atributos_Reportes.TipoPago = leer.IsDBNull(102) ? "N/A" : leer.GetString(102);
                    Atributos_Reportes.TipoPagoMatricula = leer.IsDBNull(104) ? "N/A" : leer.GetString(104);
                    Atributos_Reportes.Secciones = leer.IsDBNull(113) ? "N/A" : leer.GetString(113);
                    Atributos_Reportes.Especialidades = leer.IsDBNull(118) ? "N/A" : leer.GetString(118);
                    Atributos_Reportes.TipoEstado = leer.IsDBNull(121) ? "N/A" : leer.GetString(121);
                    Atributos_Reportes.NumeroDeTalonario = leer.IsDBNull(110) ? "" : leer.GetString(110);
                    Atributos_Reportes.NieTemporal = leer.IsDBNull(122) ? "" : leer.GetString(122);
                    Atributos_Reportes.Alergias = leer.IsDBNull(127) ? "N/A" : leer.GetString(127);
                    Atributos_Reportes.ActividadFisica = leer.IsDBNull(126) ? "N/A" : leer.GetString(126);
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


        public void MostrarDatoUsuarioReporte(int idusuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "r_UsuarioIndividual";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", idusuario);

            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Reportes.IdUsuario = leer.GetInt32(0);
                    Atributos_Reportes.NombresUsuario = leer.GetString(1);
                    Atributos_Reportes.ApellidosUsuario = leer.GetString(2);
                    Atributos_Reportes.GeneroUsuario = leer.GetString(3);
                    Atributos_Reportes.DuiUsuario = leer.GetString(4);
                    Atributos_Reportes.Usuario = leer.GetString(5);
                    Atributos_Reportes.CorreoUsuario = leer.GetString(8);
                    Atributos_Reportes.PrivilegioUsuario = leer.GetString(12);
                    Atributos_Reportes.EstadoUsuario = leer.GetString(14);
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


        //SECCIONES

        public void MostrarDatosSeccionIndividual(int idusuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "r_BuscarSeccionIndividual";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", idusuario);

            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Reportes.IdSecciones = leer.GetInt32(0);
                    Atributos_Reportes.CodigoSeccionInvidivual = leer.GetString(1);
                    Atributos_Reportes.EspecialidadInvidivual = leer.GetString(4);
                    Atributos_Reportes.GuiaInvidivual = leer.GetString(2);
                    Atributos_Reportes.TipoSeccionInvidivual = leer.GetString(3);
                    Atributos_Reportes.TotalAlumnos = leer.GetInt32(5);
                    Atributos_Reportes.TotalMasc = leer.GetInt32(6);
                    Atributos_Reportes.TotalFem = leer.GetInt32(7);
                    Atributos_Reportes.TresDosis = leer.GetInt32(8);
                    Atributos_Reportes.DosDosis = leer.GetInt32(9);
                    Atributos_Reportes.UnDosis = leer.GetInt32(10);
                    Atributos_Reportes.Reposicion = leer.GetInt32(11);
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

        //EMPLEADOS

        public void MostrarDatosEmpleadoIndividual(int idusuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "r_MostrarRegistroCompletoDocente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dato", idusuario);

            leer = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    Atributos_Reportes.IdDocente = leer.GetInt32(0);
                    Atributos_Reportes.NombreCompleto = leer.GetString(2);
                    Atributos_Reportes.NombreCompletoDUI = leer.GetString(2);
                    Atributos_Reportes.NombreCompletoNIT = leer.GetString(2);
                    Atributos_Reportes.Jubilado = leer.GetString(7);
                    Atributos_Reportes.EstadoCivil = leer.GetString(5);
                    Atributos_Reportes.Conyuge = leer.IsDBNull(4) ? "N/A" : leer.GetString(4);
                    Atributos_Reportes.NumeroDeISSS = leer.GetString(17);
                    Atributos_Reportes.DUI = leer.GetString(16);
                    Atributos_Reportes.NIT = leer.GetString(15);
                    Atributos_Reportes.AFP = leer.GetString(19);
                    Atributos_Reportes.NUP = leer.GetString(18);
                    Atributos_Reportes.NIP = leer.GetString(14);
                    Atributos_Reportes.DireccionEmpleado = leer.GetString(8);
                    Atributos_Reportes.TelefonoCasa = leer.GetString(27);
                    Atributos_Reportes.TelefonoMovilSecundario = leer.IsDBNull(26) ? "N/A" : leer.GetString(26);
                    Atributos_Reportes.TelefonoEmergencia = leer.GetString(31);
                    Atributos_Reportes.TelefonoDeOficina = leer.GetString(28);
                    Atributos_Reportes.TelefonoMovilPrincipal = leer.GetString(25);
                    Atributos_Reportes.TelefonoDeEmergenciaSecundario = leer.IsDBNull(32) ? "N/A" : leer.GetString(32);
                    Atributos_Reportes.Especialidad = leer.GetString(28);
                    Atributos_Reportes.Estado = leer.GetString(23);
                    Atributos_Reportes.NivelDeEstudio = leer.GetString(12);
                    Atributos_Reportes.AlergiaEmpleado = leer.IsDBNull(35) ? "N/A" : leer.GetString(35);
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

    }


}
