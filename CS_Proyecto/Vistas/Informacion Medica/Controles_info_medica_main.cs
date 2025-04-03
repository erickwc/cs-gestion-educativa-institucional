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

namespace CS_Proyecto.Vistas.Informacion_Medica
{
    public partial class Controles_info_medica_main : Form
    {
        public Controles_info_medica_main()
        {
            InitializeComponent();
        }

        CN_Alumnos cN_Alumnos = new CN_Alumnos();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Dashboard.Dashboard_controles), "Dashboard");
        }


        private void MostrarAfeccionesAlumno()
        {
            //Llenar tabla
            CN_Alumnos afeccionesalumno = new CN_Alumnos();
            dvg_afecciones_alumno.DataSource = afeccionesalumno.MostrarAfeccionesAlumno(txt_buscar.Text);

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dvg_afecciones_alumno.Columns["Afección"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_afecciones_alumno.Columns["Tipo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvg_afecciones_alumno.Columns["Procedimiento"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Establecer el orden de visualización del boton editar
            dvg_afecciones_alumno.Columns["ImagenColumna"].DisplayIndex = 4;
            dvg_afecciones_alumno.Columns["IdAfeccion"].Visible = false;
        }

        private void MostrarMedicamentosAlumno()
        {
            //Llenar tabla
            CN_Alumnos medicamentosalumno = new CN_Alumnos();
            dvg_medicamentos_alumno.DataSource = medicamentosalumno.MostrarMedicamentosAlumno(txt_buscar.Text);

            //Inmovilizar columnas 
            DataTable tabla = new DataTable();
            dvg_medicamentos_alumno.Columns["Medicamento"].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Establecer el orden de visualización del boton editar
            dvg_medicamentos_alumno.Columns["ImagenColumna"].DisplayIndex = 3;

            //Establecer columnas invisibles
            dvg_medicamentos_alumno.Columns["Frecuencia"].Visible = false;
            dvg_medicamentos_alumno.Columns["Dosis"].Visible = false;
            dvg_medicamentos_alumno.Columns["IdMedicamento"].Visible = false;


        }

        private void MostrarInformacionMedica()
        {
            bool busqueda = cN_Alumnos.consultaInformacionMedicaAlumno(txt_buscar.Text);

            if (busqueda)
            {
                lbl_alergias.Text = Atributos_Alumno.MostrarAlergias;
                lbl_permite_actividad_fisica.Text = Atributos_Alumno.MostrarPermiteActividadFisica;
                lbl_resp_principal.Text = Atributos_Alumno.MostrarRespPrincipal;
                lbl_resp_sec.Text = Atributos_Alumno.MostrarRespSecundario;
                lbl_tel_movil.Text = Atributos_Alumno.MostrarTelPrincipalResPrincipal;
                lbl_tel_resp_sec.Text = Atributos_Alumno.MostrarTelSecundarioResSecundario;
                lbl_seccion.Text = Atributos_Alumno.MostrarSeccionAlumno;
                lbl_tel_movil_sec.Text = Atributos_Alumno.MostrarTelSecundarioResPrincipal;
                lbl_alumno.Text = Atributos_Alumno.MostrarNombresAlumno + " " + Atributos_Alumno.MostrarApellidosAlumno;
            }
            else
            {
                LimpiarLabels();
            }
            
        }

        private void LimpiarLabels()
        {
            lbl_alergias.Text = "";
            lbl_permite_actividad_fisica.Text = "";
            lbl_resp_principal.Text = "";
            lbl_resp_sec.Text = "";
            lbl_tel_movil.Text = "";
            lbl_tel_resp_sec.Text = "";
            lbl_seccion.Text = "Sección";
            lbl_tel_movil_sec.Text = "";
            lbl_alumno.Text = "Alumno";
        }

        private void LimpiarVariablesMostrar()
        {
            Atributos_Alumno.MostrarAlergias = null;
            Atributos_Alumno.MostrarPermiteActividadFisica = null;
            Atributos_Alumno.MostrarRespPrincipal = null;
            Atributos_Alumno.MostrarRespSecundario = null;
            Atributos_Alumno.MostrarTelPrincipalResPrincipal = null;
            Atributos_Alumno.MostrarTelSecundarioResSecundario = null;
            Atributos_Alumno.MostrarSeccionAlumno = null;
            Atributos_Alumno.MostrarTelSecundarioResPrincipal = null;
            Atributos_Alumno.MostrarNombresAlumno = null; 
            Atributos_Alumno.MostrarApellidosAlumno = null;
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_buscar.Text))
            {
                LimpiarLabels();
            }
            else
            {
                LimpiarVariablesMostrar();
                LimpiarLabels();
                MostrarAfeccionesAlumno();
                MostrarMedicamentosAlumno();
                MostrarInformacionMedica();
                if ((dvg_medicamentos_alumno.Rows.Count == 0 
                    && dvg_afecciones_alumno.Rows.Count == 0)
                    && lbl_alergias.Text == String.Empty
                    && lbl_permite_actividad_fisica.Text == String.Empty
                    && lbl_resp_principal.Text == String.Empty
                    && lbl_resp_sec.Text == String.Empty
                    && lbl_tel_movil.Text == String.Empty
                    && lbl_tel_resp_sec.Text == String.Empty
                    && lbl_seccion.Text == String.Empty
                    && lbl_tel_movil_sec.Text == String.Empty
                    && lbl_alumno.Text == String.Empty)
                {
                    LimpiarLabels();
                }
            }
        }

        private void MostrarBotonTablas()
        {
            //Añadir Boton
            AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
            añadirBtn.AñadirBotonObservarEnDataGrid(dvg_afecciones_alumno);
            añadirBtn.AñadirBotonObservarEnDataGrid(dvg_medicamentos_alumno);
        }

        private void Controles_info_medica_main_Load(object sender, EventArgs e)
        {
            MostrarBotonTablas();
        }

        private void dvg_medicamentos_alumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_medicamentos_alumno.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
            
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dvg_medicamentos_alumno.Rows[e.RowIndex];
                    Atributos_Alumno.NombreMedicamento = dr.Cells["Medicamento"].Value.ToString();
                    Atributos_Alumno.Dosis = dr.Cells["Dosis"].Value.ToString();
                    Atributos_Alumno.Frecuencia = dr.Cells["Frecuencia"].Value.ToString();
                    Ventana_Medicamento mostrar = new Ventana_Medicamento();
                    mostrar.ShowDialog();
                }

             
            }
        }

        private void dvg_afecciones_alumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvg_afecciones_alumno.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dvg_afecciones_alumno.Rows[e.RowIndex];
                    Atributos_Alumno.NombreAfeccion = dr.Cells["Afección"].Value.ToString();
                    Atributos_Alumno.TipoAfeccion = dr.Cells["Tipo"].Value.ToString();
                    Atributos_Alumno.ProcedimientoMedico = dr.Cells["Procedimiento"].Value.ToString();
                    Ventana_Afecciones mostrar = new Ventana_Afecciones();
                    mostrar.ShowDialog();
                }


            }
        }

        private void cmbx_tipo_busqueda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_buscar.Enabled = true;
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbx_tipo_busqueda.Text == "Nombres Alumno" || cmbx_tipo_busqueda.Text == "Apellidos Alumno")
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
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }
        }
    }
}

