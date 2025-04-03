using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Docentes.Modificar;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
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
    public partial class AgregarCargosMateriasEspecialidades_Main : Form
    {
        public AgregarCargosMateriasEspecialidades_Main()
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

        private void btn_Especialidades_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelRegistrarEmpleadoPart2(typeof(Agregar_Docente_Especialidades));
            SeccionActiva(btn_Especialidades);
            SeccionInactiva(btn_cargos);
            SeccionInactiva(btn_materias);
        }

        private void btn_cargos_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelRegistrarEmpleadoPart2(typeof(Vistas.Docentes.Agregar_Docente_cargos));
            SeccionActiva(btn_cargos);
            SeccionInactiva(btn_materias);
            SeccionInactiva(btn_Especialidades);

        }

        private void btn_materias_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelRegistrarEmpleadoPart2(typeof(Vistas.Docentes.Agregar_materias_docentes));
            SeccionInactiva(btn_cargos);
            SeccionActiva(btn_materias);
            SeccionInactiva(btn_Especialidades);
        }

        private void AgregarCargosMateriasEspecialidades_Main_Load(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelRegistrarEmpleadoPart2(typeof(Agregar_Docente_Especialidades));
            SeccionActiva(btn_Especialidades);
            SeccionInactiva(btn_cargos);
            SeccionInactiva(btn_materias);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (InforMedicaAdicionalDocente mensaje = new InforMedicaAdicionalDocente())
            {
                fondo.Oscurecer(mensaje);
            }
        }
    }
}
