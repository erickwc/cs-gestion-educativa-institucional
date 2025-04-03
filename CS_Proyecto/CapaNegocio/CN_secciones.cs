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
    internal class CN_secciones
    {
        CD_secciones cD_Secciones = new CD_secciones();

        public void InsertarSeccion(string SeccionAbreviacion, int IdEspecialidades, int IdDocentes, int IdTipoSeccion)
        {
            cD_Secciones.InsertarSeccion(SeccionAbreviacion, IdEspecialidades, IdDocentes, IdTipoSeccion);
        }

        public void InsertarEspecialidad(string Nombre, string Duracion)
        {
            cD_Secciones.InsertarEspecialidad(Nombre, Duracion);
        }

        public void ModificarSecciones(int IdSecciones, string SeccionAbreviacion, int IdEspecialidades, int IdDocentes, int IdTipoSeccion)
        {
            cD_Secciones.ModificarSecciones(IdSecciones, SeccionAbreviacion, IdEspecialidades, IdDocentes, IdTipoSeccion);
        }

        public void ModificarEspecialidad(int IdEspecialidades, string Nombre, string Duracion)
        {
            cD_Secciones.ModificarEspecialidad(IdEspecialidades, Nombre, Duracion);
        }

        public DataTable mostrarSeccionesActuales()
        {

            return cD_Secciones.mostrarSeccionesActuales();
        }

        public DataTable mostrarEspecialidadesActuales()
        {

            return cD_Secciones.mostrarEspecialidadesActuales();
        }

        public void mostrarDatoSeccion(int dato)
        {
            cD_Secciones.mostrarDatoSeccion(dato);
        }

        public DataTable BuscadorSeccion(string dato)
        {
            return cD_Secciones.BuscadorSeccion(dato);
        }

        public void CantidadSecciones()
        {
            cD_Secciones.CantidadSeccionesActuales();
        }

        public void CantidadEspecialidesw()
        {
            cD_Secciones.CantidadEspecialidadesActuales();
        }

        public DataTable NombresEspecialidades()
        {
            return cD_Secciones.MostrarEspecialidades();
        }

    }
}
