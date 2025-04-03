using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Docentes.Modificar;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Formulario_Matricula
{
    public partial class Datos_personales : Form
    {

        public Datos_personales()
        {
            InitializeComponent();
        }

        Vistas.ClasesVista.ValidarCampos validarCampos = new Vistas.ClasesVista.ValidarCampos();
        Vistas.ClasesVista.NavegarEntreFormularios navegar = new Vistas.ClasesVista.NavegarEntreFormularios();
        private void btn_añadir_institucion_Click(object sender, EventArgs e)
        {
            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (Vistas.Mensajes_Funcionales.Nueva_Institucion nueva_Institucion = new Mensajes_Funcionales.Nueva_Institucion())
            {
                fondo.Oscurecer(nueva_Institucion);
            }
        }

        public void MostrarNacionalidades()
        {
            CD_Alumnos cd_alumno_nacionalidades = new CD_Alumnos();
            cmbx_nacionalidad.DataSource = cd_alumno_nacionalidades.MostrarNacionalidades();
            cmbx_nacionalidad.DisplayMember = "NombreNacionalidad";
            cmbx_nacionalidad.ValueMember = "IdNacionalidad";
        }

        public void MostrarInstituciones()
        {
            CD_Alumnos cd_alumno_instituciones = new CD_Alumnos();
            cmbx_inst_procedencia.DataSource = cd_alumno_instituciones.MostrarInstituciones();
            cmbx_inst_procedencia.DisplayMember = "NombreInst";
            cmbx_inst_procedencia.ValueMember = "IdInstProcedencia";
        }


        private void txt_nombres_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.Nombres = txt_nombres.Text;
            validarCampos.EstadoTextBox(txt_nombres);
        }

        private void txt_apellidos_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.Apellidos = txt_apellidos.Text;
            validarCampos.EstadoTextBox(txt_apellidos);
        }

        private void txt_lugar_nac_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.LugarNacimiento = txt_lugar_nac.Text;
            validarCampos.EstadoTextBox(txt_lugar_nac);

        }

        private void txt_partida_nacimiento_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.Partida = txt_partida_nacimiento.Text;
            validarCampos.EstadoTextBox(txt_partida_nacimiento);
        }


        private void cmbx_inst_procedencia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.IdInstitucionProcedencia = Convert.ToInt32(cmbx_inst_procedencia.SelectedValue);
            validarCampos.EstadoComboBox(cmbx_inst_procedencia);
        }


        private void cmbx_genero_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.Genero = cmbx_genero.Text;
            validarCampos.EstadoComboBox(cmbx_genero);
        }

        private void cmbx_educacion_inicial_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.EducacionInicial = cmbx_educacion_inicial.Text;
            validarCampos.EstadoComboBox(cmbx_educacion_inicial);
        }

        private void RecargarTextBox()
        {
            cmbx_inst_procedencia.SelectedValue = Convert.ToString(Atributos_Alumno.IdInstitucionProcedencia);
            cmbx_nacionalidad.SelectedValue = Convert.ToString(Atributos_Alumno.IdNacionalidad);
            txt_nombres.Text = Atributos_Alumno.Nombres;
            txt_apellidos.Text = Atributos_Alumno.Apellidos;
            tmp_fecha_nac.Text = Atributos_Alumno.FechaNacimiento;
            txt_lugar_nac.Text = Atributos_Alumno.LugarNacimiento;
            cmbx_genero.Text = Atributos_Alumno.Genero;
            txt_partida_nacimiento.Text = Atributos_Alumno.Partida; 
            cmbx_educacion_inicial.Text = Atributos_Alumno.EducacionInicial;
            cmbx_seccion_inicial.Text = Atributos_Alumno.SeccionInicial;
            cmbx_año_inicial.Text = Atributos_Alumno.AnioInicial;
            txt_nie.Text = Atributos_Alumno.NIE;
            cmbx_repitiendo_año.Text = Atributos_Alumno.RepitiendoAnio;
        }

        private void Datos_personales_Load(object sender, EventArgs e)
        {
            MostrarInstituciones();
            MostrarNacionalidades();
            MostrasAñosEnComboBox();
            RecargarTextBox();
            validarCampos.EstadoComboBox(cmbx_nacionalidad);
            validarCampos.EstadoComboBox(cmbx_educacion_inicial);
            validarCampos.EstadoComboBox(cmbx_genero);
            validarCampos.EstadoComboBox(cmbx_nacionalidad);
            validarCampos.EstadoComboBox(cmbx_inst_procedencia);
            validarCampos.EstadoComboBox(cmbx_seccion_inicial);
            validarCampos.EstadoComboBox(cmbx_año_inicial);
            validarCampos.EstadoDateTime(tmp_fecha_nac);
            validarCampos.EstadoComboBox(cmbx_repitiendo_año);

        }

        private void MostrasAñosEnComboBox()
        {
            int MostrarAños = DateTime.Now.Year;

            for (int año = 2010; año <= MostrarAños; año++)
            {
                cmbx_año_inicial.Items.Add(año);
            }
        }

        private void cmbx_seccion_inicial_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.SeccionInicial = cmbx_seccion_inicial.Text;
            validarCampos.EstadoComboBox(cmbx_seccion_inicial);
        }

        private void cmbx_nacionalidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.IdNacionalidad = Convert.ToInt32(cmbx_nacionalidad.SelectedValue);
            validarCampos.EstadoComboBox(cmbx_nacionalidad);
        }

        private void tmp_fecha_nac_CloseUp(object sender, EventArgs e)
        {
            Atributos_Alumno.FechaNacimiento = tmp_fecha_nac.Text;
            validarCampos.EstadoDateTime(tmp_fecha_nac);
        }

        private void cmbx_año_inicial_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.AnioInicial = cmbx_año_inicial.Text;
            validarCampos.EstadoComboBox(cmbx_año_inicial);
        }

        private void AñoInicialCmbx_Tick(object sender, EventArgs e)
        {
            int MostrarAños = DateTime.Now.Year;

            if (!cmbx_año_inicial.Items.Contains(MostrarAños))
            {
                cmbx_año_inicial.Items.Add(MostrarAños);
            }

            
        }

        private void txt_apellidos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_nombres_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ActualizarCombobox_Tick(object sender, EventArgs e)
        {
           
        }

        private void cmbx_inst_procedencia_Click(object sender, EventArgs e)
        {
            if (Atributos_Alumno.IdInstitucionProcedencia != 0)
            {
                cmbx_inst_procedencia.SelectedValue = Convert.ToInt32(Atributos_Alumno.IdInstitucionProcedencia);
            }
            else
            {
                MostrarInstituciones();
                cmbx_inst_procedencia.SelectedIndex = -1;
            }
        }

        private void cmbx_inst_procedencia_DropDown(object sender, EventArgs e)
        {
            if (Atributos_Alumno.IdInstitucionProcedencia != 0)
            {
                cmbx_inst_procedencia.SelectedValue = Convert.ToInt32(Atributos_Alumno.IdInstitucionProcedencia);
            }
            else
            {
                MostrarInstituciones();
                cmbx_inst_procedencia.SelectedIndex = -1;
             
            }
        }

        private void cmbx_nacionalidad_DropDown(object sender, EventArgs e)
        {
            if (Atributos_Alumno.IdNacionalidad != 0)
            {
                cmbx_nacionalidad.SelectedValue = Convert.ToInt32(Atributos_Alumno.IdNacionalidad);
            }
            else
            {
                MostrarNacionalidades();
                cmbx_nacionalidad.SelectedIndex = -1;
            }
        }

        private void btn_nacionalidades_Click(object sender, EventArgs e)
        {
            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (NuevaNacionalidad nacionalidad = new NuevaNacionalidad())
            {
                fondo.Oscurecer(nacionalidad);
            }
        }

        private void tmp_fecha_nac_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            DateTime fechaSeleccionada = tmp_fecha_nac.Value;
            if (fechaSeleccionada > fechaActual)
            {
                
                ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                using (FechaMayorALaActual fecha = new FechaMayorALaActual())
                {
                    fondo.Oscurecer(fecha);
                }

                tmp_fecha_nac.Value = fechaActual;
                tmp_fecha_nac.FillColor = Color.FromArgb(245, 247, 252);
                tmp_fecha_nac.ForeColor = Color.FromArgb(104, 104, 104);
                tmp_fecha_nac.BorderColor = Color.FromArgb(104, 104, 104);
                tmp_fecha_nac.BorderThickness = 1;
                tmp_fecha_nac.HoverState.FillColor = Color.FromArgb(245, 247, 252);
            }
        }

        private void cmbx_nacionalidad_Click(object sender, EventArgs e)
        {
            if (Atributos_Alumno.IdNacionalidad != 0)
            {
                cmbx_nacionalidad.SelectedValue = Convert.ToInt32(Atributos_Alumno.IdNacionalidad);
            }
            else
            {
                MostrarNacionalidades();
                cmbx_nacionalidad.SelectedIndex = -1;

            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbx_repitiendo_año_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Alumno.RepitiendoAnio = cmbx_repitiendo_año.Text;
            validarCampos.EstadoComboBox(cmbx_repitiendo_año);
        }

        private void btn_añadir_nie_temporal_Click(object sender, EventArgs e)
        {
            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (Vistas.Mensajes_Funcionales.Nuevo_nie_temporal nuevo_Nie_Temporal = new Mensajes_Funcionales.Nuevo_nie_temporal())
            {
                fondo.Oscurecer(nuevo_Nie_Temporal);
            }
        }

        private void BtnNieTemporal()
        {
            if (Atributos_Alumno.EstadoFormulario == "EditarAlumno")
            {
                if (string.IsNullOrWhiteSpace(Atributos_Alumno.NieTemporal))
                {
                    btn_añadir_nie_temporal.Visible = false;
                    btn_nie_verdadero.Visible = false;
                    txt_nie.Enabled = true;
                }
                else if (!string.IsNullOrWhiteSpace(Atributos_Alumno.NieTemporal))
                {
                    btn_añadir_nie_temporal.Visible = false;
                    btn_nie_verdadero.Visible = true;
                    txt_nie.Enabled = false;
                }
            }
            else if (Atributos_Alumno.EstadoFormulario == "GuardarAlumno")
            {
                if (!string.IsNullOrWhiteSpace(Atributos_Alumno.NieTemporal))
                {
                    btn_añadir_nie_temporal.Enabled = false;
                    txt_nie.Enabled = false;
                    btn_añadir_nie_temporal.ForeColor = Color.FromArgb(104, 104, 104);
                }
                else if (!string.IsNullOrWhiteSpace(Atributos_Alumno.NIE))
                {
                    btn_añadir_nie_temporal.Enabled = false;
                    btn_añadir_nie_temporal.ForeColor = Color.FromArgb(104, 104, 104);
                }
                else if (string.IsNullOrWhiteSpace(Atributos_Alumno.NieTemporal))
                {
                    btn_añadir_nie_temporal.Enabled = true;
                    btn_añadir_nie_temporal.ForeColor = Color.FromArgb(51, 53, 51);
                    txt_nie.Enabled = true;
                }
            }


        }

        private void txt_nie_TextChanged(object sender, EventArgs e)
        {
            Atributos_Alumno.NIE = txt_nie.Text;
            validarCampos.EstadoTextBoxOpcional(txt_nie);
     

        }

        private void ActualizarNieCampo_Tick(object sender, EventArgs e)
        {
            BtnNieTemporal();
            if(txt_nie.Enabled == false)
            {
                txt_nie.Text = String.Empty;
            }
        }

        private void btn_nie_verdadero_Click(object sender, EventArgs e)
        {
            Atributos_Alumno.NieTemporal = null;
            CN_Alumnos cn_alumno = new CN_Alumnos();
            cn_alumno.EditarNieTemporal(Atributos_Alumno.NieTemporal, Atributos_Alumno.IdAlumno);
            txt_nie.Enabled = true;
        }

        private void txt_nie_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_partida_nacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_partida_nacimiento.TextLength < 6)
            {

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
}
