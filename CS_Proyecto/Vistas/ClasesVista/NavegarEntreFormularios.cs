using CS_Proyecto.Vistas.Aplicacion;
using CS_Proyecto.Vistas.Dashboard;
using CS_Proyecto.Vistas.Docentes;
using CS_Proyecto.Vistas.Docentes.Modificar;
using CS_Proyecto.Vistas.Editar_Matricula;
using CS_Proyecto.Vistas.Formulario_Matricula;
using CS_Proyecto.Vistas.RestablecerContraseña;
using CS_Proyecto.Vistas.Secciones;
using CS_Proyecto.Vistas.Usuarios;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.ClasesVista
{
    internal class NavegarEntreFormularios
    {
      

        public void AbrirFormEnPanel(Type formType, string NombreSeccion)
        {
            Dashboard_Main dashboard_Main = Application.OpenForms["Dashboard_Main"] as Dashboard_Main;

            // Busca el formulario dentro del panel
            Form formToShow = dashboard_Main.Panel_Contenedor.Controls.OfType<Form>().FirstOrDefault(f => f.GetType() == formType);

            if (formToShow == null)
            {
                // Si el formulario no existe, créalo y configúrelo
                formToShow = (Form)Activator.CreateInstance(formType);
                formToShow.TopLevel = false;
                formToShow.FormBorderStyle = FormBorderStyle.None;
                formToShow.Dock = DockStyle.Fill;
                dashboard_Main.Panel_Contenedor.Controls.Add(formToShow);
                dashboard_Main.Panel_Contenedor.Tag = formToShow;
            }

            // Limpia el contenido anterior del panel
            foreach (Control control in dashboard_Main.Panel_Contenedor.Controls)
            {
                if (control != formToShow)
                {
                    control.Dispose();
                }
            }

            formToShow.Show();
            formToShow.BringToFront();

            dashboard_Main.lbl_seccion_actual.Text = NombreSeccion;
        }


        public void AbrirFormEnPanelContainerApp(Type formType, string NombreSeccion)
        {
            ContainerApp containerApp = Application.OpenForms["ContainerApp"] as ContainerApp;

            // Busca el formulario dentro del panel
            Form formToShow = containerApp.ContainerAppPanel.Controls.OfType<Form>().FirstOrDefault(f => f.GetType() == formType);

            if (formToShow == null)
            {
                // Si el formulario no existe, créalo y configúrelo
                formToShow = (Form)Activator.CreateInstance(formType);
                formToShow.TopLevel = false;
                formToShow.FormBorderStyle = FormBorderStyle.None;
                formToShow.Dock = DockStyle.Fill;
                containerApp.ContainerAppPanel.Controls.Add(formToShow);
                containerApp.ContainerAppPanel.Tag = formToShow;
            }

            // Limpia el contenido anterior del panel
            foreach (Control control in containerApp.ContainerAppPanel.Controls)
            {
                if (control != formToShow)
                {
                    control.Dispose();
                }
            }

            formToShow.Show();
            formToShow.BringToFront();

            containerApp.ContainerAppPanel.Text = NombreSeccion;
        }


        public void AbrirFormEnPanelRestablecerContra(Type formType, string NombreSeccion)
        {
            RestablecerMain panel = Application.OpenForms["RestablecerMain"] as RestablecerMain;

            // Busca el formulario dentro del panel
            Form formToShow = panel.Panel_Cont_Pass.Controls.OfType<Form>().FirstOrDefault(f => f.GetType() == formType);

            if (formToShow == null)
            {
                // Si el formulario no existe, créalo y configúrelo
                formToShow = (Form)Activator.CreateInstance(formType);
                formToShow.TopLevel = false;
                formToShow.FormBorderStyle = FormBorderStyle.None;
                formToShow.Dock = DockStyle.Fill;
                panel.Panel_Cont_Pass.Controls.Add(formToShow);
                panel.Panel_Cont_Pass.Tag = formToShow;
            }

            // Limpia el contenido anterior del panel
            foreach (Control control in panel.Panel_Cont_Pass.Controls)
            {
                if (control != formToShow)
                {
                    control.Dispose();
                }
            }

            formToShow.Show();
            formToShow.BringToFront();

            panel.Panel_Cont_Pass.Text = NombreSeccion;
        }

        private void ActivarBotonDeBarraLateral(Guna2Button btn, System.Drawing.Image img)
        {
            btn.FillColor = Color.FromArgb(232, 237, 255);
            btn.Font = new Font(btn.Font, FontStyle.Bold);
            btn.ForeColor = Color.FromArgb(63, 86, 255);
            btn.HoverState.FillColor = Color.FromArgb(232, 237, 255);
            btn.PressedColor = Color.FromArgb(232, 237, 255);
            btn.Image = img;
        }

        private void DesactivarBotonDeBarraLateral(Guna2Button btn, System.Drawing.Image img)
        {
            btn.FillColor = Color.White;
            btn.Font = new Font(btn.Font, FontStyle.Regular);
            btn.ForeColor = Color.FromArgb(51, 53, 51);
            btn.HoverState.FillColor = Color.White;
            btn.Image = img;
        }

        public void AbrirFormEnPanelYActivarBtnBarraLateral(object formhija, string NombreSeccion)
        {
            Dashboard_Main dashboard_Main = Application.OpenForms["Dashboard_Main"] as Dashboard_Main;

            if (dashboard_Main.Panel_Contenedor.Controls.Count > 0)
                dashboard_Main.Panel_Contenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            dashboard_Main.Panel_Contenedor.Controls.Add(fh);
            dashboard_Main.Panel_Contenedor.Tag = fh;
            fh.Show();

            dashboard_Main.lbl_seccion_actual.Text = NombreSeccion;

            ActivarBotonDeBarraLateral(dashboard_Main.btn_dashboard, Properties.Resources.Dashboard);
            DesactivarBotonDeBarraLateral(dashboard_Main.btn_letrapago, Properties.Resources.Letra_Pago_e);
            DesactivarBotonDeBarraLateral(dashboard_Main.btn_usuarios, Properties.Resources.Usuarios_e);
            DesactivarBotonDeBarraLateral(dashboard_Main.btn_reportes, Properties.Resources.Reportes_e);
            DesactivarBotonDeBarraLateral(dashboard_Main.btn_comprobante, Properties.Resources.Modo_e);
            DesactivarBotonDeBarraLateral(dashboard_Main.btn_Nie_Temporal, Properties.Resources.Nie_temporal_e);
            DesactivarBotonDeBarraLateral(dashboard_Main.btn_perfil, Properties.Resources.Mi_Perfil_e);
            DesactivarBotonDeBarraLateral(dashboard_Main.btn_comprobante, Properties.Resources.Comprobante_e);
            DesactivarBotonDeBarraLateral(dashboard_Main.btn_instituciones, Properties.Resources.Insticuciones_e);
        }


        

        public void AbrirFormEnPanelMatricula(Type formType)
        {
            Matricula_main matricula_Main = Application.OpenForms["Matricula_main"] as Matricula_main;

            // Busca el formulario dentro del panel
            Form formToShow = matricula_Main.Panel_Contenedor_Secciones_Matricula.Controls
                .OfType<Form>()
                .FirstOrDefault(f => f.GetType() == formType);

            if (formToShow == null)
            {
                // Cierra todos los formularios existentes en el panel
                foreach (Form existingForm in matricula_Main.Panel_Contenedor_Secciones_Matricula.Controls.OfType<Form>().ToList())
                {
                    existingForm.Close();
                }

                // Crea y configura el nuevo formulario
                formToShow = (Form)Activator.CreateInstance(formType);
                formToShow.TopLevel = false;
                formToShow.FormBorderStyle = FormBorderStyle.None;
                formToShow.Dock = DockStyle.Fill;

                // Agrega el nuevo formulario al panel
                matricula_Main.Panel_Contenedor_Secciones_Matricula.Controls.Add(formToShow);
                matricula_Main.Panel_Contenedor_Secciones_Matricula.Tag = formToShow;
                formToShow.Show();
                formToShow.BringToFront();
            }
            else
            {
                // Si el formulario ya existe en el panel, tráelo al frente
                formToShow.BringToFront();
            }
        }

        public void AbrirFormEnPanelModificarMatricula(Type formType)
        {
            Editar_main editar_main = Application.OpenForms["Editar_main"] as Editar_main;

            // Busca el formulario dentro del panel
            Form formToShow = editar_main.Panel_Contenedor_Secciones_Matricula.Controls
                .OfType<Form>()
                .FirstOrDefault(f => f.GetType() == formType);

            if (formToShow == null)
            {
                // Cierra todos los formularios existentes en el panel
                foreach (Form existingForm in editar_main.Panel_Contenedor_Secciones_Matricula.Controls.OfType<Form>().ToList())
                {
                    existingForm.Close();
                }

                // Crea y configura el nuevo formulario
                formToShow = (Form)Activator.CreateInstance(formType);
                formToShow.TopLevel = false;
                formToShow.FormBorderStyle = FormBorderStyle.None;
                formToShow.Dock = DockStyle.Fill;

                // Agrega el nuevo formulario al panel
                editar_main.Panel_Contenedor_Secciones_Matricula.Controls.Add(formToShow);
                editar_main.Panel_Contenedor_Secciones_Matricula.Tag = formToShow;
                formToShow.Show();
                formToShow.BringToFront();
            }
            else
            {
                // Si el formulario ya existe en el panel, tráelo al frente
                formToShow.BringToFront();
            }
        }


        public void AbrirFormEnPanelRegistrarEmpleado(Type formType)
        {
            Agregar_Docente_Main docente_Main = Application.OpenForms["Agregar_Docente_Main"] as Agregar_Docente_Main;

            // Busca el formulario dentro del panel
            Form formToShow = docente_Main.Panel_Contenedor_Secciones_Matricula.Controls
                .OfType<Form>()
                .FirstOrDefault(f => f.GetType() == formType);

            if (formToShow == null)
            {
                // Cierra todos los formularios existentes en el panel
                foreach (Form existingForm in docente_Main.Panel_Contenedor_Secciones_Matricula.Controls.OfType<Form>().ToList())
                {
                    existingForm.Close();
                }

                // Crea y configura el nuevo formulario
                formToShow = (Form)Activator.CreateInstance(formType);
                formToShow.TopLevel = false;
                formToShow.FormBorderStyle = FormBorderStyle.None;
                formToShow.Dock = DockStyle.Fill;

                // Agrega el nuevo formulario al panel
                docente_Main.Panel_Contenedor_Secciones_Matricula.Controls.Add(formToShow);
                docente_Main.Panel_Contenedor_Secciones_Matricula.Tag = formToShow;
                formToShow.Show();
                formToShow.BringToFront();
            }
            else
            {
                // Si el formulario ya existe en el panel, tráelo al frente
                formToShow.BringToFront();
            }
        }


        public void AbrirFormEnPanelRegistrarEmpleadoPart2(Type formType)
        {
            AgregarCargosMateriasEspecialidades_Main docente_Main = Application.OpenForms["AgregarCargosMateriasEspecialidades_Main"] as AgregarCargosMateriasEspecialidades_Main;

            // Busca el formulario dentro del panel
            Form formToShow = docente_Main.Panel_Contenedor_Secciones_Matricula.Controls
                .OfType<Form>()
                .FirstOrDefault(f => f.GetType() == formType);

            if (formToShow == null)
            {
                // Cierra todos los formularios existentes en el panel
                foreach (Form existingForm in docente_Main.Panel_Contenedor_Secciones_Matricula.Controls.OfType<Form>().ToList())
                {
                    existingForm.Close();
                }

                // Crea y configura el nuevo formulario
                formToShow = (Form)Activator.CreateInstance(formType);
                formToShow.TopLevel = false;
                formToShow.FormBorderStyle = FormBorderStyle.None;
                formToShow.Dock = DockStyle.Fill;

                // Agrega el nuevo formulario al panel
                docente_Main.Panel_Contenedor_Secciones_Matricula.Controls.Add(formToShow);
                docente_Main.Panel_Contenedor_Secciones_Matricula.Tag = formToShow;
                formToShow.Show();
                formToShow.BringToFront();
            }
            else
            {
                // Si el formulario ya existe en el panel, tráelo al frente
                formToShow.BringToFront();
            }
        }

        public void AbrirFormEnPanelModificarEmpleado(Type formType)
        {
            ModificarDocenteMain modificarDocente = Application.OpenForms["ModificarDocenteMain"] as ModificarDocenteMain;

            // Busca el formulario dentro del panel
            Form formToShow = modificarDocente.Panel_Contenedor_Secciones_Matricula.Controls
                .OfType<Form>()
                .FirstOrDefault(f => f.GetType() == formType);

            if (formToShow == null)
            {
                // Cierra todos los formularios existentes en el panel
                foreach (Form existingForm in modificarDocente.Panel_Contenedor_Secciones_Matricula.Controls.OfType<Form>().ToList())
                {
                    existingForm.Close();
                }

                // Crea y configura el nuevo formulario
                formToShow = (Form)Activator.CreateInstance(formType);
                formToShow.TopLevel = false;
                formToShow.FormBorderStyle = FormBorderStyle.None;
                formToShow.Dock = DockStyle.Fill;

                // Agrega el nuevo formulario al panel
                modificarDocente.Panel_Contenedor_Secciones_Matricula.Controls.Add(formToShow);
                modificarDocente.Panel_Contenedor_Secciones_Matricula.Tag = formToShow;
                formToShow.Show();
                formToShow.BringToFront();
            }
            else
            {
                // Si el formulario ya existe en el panel, tráelo al frente
                formToShow.BringToFront();
            }
        }

        public void AbrirFormEnPanelUsuarios(Type formType)
        {
            Nuevo_Usuario_Main nuevo_usuario = Application.OpenForms["Nuevo_Usuario_Main"] as Nuevo_Usuario_Main;

            // Busca el formulario dentro del panel
            Form formToShow = nuevo_usuario.Panel_Contenedor.Controls
                .OfType<Form>()
                .FirstOrDefault(f => f.GetType() == formType);

            if (formToShow == null)
            {
                // Cierra todos los formularios existentes en el panel
                foreach (Form existingForm in nuevo_usuario.Panel_Contenedor.Controls.OfType<Form>().ToList())
                {
                    existingForm.Close();
                }

                // Crea y configura el nuevo formulario
                formToShow = (Form)Activator.CreateInstance(formType);
                formToShow.TopLevel = false;
                formToShow.FormBorderStyle = FormBorderStyle.None;
                formToShow.Dock = DockStyle.Fill;

                // Agrega el nuevo formulario al panel
                nuevo_usuario.Panel_Contenedor.Controls.Add(formToShow);
                nuevo_usuario.Panel_Contenedor.Tag = formToShow;
                formToShow.Show();
                formToShow.BringToFront();
            }
            else
            {
                // Si el formulario ya existe en el panel, tráelo al frente
                formToShow.BringToFront();
            }
        }

        public void AbrirFormEnPanelSecciones(Type formType)
        {
            Nueva_seccion_main secciones = Application.OpenForms["Nueva_seccion_main"] as Nueva_seccion_main;

            // Busca el formulario dentro del panel
            Form formToShow = secciones.Panel_Contenedor_Secciones.Controls
                .OfType<Form>()
                .FirstOrDefault(f => f.GetType() == formType);

            if (formToShow == null)
            {
                // Cierra todos los formularios existentes en el panel
                foreach (Form existingForm in secciones.Panel_Contenedor_Secciones.Controls.OfType<Form>().ToList())
                {
                    existingForm.Close();
                }

                // Crea y configura el nuevo formulario
                formToShow = (Form)Activator.CreateInstance(formType);
                formToShow.TopLevel = false;
                formToShow.FormBorderStyle = FormBorderStyle.None;
                formToShow.Dock = DockStyle.Fill;

                // Agrega el nuevo formulario al panel
                secciones.Panel_Contenedor_Secciones.Controls.Add(formToShow);
                secciones.Panel_Contenedor_Secciones.Tag = formToShow;
                formToShow.Show();
                formToShow.BringToFront();
            }
            else
            {
                // Si el formulario ya existe en el panel, tráelo al frente
                formToShow.BringToFront();
            }
        }

        public void AbrirFormPanelInscripcion(Type formType)
        {
            Comprobante_main comprobante = Application.OpenForms["Comprobante_main"] as Comprobante_main;

            // Busca el formulario dentro del panel
            Form formToShow = comprobante.Panel_Contenedor_Secciones.Controls
                .OfType<Form>()
                .FirstOrDefault(f => f.GetType() == formType);

            if (formToShow == null)
            {
                // Cierra todos los formularios existentes en el panel
                foreach (Form existingForm in comprobante.Panel_Contenedor_Secciones.Controls.OfType<Form>().ToList())
                {
                    existingForm.Close();
                }

                // Crea y configura el nuevo formulario
                formToShow = (Form)Activator.CreateInstance(formType);
                formToShow.TopLevel = false;
                formToShow.FormBorderStyle = FormBorderStyle.None;
                formToShow.Dock = DockStyle.Fill;

                // Agrega el nuevo formulario al panel
                comprobante.Panel_Contenedor_Secciones.Controls.Add(formToShow);
                comprobante.Panel_Contenedor_Secciones.Tag = formToShow;
                formToShow.Show();
                formToShow.BringToFront();
            }
            else
            {
                // Si el formulario ya existe en el panel, tráelo al frente
                formToShow.BringToFront();
            }
        }

    }
}
