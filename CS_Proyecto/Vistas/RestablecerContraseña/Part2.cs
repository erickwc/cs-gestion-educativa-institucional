using CS_Proyecto.Atributos;
using CS_Proyecto.CapaDatos;
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

namespace CS_Proyecto.Vistas.RestablecerContraseña
{
    public partial class Part2 : Form
    {
        public Part2()
        {
            InitializeComponent();
        }

        string Token=null;
        NavegarEntreFormularios navegar = new NavegarEntreFormularios();

        private void ValidarCampoCodigo(Guna2TextBox txt)
        {
            if (txt.Text.Length > 0)
            {
                txt.BorderColor = Color.FromArgb(63, 86, 255);
                txt.ForeColor = Color.FromArgb(63, 86, 255);
                txt.FillColor = Color.FromArgb(232, 237, 255);
            }
            else
            {
                txt.BorderColor = Color.FromArgb(213, 218, 223);
                txt.ForeColor = Color.FromArgb(51, 53, 51);
                txt.FillColor = Color.White;
            }
        }

        private void txt_num_uno_TextChanged(object sender, EventArgs e)
        {
            txt_num_dos.Focus();
            ValidarCampoCodigo(txt_num_uno);
        }

        private void txt_num_dos_TextChanged(object sender, EventArgs e)
        {
            txt_num_tres.Focus();
            ValidarCampoCodigo(txt_num_dos);

        }

        private void txt_num_tres_TextChanged(object sender, EventArgs e)
        {
            txt_num_cuatro.Focus();
            ValidarCampoCodigo(txt_num_tres);

        }

        private void txt_num_cuatro_TextChanged(object sender, EventArgs e)
        {
            btn_regresar.Focus();
            ValidarCampoCodigo(txt_num_cuatro);
            Token = txt_num_uno.Text + txt_num_dos.Text + txt_num_tres.Text + txt_num_cuatro.Text;

            if (txt_num_cuatro.Text != String.Empty)
            {
                CD_RestablecerContraseña restablecerpass = new CD_RestablecerContraseña();
                var validarToken = restablecerpass.LeerToken(Token);

                if (validarToken == true)
                {
                    navegar.AbrirFormEnPanelRestablecerContra(typeof(Part3), "");
                }
                else if (validarToken == false)
                {
                    MessageBox.Show("El codigo ya no es valido");
                    Token = null;
                    txt_num_uno.Text = String.Empty;
                    txt_num_dos.Text = String.Empty;
                    txt_num_tres.Text = String.Empty;
                    txt_num_cuatro.Text = String.Empty;
                }
            }
            else if (txt_num_cuatro.Text == String.Empty)
            {
                txt_num_uno.Focus();
            }
        }

        private void txt_num_uno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_num_uno.TextLength < 1)
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

        private void txt_num_dos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_num_dos.TextLength < 1)
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

        private void txt_num_tres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_num_tres.TextLength < 1)
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

        private void txt_num_cuatro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_num_cuatro.TextLength < 1)
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

        private void Part2_Load(object sender, EventArgs e)
        {
            lbl_correo.Text = Atributos_RecuperarContraseña.Correo;
            txt_num_uno.Focus();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelRestablecerContra(typeof(Part1), "");
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
