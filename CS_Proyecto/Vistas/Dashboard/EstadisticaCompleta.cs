using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Dashboard
{
    public partial class EstadisticaCompleta : Form
    {
        public EstadisticaCompleta()
        {
            InitializeComponent();
        }

        ClasesVista.NavegarEntreFormularios navegar = new ClasesVista.NavegarEntreFormularios();

        private void EstadisticaGeneral()
        {
            //Instancia para llenar la tabla
            CN_Dashboard cn_Dashboard = new CN_Dashboard(); ;
            dvg_estadistica.DataSource = cn_Dashboard.EstadisticaGeneral();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dvg_estadistica.Columns["Sección"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_estadistica.Columns["Guia"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_estadistica.Columns["Total"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_estadistica.Columns["Masc."].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_estadistica.Columns["Fem."].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_estadistica.Columns["3 Dos."].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_estadistica.Columns["2 Dos."].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_estadistica.Columns["1 Dos."].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_estadistica.Columns["Repo."].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Establecer Tamaño de celdas
            dvg_estadistica.Columns["Guia"].Width = 180;
            dvg_estadistica.Columns["IdSecciones"].Visible = false;

        }
        private void EstadisticaCompleta_Load(object sender, EventArgs e)
        {
            EstadisticaGeneral();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbx_tipo_busqueda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_buscar.Text = String.Empty;
            txt_buscar.Enabled = true;
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbx_tipo_busqueda.Text == "Total")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }
            else
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

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if(txt_buscar.Text != String.Empty)
            {
                CD_Dashboard dashboard = new CD_Dashboard();
                dvg_estadistica.DataSource = dashboard.BuscarSeccionPorEspecialidad(txt_buscar.Text);
            }
            else{
                CN_Dashboard cn_Dashboard = new CN_Dashboard(); ;
                dvg_estadistica.DataSource = cn_Dashboard.EstadisticaGeneral();
            }
            
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Dashboard.Dashboard_controles), "Dashboard");
        }
    }
}
