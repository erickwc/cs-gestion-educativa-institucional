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
    public partial class Controles_datos_inactivos : Form
    {
        public Controles_datos_inactivos()
        {
            InitializeComponent();
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();

        private void btn_alumnos_inactivos_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Datos_Inactivos.Alumnos_inactivos), "Alumnos Inactivos");
        }

        private void btn_docentes_inactivos_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Datos_Inactivos.Docentes_inactivos), "Docentes Inactivos");
        }

        private void btn_usuarios_inactivos_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Datos_Inactivos.Usuarios_inactivos), "Usuarios Inactivos");
        }

        private void btn_volver_dashboard_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Dashboard.Dashboard_controles), "Dashboard");
        }

        private void ALumnosInactivosPreview()
        {
            CN_DatosInactivos cn_inactivos = new CN_DatosInactivos();
            dgv_alumnos_inactivos.DataSource = cn_inactivos.AlumnosInactivosPreview();
            dgv_alumnos_inactivos.Columns["Ultimos alumnos inactivos"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_alumnos_inactivos.Columns["IdAlumno"].Visible = false;
        }

        private void DocentesInactivosPreview()
        {
            CN_DatosInactivos cn_inactivos = new CN_DatosInactivos();
            dgv_docentes_inactivos.DataSource = cn_inactivos.DocentesInactivosPreview();
            dgv_docentes_inactivos.Columns["Ultimos docentes inactivos"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_docentes_inactivos.Columns["IdDocentes"].Visible = false;
        }

        private void UsuariosInactivosPreview()
        {
            CN_DatosInactivos cn_inactivos = new CN_DatosInactivos();
            dgv_usuarios_inactivos.DataSource = cn_inactivos.UsuariosInactivosPreview();
            dgv_usuarios_inactivos.Columns["Ultimos usuarios inactivos"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_usuarios_inactivos.Columns["IdUsuario"].Visible = false;
        }

        private void Controles_datos_inactivos_Load(object sender, EventArgs e)
        {
            ALumnosInactivosPreview();
            DocentesInactivosPreview();
            UsuariosInactivosPreview();
        }
    }
}
