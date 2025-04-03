using CS_Proyecto.Atributos;
using CS_Proyecto.CapaNegocio;
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

namespace CS_Proyecto.Vistas.Usuarios
{
    public partial class Datos_Personales_Usuarios : Form
    {
        public Datos_Personales_Usuarios()
        {
            InitializeComponent();
        }

        ValidarCampos validar = new ValidarCampos();
        DUI DUI = new DUI();

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.pnelito.Controls.Count > 0)
                this.pnelito.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnelito.Controls.Add(fh);
            this.pnelito.Tag = fh;
            fh.Show();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Vistas.Usuarios.Nuevo_Usuario_Main());
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Vistas.Usuarios.Datos_Usuarios());

        }

        private void txt_nombres_TextChanged(object sender, EventArgs e)
        {
            Atributos_Usuarios.Nombres = txt_nombres.Text;
            validar.EstadoTextBox(txt_nombres);
        }

        private void txt_apellidos_TextChanged(object sender, EventArgs e)
        {
            Atributos_Usuarios.Apellidos = txt_apellidos.Text;
            validar.EstadoTextBox(txt_apellidos);
        }

        private void txt_dui_TextChanged(object sender, EventArgs e)
        {
            Atributos_Usuarios.Dui = txt_dui.Text;
            validar.EstadoTextBox(txt_dui);
        }

        private void cmbx_genero_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Atributos_Usuarios.Genero = cmbx_genero.Text;
            validar.EstadoComboBox(cmbx_genero);
        }

        private void RecordarCampos()
        {
            txt_dui.Text = Atributos_Usuarios.Dui;
            txt_apellidos.Text = Atributos_Usuarios.Apellidos;
            txt_nombres.Text = Atributos_Usuarios.Nombres;
            cmbx_genero.Text = Atributos_Usuarios.Genero;
        }

        private void Datos_Personales_Usuarios_Load(object sender, EventArgs e)
        {
            RecordarCampos();
            validar.EstadoComboBox(cmbx_genero);
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

        private void txt_dui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && txt_dui.TextLength < 10)
            {
                // Agregar el guión después del séptimo dígito.
                if (txt_dui.TextLength ==8)
                {
                    txt_dui.Text += "-";
                    txt_dui.SelectionStart = txt_dui.TextLength; 
                }
            }
            
            else if (e.KeyChar == '\b')
            {
                // No hacer nada, permitir el borrado.
            }
            else
            {
                // Prevenir la entrada de caracteres no numéricos y asegurarse de que no se ingresen más de 9 caracteres.
                e.Handled = true;
            }
        }
    }
}
