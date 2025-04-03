using CS_Proyecto.Atributos;
using CS_Proyecto.CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Proyecto.Vistas.ClasesVista
{
    public class LimpiarVariables
    {
        public void LimpiarVariablesComprobantePagoAlumno()
        {
            Atributos_Alumno.CantidadCancelada = 0.00;
            Atributos_Alumno.CantidadPendiente = 45.00;
            Atributos_Alumno.IdTipoPago = 0;
            Atributos_Alumno.NIE = null;
            Atributos_Alumno.IdSecciones = 0;
            Atributos_Alumno.IdEspecialidades = 0;
            Atributos_Alumno.IdTipoEstado = 0;
            Atributos_Alumno.NumeroDeTalonario = null;
            Atributos_Alumno.IdAlumno = 0;
            Atributos_Alumno.IdTipoPagoMatricula = 0;
        }

        public void LimpiarVariablesMatriculaAlumno()
        {
            Atributos_Alumno.Nombres = null;
            Atributos_Alumno.NieTemporal = null;
            Atributos_Alumno.NIE = null;
            Atributos_Alumno.Apellidos = null;
            Atributos_Alumno.NieTemporal = null;
            Atributos_Alumno.PoliticamenteExpuesto = null;
            Atributos_Alumno.Genero = null;
            Atributos_Alumno.FechaNacimiento = null;
            Atributos_Alumno.LugarNacimiento = null;
            Atributos_Alumno.Partida = null;
            Atributos_Alumno.EducacionInicial = null;
            Atributos_Alumno.SeccionInicial = null;
            Atributos_Alumno.AnioInicial = null;
            Atributos_Alumno.IdInstitucionProcedencia = 0;
            Atributos_Alumno.IdNacionalidad = 0;
            Atributos_Alumno.Direccion = null;
            Atributos_Alumno.Canton = null;
            Atributos_Alumno.Caserio = null;
            Atributos_Alumno.IdMunicipio = 0;
            Atributos_Alumno.IdDepartamento = 0;
            Atributos_Alumno.IdZonaResidencia = 0;
            Atributos_Alumno.EmailAumno = null;
            Atributos_Alumno.NumeroMiembrosFamilia = null;
            Atributos_Alumno.DependenciaFamiliar = null;
            Atributos_Alumno.DependenciaEconomica = null;
            Atributos_Alumno.LugarTrabajo = null;
            Atributos_Alumno.Cargo = null;
            Atributos_Alumno.EsquemaVacunacion = null;
            Atributos_Alumno.ProcesoAcademico = null;
            Atributos_Alumno.PoseeInternet = null;
            Atributos_Alumno.RepitiendoAnio = null;
            Atributos_Alumno.IdTipoConexion = 0;
            Atributos_Alumno.IdEstabilidad = 0;
            Atributos_Alumno.IdProveedorPrincipal = 0;
            Atributos_Alumno.RecursosTecnologicos = null;
            Atributos_Alumno.ResponsablePrincipal = null;
            Atributos_Alumno.ParentescoResponsablePrincipal = null;
            Atributos_Alumno.DuiResponsablePrincipal = null;
            Atributos_Alumno.GeneroResponsablePrincipal = null;
            Atributos_Alumno.EmailResponsablePrincipal = null;
            Atributos_Alumno.LugarTrabajoResponsablePrincipal = null;
            Atributos_Alumno.ResponsableSecundario = null;
            Atributos_Alumno.ParentescoResponsableSecundario = null;
            Atributos_Alumno.LugarTrabajoResponsableSecundario = null;
            Atributos_Alumno.DuiResponsableSecundario = null;
            Atributos_Alumno.TelMovilPrincipalAlumno = null;
            Atributos_Alumno.TelMovilSecundarioAlumno = null;
            Atributos_Alumno.TelMovilPrincipalResponsablePrincipal = null;
            Atributos_Alumno.TelMovilSecundarioResponsablePrincipal = null;
            Atributos_Alumno.NumeroTrabajoPrincipal = null;
            Atributos_Alumno.NumeroTrabajoSecundario = null;
            Atributos_Alumno.TelMovilPrincipalResponsableSecundario = null;
            Atributos_Alumno.TelMovilSecundarioResponsableSecundario = null;
            Atributos_Alumno.TelFijoPrincipal = null;
            Atributos_Alumno.TelFijoSecundario = null;
        }

        public void limpiarVarMedicamento()
        {
            Atributos_Alumno.NombreMedicamento = null;
            Atributos_Alumno.Dosis = null;
            Atributos_Alumno.Frecuencia = null;
        }

        //Var Empleados
        public void limpiarVarDocentes()
        {
            Atributos_Empleado.NombreCompleto = null;
            Atributos_Empleado.NombreCompletoDUI = null;
            Atributos_Empleado.NombreCompletoNIT = null;
            Atributos_Empleado.Conyuge = null;
            Atributos_Empleado.EstadoCivil = null;
            Atributos_Empleado.Jubilado = null;
            Atributos_Empleado.Direccion = null;
            Atributos_Empleado.IdNivelDeEstudio = 0;
            Atributos_Empleado.IdTipoDeCargo = 0;
            Atributos_Empleado.IdEspecialidad = 0;
            Atributos_Empleado.NIP = null;
            Atributos_Empleado.NIT = null;
            Atributos_Empleado.DUI = null;
            Atributos_Empleado.NumeroDeISSS = null;
            Atributos_Empleado.NUP = null;
            Atributos_Empleado.AFP = null;
            Atributos_Empleado.IdEstado = 0;
            Atributos_Empleado.TelefonoMovilPrincipal = null;
            Atributos_Empleado.TelefonoMovilSecundario = null;
            Atributos_Empleado.TelefonoCasa = null;
            Atributos_Empleado.TelefonoDeOficina = null;
            Atributos_Empleado.TelefonoEmergencia = null;
            Atributos_Empleado.TelefonoDeEmergenciaSecundario = null;

            Atributos_Empleado.NombreAfeccion = null;
            Atributos_Empleado.TipoAfeccion = null;
            Atributos_Empleado.ProcedimientoMedico = null;

            Atributos_Empleado.AlegiasPadecidas = null;

            Atributos_Empleado.NombreMedicamento = null;
            Atributos_Empleado.Dosis = null;
            Atributos_Empleado.Frecuencia = null;
        }

        public void limpiarVarInformacionMedica()
        {
            Atributos_Empleado.IdDocente = 0;
            Atributos_Empleado.MostrarAlergias = null;
            Atributos_Empleado.MostrarTelPrincipal = null;
            Atributos_Empleado.MostrarTelSecundario = null;
            Atributos_Empleado.MostrarTelEmergenciaPrincipal = null;
            Atributos_Empleado.MostrarTelEmergenciaSecundario = null;
            Atributos_Empleado.MostrarNombreDocente = null;
            Atributos_Empleado.MostrarCargoDocente = null;
        }

        public void limpiarVarEditarNivelDeEstudio()
        {
            Atributos_Empleado.ModificarCargo = null;
            Atributos_Empleado.IdCargoAModificar = null;
        }

        public void limpiarVarEditarCargos()
        {
            Atributos_Empleado.ModificarCargo = null;
            Atributos_Empleado.IdCargoAModificar = null;
        }

        public void limpiarVarEspecialidades()
        {
            Atributos_Empleado.ModificarEspecialidad = null;
            Atributos_Empleado.IdEspecialidadAModificar = null;
        }

        public void limpiarVarMaterias()
        {
            Atributos_Empleado.ModificarMateria = null;
            Atributos_Empleado.IdMateriaAModificar = null;
        }


        //Var Usuarios

        public void LimpiarVarUsuarios()
        {
            Atributos_Usuarios.Nombres = null;
            Atributos_Usuarios.Apellidos = null;
            Atributos_Usuarios.Genero = null;
            Atributos_Usuarios.Dui = null;
            Atributos_Usuarios.NombreUsuario = null;
            Atributos_Usuarios.Contrasena = null;
            Atributos_Usuarios.ContraseñaNoCoincide = null;
            Atributos_Usuarios.ValidarContrasena = null;
            Atributos_Usuarios.Imagen = null;
            Atributos_Usuarios.Correo = null;
            Atributos_Usuarios.IdRol = 0;
            Atributos_Usuarios.IdEstado = 0;
        }


        //VAR SECCIONES

        public void LimpiarVarSecciones()
        {
            Atributos_seccion.SeccionAbreviacion = null;
            Atributos_seccion.IdTipoSeccion = 0;
            Atributos_seccion.IdDocentes = 0;
            Atributos_seccion.IdEspecialidades = 0;
           
        }
    }
}
