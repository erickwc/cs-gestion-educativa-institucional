using CS_Proyecto.Vistas.ClasesVista;
using CS_Proyecto.Vistas.Login;
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
    public partial class Part4 : Form
    {
        public Part4()
        {
            InitializeComponent();
        }

        NavegarEntreFormularios navegar = new NavegarEntreFormularios();
        private void btn_enviar_codigo_Click(object sender, EventArgs e)
        {
            navegar.AbrirFormEnPanelContainerApp(typeof(Login_main), "");
        }
    }
}
