using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Datos_Inactivos
{
    public partial class Alumnos_inactivos : Form
    {
        public Alumnos_inactivos()
        {
            InitializeComponent();
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        private string IdAlumno = null;
        CN_Alumnos cn_alumno = new CN_Alumnos();
        string datoBusqueda;

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Datos_Inactivos.Controles_datos_inactivos),"Datos Inactivos");
        }

        private void AlumnosInactivos()
        {
            CN_DatosInactivos cn_inactivos = new CN_DatosInactivos();
            dgv_alumnos_inactivos.DataSource = cn_inactivos.AlumnosInactivosVista();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dgv_alumnos_inactivos.Columns["NIE"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_alumnos_inactivos.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_alumnos_inactivos.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_alumnos_inactivos.Columns["Seccion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_alumnos_inactivos.Columns["Resp. Principal"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_alumnos_inactivos.Columns["Tel Resp. Principal"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //PonerTamaño
            dgv_alumnos_inactivos.Columns["NIE"].Width = 70;
            dgv_alumnos_inactivos.Columns["Seccion"].Width = 90;
            dgv_alumnos_inactivos.Columns["Resp. Principal"].Width = 250;
            dgv_alumnos_inactivos.Columns["Tel Resp. Principal"].Width = 160;

            //Poner Invisible una columna
            dgv_alumnos_inactivos.Columns["IdAlumno"].Visible = false;
        }

        private void añadirBtnTabla()
        {
            
            //Añadir Boton
            añadirBtn.AñadirBotonEditarEnDataGrid(dgv_alumnos_inactivos);

            //Establecer el orden de visualización del boton editar
            dgv_alumnos_inactivos.Columns["ImagenColumna"].DisplayIndex = 8;
            dgv_alumnos_inactivos.Columns["ImagenColumna"].Width = 100;

        }

        private void Alumnos_inactivos_Load(object sender, EventArgs e)
        {
            
            AlumnosInactivos();
            añadirBtnTabla();
        }

        private void dgv_alumnos_inactivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_alumnos_inactivos.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgv_alumnos_inactivos.Rows[e.RowIndex];
                    IdAlumno = dr.Cells["IdAlumno"].Value.ToString();
                    Atributos_Alumno.IdAlumno = Convert.ToInt32(IdAlumno);

                    cn_alumno.MostrarRegistroCompletoDelAlumno(Atributos_Alumno.IdAlumno);
                    navegar.AbrirFormEnPanel(typeof(Vistas.Editar_Matricula.Editar_main), "Editar Matricula");
                    Atributos_Alumno.EstadoFormulario = "EditarAlumno";
                }
            }
        }

        private void dgv_alumnos_inactivos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_alumnos_inactivos.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {

                        if (Convert.ToString(e.Value) == "Inactivo")
                        {
                            e.CellStyle.ForeColor = Color.FromArgb(230, 57, 70);
                            e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                        }
                    }
                }
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            datoBusqueda = txt_buscar.Text;
            CN_DatosInactivos cn_inactivos = new CN_DatosInactivos();
            dgv_alumnos_inactivos.DataSource = cn_inactivos.BuscarAlumnosInactivosVista(datoBusqueda);
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbx_tipo_busqueda.Text == "Nombres" || cmbx_tipo_busqueda.Text == "Apellidos")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                }
            }
            else if (cmbx_tipo_busqueda.Text == "DUI")
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

        private void cmbx_tipo_busqueda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_buscar.Enabled = true;
            txt_buscar.Text = String.Empty;
        }
    }
}
