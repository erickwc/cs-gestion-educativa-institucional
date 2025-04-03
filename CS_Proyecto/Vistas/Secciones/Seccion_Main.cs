using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Dashboard;
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
    public partial class Seccion_Main : Form
    {
        public Seccion_Main()
        {
            InitializeComponent();
        }

        Vistas.ClasesVista.ValidarCampos validar = new Vistas.ClasesVista.ValidarCampos();
        string IdSecciones = null;
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        CN_secciones cN_Secciones1 = new CN_secciones();
        

        private void btn_especialidades_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Especialidades_Seccion), "Especialidades Secciones");
        }

        private void btn_modificar_seccion_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Modificar_Eliminar_Seccion), "Especialidades Secciones");
        }

        private void cargarTablaSecciones()
        {
            CN_secciones cN_Secciones = new CN_secciones();
            dgv_seccionesActuales.DataSource = cN_Secciones.mostrarSeccionesActuales();

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dgv_seccionesActuales.Columns["IdSecciones"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_seccionesActuales.Columns["Codigo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_seccionesActuales.Columns["Especialides"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_seccionesActuales.Columns["Docente"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_seccionesActuales.Columns["Tipo Seccion"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Añadir Boton
            AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
            añadirBtn.AñadirBotonEditarEnDataGrid(dgv_seccionesActuales);

            //poner invisible una columna
            dgv_seccionesActuales.Columns["IdSecciones"].Visible = false;
            dgv_seccionesActuales.Columns["Codigo"].Width = 160;
            dgv_seccionesActuales.Columns["Especialides"].Width = 300;
            dgv_seccionesActuales.Columns["Docente"].Width = 260;
            dgv_seccionesActuales.Columns["Tipo Seccion"].Width = 160;
            dgv_seccionesActuales.Columns["ImagenColumna"].Width = 100;
        }

        private void cargarTablaEspecialidades()
        {
            CN_secciones cN_Secciones = new CN_secciones();
            dvg_especialidades.DataSource = cN_Secciones.NombresEspecialidades();
        }

        private void Seccion_Main_Load(object sender, EventArgs e)
        {
            cargarTablaSecciones();
            cN_Secciones1.CantidadSecciones();
            cN_Secciones1.CantidadEspecialidesw();
            lblCantidadEspecialidades.Text = Convert.ToString(Atributos_seccion.CantidadEspecialidades);
            lblCantidadSecciones.Text = Convert.ToString(Atributos_seccion.CantidadSecciones);
            cargarTablaEspecialidades();
        }

        private void dgv_seccionesActuales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_seccionesActuales.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgv_seccionesActuales.Rows[e.RowIndex];
                    IdSecciones = dr.Cells["IdSecciones"].Value.ToString();
                    Atributos_seccion.IdSecciones = Convert.ToInt32(IdSecciones);

                    cN_Secciones1.mostrarDatoSeccion(Atributos_seccion.IdSecciones);

                    Atributos_seccion.EstadoFormulario = "Editar";
                    
                    navegar.AbrirFormEnPanel(typeof(Nueva_seccion_main), "Editar Seccion");

                }

            }
        }

        private void btn_tipos_secciones_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(TipoSeccion), "Tipos de Sección");
        }

        private void btn_nueva_seccion_Click_1(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Secciones.Nueva_seccion_main), "Nueva Sección");
            Atributos_seccion.EstadoFormulario = "Guardar";
        }
    }
}
