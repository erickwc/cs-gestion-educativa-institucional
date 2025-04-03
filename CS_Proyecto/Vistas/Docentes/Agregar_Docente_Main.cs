using CS_Proyecto.Atributos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Docentes.Modificar;
using CS_Proyecto.Vistas.Editar_Matricula;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
using CS_Proyecto.Vistas.OscurecerFondo;
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

namespace CS_Proyecto.Vistas.Docentes
{
    public partial class Agregar_Docente_Main : Form
    {
        public Agregar_Docente_Main()
        {
            InitializeComponent();
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        CN_Empleado cn_empleado = new CN_Empleado();
        LimpiarVariables limpiarvar = new LimpiarVariables();
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

        private void btn_DatosPersonales_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelRegistrarEmpleado(typeof(Vistas.Docentes.Agregar_Docentes_Datos_Personales));
            SeccionActiva(btn_DatosPersonales);
            SeccionInactiva(btn_Identificacion);
            SeccionInactiva(btn_ResidenciaContacto);
        }

        private void btn_Identificacion_Click_1(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelRegistrarEmpleado(typeof(Vistas.Docentes.Agregar_Docente_Identificacion));
            SeccionActiva(btn_Identificacion);
            SeccionInactiva(btn_DatosPersonales);
            SeccionInactiva(btn_ResidenciaContacto);
        }

        private void btn_ResidenciaContacto_Click_1(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelRegistrarEmpleado(typeof(Vistas.Docentes.Agregar_Docente_Residencia_Contacto));
            SeccionActiva(btn_ResidenciaContacto);
            SeccionInactiva(btn_DatosPersonales);
            SeccionInactiva(btn_Identificacion);
        }

        private void Agregar_Docente_Main_Load(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelRegistrarEmpleado(typeof(Vistas.Docentes.Agregar_Docentes_Datos_Personales));
            SeccionActiva(btn_DatosPersonales);
            SeccionInactiva(btn_Identificacion);
            SeccionInactiva(btn_ResidenciaContacto);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                cn_empleado.insertarEmpleado(
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
                    Atributos_Empleado.TelefonoDeEmergenciaSecundario
                    );

                limpiarvar.limpiarVarDocentes();

                ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                using (EmpleadoRegistradoPart1 cancelar = new EmpleadoRegistradoPart1())
                {
                    fondo.Oscurecer(cancelar);
                }

                navegar.AbrirFormEnPanel(typeof(Vistas.Docentes.AgregarCargosMateriasEspecialidades_Main),"Datos Adicionales");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarFormularioDocentes_Tick(object sender, EventArgs e)
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
                btn_guardar.Visible = true;
            }
            else
            {
                btn_guardar.Visible = false;
            }
            this.Invalidate();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (CancelarEmpleado cancelar = new CancelarEmpleado())
            {
                fondo.Oscurecer(cancelar);
            }
        }
    }
}
