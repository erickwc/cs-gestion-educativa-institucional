namespace CS_Proyecto.Vistas.Mi_Perfil
{
    partial class ImgPerfil
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
            this.PictFoto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cambiar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_quitar = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // PictFoto
            // 
            this.PictFoto.BorderRadius = 5;
            this.PictFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictFoto.Image = global::CS_Proyecto.Properties.Resources.ImgPerfil;
            this.PictFoto.Location = new System.Drawing.Point(77, 64);
            this.PictFoto.Name = "PictFoto";
            this.PictFoto.ShadowDecoration.Parent = this.PictFoto;
            this.PictFoto.Size = new System.Drawing.Size(300, 300);
            this.PictFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictFoto.TabIndex = 0;
            this.PictFoto.TabStop = false;
            this.PictFoto.Click += new System.EventHandler(this.PictFoto_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lbl_titulo.Location = new System.Drawing.Point(440, 122);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(149, 29);
            this.lbl_titulo.TabIndex = 36;
            this.lbl_titulo.Text = "Imagen de perfil";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lbl_descripcion.Location = new System.Drawing.Point(440, 163);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbl_descripcion.Size = new System.Drawing.Size(391, 54);
            this.lbl_descripcion.TabIndex = 37;
            this.lbl_descripcion.Text = "Puedes agregar una foto de perfil en los siguientes formatos";
            this.lbl_descripcion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(512, 187);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "(PNG, JPG, JPEG).";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btn_cambiar
            // 
            this.btn_cambiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cambiar.BorderRadius = 5;
            this.btn_cambiar.CheckedState.Parent = this.btn_cambiar;
            this.btn_cambiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cambiar.CustomImages.Parent = this.btn_cambiar;
            this.btn_cambiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_cambiar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cambiar.ForeColor = System.Drawing.Color.White;
            this.btn_cambiar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_cambiar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_cambiar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_cambiar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_cambiar.HoverState.Parent = this.btn_cambiar;
            this.btn_cambiar.Location = new System.Drawing.Point(444, 239);
            this.btn_cambiar.Name = "btn_cambiar";
            this.btn_cambiar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_cambiar.ShadowDecoration.Parent = this.btn_cambiar;
            this.btn_cambiar.Size = new System.Drawing.Size(190, 61);
            this.btn_cambiar.TabIndex = 40;
            this.btn_cambiar.Text = "Guardar Cambios";
            this.btn_cambiar.Click += new System.EventHandler(this.btn_cambiar_Click);
            // 
            // btn_quitar
            // 
            this.btn_quitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_quitar.BorderRadius = 5;
            this.btn_quitar.CheckedState.Parent = this.btn_quitar;
            this.btn_quitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitar.CustomImages.Parent = this.btn_quitar;
            this.btn_quitar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_quitar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_quitar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_quitar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_quitar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_quitar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_quitar.HoverState.Parent = this.btn_quitar;
            this.btn_quitar.Location = new System.Drawing.Point(650, 239);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_quitar.ShadowDecoration.Parent = this.btn_quitar;
            this.btn_quitar.Size = new System.Drawing.Size(190, 61);
            this.btn_quitar.TabIndex = 39;
            this.btn_quitar.Text = "Quitar Foto";
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.label2.Location = new System.Drawing.Point(73, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "Presiona la imagen";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.Interval = 150;
            // 
            // ImgPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cambiar);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.PictFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImgPerfil";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ImgPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PictFoto;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2Button btn_cambiar;
        private Guna.UI2.WinForms.Guna2Button btn_quitar;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}