using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Alertas
{
    public partial class Seleccionar_tipo_busqueda : Form
    {
        public Seleccionar_tipo_busqueda()
        {
            InitializeComponent();
        }

       

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
