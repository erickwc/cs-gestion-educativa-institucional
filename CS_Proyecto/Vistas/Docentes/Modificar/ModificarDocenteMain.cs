using CS_Proyecto.Atributos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Docentes.Modificar
{
    public partial class ModificarDocenteMain : Form
    {
        public ModificarDocenteMain()
        {
            InitializeComponent();
        }

        LimpiarVariables limpiarvar = new LimpiarVariables();
        CN_Empleado cn_empleado = new CN_Empleado();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();

        private void SeccionActiva(Guna2Button btn)
        {
            btn.FillColor = Color.FromArgb(232, 237, 255);
            btn.ForeColor = Color.FromArgb(63, 86, 255);
            btn.HoverState.FillColor = Color.FromArgb(232, 237, 255);
            btn.PressedColor = Color.FromArgb(232, 237, 255);
            btn.Font = new Font(btn.Font, FontStyle.Bold);
        }

        private void SeccionInactiva(Guna2Button btn)
        {
            btn.FillColor = Color.White;
            btn.ForeColor = Color.FromArgb(104, 104, 104);
            btn.HoverState.FillColor = Color.White;
            btn.PressedColor = Color.White;
            btn.Font = new Font(btn.Font, FontStyle.Regular);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                cn_empleado.modificarEmpleado(
                    Atributos_Empleado.NombreCompleto,
                    Atributos_Empleado.NombreCompletoDUI,
                    Atributos_Empleado.NombreCompletoNIT,
                    Atributos_Empleado.Conyuge,
                    Atributos_Empleado.EstadoCivil,
                    Atributos_Empleado.Jubilado,
                    Atributos_Empleado.Direccion,
                    Atributos_Empleado.IdNivelDeEstudio,
                 
                    Atributos_Empleado.NIP,
                    Atributos_Empleado.NIT,
                    Atributos_Empleado.DUI,
                    Atributos_Empleado.NumeroDeISSS,
                    Atributos_Empleado.NUP,
                    Atributos_Empleado.AFP,
                    Atributos_Empleado.IdEstado,
                    Atributos_Empleado.TelefonoMovilPrincipal,
                    Atributos_Empleado.TelefonoMovilSecundario,
                    Atributos_Empleado.TelefonoCasa,
                    Atributos_Empleado.TelefonoDeOficina,
                    Atributos_Empleado.TelefonoEmergencia,
                    Atributos_Empleado.TelefonoDeEmergenciaSecundario,
                    Atributos_Empleado.IdDocente
                    );

                ;
                
                ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                using (Mensajes_Funcionales.RegistroEditado mensaje = new Mensajes_Funcionales.RegistroEditado())
                {
                    fondo.Oscurecer(mensaje);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DatosPersonales_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelModificarEmpleado(typeof(Vistas.Docentes.Agregar_Docentes_Datos_Personales));
            SeccionActiva(btn_DatosPersonales);
            SeccionInactiva(btn_Identificacion);
            SeccionInactiva(btn_informacion_medica);
            SeccionInactiva(btn_ResidenciaContacto);
            SeccionInactiva(btn_materias);
            SeccionInactiva(btn_cargos);
            SeccionInactiva(btn_especialidades);
            seccion_botones.Height = 137;
            btn_modificar.Visible = true;
        }

        private void btn_Identificacion_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelModificarEmpleado(typeof(Vistas.Docentes.Agregar_Docente_Identificacion));
            SeccionActiva(btn_Identificacion);
            SeccionInactiva(btn_DatosPersonales);
            SeccionInactiva(btn_informacion_medica);
            SeccionInactiva(btn_ResidenciaContacto);
            SeccionInactiva(btn_materias);
            SeccionInactiva(btn_cargos);
            SeccionInactiva(btn_especialidades);
            seccion_botones.Height = 137;
            btn_modificar.Visible = true;
        }

        private void btn_ResidenciaContacto_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelModificarEmpleado(typeof(Vistas.Docentes.Agregar_Docente_Residencia_Contacto));
            SeccionActiva(btn_ResidenciaContacto);
            SeccionInactiva(btn_DatosPersonales);
            SeccionInactiva(btn_Identificacion);
            SeccionInactiva(btn_informacion_medica);
            SeccionInactiva(btn_materias);
            SeccionInactiva(btn_cargos);
            SeccionInactiva(btn_especialidades);
            seccion_botones.Height = 137;
            btn_modificar.Visible = true;

        }

        private void btn_informacion_medica_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelModificarEmpleado(typeof(Vistas.Docentes.Modificar.Modificar_Informacion_Medica_Main));
            SeccionActiva(btn_informacion_medica);
            SeccionInactiva(btn_DatosPersonales);
            SeccionInactiva(btn_Identificacion);
            SeccionInactiva(btn_ResidenciaContacto);
            SeccionInactiva(btn_materias);
            SeccionInactiva(btn_especialidades);
            SeccionInactiva(btn_cargos);
            seccion_botones.Height = 110;
            btn_modificar.Visible = false;
        }

        private void ModificarDocenteMain_Load(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelModificarEmpleado(typeof(Vistas.Docentes.Agregar_Docentes_Datos_Personales));
            SeccionActiva(btn_DatosPersonales);
            SeccionInactiva(btn_Identificacion);
            SeccionInactiva(btn_informacion_medica);
            SeccionInactiva(btn_ResidenciaContacto);
            SeccionInactiva(btn_materias);
            SeccionInactiva(btn_cargos);
            SeccionInactiva(btn_especialidades);

        }

        private void btn_materias_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelModificarEmpleado(typeof(Vistas.Docentes.Agregar_materias_docentes));
            SeccionActiva(btn_materias);
            SeccionInactiva(btn_Identificacion);
            SeccionInactiva(btn_informacion_medica);
            SeccionInactiva(btn_ResidenciaContacto);
            SeccionInactiva(btn_DatosPersonales);
            SeccionInactiva(btn_cargos);
            SeccionInactiva(btn_especialidades);

            seccion_botones.Height = 110;
            btn_modificar.Visible = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Docentes.Modificar_O_Eliminar_Docente), "Editar Empleados");
            limpiarvar.limpiarVarDocentes();
            limpiarvar.limpiarVarInformacionMedica();
            limpiarvar.limpiarVarMedicamento();
        }

        private void btn_cargos_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelModificarEmpleado(typeof(Vistas.Docentes.Agregar_Docente_cargos));
            SeccionActiva(btn_cargos);
            SeccionInactiva(btn_Identificacion);
            SeccionInactiva(btn_informacion_medica);
            SeccionInactiva(btn_ResidenciaContacto);
            SeccionInactiva(btn_DatosPersonales);
            SeccionInactiva(btn_materias);
            SeccionInactiva(btn_especialidades);
            seccion_botones.Height = 110;
            btn_modificar.Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void actualizarBtn_Tick(object sender, EventArgs e)
        {
            if (
               !string.IsNullOrWhiteSpace(Atributos_Empleado.NombreCompleto)
               && !string.IsNullOrWhiteSpace(Atributos_Empleado.NombreCompletoDUI)
               && !string.IsNullOrWhiteSpace(Atributos_Empleado.NombreCompletoNIT)
               && !string.IsNullOrWhiteSpace(Atributos_Empleado.DUI)
               && !string.IsNullOrWhiteSpace(Atributos_Empleado.NIT)
               && !string.IsNullOrWhiteSpace(Atributos_Empleado.Jubilado)
               && !string.IsNullOrWhiteSpace(Atributos_Empleado.EstadoCivil)
               && !string.IsNullOrWhiteSpace(Atributos_Empleado.NumeroDeISSS)
               && !string.IsNullOrWhiteSpace(Atributos_Empleado.AFP)
               && !string.IsNullOrWhiteSpace(Atributos_Empleado.NUP)
               && !string.IsNullOrWhiteSpace(Atributos_Empleado.NIP)
               && !string.IsNullOrWhiteSpace(Atributos_Empleado.Direccion)
               && !string.IsNullOrWhiteSpace(Atributos_Empleado.TelefonoCasa)
               && !string.IsNullOrWhiteSpace(Atributos_Empleado.TelefonoEmergencia)
               && !string.IsNullOrWhiteSpace(Atributos_Empleado.TelefonoDeOficina)
               && !string.IsNullOrWhiteSpace(Atributos_Empleado.TelefonoMovilPrincipal)

               && Atributos_Empleado.IdEstado != 0
               && Atributos_Empleado.IdNivelDeEstudio != 0
               )
            {
                btn_modificar.Visible = true;
            }
            else
            {
                btn_modificar.Visible = false;
            }
            this.Invalidate();
        }

        private void btn_especialidades_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelModificarEmpleado(typeof(Agregar_Docente_Especialidades));
            SeccionActiva(btn_especialidades);
            SeccionInactiva(btn_Identificacion);
            SeccionInactiva(btn_informacion_medica);
            SeccionInactiva(btn_ResidenciaContacto);
            SeccionInactiva(btn_DatosPersonales);
            SeccionInactiva(btn_materias);
            SeccionInactiva(btn_cargos);
            seccion_botones.Height = 110;
            btn_modificar.Visible = false;
        }
    }
}
