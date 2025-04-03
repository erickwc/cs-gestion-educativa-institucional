using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Proyecto.Vistas.Pantalla_de_Carga
{
    public partial class Pantalla_Carga : Form
    {
        public Pantalla_Carga()
        {
            InitializeComponent();
        }

        private void TimerBarra_Tick(object sender, EventArgs e)
        {
            barra_progreso.Increment(1);
            int nivelIncremento = barra_progreso.Value;
            lbl_porcentaje.Text = "(" + nivelIncremento + ")" + "%";

            if (barra_progreso.Value == 100)
            {
                TimerBarra.Stop();
                lbl_cargando.Text = "¡Finalizado!";
                Vistas.Dashboard.Dashboard_Main dashboard_administrador = new Vistas.Dashboard.Dashboard_Main();
                dashboard_administrador.Show();
                this.Hide();
            }
        }

        private void Pantalla_Carga_Load(object sender, EventArgs e)
        {
            TimerBarra.Start();
        }
    }
}
