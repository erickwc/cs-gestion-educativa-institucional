namespace CS_Proyecto.Vistas.RestablecerContraseña
{
    partial class Part1
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
            this.btn_salir = new System.Windows.Forms.Label();
            this.Btn_enviar_codigo = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_correo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.EliminarToken = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_salir.Location = new System.Drawing.Point(321, 444);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(527, 25);
            this.btn_salir.TabIndex = 34;
            this.btn_salir.Text = "Regresar al inicio";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Btn_enviar_codigo
            // 
            this.Btn_enviar_codigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_enviar_codigo.BorderRadius = 5;
            this.Btn_enviar_codigo.CheckedState.Parent = this.Btn_enviar_codigo;
            this.Btn_enviar_codigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_enviar_codigo.CustomImages.Parent = this.Btn_enviar_codigo;
            this.Btn_enviar_codigo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.Btn_enviar_codigo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_enviar_codigo.ForeColor = System.Drawing.Color.White;
            this.Btn_enviar_codigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.Btn_enviar_codigo.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.Btn_enviar_codigo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.Btn_enviar_codigo.HoverState.ForeColor = System.Drawing.Color.White;
            this.Btn_enviar_codigo.HoverState.Parent = this.Btn_enviar_codigo;
            this.Btn_enviar_codigo.Location = new System.Drawing.Point(321, 368);
            this.Btn_enviar_codigo.Name = "Btn_enviar_codigo";
            this.Btn_enviar_codigo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.Btn_enviar_codigo.ShadowDecoration.Parent = this.Btn_enviar_codigo;
            this.Btn_enviar_codigo.Size = new System.Drawing.Size(527, 53);
            this.Btn_enviar_codigo.TabIndex = 33;
            this.Btn_enviar_codigo.Text = "Enviar codigo de recuperación";
            this.Btn_enviar_codigo.Click += new System.EventHandler(this.Btn_enviar_codigo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(316, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ingresa el correo asociado a tu cuenta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_correo
            // 
            this.txt_correo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_correo.Animated = true;
            this.txt_correo.BackColor = System.Drawing.Color.Transparent;
            this.txt_correo.BorderRadius = 5;
            this.txt_correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_correo.DefaultText = "";
            this.txt_correo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_correo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_correo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_correo.DisabledState.Parent = this.txt_correo;
            this.txt_correo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_correo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.txt_correo.FocusedState.Parent = this.txt_correo;
            this.txt_correo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_correo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.txt_correo.HoverState.Parent = this.txt_correo;
            this.txt_correo.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txt_correo.IconLeftSize = new System.Drawing.Size(10, 15);
            this.txt_correo.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txt_correo.IconRightSize = new System.Drawing.Size(15, 15);
            this.txt_correo.Location = new System.Drawing.Point(321, 296);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.PasswordChar = '\0';
            this.txt_correo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_correo.PlaceholderText = "";
            this.txt_correo.SelectedText = "";
            this.txt_correo.ShadowDecoration.Parent = this.txt_correo;
            this.txt_correo.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(15);
            this.txt_correo.Size = new System.Drawing.Size(527, 39);
            this.txt_correo.TabIndex = 31;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lbl_titulo.Location = new System.Drawing.Point(24, 191);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(1126, 29);
            this.lbl_titulo.TabIndex = 29;
            this.lbl_titulo.Text = "Restablece tu contraseña";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lbl_descripcion.Location = new System.Drawing.Point(20, 223);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbl_descripcion.Size = new System.Drawing.Size(1130, 32);
            this.lbl_descripcion.TabIndex = 30;
            this.lbl_descripcion.Text = "No te preocupes, te mostraremos las instrucciones de restablecimiento.\n";
            this.lbl_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EliminarToken
            // 
            this.EliminarToken.Interval = 240000;
            this.EliminarToken.Tick += new System.EventHandler(this.EliminarToken_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::CS_Proyecto.Properties.Resources.img_pass;
            this.pictureBox1.Location = new System.Drawing.Point(539, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // Part1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 607);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.Btn_enviar_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_descripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Part1";
            this.Text = "Part1";
            this.Load += new System.EventHandler(this.Part1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btn_salir;
        public Guna.UI2.WinForms.Guna2Button Btn_enviar_codigo;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox txt_correo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Timer EliminarToken;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}