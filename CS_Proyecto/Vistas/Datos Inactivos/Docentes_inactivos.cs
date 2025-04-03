using CS_Proyecto.Atributos;
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
    public partial class Docentes_inactivos : Form
    {
        public Docentes_inactivos()
        {
            InitializeComponent();
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        CN_Empleado cn_empleado = new CN_Empleado();
        string datoBusqueda;
        string IdDocente;
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Datos_Inactivos.Controles_datos_inactivos), "Datos Inactivos");
        }

        private void DocentesInactivos()
        {
            CN_DatosInactivos cn_inactivos = new CN_DatosInactivos();
            dgv_docentes_inactivos.DataSource = cn_inactivos.DocentesInactivosVista();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dgv_docentes_inactivos.Columns["DUI"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_docentes_inactivos.Columns["Cargo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_docentes_inactivos.Columns["Nivel De Estudio"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_docentes_inactivos.Columns["Tel. Emergencia"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_docentes_inactivos.Columns["Telefono"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_docentes_inactivos.Columns["Estado"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_docentes_inactivos.Columns["Docente"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //PonerTamaño
            dgv_docentes_inactivos.Columns["Docente"].Width = 250;

            //Poner Invisible una columna
            dgv_docentes_inactivos.Columns["IdDocentes"].Visible = false;
        }

        private void añadirBtnTabla()
        {

            //Añadir Boton
            añadirBtn.AñadirBotonEditarEnDataGrid(dgv_docentes_inactivos);

            //Establecer el orden de visualización del boton editar
            dgv_docentes_inactivos.Columns["ImagenColumna"].DisplayIndex = 8;
            dgv_docentes_inactivos.Columns["ImagenColumna"].Width = 100;

        }

        private void Docentes_inactivos_Load(object sender, EventArgs e)
        {
            DocentesInactivos();
            añadirBtnTabla();
        }

        private void dgv_docentes_inactivos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_docentes_inactivos.Columns[e.ColumnIndex].Name == "Estado")
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

        private void cmbx_tipo_busqueda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_buscar.Enabled = true;
            txt_buscar.Text = String.Empty;
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            datoBusqueda = txt_buscar.Text;
            CN_DatosInactivos cn_inactivos = new CN_DatosInactivos();
            dgv_docentes_inactivos.DataSource = cn_inactivos.BuscarDocentesInactivosVista(datoBusqueda);
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbx_tipo_busqueda.Text == "DUI")
            {
                if (char.IsDigit(e.KeyChar) && txt_buscar.TextLength < 9)
                {
                    if (txt_buscar.TextLength == 7)
                    {
                        txt_buscar.Text += "-";
                        txt_buscar.SelectionStart = txt_buscar.TextLength;
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
            else if (cmbx_tipo_busqueda.Text == "Nombre Completo")
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

        private void dgv_docentes_inactivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_docentes_inactivos.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgv_docentes_inactivos.Rows[e.RowIndex];
                    IdDocente = dr.Cells["IdDocentes"].Value.ToString();
                    Atributos_Empleado.IdDocente = Convert.ToInt32(IdDocente);
                    cn_empleado.MostrarRegistroCompletoDocente(Atributos_Empleado.IdDocente);
                    navegar.AbrirFormEnPanel(typeof(Vistas.Docentes.Modificar.ModificarDocenteMain), "Editar Empleados");
                    Atributos_Empleado.EstadoFormulario = "EditarDocente";
                }
            }
        }
    }
}
