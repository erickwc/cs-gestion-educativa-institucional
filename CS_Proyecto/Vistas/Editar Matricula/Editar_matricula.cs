using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Dashboard;
using CS_Proyecto.Vistas.Formulario_Matricula;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Editar_Matricula
{
    public partial class Editar_matricula : Form
    {
        public Editar_matricula()
        {
            InitializeComponent();
        }

        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        private string IdAlumno = null;
        CN_Alumnos cn_alumno = new CN_Alumnos();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        private string datoBusqueda = string.Empty;

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Dashboard.Dashboard_controles), "dashboard");
        }

        private void cmbx_tipo_busqueda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_buscar.Enabled = true;
            txt_buscar.Text = String.Empty;
        }

        private void MostrarUltimoAlumnoRegistradoParteMatriculaDos()
        {
            //Instancia para llenar la tabla
            CN_Alumnos cn_alumnos = new CN_Alumnos(); 
            dvg_editar_alumnos.DataSource = cn_alumnos.MostrarUltimoAlumnoParteMatriculaDos();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dvg_editar_alumnos.Columns["NIE"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_editar_alumnos.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_editar_alumnos.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_editar_alumnos.Columns["Seccion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_editar_alumnos.Columns["Especialidad"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_editar_alumnos.Columns["Resp. Principal"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_editar_alumnos.Columns["Tel Resp. Principal"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Añadir Boton
            añadirBtn.AñadirBotonEditarEnDataGrid(dvg_editar_alumnos);

            //Establecer el orden de visualización del boton editar
            dvg_editar_alumnos.Columns["ImagenColumna"].DisplayIndex = 8;

            //Establecer Tamaño de celdas
            dvg_editar_alumnos.Columns["NIE"].Width = 60;
            dvg_editar_alumnos.Columns["Seccion"].Width = 60;
            dvg_editar_alumnos.Columns["Apellidos"].Width = 120;
            dvg_editar_alumnos.Columns["Nombres"].Width = 120;
            dvg_editar_alumnos.Columns["Resp. Principal"].Width = 180;
            dvg_editar_alumnos.Columns["Tel Resp. Principal"].Width = 95;
            dvg_editar_alumnos.Columns["Especialidad"].Width = 220;

            //Poner Invisible una columna
            dvg_editar_alumnos.Columns["IdAlumno"].Visible = false;
        }

        private void Editar_matricula_Load(object sender, EventArgs e)
        {
            MostrarUltimoAlumnoRegistradoParteMatriculaDos();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            datoBusqueda = txt_buscar.Text;
            CN_Alumnos cN_Alumnos = new CN_Alumnos();
            dvg_editar_alumnos.DataSource = cN_Alumnos.consultaUltimoAlumnoRegistradoMatriculaParteDos(datoBusqueda);
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbx_tipo_busqueda.Text == "Nombres Alumno" || cmbx_tipo_busqueda.Text == "Apellidos Alumno")
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
            else
            {
                if (char.IsDigit(e.KeyChar) && txt_buscar.TextLength < 7)
                {

                }

                else if (e.KeyChar == '\b')
                {
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void dvg_editar_alumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_editar_alumnos.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dvg_editar_alumnos.Rows[e.RowIndex];
                    IdAlumno = dr.Cells["IdAlumno"].Value.ToString();
                    Atributos_Alumno.IdAlumno = Convert.ToInt32(IdAlumno);
                    cn_alumno.MostrarRegistroCompletoDelAlumno(Atributos_Alumno.IdAlumno);

                    navegar.AbrirFormEnPanel(typeof(Vistas.Editar_Matricula.Editar_main), "Editar Matricula");
                    Atributos_Alumno.EstadoFormulario = "EditarAlumno";
                }
            }
        }

        private void RefrescarDatos_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(datoBusqueda))
            {
                CN_Alumnos cN_Alumnos = new CN_Alumnos();
                dvg_editar_alumnos.DataSource = cN_Alumnos.consultaUltimoAlumnoRegistradoMatriculaParteDos(datoBusqueda);
            }
            else
            {
                CN_Alumnos cN_Alumnos = new CN_Alumnos();
                dvg_editar_alumnos.DataSource = cN_Alumnos.MostrarUltimoAlumnoParteMatriculaDos();
            }
        }
    }
}
