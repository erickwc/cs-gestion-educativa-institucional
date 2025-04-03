namespace CS_Proyecto.Vistas.Aplicacion
{
    partial class ContainerApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContainerApp));
            this.ContainerAppPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ContainerAppPanel
            // 
            this.ContainerAppPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerAppPanel.Location = new System.Drawing.Point(0, 0);
            this.ContainerAppPanel.Name = "ContainerAppPanel";
            this.ContainerAppPanel.Size = new System.Drawing.Size(1264, 681);
            this.ContainerAppPanel.TabIndex = 0;
            // 
            // ContainerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ContainerAppPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "ContainerApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ContainerApp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel ContainerAppPanel;
    }
}