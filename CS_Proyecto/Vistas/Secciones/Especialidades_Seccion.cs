using CS_Proyecto.Atributos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
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
    public partial class Especialidades_Seccion : Form
    {
        public Especialidades_Seccion()
        {
            InitializeComponent();
        }

        Vistas.ClasesVista.ValidarCampos validar = new Vistas.ClasesVista.ValidarCampos();
        CN_secciones cN_Secciones = new CN_secciones();
        string AccionBtn = "Guardar";
        string IdEspecialidades = null;
        AñadirBotonParaTablas añadirBtn = new AñadirBotonParaTablas();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();


        private void cargarEspecialidades()
        {
            CN_secciones cN_Secciones = new CN_secciones();
            DGV_especialidades_secciones.DataSource = cN_Secciones.mostrarEspecialidadesActuales();

            DGV_especialidades_secciones.Columns["IdEspecialidades"].Visible = false;
            DGV_especialidades_secciones.Columns["Especialidades"].Width = 500;
            //DGV_especialidades_secciones.Columns["Duracion"].Width = 150;
        }

        private void MostrarBtn()
        {
            añadirBtn.AñadirBotonEditarEnDataGrid(DGV_especialidades_secciones);
            DGV_especialidades_secciones.Columns["ImagenColumna"].DisplayIndex = 3;
            DGV_especialidades_secciones.Columns["ImagenColumna"].Width = 150;
        }

        private void txt_especialidad_TextChanged(object sender, EventArgs e)
        {
            SaberSiYaExisteElRegistro();
            Atributos_seccion.Nombre = txt_especialidad.Text;
            
        }

        private void SaberSiYaExisteElRegistro()
        {
            bool registroDuplicadoEncontrado = false;

            string txt_cargoValue = txt_especialidad.Text.Trim().ToLower();

            foreach (DataGridViewRow dr in DGV_especialidades_secciones.Rows)
            {
                string tipoexistente = dr.Cells["Especialidades"].Value.ToString().Trim().ToLower();

                if (tipoexistente == txt_cargoValue)
                {
                    registroDuplicadoEncontrado = true;

                    if (AccionBtn == "Guardar")
                    {
                        lbl_alerta.Visible = true;
                        btn_guardar_modificar.Visible = false;
                        validar.UsuarioConNombreIgual(txt_especialidad);
                        break;
                    }
                    if (AccionBtn == "Editar")
                    {
                        txt_especialidad.Text = dr.Cells["Especialidades"].Value.ToString();
                    }
                }
            }

            if (!registroDuplicadoEncontrado)
            {
                lbl_alerta.Visible = false;
                btn_guardar_modificar.Visible = true;
                validar.EstadoTextBoxOpcional(txt_especialidad);

            }
        }

        private void cmbx_duracion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_seccion.Duracion = cmbx_duracion.Text;
            validar.EstadoComboBox(cmbx_duracion);
        }

        private void Especialidades_Seccion_Load(object sender, EventArgs e)
        {
            cargarEspecialidades();
            MostrarBtn();
        }

        private void btn_guardar_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (AccionBtn == "Guardar")
                {
                    cN_Secciones.InsertarEspecialidad(
                         txt_especialidad.Text,
                        cmbx_duracion.Text
                    );

                    cargarEspecialidades();

                    txt_especialidad.Text = String.Empty;
                    cmbx_duracion.SelectedIndex = -1;

                    validar.EstadoComboBox(cmbx_duracion);

                }

                else if (AccionBtn == "Editar")
                {
                    cN_Secciones.ModificarEspecialidad(
                        Convert.ToInt32(IdEspecialidades),
                        txt_especialidad.Text,
                        cmbx_duracion.Text
                    );

                  
                    cargarEspecialidades();

                    txt_especialidad.Text = String.Empty;
                    cmbx_duracion.SelectedIndex = -1;

                    validar.EstadoComboBox(cmbx_duracion);
                    AccionBtn = "Guardar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void DGV_especialidades_secciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_especialidades_secciones.Columns["ImagenColumna"].Index && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dr = DGV_especialidades_secciones.Rows[e.RowIndex];
                    IdEspecialidades = dr.Cells["IdEspecialidades"].Value.ToString();
                    AccionBtn = "Editar";
                    txt_especialidad.Text = dr.Cells["Especialidades"].Value.ToString();
                    cmbx_duracion.Text = dr.Cells["Duracion"].Value.ToString();
                    validar.EstadoComboBox(cmbx_duracion);
                }

            }
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Seccion.Seccion_Main), "Secciónes");

        }

        private void btn_Tick(object sender, EventArgs e)
        {
            if (lbl_alerta.Visible == true)
            {
                btn_guardar_modificar.Visible = false;
            }
            else if (!string.IsNullOrWhiteSpace(txt_especialidad.Text))

            {
                btn_guardar_modificar.Visible = true;
            }
            else
            {
                btn_guardar_modificar.Visible = false;
            }
        }

    }
}
