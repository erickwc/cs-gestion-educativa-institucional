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

namespace CS_Proyecto.Vistas.Docentes
{
    public partial class Dashboard_Docente : Form
    {
        public Dashboard_Docente()
        {
            InitializeComponent();
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        string IdDocente;
        CN_Empleado cn_empleado = new CN_Empleado();
        private void CargarEspecialidades()
        {
            CD_Empleados cD_Empleados = new CD_Empleados();
            dgv_especialidades.DataSource = cD_Empleados.MostrarEspecialidades();
        }

        private void MostrarEspecialidades()
        {
            dgv_especialidades.Columns["IdEspecialidadDocentes"].Visible = false;
        }

        private void AjustarFilas()
        {
            dvg_docentes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dvg_docentes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dvg_docentes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void EstadistivaGeneral()
        {
            CN_Empleado cN_Empleado = new CN_Empleado();
            dvg_docentes.DataSource = cN_Empleado.EstadisticaGeneralDocentes();

            DataTable dt = new DataTable();
            dvg_docentes.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_docentes.Columns["Nivel de estudio"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_docentes.Columns["Cargo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dvg_docentes.Columns["Especialidad"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_docentes.Columns["Telefono"].SortMode = DataGridViewColumnSortMode.NotSortable;

            dvg_docentes.Columns["Nombre"].Width = 220;
            dvg_docentes.Columns["Cargo"].Width = 160;
            dvg_docentes.Columns["Nivel de estudio"].Width = 210;
            //dvg_docentes.Columns["Especialidad"].Width = 150;
            dvg_docentes.Columns["Telefono"].Width = 100;
            dvg_docentes.Columns["IdDocentes"].Visible = false;
           
        }

        private void AñadirBtn()
        {
            añadirBtn.AñadirBotonEditarEnDataGrid(dvg_docentes);
            dvg_docentes.Columns["ImagenColumna"].Width = 110;
            
            DataGridViewColumn columnaImagen = dvg_docentes.Columns["ImagenColumna"];
            DataGridViewCellStyle estiloColumnaImagen = columnaImagen.DefaultCellStyle;
            estiloColumnaImagen.Alignment = DataGridViewContentAlignment.TopLeft;
        }

        


        private void CantidadDeDocentesRegistrados()
        {

            CD_Empleados cD_Empleados = new CD_Empleados();
            cD_Empleados.TotalDeDocentesActivos();
            lblCantidadDocentes.Text = Convert.ToString(Atributos_Dashboard_Docente.CantidadTotalDeDocentes);

        }


        private void MostrarCantidadEspecialidades()
        {
            CD_Empleados cD_Empleados = new CD_Empleados();
            cD_Empleados.TotalDeEspecialidadesRegistradas();
            lbl_especialidades.Text = Convert.ToString(Atributos_Dashboard_Docente.CantidadDeEspecialidades);
        }

        private void Dashboard_Docente_Load(object sender, EventArgs e)
        {
            EstadistivaGeneral();
            AñadirBtn();
            CantidadDeDocentesRegistrados();
            CargarEspecialidades();
            MostrarEspecialidades();
            MostrarCantidadEspecialidades();
            AjustarFilas();
           
        }

        private void btn_nuevo_docente_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Docentes.Agregar_Docente_Main), "Nuevo Empleado");
        }

        private void btn_editar_docente_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Docentes.Modificar_O_Eliminar_Docente), "Editar Empleado");
        }

        private void btn_informacion_medica_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Docentes.Informacion_Medica_Docentes), "Informacion Medica de Empleados");
        }

        private void btn_mantenimiento_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Docentes.MantenimientoDocentes), "Informacion Medica de Empleados");

        }

        private void dvg_docentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_docentes.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dvg_docentes.Rows[e.RowIndex];
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
