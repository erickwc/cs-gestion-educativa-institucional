using Actividad.CapaDatos;
using CS_Proyecto.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Proyecto.CapaNegocio
{
    internal class CN_Alumnos
    {
        CD_Alumnos cD_Alumnos = new CD_Alumnos();
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
            cD_Alumnos.insertarAlumno(
             nombres,
             apellidos,
             nie,
             Genero,
             FechaNacimiento,
             LugarNacimiento,
             PartidaNacimiento,
             EducacionInicial,
             SeccionInicial,
             AnioInicial,
             IdInstitucion,
             IdNacionalidad,
             RepitiendoAnio,
             Direccion,
             Canton,
             Caserio,
             IdMunicipio,
             IdDepartamento,
             IdZonaResidencia,
             EmailAlumno,
             NumeroMiembrosFamiliares,
             DependenciaFamiliar,
             DependenciaEconomica,
             LugarTrabajo,
             Cargo,
             EsquemaVacunacion,
             ProcesoAcademico,
             PoseeInternet,
             IdTipoConexion,
             IdEstabilidad,
             IdProveedorPrincipal,
             RecursosTecnologicos,
             ResponsablePrincipal,
             ParentescoResponsablePrincipal,
             DuiResponsablePrincipal,
             GeneroResponsablePrincipal,
             EmailResponsablePrincipal,
             LugarTrabajoResponsablePrincipal,
             PoliticamenteExpuesto,
             ResponsableSecundario,
             ParentescoResponsableSecundario,
             LugarTrabajoResponsableSecundario,
             DuiResponsableSecundario,
             TelefonoMovilPrincipalAlumno,
             TelefonoMovilSecundarioAlumno,
             TelMovilPrincipalResponsablePrincipal,
             TelMovilSecundarioResponsablePrincipal,
             NumeroTrabajoPrincipal,
             NumeroTrabajoSecundario,
             TelMovilPrincipalResponsableSecundario,
             TelMovilSecundarioResponsableSecundario,
             TelFijoPrincipal,
             TelFijoSecundario);
        }

        public void InsertarMedicamento(string NombreMedicamento, string Dosis, string Frecuencia, int IdAlumno)
        {
            cD_Alumnos.InsertarMedicamento(NombreMedicamento, Dosis, Frecuencia, IdAlumno);
        }

        public void ModificarMedicamento(string NombreMedicamento, string Dosis, string Frecuencia, int IdMedicamento)
        {
            cD_Alumnos.ModificarMedicamento(NombreMedicamento, Dosis, Frecuencia, IdMedicamento);
        }

        public void EliminarMedicamento(int IdMedicamento)
        {
            cD_Alumnos.EliminarMedicamento(IdMedicamento);
        }

        public void InsertarInfecciones(string NombreAfeccion, string Tipo, string Procedimiento, int IdAlumno)
        {
            cD_Alumnos.InsertarInfecciones(NombreAfeccion, Tipo, Procedimiento, IdAlumno);
        }

        public void ModificarAfecciones(string NombreAfeccion, string Tipo, string Procedimiento, int IdAfeccion)
        {
            cD_Alumnos.ModificarInfecciones(NombreAfeccion, Tipo, Procedimiento, IdAfeccion);
        }

        public void EliminarAfecciones(int IdAfeccion)
        {
            cD_Alumnos.EliminarAfecciones(IdAfeccion);
        }

        public void InsertarDetallesMedicos(string PermiteActividadFisica, string Alergias, int IdAlumno)
        {
            cD_Alumnos.InsertarDetallesMedicos(PermiteActividadFisica, Alergias, IdAlumno);
        }

        public void ModificarDetallesMedicos(string PermiteActividadFisica, string Alergias, int IdAlumno)
        {
            cD_Alumnos.ModificarDetallesMedicos(PermiteActividadFisica, Alergias, IdAlumno);
        }

        public DataTable MostrarUltimoAlumnoRegistrado()
        {
            DataTable tabla = new DataTable();
            tabla = cD_Alumnos.MostrarUltimoAlumnoRegistrado();
            return tabla;
        }

        public void InsertaComprobanteAlumno(double CantidadCancelada, double CantidadRestante, int TipoPago, int TipoPagoMatricula, int Seccion, int Especialidad, int Estado, string Talonario, int IdAlumno)
        {
            cD_Alumnos.InsertaComprobanteAlumno(CantidadCancelada, CantidadRestante, TipoPago, TipoPagoMatricula, Seccion, Especialidad, Estado, Talonario, IdAlumno);
        }

        public void InsertaInstitucion(string NombreInstitucion)
        {
            cD_Alumnos.InsertarInstituciones(NombreInstitucion);
        }

        public void InsertaNieTemporal(string NieTemporal, int IdAlumno)
        {
            cD_Alumnos.InsertarNieTemporal(NieTemporal, IdAlumno);
        }

        public void EditarNieTemporal(string NieTemporal, int IdAlumno)
        {
            cD_Alumnos.ModificarNieTemporal(NieTemporal, IdAlumno);
        }

        public DataTable consultaUltimoAlumnoRegistradoMatriculaParteUno(string datobusqueda)
        {
            return cD_Alumnos.ConsultarUltimoAlumnoParteMatriculaUno(datobusqueda);
        }

        public DataTable consultaUltimoAlumnoRegistradoMatriculaParteDos(string datobusqueda)
        {
            return cD_Alumnos.ConsultarUltimoAlumnoParteMatriculaDos(datobusqueda);
        }


        public DataTable MostrarUltimoAlumnoParteMatriculaDos()
        {
            DataTable tabla = new DataTable();
            tabla = cD_Alumnos.ConsultarUltimoAlumnoParteMatriculaDos();
            return tabla;
        }

        public bool consultaInformacionMedicaAlumno(string datobusqueda)
        {
            return cD_Alumnos.ConsultarInformacionMedicaAlumno(datobusqueda);
        }

        public DataTable MostrarMedicamentosAlumno(string datobusqueda)
        {
            DataTable tabla = new DataTable();
            tabla = cD_Alumnos.ConsultarMedicamentosAlumno(datobusqueda);
            return tabla;
        }

        public DataTable MostrarAfeccionesAlumno(string datobusqueda)
        {
            DataTable tabla = new DataTable();
            tabla = cD_Alumnos.ConsultarAfeccionesAlumno(datobusqueda);
            return tabla;
        }
        public bool MostrarRegistroCompletoDelAlumno(int IdAlumno)
        {
            return cD_Alumnos.ConsultarRegistroCompletoDelAlumno(IdAlumno);
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
            cD_Alumnos.ModificarAlumno(
                nombres,
                apellidos,
                nie,
                Genero,
                FechaNacimiento,
                LugarNacimiento,
                PartidaNacimiento,
                EducacionInicial,
                SeccionInicial,
                AnioInicial,
                IdInstitucion,
                IdNacionalidad,
                RepitiendoAnio,
                Direccion,
                Canton,
                Caserio,
             IdMunicipio,
             IdDepartamento,
             IdZonaResidencia,
                EmailAlumno,
                NumeroMiembrosFamiliares,
                DependenciaFamiliar,
                DependenciaEconomica,
                LugarTrabajo,
                Cargo,
                EsquemaVacunacion,
                ProcesoAcademico,
                PoseeInternet,
             IdTipoConexion,
             IdEstabilidad,
             IdProveedorPrincipal,
                RecursosTecnologicos,
                ResponsablePrincipal,
                ParentescoResponsablePrincipal,
                DuiResponsablePrincipal,
                GeneroResponsablePrincipal,
                EmailResponsablePrincipal,
                LugarTrabajoResponsablePrincipal,
                PoliticamenteExpuesto,
                ResponsableSecundario,
                ParentescoResponsableSecundario,
                LugarTrabajoResponsableSecundario,
                DuiResponsableSecundario,
                TelefonoMovilPrincipalAlumno,
                TelefonoMovilSecundarioAlumno,
                TelMovilPrincipalResponsablePrincipal,
                TelMovilSecundarioResponsablePrincipal,
                NumeroTrabajoPrincipal,
                NumeroTrabajoSecundario,
                TelMovilPrincipalResponsableSecundario,
                TelMovilSecundarioResponsableSecundario,
                TelFijoPrincipal,
                TelFijoSecundario,
                CantidadCancelada,
                CantidadRestante,
                TipoPago,
                TipoPagoMatricula,
                Seccion,
                Especialidad,
                Estado,
                Talonario
                );
        }

        public DataTable ConsultarMedicamentosAlumnoPorId(int DatoBusqueda)
        {
            DataTable tabla = new DataTable();
            tabla = cD_Alumnos.ConsultarMedicamentosAlumnoPorId(DatoBusqueda);
            return tabla;
        }

        public DataTable ConsultarAfeccionesAlumnoPorId(int DatoBusqueda)
        {
            DataTable tabla = new DataTable();
            tabla = cD_Alumnos.ConsultarAfeccionesAlumnoPorId(DatoBusqueda);
            return tabla;
        }

        public bool ConsultarDetallesMedicosAlumnoPorId(int Dato)
        {
            return cD_Alumnos.ConsultarDetallesMedicosAlumnoPorId(Dato);
        }

        public DataTable MostrarAlumnosEnLetraPago()
        {
            DataTable tabla = new DataTable();
            tabla = cD_Alumnos.MostrarAlumnosEnLetraPago();
            return tabla;
        }

        public DataTable ConsultarAlumnosEnLetraPago(string Dato)
        {
            return cD_Alumnos.ConsultarAlumnosEnLetraPago(Dato);
        }

        public DataTable MostrarAlumnosConNieTemporal()
        {
            DataTable tabla = new DataTable();
            tabla = cD_Alumnos.MostrarAlumnosConNieTemporal();
            return tabla;
        }

        public DataTable ConsultarAlumnosConNieTemporal(string Dato)
        {
            return cD_Alumnos.ConsultarAlumnosConNieTemporal(Dato);
        }

        public bool ConsultarCantidadAlumnosEnLetraPago()
        {
            return cD_Alumnos.CantidadAlumnosEnLetraPago();
        }

        public bool ConsultarCantidadAlumnosConNieTemporal()
        {
            return cD_Alumnos.CantidadAlumnosConNieTemporal();
        }

        public bool ObtenerUltimoNieTemporal()
        {
            return cD_Alumnos.ObtenerUltimoNieTemporal();
        }
    }
}
