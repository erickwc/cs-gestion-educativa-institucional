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
    public partial class RestablecerMain : Form
    {
        public RestablecerMain()
        {
            InitializeComponent();
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();

        private void RestablecerMain_Load(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelRestablecerContra(typeof(Part1), "");
        }
    }
}
