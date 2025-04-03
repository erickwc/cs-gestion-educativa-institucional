using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
using CS_Proyecto.Vistas.ClasesVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.RestablecerContraseña
{
    public partial class Part3 : Form
    {
        public Part3()
        {
            InitializeComponent();
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        ValidarCampos validar = new ValidarCampos();

        private void btn_enviar_codigo_Click(object sender, EventArgs e)
        {
            CD_RestablecerContraseña restablecerpass = new CD_RestablecerContraseña();
            string ContraseñEncriptada = BCrypt.Net.BCrypt.HashPassword((txt_pass.Text));

            restablecerpass.ModificarContraseña(ContraseñEncriptada, Atributos_RecuperarContraseña.Usuario);

            navegar.AbrirFormEnPanelRestablecerContra(typeof(Part4), "RestablecerContraseña");
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            validar.EstadoTextBox(txt_pass);
        }

        private void txt_confirmar_pass_TextChanged(object sender, EventArgs e)
        {
            if(txt_confirmar_pass.Text.Length > 8)
            {
                if (txt_confirmar_pass.Text != txt_pass.Text)
                {
                    validar.UsuarioConNombreIgual(txt_confirmar_pass);
                    btn_enviar_codigo.Visible = false;
                }
                else if (txt_confirmar_pass.Text == txt_pass.Text)
                {
                    validar.EstadoTextBox(txt_confirmar_pass);
                    btn_enviar_codigo.Visible = true;
                }
            }
            else
            {
                validar.UsuarioConNombreIgual(txt_confirmar_pass);
                btn_enviar_codigo.Visible = false;
            }
        }
    }
}
