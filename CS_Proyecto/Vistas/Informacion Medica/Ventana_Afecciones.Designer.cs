namespace CS_Proyecto.Vistas.Informacion_Medica
{
    partial class Ventana_Afecciones
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
            this.btn_regresar = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.lbl_saludo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_afeccion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_proc_medico_alumno = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_regresar.BorderRadius = 5;
            this.btn_regresar.CheckedState.Parent = this.btn_regresar;
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.CustomImages.Parent = this.btn_regresar;
            this.btn_regresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_regresar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.ForeColor = System.Drawing.Color.White;
            this.btn_regresar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_regresar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_regresar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_regresar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_regresar.HoverState.Parent = this.btn_regresar;
            this.btn_regresar.Location = new System.Drawing.Point(64, 550);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 18);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_regresar.ShadowDecoration.Parent = this.btn_regresar;
            this.btn_regresar.Size = new System.Drawing.Size(1339, 70);
            this.btn_regresar.TabIndex = 91;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rol.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lbl_rol.Location = new System.Drawing.Point(59, 94);
            this.lbl_rol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(392, 27);
            this.lbl_rol.TabIndex = 81;
            this.lbl_rol.Text = "Información de la afección seleccionada";
            // 
            // lbl_saludo
            // 
            this.lbl_saludo.AutoSize = true;
            this.lbl_saludo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_saludo.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saludo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lbl_saludo.Location = new System.Drawing.Point(57, 50);
            this.lbl_saludo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_saludo.Name = "lbl_saludo";
            this.lbl_saludo.Size = new System.Drawing.Size(276, 31);
            this.lbl_saludo.TabIndex = 80;
            this.lbl_saludo.Text = "Detalle de la Afección";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::CS_Proyecto.Properties.Resources.Dosis_target;
            this.pictureBox3.Location = new System.Drawing.Point(60, 314);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 98);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 99;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(153, 327);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 39);
            this.label6.TabIndex = 98;
            this.label6.Text = "Procedimiento Medico";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lbl_tipo.Location = new System.Drawing.Point(828, 215);
            this.lbl_tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(575, 90);
            this.lbl_tipo.TabIndex = 97;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CS_Proyecto.Properties.Resources.Frecuencia_target;
            this.pictureBox2.Location = new System.Drawing.Point(735, 162);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 96;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(828, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 39);
            this.label3.TabIndex = 95;
            this.label3.Text = "Tipo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_afeccion
            // 
            this.lbl_afeccion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_afeccion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_afeccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lbl_afeccion.Location = new System.Drawing.Point(153, 215);
            this.lbl_afeccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_afeccion.Name = "lbl_afeccion";
            this.lbl_afeccion.Size = new System.Drawing.Size(520, 90);
            this.lbl_afeccion.TabIndex = 94;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CS_Proyecto.Properties.Resources.pastilla;
            this.pictureBox1.Location = new System.Drawing.Point(60, 162);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(153, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 39);
            this.label4.TabIndex = 92;
            this.label4.Text = "Afección";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_proc_medico_alumno
            // 
            this.txt_proc_medico_alumno.BorderColor = System.Drawing.Color.White;
            this.txt_proc_medico_alumno.BorderRadius = 5;
            this.txt_proc_medico_alumno.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_proc_medico_alumno.DefaultText = "";
            this.txt_proc_medico_alumno.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txt_proc_medico_alumno.DisabledState.FillColor = System.Drawing.Color.White;
            this.txt_proc_medico_alumno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.txt_proc_medico_alumno.DisabledState.Parent = this.txt_proc_medico_alumno;
            this.txt_proc_medico_alumno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.txt_proc_medico_alumno.Enabled = false;
            this.txt_proc_medico_alumno.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.txt_proc_medico_alumno.FocusedState.Parent = this.txt_proc_medico_alumno;
            this.txt_proc_medico_alumno.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proc_medico_alumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.txt_proc_medico_alumno.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.txt_proc_medico_alumno.HoverState.Parent = this.txt_proc_medico_alumno;
            this.txt_proc_medico_alumno.Location = new System.Drawing.Point(143, 369);
            this.txt_proc_medico_alumno.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_proc_medico_alumno.Multiline = true;
            this.txt_proc_medico_alumno.Name = "txt_proc_medico_alumno";
            this.txt_proc_medico_alumno.PasswordChar = '\0';
            this.txt_proc_medico_alumno.PlaceholderText = "";
            this.txt_proc_medico_alumno.SelectedText = "";
            this.txt_proc_medico_alumno.ShadowDecoration.Parent = this.txt_proc_medico_alumno;
            this.txt_proc_medico_alumno.Size = new System.Drawing.Size(1260, 154);
            this.txt_proc_medico_alumno.TabIndex = 100;
            this.txt_proc_medico_alumno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_proc_medico_alumno_MouseClick);
            // 
            // Ventana_Afecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1468, 676);
            this.ControlBox = false;
            this.Controls.Add(this.txt_proc_medico_alumno);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_afeccion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.lbl_rol);
            this.Controls.Add(this.lbl_saludo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ventana_Afecciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Ventana_Afecciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button btn_regresar;
        private System.Windows.Forms.Label lbl_rol;
        public System.Windows.Forms.Label lbl_saludo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_afeccion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_proc_medico_alumno;
    }
}