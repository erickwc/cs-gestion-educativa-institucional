using CS_Proyecto.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CS_Proyecto.CapaNegocio
{
    internal class CN_Empleado
    {

        CD_Empleados cd_Empleados = new CD_Empleados();

        public DataTable EstadisticaGeneralDocentes() {
            DataTable tabla = new DataTable();
            tabla = cd_Empleados.MostrarEstadisticaDocentes();
            return tabla;
        }

        public void MostrarAlergiasDocente(int idDocente) {
            cd_Empleados.AlergiasDocente(idDocente);
        }

        public DataTable EstadisticaEditarDocente() {
            DataTable tabla = new DataTable();
            tabla = cd_Empleados.MostrarEstadisticaEditarDocentes();
            return tabla;
        }

        public void insertarEmpleado(
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
            cd_Empleados.insertarDocente(
                NombreCompleto,
                NombreCompletoDUI,
                NombreCompletoNIT,
                Conyuge,
                EstadoCivil,
                Jubilado,
                Direccion,
                IdNivelEstudio,
       
                NIP,
                NIT,
                DUI,
                ISSS,
                NUP,
                AFP,
                IdTipoEstado,
                TelefonoMovilPrincipalDocente,
                TelefonoMovilSecundarioDocente,
                TelefonoCasa,
                TelefonoOficina,
                TelefonoMovilEmergencia,
                TelefonoMovilEmergenciaSecundario);
        }

        public void modificarEmpleado(
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
            cd_Empleados.modificarDocente(
                NombreCompleto,
                NombreCompletoDUI,
                NombreCompletoNIT,
                Conyuge,
                EstadoCivil,
                Jubilado,
                Direccion,
                IdNivelEstudio,
               
                NIP,
                NIT,
                DUI,
                ISSS,
                NUP,
                AFP,
                IdTipoEstado,
                TelefonoMovilPrincipalDocente,
                TelefonoMovilSecundarioDocente,
                TelefonoCasa,
                TelefonoOficina,
                TelefonoMovilEmergencia,
                TelefonoMovilEmergenciaSecundario,
                idDocente);
        }

        public void insertarNivelDeEstudio(string NivelDeEstudio) {
            cd_Empleados.insertarNivelDeEstudio(NivelDeEstudio);
        }

        public void modificarNivelDeEstudioDocente(string nivel, int id) {
            cd_Empleados.modificarNivelDeEstudio(nivel, id);
        }

        public void insertarTipoDocente(string TipoDocente) {
            cd_Empleados.insertarTipoDocente(TipoDocente);
        }

        public void modificarTipoDocente(string TipoDocente, int id) {
            cd_Empleados.modificarTipoDocente(TipoDocente, id);
        }

        public void insertarEspecialidadDocentes(string Especialidad) { 
            cd_Empleados.insertarEspecialidadDocente(Especialidad);
        }

        public void modificarEspecialidadDocente(string Especialidad, int idEspecialidad)
        {
            cd_Empleados.modificarEspecialidadDocente(Especialidad, idEspecialidad);
        }

        public void insertarMateria(string Materia)
        {
            cd_Empleados.insertarMateria(Materia);
        }

        public void modificarMateria(string Materia, int idMateria) {
            cd_Empleados.modificarMateria(Materia, idMateria);
        }

        public void insertarAfeccionesDocentes(string Afeccion, string Tipo, string Procedimiento, int IdDocente) {
            cd_Empleados.insertarAfeccionesDocente(Afeccion, Tipo, Procedimiento, IdDocente);
        }

        public void modificarAfeccionesDocentes(string Afeccion, string Tipo, string Procedimiento, int idAfeccion) {
            cd_Empleados.modificarAfeccionesDocente(Afeccion, Tipo, Procedimiento, idAfeccion);
        }

        public void eliminarAfeccionesDocentes(int idAfeccion)
        {
            cd_Empleados.eliminarAfeccionesDocente(idAfeccion);
        }

        public void insertarMedicamentosDocentes(string NombreMedicamento, string Dosis, string Frecuencia, int IdDocente) {
            cd_Empleados.insertarMedicamentos(NombreMedicamento, Dosis, Frecuencia, IdDocente);
        }

        public void modificarMedicamentos(string NombreMedicamento, string Dosis, string Frecuencia, int IdDocente, int IdMedicamento) {
            cd_Empleados.modificarMedicamentos(NombreMedicamento, Dosis, Frecuencia, IdDocente, IdMedicamento);
        }

        public void eliminarMedicamentosDocentes(int IdMedicamento)
        {
            cd_Empleados.eliminarMedicamentosDocente(IdMedicamento);
        }

        public void insertarDetallesMedicosDocente(string Alergias, int idDocente) {
            cd_Empleados.insertarDetallesMedicos(Alergias, idDocente);
        }

        public void modificarDetallesMedicosDocente(string Alergias, int idDocente) {
            cd_Empleados.modificarDetallesMedicos(Alergias, idDocente);
        }

        public DataTable buscarEmpleadoPorNombre(string Nombre) { 
            return cd_Empleados.BuscarDocentePorNombreOApellido(Nombre);
        }

        public DataTable buscarEmpleadoPorDUI(string DUI)
        {
            return cd_Empleados.BuscarDocentePorDUI(DUI);
        }


        public DataTable buscarAfeccionesDocentes(int id) {
            return cd_Empleados.BuscarAfeccionesDocente(id);
        }

        public DataTable mostrarAfeccionesDocentes(int id)
        {
            return cd_Empleados.mostrarAfeccionesDocente(id);
        }

        public DataTable buscarMedicamentosDocente(int id) {
            return cd_Empleados.BuscarMedicamentosDocentes(id);
        }

        public DataTable buscarMedicamentosEditarDocente(int id)
        {
            return cd_Empleados.BuscarMedicamentosEditarDocentes(id);
        }

        public bool buscarInformacionMedicaDocente(string Nombre) {
            return cd_Empleados.ConsultarInformacionMedicaDocente(Nombre);
        }

        public bool buscarInformacionMedicaDocentePorDUI(string DUI)
        {
            return cd_Empleados.ConsultarInformacionMedicaPorDUI(DUI);
        }

        public bool MostrarRegistroCompletoDocente(int IdDocente) {
            return cd_Empleados.ConsultarRegistroCompletoDelDocente(IdDocente);
        }

        public DataTable MostrarMateriasParaCompletarRegistro()
        {
            DataTable tabla = new DataTable();
            tabla = cd_Empleados.MostrarMateriasParaCompletarRegistro();
            return tabla;
        }

        public void EliminarMateriasDocentes(int IdDocenteMaterias)
        {
            cd_Empleados.QuitarMateriasDocentes(IdDocenteMaterias);
        }
    }
}
