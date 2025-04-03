namespace CS_Proyecto.Vistas.RestablecerContraseña
{
    partial class RestablecerMain
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
            this.Panel_Cont_Pass = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Panel_Cont_Pass
            // 
            this.Panel_Cont_Pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Cont_Pass.Location = new System.Drawing.Point(0, 0);
            this.Panel_Cont_Pass.Name = "Panel_Cont_Pass";
            this.Panel_Cont_Pass.Size = new System.Drawing.Size(1264, 681);
            this.Panel_Cont_Pass.TabIndex = 0;
            // 
            // RestablecerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Panel_Cont_Pass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestablecerMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RestablecerMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Panel_Cont_Pass;
    }
}