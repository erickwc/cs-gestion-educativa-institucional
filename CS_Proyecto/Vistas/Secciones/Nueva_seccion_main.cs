using CS_Proyecto.Atributos;
using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Dashboard;
using CS_Proyecto.Vistas.Docentes.Modificar;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
using CS_Proyecto.Vistas.Seccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Secciones
{
    public partial class Nueva_seccion_main : Form
    {
        public Nueva_seccion_main()
        {
            InitializeComponent();
        }

        CN_secciones cN_Secciones = new CN_secciones();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        LimpiarVariables limpiarvar = new LimpiarVariables();

        private void Nueva_seccion_main_Load(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelSecciones(typeof(Vistas.Seccion.Nueva_Seccion));

            if (Atributos_seccion.EstadoFormulario == "Editar")
            {
                btn_guardar_registro.Text = "Guardar Cambios";
                btn_cancelar.Text = "Regresar y Limpiar";

            }
        }

        private void btn_guardar_registro_Click(object sender, EventArgs e)
        {
            try
            {
                if (Atributos_seccion.EstadoFormulario == "Guardar")
                {
                    cN_Secciones.InsertarSeccion(
                    Atributos_seccion.SeccionAbreviacion,
                    Atributos_seccion.IdEspecialidades,
                    Atributos_seccion.IdDocentes,
                    Atributos_seccion.IdTipoSeccion
                    );

                    limpiarvar.LimpiarVarSecciones();

                    ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                    using (AgregadoEditadoSeccion alert = new AgregadoEditadoSeccion())
                    {
                        fondo.Oscurecer(alert);
                    }


                }
                else if (Atributos_seccion.EstadoFormulario == "Editar")
                {
                    cN_Secciones.ModificarSecciones(
                    Atributos_seccion.IdSecciones,
                    Atributos_seccion.SeccionAbreviacion,
                    Atributos_seccion.IdEspecialidades,
                    Atributos_seccion.IdDocentes,
                    Atributos_seccion.IdTipoSeccion
                    );

                    limpiarvar.LimpiarVarSecciones();

                    ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                    using (AgregadoEditadoSeccion alert = new AgregadoEditadoSeccion())
                    {
                        fondo.Oscurecer(alert);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo" + ex);
            }
        }

        private void ActualizarForm_Tick(object sender, EventArgs e)
        {
            if (
                     !string.IsNullOrWhiteSpace(Atributos_seccion.SeccionAbreviacion)
                  && Atributos_seccion.IdEspecialidades != 0
                  && Atributos_seccion.IdDocentes != 0
                  && Atributos_seccion.IdTipoSeccion != 0)
            {
                btn_guardar_registro.Visible = true;
            }
            else
            {
                btn_guardar_registro.Visible = false;
            }
            this.Invalidate();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (Atributos_seccion.EstadoFormulario == "Editar")
            {
                limpiarvar.LimpiarVarSecciones();
                navegar.AbrirFormEnPanel(typeof(Seccion_Main), "Secciónes");
                this.Close();
            }
            else if (Atributos_seccion.EstadoFormulario == "Guardar")
            {
                limpiarvar.LimpiarVarSecciones();
               
                ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                using (CancelarSeccion cancel = new CancelarSeccion())
                {
                    fondo.Oscurecer(cancel);
                }
            }

        }
    }
}
