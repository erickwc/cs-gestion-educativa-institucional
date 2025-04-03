using CS_Proyecto.Atributos;
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

namespace CS_Proyecto.Vistas.Usuarios
{
    public partial class Editar_Usuario : Form
    {
        public Editar_Usuario()
        {
            InitializeComponent();
        }

        string idusuario = null;
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        CN_Usuarios Cn_Usuarios = new CN_Usuarios();
        AñadirBotonParaTablas añadir = new AñadirBotonParaTablas();

        private void MostrarUltimoUsuarioRegistrado()
        {
            //Instancia para llenar la tabla
            CN_Usuarios cn_usuarios = new CN_Usuarios(); ;
            tbl_usuarios_registrados.DataSource = cn_usuarios.EditarUsuarioRegistrado();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            tbl_usuarios_registrados.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Genero"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Dui"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Usuario"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Contraseña"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Correo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Estado"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Privilegio"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["ID"].SortMode = DataGridViewColumnSortMode.NotSortable;

            tbl_usuarios_registrados.Columns["ID"].Width = 25;
            tbl_usuarios_registrados.Columns["Estado"].Width = 25;
            tbl_usuarios_registrados.Columns["Privilegio"].Width = 50;
            tbl_usuarios_registrados.Columns["Genero"].Width = 50;
            tbl_usuarios_registrados.Columns["Dui"].Visible = false;
            tbl_usuarios_registrados.Columns["Correo"].Visible = false;
            tbl_usuarios_registrados.Columns["Contraseña"].Width = 65;
            tbl_usuarios_registrados.Columns["Nombres"].Width = 180;
            tbl_usuarios_registrados.Columns["Apellidos"].Width = 180;
            tbl_usuarios_registrados.Columns["Usuario"].Width = 110;

        }
        private void mostrarboton()
        {

            añadir.AñadirBotonEditarEnDataGrid(tbl_usuarios_registrados);

            //Establecer el orden de visualización del boton editar
            tbl_usuarios_registrados.Columns["ImagenColumna"].DisplayIndex = 10;
            tbl_usuarios_registrados.Columns["ImagenColumna"].Width = 140;


        }

        private void tbl_usuarios_registrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tbl_usuarios_registrados.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = tbl_usuarios_registrados.Rows[e.RowIndex];
                    idusuario = dr.Cells["ID"].Value.ToString();

                    Atributos_Usuarios.IdUsuario = Convert.ToInt32(idusuario);
                    Atributos_Usuarios.EstadoFormulario = "EditarUsuario";


                    Cn_Usuarios.MostrarDatoUsuario(Atributos_Usuarios.IdUsuario);
                    navegar.AbrirFormEnPanel(typeof(Vistas.Usuarios.Nuevo_Usuario_Main), "EditarUsuario");
                }
            }
        }

        private void Editar_Usuario_Load(object sender, EventArgs e)
        {
            MostrarUltimoUsuarioRegistrado();
            mostrarboton();
        }

        private void tbl_usuarios_registrados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tbl_usuarios_registrados.Columns[e.ColumnIndex].Name == "Contraseña")
            {
                if (e.Value != null)
                {
                    string contraseña = e.Value.ToString();
                    e.Value = new string('●', contraseña.Length);
                }
            }
        }

        private void cmbx_buscador_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_buscador.Enabled = true;
            txt_buscador.Text = String.Empty;
        }

        private void txt_buscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbx_buscador.Text == "Nombre de Usuario" || cmbx_buscador.Text == "Nombres" || cmbx_buscador.Text == "Apellidos")
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
                if (char.IsDigit(e.KeyChar) && txt_buscador.TextLength < 9)
                {
                    if (txt_buscador.TextLength == 7)
                    {
                        txt_buscador.Text += "-";
                        txt_buscador.SelectionStart = txt_buscador.TextLength; // Mover el cursor al final del texto.
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

        private void txt_buscador_TextChanged(object sender, EventArgs e)
        {
            CN_Usuarios cn_buscador = new CN_Usuarios();
            tbl_usuarios_registrados.DataSource = cn_buscador.BuscarUsuario(txt_buscador.Text);
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Controles_Usuarios), "Usuarios");
        }
    }
}
