using CS_Proyecto.Atributos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Secciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Seccion
{
    public partial class Modificar_Eliminar_Seccion : Form
    {
        public Modificar_Eliminar_Seccion()
        {
            InitializeComponent();
        }

        string IdSecciones = null;
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        CN_secciones cN_Secciones1 = new CN_secciones();

        private void mostrarSeccionesActuales()
        {
            //Instancia para llenar la tabla
            CN_secciones cN_Secciones = new CN_secciones(); ;
            dgv_secciones.DataSource = cN_Secciones.mostrarSeccionesActuales();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dgv_secciones.Columns["IdSecciones"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_secciones.Columns["Codigo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_secciones.Columns["Especialides"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_secciones.Columns["Docente"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_secciones.Columns["Tipo Seccion"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Añadir Boton
            AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
            añadirBtn.AñadirBotonEditarEnDataGrid(dgv_secciones);

            //poner invisible una columna
            dgv_secciones.Columns["IdSecciones"].Visible = false;
            dgv_secciones.Columns["Codigo"].Width = 150;
            dgv_secciones.Columns["Especialides"].Width = 300;
            dgv_secciones.Columns["Docente"].Width = 250;
            dgv_secciones.Columns["Tipo Seccion"].Width = 150;
            dgv_secciones.Columns["ImagenColumna"].Width = 100;

        }

        private void Modificar_Eliminar_Seccion_Load(object sender, EventArgs e)
        {
            mostrarSeccionesActuales();
        }

        private void dgv_secciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_secciones.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgv_secciones.Rows[e.RowIndex];
                    IdSecciones = dr.Cells["IdSecciones"].Value.ToString();
                    Atributos_seccion.IdSecciones = Convert.ToInt32(IdSecciones);

                    cN_Secciones1.mostrarDatoSeccion(Atributos_seccion.IdSecciones);

                    Atributos_seccion.EstadoFormulario = "Editar";

                    navegar.AbrirFormEnPanel(typeof(Nueva_seccion_main), "Editar Seccion");
                }

            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            CN_secciones cN_Secciones2 = new CN_secciones();
            dgv_secciones.DataSource = cN_Secciones2.BuscadorSeccion(txt_buscar.Text);
        }

        private void cmbx_tipo_busqueda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_buscar.Enabled = true;
            txt_buscar.Text = String.Empty;
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbx_tipo_busqueda.Text == "Codigo")
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; // Ignorar otros caracteres
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; // Ignorar otros caracteres
                }
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Seccion_Main), "Secciónes");
        }
    }
}
