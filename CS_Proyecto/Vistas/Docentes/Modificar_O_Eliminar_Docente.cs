using CS_Proyecto.Atributos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Docentes
{
    public partial class Modificar_O_Eliminar_Docente : Form
    {
        public Modificar_O_Eliminar_Docente()
        {
            InitializeComponent();
        }

        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        private string IdDocente = string.Empty;
        CN_Empleado cn_empleado = new CN_Empleado();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();

        private void PoblarComboBox()
        {
            cbx_datos_busqueda.Items.Add("Nombre Completo");
            cbx_datos_busqueda.Items.Add("DUI");
            cbx_datos_busqueda.SelectedIndex = -1;

            txt_busqueda.Enabled = false;
        }

        public void MostrarDatos()
        {
            CN_Empleado cn_empleado = new CN_Empleado();
            dvg_editar_docentes.DataSource = cn_empleado.EstadisticaEditarDocente();

            añadirBtn.AñadirBotonEditarEnDataGrid(dvg_editar_docentes);

            foreach (DataGridViewColumn column in dvg_editar_docentes.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.MinimumWidth = 3;
            }

            dvg_editar_docentes.Columns["IdDocentes"].Visible = false;
            dvg_editar_docentes.Columns["Cargo"].Width = 150;
            dvg_editar_docentes.Columns["Nombre Completo"].Width = 220;
            dvg_editar_docentes.Columns["Nivel de Estudio"].Width = 200;
            //dvg_editar_docentes.Columns["Especialidad"].Width = 160;
            dvg_editar_docentes.Columns["DUI"].Width = 100;
            dvg_editar_docentes.Columns["Tel. Emergencia"].Width = 110;
            dvg_editar_docentes.Columns["Telefono"].Width = 110;
            dvg_editar_docentes.Columns["ImagenColumna"].Width = 100;

            dvg_editar_docentes.Columns["ImagenColumna"].DisplayIndex = 7;
        }

        private void Modificar_O_Eliminar_Docente_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            PoblarComboBox();
        }

        private void cbx_datos_busqueda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_busqueda.Enabled = true;
            txt_busqueda.Text = String.Empty;
        }

        private void dvg_editar_docentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_editar_docentes.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dvg_editar_docentes.Rows[e.RowIndex];
                    IdDocente = dr.Cells["IdDocentes"].Value.ToString();
                    Atributos_Empleado.IdDocente = Convert.ToInt32(IdDocente);
                    cn_empleado.MostrarRegistroCompletoDocente(Atributos_Empleado.IdDocente);
                    navegar.AbrirFormEnPanel(typeof(Vistas.Docentes.Modificar.ModificarDocenteMain), "Editar Empleados");
                    Atributos_Empleado.EstadoFormulario = "EditarDocente";
                }
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Docentes.Dashboard_Docente), "Empleados");

        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            CN_Empleado cn_empleado = new CN_Empleado();

            if (cbx_datos_busqueda.Text == "Nombre Completo")
            {
                dvg_editar_docentes.DataSource = cn_empleado.buscarEmpleadoPorNombre(txt_busqueda.Text);
            }
            else
            {
                dvg_editar_docentes.DataSource = cn_empleado.buscarEmpleadoPorDUI(txt_busqueda.Text);
            }
        }

        private void txt_busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbx_datos_busqueda.Text == "DUI")
            {
                if (char.IsDigit(e.KeyChar) && txt_busqueda.TextLength < 9)
                {
                    if (txt_busqueda.TextLength == 7)
                    {
                        txt_busqueda.Text += "-";
                        txt_busqueda.SelectionStart = txt_busqueda.TextLength;
                    }
                }
                else if (e.KeyChar == '\b')
                {
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (cbx_datos_busqueda.Text == "Nombre Completo")
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

           
        }
    }
}
