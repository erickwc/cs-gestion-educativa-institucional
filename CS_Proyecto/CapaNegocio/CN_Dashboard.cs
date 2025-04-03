using CS_Proyecto.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Proyecto.CapaNegocio
{
    internal class CN_Dashboard
    {
        CD_Dashboard cD_Dashboard = new CD_Dashboard();
        public DataTable EstadisticaGeneral()
        {
            DataTable tabla = new DataTable();
            tabla = cD_Dashboard.TablaEstadistica();
            return tabla;
        }

        public DataTable UltimoEmpleadoRegistrado()
        {
            DataTable tabla = new DataTable();
            tabla = cD_Dashboard.UltimoEmpleadoRegistrado();
            return tabla;
        }

    }
}
