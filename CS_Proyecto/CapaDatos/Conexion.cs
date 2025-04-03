using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.CapaDatos
{
    internal class Conexion
    {
        private  SqlConnection conexion = new SqlConnection ("Data Source=DESKTOP-U36550G\\SQLEXPRESS ;Initial Catalog=BD_CS;Integrated Security=True;");

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed ) 
                conexion.Open();
            return conexion;
            
        }
         
        public SqlConnection CerrarConexion () 
        { 
          if (conexion.State == ConnectionState.Open)
             conexion.Close();
          return conexion;
        
        }
    }
}
