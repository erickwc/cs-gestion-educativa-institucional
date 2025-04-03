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
    public partial class Usuarios_inactivos : Form
    {
        public Usuarios_inactivos()
        {
            InitializeComponent();
        }

        private string datoBusqueda = string.Empty;
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        CN_Usuarios cn_usuarios = new CN_Usuarios();
        string IdUsuario = null;
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Datos_Inactivos.Controles_datos_inactivos), "Datos Inactivos");
        }

        private void UsuariosInactivos()
        {
            CN_DatosInactivos cn_inactivos = new CN_DatosInactivos();
            dgv_usuarios_inactivos.DataSource = cn_inactivos.UsuariosInactivosVista();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dgv_usuarios_inactivos.Columns["Usuario"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_usuarios_inactivos.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_usuarios_inactivos.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_usuarios_inactivos.Columns["Genero"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_usuarios_inactivos.Columns["DUI"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_usuarios_inactivos.Columns["Correo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_usuarios_inactivos.Columns["Privilegio"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_usuarios_inactivos.Columns["Estado"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Poner Invisible una columna
            dgv_usuarios_inactivos.Columns["ID"].Visible = false;
            dgv_usuarios_inactivos.Columns["Nombres"].Width = 150;
            dgv_usuarios_inactivos.Columns["Apellidos"].Width = 150;

        }

        private void añadirBtnTabla()
        {

            //Añadir Boton
            añadirBtn.AñadirBotonEditarEnDataGrid(dgv_usuarios_inactivos);

            //Establecer el orden de visualización del boton editar
            dgv_usuarios_inactivos.Columns["ImagenColumna"].DisplayIndex = 9;
            dgv_usuarios_inactivos.Columns["ImagenColumna"].Width = 100;

        }

        private void Usuarios_inactivos_Load(object sender, EventArgs e)
        {
            UsuariosInactivos();
            añadirBtnTabla();
        }

        private void dgv_usuarios_inactivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_usuarios_inactivos.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgv_usuarios_inactivos.Rows[e.RowIndex];
                    IdUsuario = dr.Cells["ID"].Value.ToString();
                    Atributos_Usuarios.IdUsuario = Convert.ToInt32(IdUsuario);

                    cn_usuarios.MostrarDatoUsuario(Atributos_Usuarios.IdUsuario);
                    navegar.AbrirFormEnPanel(typeof(Vistas.Usuarios.Nuevo_Usuario_Main), "Activar Usuario");
                    Atributos_Usuarios.EstadoFormulario = "EditarUsuario";
                }
            }
        }

        private void dgv_usuarios_inactivos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_usuarios_inactivos.Columns[e.ColumnIndex].Name == "Estado")
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
            dgv_usuarios_inactivos.DataSource = cn_inactivos.BuscarUsuariosInactivosVista(datoBusqueda);
        }

        private void RefrescarDatos_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(datoBusqueda))
            {
                CN_DatosInactivos cn_inactivos = new CN_DatosInactivos();
                dgv_usuarios_inactivos.DataSource = cn_inactivos.BuscarUsuariosInactivosVista(datoBusqueda);
            }
            else
            {
                CN_DatosInactivos cn_inactivos = new CN_DatosInactivos();
                dgv_usuarios_inactivos.DataSource = cn_inactivos.UsuariosInactivosVista();
            }
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbx_tipo_busqueda.Text == "Nombre de usuario" || cmbx_tipo_busqueda.Text == "Nombres" || cmbx_tipo_busqueda.Text == "Apellidos")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                }
            }
            else if (cmbx_tipo_busqueda.Text == "DUI")
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
        }

        private void cmbx_tipo_busqueda_SelectionChangeCommitted(object sender, EventArgs e)
        {

            txt_buscar.Enabled = true;
            txt_buscar.Text = String.Empty;
        }
    }
}
