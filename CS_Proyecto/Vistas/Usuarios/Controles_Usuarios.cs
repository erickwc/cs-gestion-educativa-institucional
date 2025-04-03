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

namespace CS_Proyecto.Vistas.Usuarios
{
    public partial class Controles_Usuarios : Form
    {
        public Controles_Usuarios()
        {
            InitializeComponent();
        }

        CN_Usuarios cn_usuarios = new CN_Usuarios();
        AñadirBotonParaTablas añadir = new AñadirBotonParaTablas();
        string idusuario = null;
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        CN_Usuarios Cn_Usuarios = new CN_Usuarios();

        private void MostrarUltimoUsuarioInactivos()
        {
            //Instancia para llenar la tabla
            CN_Usuarios cn_usuarios = new CN_Usuarios(); ;
            tbl_usuarios_inactivos.DataSource = cn_usuarios.MostrarUsuariosInactivos();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            tbl_usuarios_inactivos.Columns["Usuarios"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_inactivos.Columns["Estado"].SortMode = DataGridViewColumnSortMode.NotSortable;

        }

        private void MostrarUltimoUsuarioRegistrado()
        {
            //Instancia para llenar la tabla
            CN_Usuarios cn_usuarios = new CN_Usuarios(); ;
            tbl_usuarios_registrados.DataSource = cn_usuarios.MostrarUsuarioRegistrado();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            tbl_usuarios_registrados.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Genero"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Usuario"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Contraseña"].SortMode = DataGridViewColumnSortMode.NotSortable;
            tbl_usuarios_registrados.Columns["Privilegio"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //poner invisible una columna
            tbl_usuarios_registrados.Columns["IdUsuario"].Visible = false;
            tbl_usuarios_registrados.Columns["Privilegio"].Width = 95;
            tbl_usuarios_registrados.Columns["Usuario"].Width = 95;
            tbl_usuarios_registrados.Columns["Genero"].Width = 95;
            tbl_usuarios_registrados.Columns["Nombres"].Width = 115;
            tbl_usuarios_registrados.Columns["Apellidos"].Width = 115;
            tbl_usuarios_registrados.Columns["Contraseña"].Width = 115;

        }

        private void btn_nuevo_usuario_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Usuarios.Nuevo_Usuario_Main), "Nuevo Usuario");
            Atributos_Usuarios.EstadoFormulario = "GuardarUsuario";
        }

        private void Controles_Usuarios_Load(object sender, EventArgs e)
        {
            MostrarUltimoUsuarioInactivos();
            MostrarUltimoUsuarioRegistrado();
            cn_usuarios.UsuariosActuales();
            cn_usuarios.UsuariosActivos();
            cn_usuarios.UsuariosInactivos();
            lblUsuariosActuales.Text = Convert.ToString(Atributos_Usuarios.Usuariostotales);
            lblUsuariosActivos.Text = Convert.ToString(Atributos_Usuarios.UsuariosActivos);
            lblUsuariosInactivos.Text = Convert.ToString(Atributos_Usuarios.UsuariosInactivos);
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

        private void btn_editar_usuario_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Usuarios.Editar_Usuario), "Editar Usuario");
            Atributos_Usuarios.EstadoFormulario = "EditarUsuario";
        }

        private void mostrarboton()
        {

            añadir.AñadirBotonEditarEnDataGrid(tbl_usuarios_registrados);

            //Establecer el orden de visualización del boton editar
            tbl_usuarios_registrados.Columns["ImagenColumna"].DisplayIndex = 7;
            tbl_usuarios_registrados.Columns["ImagenColumna"].Width =100;
        }

        private void tbl_usuarios_registrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tbl_usuarios_registrados.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = tbl_usuarios_registrados.Rows[e.RowIndex];
                    idusuario = dr.Cells["IdUsuario"].Value.ToString();

                    Atributos_Usuarios.IdUsuario = Convert.ToInt32(idusuario);
                    Atributos_Usuarios.EstadoFormulario = "EditarUsuario";


                    Cn_Usuarios.MostrarDatoUsuario(Atributos_Usuarios.IdUsuario);
                    navegar.AbrirFormEnPanel(typeof(Vistas.Usuarios.Nuevo_Usuario_Main), "EditarUsuario");
                }
            }
        }

        private void icono_Click(object sender, EventArgs e)
        {

        }
    }
}
