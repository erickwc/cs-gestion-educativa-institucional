using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CS_Proyecto.Vistas.Modo_Nocturno
{
    public partial class Modo_nocturno : Form
    {

        public Modo_nocturno()
        {
            InitializeComponent();
        }

        private void Modo_nocturno_Load(object sender, EventArgs e)
        {
            
        }

        private void img_modo_oscuro_Click(object sender, EventArgs e)
        {
            pnl_modo_oscuro.BorderColor = Color.FromArgb(36, 86, 255);
            pnl_modo_claro.BorderColor = Color.FromArgb(246, 247, 252);
            lbl_oscuro.ForeColor = Color.FromArgb(36, 86, 255);
            lbl_claro.ForeColor = Color.FromArgb(51, 53, 51);
        }

        private void pnl_modo_claro_Click(object sender, EventArgs e)
        {
            pnl_modo_claro.BorderColor = Color.FromArgb(36, 86, 255);
            pnl_modo_oscuro.BorderColor = Color.FromArgb(246, 247, 252);
            lbl_claro.ForeColor = Color.FromArgb(36, 86, 255);
            lbl_oscuro.ForeColor = Color.FromArgb(51, 53, 51);
        }

        private void btn_seguir_modo_actual_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
