using CS_Proyecto.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Proyecto.CapaNegocio
{
    public static class Atributos_Alumno
    {
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
        public static int IdInstitucionProcedencia { get; set; }
        public static int IdNacionalidad { get; set; }
        public static string Direccion { get; set; }
        public static string Canton { get; set; }
        public static string Caserio { get; set; }
        public static int IdMunicipio { get; set; }
        public static int IdDepartamento { get; set; }
        public static int IdZonaResidencia { get; set; }
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
        public static int IdTipoConexion { get; set; }
        public static int IdEstabilidad { get; set; }
        public static int IdProveedorPrincipal { get; set; }
        public static int IdRecursosTecnologicos { get; set; }
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

        // Afecciones
        public static int IdAfeccion { get; set; }
        public static string NombreAfeccion { get; set; }
        public static string TipoAfeccion { get; set; }
        public static string ProcedimientoMedico { get; set; }

        // Alergias
        public static string AlegiasPadecidas { get; set; }
        public static string PermiteActividadFisica { get; set; }

        // Medicamentos
        public static string IdMedicamento { get; set; }
        public static string NombreMedicamento { get; set; }
        public static string Dosis { get; set; }
        public static string Frecuencia { get; set; }


        //Comprobante de pago

        public static string TipoPagoMatricula { get; set; }
        public static double CantidadCancelada { get; set; }
        public static double CantidadPendiente { get; set; }

        public static double CantidadCanceladaGuardada { get; set; }

        public static int IdTipoPago { get; set; }
        public static int IdTipoPagoMatricula { get; set; }


        public static int IdSecciones { get; set; }
        public static int IdEspecialidades { get; set; }
        public static int IdTipoEstado { get; set; }
        public static string NumeroDeTalonario { get; set; }

        //NIE Temporal
        public static string NieTemporal { get; set; }
        public static string GuardarConNieTemporal { get; set; }

        //MostrarInformacionMedica

        public static string MostrarAlergias { get; set; }
        public static string MostrarPermiteActividadFisica { get; set; }
        public static string MostrarRespPrincipal { get; set; }
        public static string MostrarTelPrincipalResPrincipal { get; set; }
        public static string MostrarTelSecundarioResPrincipal { get; set; }
        public static string MostrarRespSecundario { get; set; }
        public static string MostrarTelSecundarioResSecundario { get; set; }
        public static string MostrarNombresAlumno { get; set; }
        public static string MostrarApellidosAlumno { get; set; }
        public static string MostrarSeccionAlumno { get; set; }


        //Cantidad de alumnos
        public static int AlumnosEnLetraDePago { get; set; }
        public static int AlumnosConNieTemporal { get; set; }


        //Variable para saber en que estado estoy del formulario
        public static string EstadoFormulario { get; set; }

        //obtener Correos
        public static List<string> CorreosAdmins { get; set; }


        //saber precio tipo matricula

        public static double PrecioMatriculaSegunTipo { get; set; }


        // Correos Inscripcion

        public static List<string> CorreosInscripcionAlumnoResponsable { get; set; }
        public static string AlumnoInscrito { get; set; }
        public static string ResponsableInscrito { get; set; }

        public static string EspecialidadAlumno { get; set; }

    }
}
