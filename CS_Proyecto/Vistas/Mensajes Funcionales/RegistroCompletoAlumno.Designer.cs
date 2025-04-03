namespace CS_Proyecto.Vistas.Mensajes_Funcionales
{
    partial class RegistroCompletoAlumno
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
            this.components = new System.ComponentModel.Container();
            this.btn_aceptar = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_aceptar.BorderRadius = 5;
            this.btn_aceptar.CheckedState.Parent = this.btn_aceptar;
            this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aceptar.CustomImages.Parent = this.btn_aceptar;
            this.btn_aceptar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_aceptar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_aceptar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_aceptar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_aceptar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_aceptar.HoverState.Parent = this.btn_aceptar;
            this.btn_aceptar.Location = new System.Drawing.Point(66, 260);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_aceptar.ShadowDecoration.Parent = this.btn_aceptar;
            this.btn_aceptar.Size = new System.Drawing.Size(558, 66);
            this.btn_aceptar.TabIndex = 46;
            this.btn_aceptar.Text = "Aceptar y finalizar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lbl_titulo.Location = new System.Drawing.Point(61, 157);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(563, 25);
            this.lbl_titulo.TabIndex = 43;
            this.lbl_titulo.Text = "¡Registro finalizado exitosamente!";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lbl_descripcion.Location = new System.Drawing.Point(61, 182);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbl_descripcion.Size = new System.Drawing.Size(563, 74);
            this.lbl_descripcion.TabIndex = 44;
            this.lbl_descripcion.Text = "Los datos medicos del alumno se agregaron exitosamente dentro del sistema al igua" +
    "l que el registro completo.";
            this.lbl_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::CS_Proyecto.Properties.Resources.InformacionRegistrada;
            this.pictureBox1.Location = new System.Drawing.Point(61, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // RegistroCompletoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.ControlBox = false;
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_descripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(685, 389);
            this.MinimumSize = new System.Drawing.Size(685, 389);
            this.Name = "RegistroCompletoAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button btn_aceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_descripcion;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}