using CS_Proyecto.Atributos;
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

namespace CS_Proyecto.Vistas.Usuarios
{
    public partial class Nuevo_Usuario_Main : Form
    {
        public Nuevo_Usuario_Main()
        {
            InitializeComponent();
        }

        CN_Usuarios cN_Usuarios = new CN_Usuarios();
        LimpiarVariables limpiar = new LimpiarVariables();
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

        private void Nuevo_Usuario_Main_Load(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelUsuarios(typeof(Vistas.Usuarios.Datos_Personales_Usuarios));
            SeccionActiva(btn_datos_personales);

            if (Atributos_Usuarios.EstadoFormulario == "EditarUsuario")
            {
                btn_guardar.Text = "Guardar Cambios";
            }
            else if (Atributos_Usuarios.EstadoFormulario == "GuardarUsuario")
            {
                btn_guardar.Text = "Registrar Usuario";
            }
        }

        private void btn_datos_personales_Click_1(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelUsuarios(typeof(Vistas.Usuarios.Datos_Personales_Usuarios));
            SeccionInactiva(btn_datos_usuario);
            SeccionActiva(btn_datos_personales);
            SeccionInactiva(btn_privilegios);
            SeccionInactiva(btn_foto);
        }

        private void btn_datos_usuario_Click_1(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelUsuarios(typeof(Vistas.Usuarios.Datos_Usuarios));
            SeccionInactiva(btn_datos_personales);
            SeccionActiva(btn_datos_usuario);
            SeccionInactiva(btn_privilegios);
            SeccionInactiva(btn_foto);
        }

        private void btn_privilegios_Click_1(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelUsuarios(typeof(Vistas.Usuarios.Privilegios_Estados));
            SeccionInactiva(btn_datos_personales);
            SeccionActiva(btn_privilegios);
            SeccionInactiva(btn_datos_usuario);
            SeccionInactiva(btn_foto);
        }

        private void btn_foto_Click_1(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelUsuarios(typeof(Vistas.Usuarios.FotoPerfil));
            SeccionInactiva(btn_privilegios);
            SeccionActiva(btn_foto);
            SeccionInactiva(btn_datos_usuario);
            SeccionInactiva(btn_privilegios);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Atributos_Usuarios.EstadoFormulario == "GuardarUsuario")
                {
                    string ContraseñEncriptada = BCrypt.Net.BCrypt.HashPassword((Atributos_Usuarios.Contrasena));

                    cN_Usuarios.InsertarUsuario(
                        Atributos_Usuarios.Nombres,
                        Atributos_Usuarios.Apellidos,
                        Atributos_Usuarios.Genero,
                        Atributos_Usuarios.Dui,
                        Atributos_Usuarios.NombreUsuario,
                        ContraseñEncriptada,
                        Atributos_Usuarios.Imagen,
                        Atributos_Usuarios.Correo,
                        Atributos_Usuarios.IdRol,
                        Atributos_Usuarios.IdEstado
                       );

                    limpiar.LimpiarVarUsuarios();
                    
                    ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                    using (UsuarioAgregado registro_exitoso = new UsuarioAgregado())
                    {
                        fondo.Oscurecer(registro_exitoso);
                    }
                }

                else if (Atributos_Usuarios.EstadoFormulario == "EditarUsuario")
                {
                    cN_Usuarios.ModificarUsuario(
                       Atributos_Usuarios.Nombres,
                       Atributos_Usuarios.Apellidos,
                       Atributos_Usuarios.Genero,
                       Atributos_Usuarios.Dui,
                       Atributos_Usuarios.NombreUsuario,
                       Atributos_Usuarios.Contrasena,
                       Atributos_Usuarios.Imagen,
                       Atributos_Usuarios.Correo,
                       Atributos_Usuarios.IdRol,
                       Atributos_Usuarios.IdEstado,
                       Atributos_Usuarios.IdUsuario
                       );

                    ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                    using (RegistroEditado editado = new RegistroEditado())
                    {
                        fondo.Oscurecer(editado);
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
                     !string.IsNullOrWhiteSpace(Atributos_Usuarios.Nombres)
                  && !string.IsNullOrWhiteSpace(Atributos_Usuarios.Apellidos)
                  && !string.IsNullOrWhiteSpace(Atributos_Usuarios.Genero)
                  && !string.IsNullOrWhiteSpace(Atributos_Usuarios.Contrasena)
                  && !string.IsNullOrWhiteSpace(Atributos_Usuarios.Correo)
                  && !string.IsNullOrWhiteSpace(Atributos_Usuarios.Dui)
                  && !string.IsNullOrWhiteSpace(Atributos_Usuarios.NombreUsuario)
                  && !string.IsNullOrWhiteSpace(Atributos_Usuarios.ValidarContrasena)
                  && Atributos_Usuarios.ContraseñaNoCoincide != "las contraseñas no coinciden"
                  && Atributos_Usuarios.ValidarNombreUsuario != "UsuarioExiste"
                  && Atributos_Usuarios.ValidarLongitudContraseña != "Es Menor"
                  && Atributos_Usuarios.IdEstado != 0
                  && Atributos_Usuarios.IdRol != 0)
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
            if (Atributos_Usuarios.EstadoFormulario == "EditarUsuario")
            {
                limpiar.LimpiarVarUsuarios();
                navegar.AbrirFormEnPanel(typeof(Controles_Usuarios), "Usuarios");
            }
            else if (Atributos_Usuarios.EstadoFormulario == "GuardarUsuario")
            {
                ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                using (CancelarRegistroUsuario cancelar = new CancelarRegistroUsuario())
                {
                    fondo.Oscurecer(cancelar);
                }
            }
        }

        private void Panel_Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
