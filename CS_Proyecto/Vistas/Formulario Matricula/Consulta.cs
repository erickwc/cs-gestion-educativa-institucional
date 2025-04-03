
using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Dashboard;
using CS_Proyecto.Vistas.Editar_Matricula;
using CS_Proyecto.Vistas.Formulario_Matricula;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CS_Proyecto.Vistas.Formulario_Matricula
{
    public partial class Consulta : Form
    {

        
        public Consulta()
        {
            InitializeComponent();
        }

        private string IdAlumno = null;
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        private string datoBusqueda = string.Empty;


        private void Consulta_Load(object sender, EventArgs e)
        {
            MostrarUltimoAlumnoRegistrado();
        }

        private void MostrarUltimoAlumnoRegistrado()
        {
            //Instancia para llenar la tabla
            CN_Alumnos cn_alumnos = new CN_Alumnos(); ;
            dgv_tabla_consulta.DataSource = cn_alumnos.MostrarUltimoAlumnoRegistrado();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dgv_tabla_consulta.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_tabla_consulta.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_tabla_consulta.Columns["Responsable Principal"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_tabla_consulta.Columns["Tel. Princ. Responsable"].SortMode = DataGridViewColumnSortMode.NotSortable;
            
            //Añadir Boton
            AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
            añadirBtn.AñadirBotonComprobanteEnDataGrid(dgv_tabla_consulta);
            
            //poner invisible una columna
            dgv_tabla_consulta.Columns["Id"].Visible = false;
            dgv_tabla_consulta.Columns["Tel. Princ. Responsable"].Width = 150;
        }


        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Dashboard.Dashboard_controles), "Dashboard");
        }


        private void dgv_tabla_consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_tabla_consulta.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgv_tabla_consulta.Rows[e.RowIndex];
                    IdAlumno = dr.Cells["Id"].Value.ToString();
                }
                Atributos_Alumno.IdAlumno = Convert.ToInt32(IdAlumno);
                navegar.AbrirFormEnPanel(typeof(Vistas.Formulario_Matricula.Comprobante_main), "Comprobante del Alumno");
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            datoBusqueda = txt_buscar.Text;
            CN_Alumnos cN_Alumnos = new CN_Alumnos();
            dgv_tabla_consulta.DataSource = cN_Alumnos.consultaUltimoAlumnoRegistradoMatriculaParteUno(datoBusqueda);
        }

        private void cmbx_tipo_busqueda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_buscar.Enabled = true;
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            else if (char.IsLetter(e.KeyChar) && e.KeyChar >= 128)
            {
                e.Handled = true;
            }
        }

        private void RefrescarDatos_Tick(object sender, EventArgs e)
        {
            CN_Alumnos cn_alumnos = new CN_Alumnos(); ;
            dgv_tabla_consulta.DataSource = cn_alumnos.MostrarUltimoAlumnoRegistrado();
        }

        private void RefrescarDatos_Tick_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(datoBusqueda))
            {
                CN_Alumnos cN_Alumnos = new CN_Alumnos();
                dgv_tabla_consulta.DataSource = cN_Alumnos.consultaUltimoAlumnoRegistradoMatriculaParteUno(datoBusqueda);
            }
            else
            {
                CN_Alumnos cN_Alumnos = new CN_Alumnos();
                dgv_tabla_consulta.DataSource = cN_Alumnos.MostrarUltimoAlumnoRegistrado();
            }
        }
    }
}
