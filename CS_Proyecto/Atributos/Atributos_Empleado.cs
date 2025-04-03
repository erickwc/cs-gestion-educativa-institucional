using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CS_Proyecto.Atributos
{
    internal class Atributos_Empleado
    {
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
        public static string Direccion { get; set; }
        public static string TelefonoCasa { get; set; }
        public static string TelefonoMovilSecundario { get; set; }
        public static string TelefonoEmergencia { get; set; }
        public static string TelefonoDeOficina { get; set; }
        public static string TelefonoMovilPrincipal { get; set; }
        public static string TelefonoDeEmergenciaSecundario { get; set; }
        public static int IdTipoDeCargo { get; set; }
        public static int IdEspecialidad { get; set; }
        public static int IdEstado { get; set; }
        public static int IdNivelDeEstudio { get; set; }

        // Afecciones
        public static int IdAfeccion { get; set; }
        public static string NombreAfeccion { get; set; }
        public static string TipoAfeccion { get; set; }
        public static string ProcedimientoMedico { get; set; }

        // Alergias
        public static string AlegiasPadecidas { get; set; }

        // Medicamentos
        public static int IdMedicamento { get; set; }
        public static string NombreMedicamento { get; set; }
        public static string Dosis { get; set; }
        public static string Frecuencia { get; set; }


        //MostrarInformacionMedica
        public static string MostrarAlergias { get; set; }
        public static string MostrarTelPrincipal { get; set; }
        public static string MostrarTelSecundario { get; set; }
        public static string MostrarTelEmergenciaPrincipal { get; set; }
        public static string MostrarTelEmergenciaSecundario { get; set; }
        public static string MostrarNombreDocente { get; set; }
        public static string MostrarCargoDocente { get; set; }

        //Variable para saber en que estado estoy del formulario
        public static string EstadoFormulario { get; set; }

        // Editar nivel de estudio
        public static string ModificarNivelDeEstudio { get; set; }
        public static string IdNivelDeEstudioAModificar { get; set; }

        // Editar Cargo
        public static string ModificarCargo { get; set; }
        public static string IdCargoAModificar { get; set; }

        // Editar Especialidad
        public static string ModificarEspecialidad { get; set; }
        public static string IdEspecialidadAModificar { get; set; }

        // Editar Materia
        public static string ModificarMateria { get; set; }
        public static string IdMateriaAModificar { get; set; }
    }
}
