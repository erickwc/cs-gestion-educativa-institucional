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

namespace CS_Proyecto.Vistas.Letra_de_Pago
{
    public partial class Letra_de_pago_main : Form
    {
        public Letra_de_pago_main()
        {
            InitializeComponent();
        }

        CN_Alumnos cn_alumno = new CN_Alumnos();
        string IdAlumno = null;
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
       

        private void MostrarAlumnosEnLetraPago()
        {
            CN_Alumnos cn_alumnos = new CN_Alumnos(); ;
            dvg_letra_pago.DataSource = cn_alumnos.MostrarAlumnosEnLetraPago();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dvg_letra_pago.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_letra_pago.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_letra_pago.Columns["Responsable Principal"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_letra_pago.Columns["Tel. Princ. Responsable"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_letra_pago.Columns["Estado de pago"].SortMode = DataGridViewColumnSortMode.NotSortable;


            //Añadir Boton
            AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
            añadirBtn.AñadirBotonEditarEnDataGrid(dvg_letra_pago);

            dvg_letra_pago.Columns["ImagenColumna"].DisplayIndex = 8;

            //poner invisible una columna
            dvg_letra_pago.Columns["Id"].Visible = false;
            dvg_letra_pago.Columns["Nombres"].Width = 170;
            dvg_letra_pago.Columns["Apellidos"].Width = 170;
            dvg_letra_pago.Columns["Responsable Principal"].Width = 250;
            dvg_letra_pago.Columns["Tel. Princ. Responsable"].Width = 150;
            dvg_letra_pago.Columns["Estado de pago"].Width = 120;
            dvg_letra_pago.Columns["Cancelado"].Width = 120;
            dvg_letra_pago.Columns["Pendiente"].Width = 70;
            dvg_letra_pago.Columns["ImagenColumna"].Width = 250;

        }



        private void Letra_de_pago_main_Load(object sender, EventArgs e)
        {
            MostrarAlumnosEnLetraPago();
            cn_alumno.ConsultarCantidadAlumnosEnLetraPago();
            lblCantidadAlumnos.Text = Convert.ToString(Atributos_Alumno.AlumnosEnLetraDePago);
        }

        private void dvg_letra_pago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_letra_pago.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dvg_letra_pago.Rows[e.RowIndex];
                    IdAlumno = dr.Cells["Id"].Value.ToString();
                    Atributos_Alumno.IdAlumno = Convert.ToInt32(IdAlumno);
                    cn_alumno.MostrarRegistroCompletoDelAlumno(Atributos_Alumno.IdAlumno);
                    navegar.AbrirFormEnPanel(typeof(Vistas.Editar_Matricula.Editar_main), "Editar Matricula");
                    Atributos_Alumno.EstadoFormulario = "EditarAlumno";
                }
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            CN_Alumnos cN_Alumnos = new CN_Alumnos();
            dvg_letra_pago.DataSource = cN_Alumnos.ConsultarAlumnosEnLetraPago(txt_buscar.Text);
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

        private void cmbx_tipo_busqueda_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            txt_buscar.Enabled = true;
            txt_buscar.Text = String.Empty;
        }
    }
}
