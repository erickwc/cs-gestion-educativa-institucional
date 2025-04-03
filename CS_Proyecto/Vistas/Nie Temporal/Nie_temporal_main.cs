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

namespace CS_Proyecto.Vistas.Nie_Temporal
{
    public partial class Nie_temporal_main : Form
    {
        public Nie_temporal_main()
        {
            InitializeComponent();
        }
        
        CN_Alumnos cn_alumnos = new CN_Alumnos();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        private string IdAlumno = null;
       
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Dashboard.Dashboard_controles), "Dashboard");
        }

        private void MostrarAlumnosConNieTemporal()
        {
            CN_Alumnos cn_alumnos = new CN_Alumnos(); ;
            dvg_nie_temporal.DataSource = cn_alumnos.MostrarAlumnosConNieTemporal();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dvg_nie_temporal.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_nie_temporal.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_nie_temporal.Columns["Responsable Principal"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_nie_temporal.Columns["Tel. Princ. Responsable"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_nie_temporal.Columns["NIE TEMP."].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Añadir Boton
            AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
            añadirBtn.AñadirBotonEditarEnDataGrid(dvg_nie_temporal);

            dvg_nie_temporal.Columns["ImagenColumna"].DisplayIndex = 6;

            //poner invisible una columna
            dvg_nie_temporal.Columns["Id"].Visible = false;
            dvg_nie_temporal.Columns["Nombres"].Width = 180;
            dvg_nie_temporal.Columns["Apellidos"].Width = 180;
            dvg_nie_temporal.Columns["Responsable Principal"].Width = 250;
            dvg_nie_temporal.Columns["Tel. Princ. Responsable"].Width = 160;
            dvg_nie_temporal.Columns["NIE TEMP."].Width = 150;
        }

        private void Nie_temporal_main_Load(object sender, EventArgs e)
        {
            MostrarAlumnosConNieTemporal();
            cn_alumnos.ConsultarCantidadAlumnosConNieTemporal();
            lblCantidadAlumnos.Text = Convert.ToString(Atributos_Alumno.AlumnosConNieTemporal);
        }

        private void cmbx_tipo_busqueda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_buscar.Enabled = true;
            txt_buscar.Text = String.Empty;
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            CN_Alumnos cN_Alumnos = new CN_Alumnos();
            dvg_nie_temporal.DataSource = cN_Alumnos.ConsultarAlumnosConNieTemporal(txt_buscar.Text);
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
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void dvg_nie_temporal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_nie_temporal.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dvg_nie_temporal.Rows[e.RowIndex];
                    IdAlumno = dr.Cells["Id"].Value.ToString();
                    Atributos_Alumno.IdAlumno = Convert.ToInt32(IdAlumno);
                    
                    cn_alumnos.MostrarRegistroCompletoDelAlumno(Atributos_Alumno.IdAlumno);

                    navegar.AbrirFormEnPanel(typeof(Vistas.Editar_Matricula.Editar_main), "Editar Matricula");
                    Atributos_Alumno.EstadoFormulario = "EditarAlumno";
                }
            }
        }
    }
}
