using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Proyecto.Atributos
{
    public static class Atributos_Reportes
    {
        public static string TipoReporte { get; set; }
        public static string Nombres { get; set; }
        public static string Apellidos { get; set; }
        public static string NIE { get; set; }
        public static string Genero { get; set; }
        public static string FechaNacimiento { get; set; }
        public static string LugarNacimiento { get; set; }
        public static string Partida { get; set; }
        public static string EducacionInicial { get; set; }
        public static string SeccionInicial { get; set; }
        public static string AnioInicial { get; set; }
        public static string InstitucionProcedencia { get; set; }
        public static string Nacionalidad { get; set; }
        public static string Direccion { get; set; }
        public static string Canton { get; set; }
        public static string Caserio { get; set; }
        public static string Municipio { get; set; }
        public static string Departamento { get; set; }
        public static string ZonaResidencia { get; set; }
        public static string EmailAumno { get; set; }
        public static string NumeroMiembrosFamilia { get; set; }
        public static string DependenciaFamiliar { get; set; }
        public static string DependenciaEconomica { get; set; }
        public static string LugarTrabajo { get; set; }
        public static string Cargo { get; set; }
        public static string EsquemaVacunacion { get; set; }
        public static string ProcesoAcademico { get; set; }
        public static string PoseeInternet { get; set; }
        public static string RepitiendoAnio { get; set; }
        public static string TipoConexion { get; set; }
        public static string Estabilidad { get; set; }
        public static string ProveedorPrincipal { get; set; }
        public static string RecursosTecnologicos { get; set; }
        public static string ResponsablePrincipal { get; set; }
        public static string PoliticamenteExpuesto { get; set; }
        public static string ParentescoResponsablePrincipal { get; set; }
        public static string DuiResponsablePrincipal { get; set; }
        public static string GeneroResponsablePrincipal { get; set; }
        public static string EmailResponsablePrincipal { get; set; }
        public static string LugarTrabajoResponsablePrincipal { get; set; }
        public static string ResponsableSecundario { get; set; }
        public static string ParentescoResponsableSecundario { get; set; }
        public static string LugarTrabajoResponsableSecundario { get; set; }
        public static string DuiResponsableSecundario { get; set; }
        public static string TelMovilPrincipalAlumno { get; set; }
        public static string TelMovilSecundarioAlumno { get; set; }
        public static string TelMovilPrincipalResponsablePrincipal { get; set; }
        public static string TelMovilSecundarioResponsablePrincipal { get; set; }
        public static string NumeroTrabajoPrincipal { get; set; }
        public static string NumeroTrabajoSecundario { get; set; }
        public static string TelMovilPrincipalResponsableSecundario { get; set; }
        public static string TelMovilSecundarioResponsableSecundario { get; set; }
        public static string TelFijoPrincipal { get; set; }
        public static string TelFijoSecundario { get; set; }
        public static string CodigoSeccion { get; set; }
        public static int IdAlumno { get; set; }


        //Comprobante de pago
        public static string TipoPagoMatricula { get; set; }
        public static double CantidadCancelada { get; set; }
        public static double CantidadPendiente { get; set; }
        public static string TipoPago { get; set; }



        public static string Secciones { get; set; }
        public static string Especialidades { get; set; }
        public static string TipoEstado { get; set; }
        public static string NumeroDeTalonario { get; set; }

        //NIE Temporal
        public static string NieTemporal { get; set; }

        // DETALLES MEDICOS
        public static string ActividadFisica { get; set; }
        public static string Alergias { get; set; }



        //USUARIO

        public static int IdUsuario { get; set; }
        public static string NombresUsuario { get; set; }
        public static string ApellidosUsuario { get; set; }
        public static string GeneroUsuario { get; set; }
        public static string DuiUsuario { get; set; }
        public static string Usuario { get; set; }
        public static string CorreoUsuario { get; set; }
        public static string PrivilegioUsuario { get; set; }
        public static string EstadoUsuario { get; set; }


        //SECCION
        public static int IdSecciones { get; set; }
        public static string CodigoSeccionInvidivual { get; set; }
        public static string EspecialidadInvidivual { get; set; }
        public static string GuiaInvidivual { get; set; }
        public static string TipoSeccionInvidivual { get; set; }
        public static int TotalAlumnos { get; set; }
        public static int TotalMasc { get; set; }
        public static int TotalFem { get; set; }
        public static int TresDosis { get; set; }
        public static int DosDosis { get; set; }
        public static int UnDosis { get; set; }
        public static int Reposicion { get; set; }


        //EMPLEADOS

        public static int IdDocente { get; set; }
        public static string NombreCompleto { get; set; }
        public static string DUI { get; set; }
        public static string NIT { get; set; }
        public static string NombreCompletoDUI { get; set; }
        public static string NombreCompletoNIT { get; set; }
        public static string Jubilado { get; set; }
        public static string EstadoCivil { get; set; }
        public static string Conyuge { get; set; }
        public static string NumeroDeISSS { get; set; }
        public static string AFP { get; set; }
        public static string NUP { get; set; }
        public static string NIP { get; set; }
        public static string DireccionEmpleado { get; set; }
        public static string TelefonoCasa { get; set; }
        public static string TelefonoMovilSecundario { get; set; }
        public static string TelefonoEmergencia { get; set; }
        public static string TelefonoDeOficina { get; set; }
        public static string TelefonoMovilPrincipal { get; set; }
        public static string TelefonoDeEmergenciaSecundario { get; set; }
        public static string TipoDeCargo { get; set; }
        public static string Especialidad { get; set; }
        public static string Estado { get; set; }
        public static string NivelDeEstudio { get; set; }
        public static string AlergiaEmpleado { get; set; }



        //IMG REPORTE PREVIEW 

        public static byte[] ImagenReporte { get; set; }

    }
}
