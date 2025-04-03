using CS_Proyecto.Atributos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Informacion_Medica;
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
    public partial class Informacion_Medica_Docentes : Form
    {
        public Informacion_Medica_Docentes()
        {
            InitializeComponent();
        }

        LimpiarVariables limpiar = new LimpiarVariables();

        private void MostrarBotonTablas()
        {
            //Añadir Boton
            AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
            añadirBtn.AñadirBotonObservarEnDataGrid(dgv_afecciones);
            añadirBtn.AñadirBotonObservarEnDataGrid(dgv_medicamentos);
        }
        private void poblarAfecciones()
        {
            CN_Empleado cn_empleado = new CN_Empleado();
            dgv_afecciones.DataSource = cn_empleado.buscarAfeccionesDocentes(Atributos_Empleado.IdDocente);
            dgv_afecciones.Columns["ImagenColumna"].DisplayIndex = 3;
        }

        private void poblarMedicamentos()
        {
            CN_Empleado cN_Empleado = new CN_Empleado();
            dgv_medicamentos.DataSource = cN_Empleado.buscarMedicamentosDocente(Atributos_Empleado.IdDocente);
            dgv_medicamentos.Columns["Dosis"].Visible = false;
            dgv_medicamentos.Columns["Frecuencia"].Visible = false;
            dgv_medicamentos.Columns["ImagenColumna"].DisplayIndex = 3;
        }


        private void mostrarInformacionMedica()
        {
            CN_Empleado cN_Empleado = new CN_Empleado();

            if (cmbx_tipo_busqueda.Text == "Nombre Completo")
            {
                bool busquedaNombre = cN_Empleado.buscarInformacionMedicaDocente(txt_buscar.Text);

                if (busquedaNombre)
                {
                    lbl_alergias.Text = Atributos_Empleado.MostrarAlergias;
                    lbl_Docente.Text = Atributos_Empleado.MostrarNombreDocente;
                    lbl_cargo.Text = Atributos_Empleado.MostrarCargoDocente;
                    lbl_telmov.Text = Atributos_Empleado.MostrarTelPrincipal;
                    lbl_telmovsec.Text = Atributos_Empleado.MostrarTelSecundario;
                    lbl_tel_emergencia.Text = Atributos_Empleado.MostrarTelEmergenciaPrincipal;
                    lbl_tel_emergencia_secundario.Text = Atributos_Empleado.MostrarTelEmergenciaSecundario;
                }
                else
                {
                    LimpiarLabels();
                }
            }
            else
            {
                bool busquedaDUI = cN_Empleado.buscarInformacionMedicaDocentePorDUI(txt_buscar.Text);

                if (busquedaDUI)
                {
                    lbl_alergias.Text = Atributos_Empleado.MostrarAlergias;
                    lbl_Docente.Text = Atributos_Empleado.MostrarNombreDocente;
                    lbl_cargo.Text = Atributos_Empleado.MostrarCargoDocente;
                    lbl_telmov.Text = Atributos_Empleado.MostrarTelPrincipal;
                    lbl_telmovsec.Text = Atributos_Empleado.MostrarTelSecundario;
                    lbl_tel_emergencia.Text = Atributos_Empleado.MostrarTelEmergenciaPrincipal;
                    lbl_tel_emergencia_secundario.Text = Atributos_Empleado.MostrarTelEmergenciaSecundario;
                }
                else
                {
                    LimpiarLabels();
                }
            }

        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_buscar.Text))
            {
                LimpiarLabels();
                LimpiarDGV();
            }
            else
            {
                LimpiarVariablesMostrar();
                LimpiarLabels();
                mostrarInformacionMedica();
                poblarAfecciones();
                poblarMedicamentos();
                if ((dgv_afecciones.Rows.Count == 0
                    && dgv_medicamentos.Rows.Count == 0)
                    && lbl_alergias.Text == String.Empty
                    && lbl_alergias.Text == String.Empty
                    && lbl_cargo.Text == String.Empty
                    && lbl_descripcion.Text == String.Empty
                    && lbl_Docente.Text == String.Empty
                    && lbl_telmov.Text == String.Empty
                    && lbl_tel_emergencia.Text == String.Empty
                    && lbl_tel_emergencia_secundario.Text == String.Empty)
                {
                    LimpiarLabels();
                    LimpiarDGV();
                }
            }
        }

        private void cmbx_tipo_busqueda_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_buscar.Enabled = true;
        }

        private void LimpiarLabels()
        {
            lbl_alergias.Text = "";
            lbl_Docente.Text = "Docente";
            lbl_telmov.Text = "";
            lbl_alergias.Text = "";
            lbl_telmovsec.Text = "";
            lbl_tel_emergencia.Text = "";
            lbl_tel_emergencia_secundario.Text = "";
            lbl_cargo.Text = "Cargo";

            limpiar.limpiarVarInformacionMedica();
        }

        private void LimpiarDGV()
        {
            dgv_afecciones.DataSource = null;
            dgv_medicamentos.DataSource = null;
        }

        private void LimpiarVariablesMostrar()
        {
            Atributos_Empleado.MostrarAlergias = null;
            Atributos_Empleado.MostrarNombreDocente = null;
            Atributos_Empleado.MostrarCargoDocente = null;
            Atributos_Empleado.MostrarTelPrincipal = null;
            Atributos_Empleado.MostrarTelSecundario = null;
            Atributos_Empleado.MostrarTelEmergenciaPrincipal = null;
            Atributos_Empleado.MostrarTelEmergenciaSecundario = null;
        }

        private void Informacion_Medica_Docentes_Load(object sender, EventArgs e)
        {
            MostrarBotonTablas();
        }

        private void dgv_afecciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_afecciones.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgv_afecciones.Rows[e.RowIndex];
                    Atributos_Alumno.NombreAfeccion = dr.Cells["Afeccion"].Value.ToString();
                    Atributos_Alumno.TipoAfeccion = dr.Cells["Tipo"].Value.ToString();
                    Atributos_Alumno.ProcedimientoMedico = dr.Cells["Procedimiento"].Value.ToString();
                    Ventana_Afecciones mostrar = new Ventana_Afecciones();
                    mostrar.ShowDialog();
                }
            }
        }

        private void dgv_medicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_medicamentos.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = dgv_medicamentos.Rows[e.RowIndex];
                    Atributos_Alumno.NombreMedicamento = dr.Cells["Medicamento"].Value.ToString();
                    Atributos_Alumno.Dosis = dr.Cells["Dosis"].Value.ToString();
                    Atributos_Alumno.Frecuencia = dr.Cells["Frecuencia"].Value.ToString();
                    Ventana_Medicamento mostrar = new Ventana_Medicamento();
                    mostrar.ShowDialog();
                }
            }
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
    }
}
