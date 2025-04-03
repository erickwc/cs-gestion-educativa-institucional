namespace CS_Proyecto.Vistas.RestablecerContraseña
{
    partial class Part4
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
            this.btn_enviar_codigo = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_enviar_codigo
            // 
            this.btn_enviar_codigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_enviar_codigo.BorderRadius = 5;
            this.btn_enviar_codigo.CheckedState.Parent = this.btn_enviar_codigo;
            this.btn_enviar_codigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enviar_codigo.CustomImages.Parent = this.btn_enviar_codigo;
            this.btn_enviar_codigo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_enviar_codigo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar_codigo.ForeColor = System.Drawing.Color.White;
            this.btn_enviar_codigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_enviar_codigo.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_enviar_codigo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_enviar_codigo.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_enviar_codigo.HoverState.Parent = this.btn_enviar_codigo;
            this.btn_enviar_codigo.Location = new System.Drawing.Point(320, 363);
            this.btn_enviar_codigo.Name = "btn_enviar_codigo";
            this.btn_enviar_codigo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_enviar_codigo.ShadowDecoration.Parent = this.btn_enviar_codigo;
            this.btn_enviar_codigo.Size = new System.Drawing.Size(527, 53);
            this.btn_enviar_codigo.TabIndex = 43;
            this.btn_enviar_codigo.Text = "Iniciar Sesion";
            this.btn_enviar_codigo.Click += new System.EventHandler(this.btn_enviar_codigo_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lbl_titulo.Location = new System.Drawing.Point(22, 255);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(1126, 29);
            this.lbl_titulo.TabIndex = 41;
            this.lbl_titulo.Text = "¡Contraseña restablecida correctamente!";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lbl_descripcion.Location = new System.Drawing.Point(316, 288);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbl_descripcion.Size = new System.Drawing.Size(527, 62);
            this.lbl_descripcion.TabIndex = 42;
            this.lbl_descripcion.Text = "Tu nueva contraseña se establecio dentro del sistema, Inicia Sesion nuevamente co" +
    "n tu nueva contraseña";
            this.lbl_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::CS_Proyecto.Properties.Resources.img_pass_confirmado;
            this.pictureBox1.Location = new System.Drawing.Point(538, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // Part4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 607);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_enviar_codigo);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_descripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Part4";
            this.Text = "Part4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button btn_enviar_codigo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}