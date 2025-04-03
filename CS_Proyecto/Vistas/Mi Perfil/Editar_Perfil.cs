using CS_Proyecto.CapaNegocio;
using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Docentes.Modificar;
using CS_Proyecto.Vistas.Mensajes_Funcionales;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Mi_Perfil
{
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
        }

        CN_Perfil cN_Perfil = new CN_Perfil();
        ValidarCampos validar = new ValidarCampos();
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();


        private void Editar_Perfil_Load(object sender, EventArgs e)
        {
            txt_apellidos.Text = Atributos_Login.Apellidos;
            txt_nombres.Text = Atributos_Login.Nombres;
            txt_dui.Text = Atributos_Login.Dui;
            cmbx_genero.Text = Atributos_Login.Genero;
            txt_nombre_usuario.Text = Atributos_Login.Usuario;
            txt_contraseña.Text = Atributos_Login.Contraseña;
            txt_correo.Text = Atributos_Login.Correo;
            validar.EstadoComboBox(cmbx_genero);
            MostrarFotoPerfil();
        }


        private void btn_guardar_cambios_Click(object sender, EventArgs e)
        {
            try
            {
                string ContraseñEncriptada = BCrypt.Net.BCrypt.HashPassword((txt_contraseña.Text));

                cN_Perfil.EditarPerfil(
                Atributos_Login.IdUsuario,
                txt_nombres.Text,
                txt_apellidos.Text,
                cmbx_genero.Text,
                txt_dui.Text,
                txt_nombre_usuario.Text,
                ContraseñEncriptada,
                Atributos_Login.Imagen,
                txt_correo.Text,
                Atributos_Login.IdRol,
                Atributos_Login.IdEstado
                );

                Atributos_Login.Apellidos = txt_apellidos.Text;
                Atributos_Login.Nombres = txt_nombres.Text;
                Atributos_Login.Dui = txt_dui.Text;
                Atributos_Login.Genero = cmbx_genero.Text;
                Atributos_Login.Usuario = txt_nombre_usuario.Text;
                Atributos_Login.Contraseña = txt_contraseña.Text;
                Atributos_Login.Correo = txt_correo.Text;

                ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
                using (PerfilEditado mensaje = new PerfilEditado())
                {
                    fondo.Oscurecer(mensaje);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void pict_foto_Click(object sender, EventArgs e)
        {
            ClasesVista.OscurecerFondo fondo = new ClasesVista.OscurecerFondo();
            using (ImgPerfil img = new ImgPerfil())
            {
                fondo.Oscurecer(img);
            }
        }

        private void MostrarFotoPerfil()
        {
            if (Atributos_Login.Imagen != null && Atributos_Login.Imagen.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(Atributos_Login.Imagen))
                {
                    Image imagen = Image.FromStream(ms);
                    pict_foto.Image = imagen;
                }
            }
            else if (Atributos_Login.Imagen == null)
            {
                pict_foto.Image = Properties.Resources.ImgPerfil;
            }
        }

        private void txt_nombres_TextChanged(object sender, EventArgs e)
        {
            validar.EstadoTextBox(txt_nombres);

        }

        private void txt_apellidos_TextChanged(object sender, EventArgs e)
        {
            validar.EstadoTextBox(txt_apellidos);
        }

        private void txt_dui_TextChanged(object sender, EventArgs e)
        {
            validar.EstadoTextBox(txt_dui);
        }

        private void txt_nombre_usuario_TextChanged(object sender, EventArgs e)
        {
            validar.EstadoTextBox(txt_nombre_usuario);
        }

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_correo_TextChanged(object sender, EventArgs e)
        {
            validar.EstadoTextBox(txt_correo);

        }

        private void ActualizarFoto_Tick(object sender, EventArgs e)
        {
            MostrarFotoPerfil();
        }

        private void mostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrarContra.Checked == true)
            {
                txt_contraseña.PasswordChar = '\0';
            }
            else
            {
                txt_contraseña.PasswordChar = '●';
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanel(typeof(Vistas.Mi_Perfil.Mi_perfil_main), "Mi perfil");
        }

        private void btn_Tick(object sender, EventArgs e)
        {

            if (txt_contraseña.Text.Length > 8)
            {
                validar.EstadoTextBox(txt_contraseña);
                btn_guardar_cambios.Visible = true;
            }
            else if (txt_contraseña.Text.Length < 9)
            {
                btn_guardar_cambios.Visible = false;
                validar.UsuarioConNombreIgual(txt_contraseña);
            }
            else if (
                txt_apellidos.Text != String.Empty
                && txt_nombres.Text != String.Empty
                 && txt_dui.Text != String.Empty
                  && txt_correo.Text != String.Empty
                   && txt_nombre_usuario.Text != String.Empty
                    && txt_contraseña.Text != String.Empty
                )
            {
                btn_guardar_cambios.Visible = true;
            }
            
          
            else{
                btn_guardar_cambios.Visible = false;

            }
        }
    }
}
