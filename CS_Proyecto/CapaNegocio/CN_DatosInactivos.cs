using CS_Proyecto.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Proyecto.CapaNegocio
{
    internal class CN_DatosInactivos
    {
        CD_DatosInactivos cd_datosInactvos = new CD_DatosInactivos();

        public DataTable AlumnosInactivosPreview()
        {
            DataTable tabla = new DataTable();
            tabla = cd_datosInactvos.AlumnosInactivosPreview();
            return tabla;
        }

        public DataTable DocentesInactivosPreview()
        {
            DataTable tabla = new DataTable();
            tabla = cd_datosInactvos.DocentesInactivosFondos();
            return tabla;
        }

        public DataTable UsuariosInactivosPreview()
        {
            DataTable tabla = new DataTable();
            tabla = cd_datosInactvos.UsuariosInactivosPreview();
            return tabla;
        }

        public DataTable AlumnosInactivosVista()
        {
            DataTable tabla = new DataTable();
            tabla = cd_datosInactvos.AlumnosInactivosVista();
            return tabla;
        }

        public DataTable DocentesInactivosVista()
        {
            DataTable tabla = new DataTable();
            tabla = cd_datosInactvos.DocentesInactivosVista();
            return tabla;
        }

        public DataTable UsuariosInactivosVista()
        {
            DataTable tabla = new DataTable();
            tabla = cd_datosInactvos.UsuariosInactivosVista();
            return tabla;
        }

        public DataTable BuscarAlumnosInactivosVista(string dato)
        {
            DataTable tabla = new DataTable();
            tabla = cd_datosInactvos.BuscarAlumnosInactivos(dato);
            return tabla;
        }

        public DataTable BuscarDocentesInactivosVista(string dato)
        {
            DataTable tabla = new DataTable();
            tabla = cd_datosInactvos.BuscarDocentesInactivos(dato);
            return tabla;
        }

        public DataTable BuscarUsuariosInactivosVista(string dato)
        {
            DataTable tabla = new DataTable();
            tabla = cd_datosInactvos.BuscarUsuariosInactivos(dato);
            return tabla;
        }
    }
}
