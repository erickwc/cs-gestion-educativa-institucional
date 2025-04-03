namespace CS_Proyecto.Vistas.Usuarios
{
    partial class FotoPerfil
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eliminar_foto = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cargar_foto = new Guna.UI2.WinForms.Guna2Button();
            this.pict_foto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pict_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lbl_titulo.Location = new System.Drawing.Point(409, 136);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(223, 29);
            this.lbl_titulo.TabIndex = 37;
            this.lbl_titulo.Text = "Imagen de Perfil";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lbl_descripcion.Location = new System.Drawing.Point(410, 171);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbl_descripcion.Size = new System.Drawing.Size(199, 32);
            this.lbl_descripcion.TabIndex = 38;
            this.lbl_descripcion.Text = "Escoge una foto de perfil";
            this.lbl_descripcion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(596, 172);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "(Opcional)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btn_eliminar_foto
            // 
            this.btn_eliminar_foto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_eliminar_foto.BackColor = System.Drawing.Color.White;
            this.btn_eliminar_foto.BorderRadius = 5;
            this.btn_eliminar_foto.CheckedState.Parent = this.btn_eliminar_foto;
            this.btn_eliminar_foto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar_foto.CustomImages.Parent = this.btn_eliminar_foto;
            this.btn_eliminar_foto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_eliminar_foto.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_foto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_eliminar_foto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_eliminar_foto.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_eliminar_foto.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_eliminar_foto.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_eliminar_foto.HoverState.Parent = this.btn_eliminar_foto;
            this.btn_eliminar_foto.Location = new System.Drawing.Point(618, 215);
            this.btn_eliminar_foto.Name = "btn_eliminar_foto";
            this.btn_eliminar_foto.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_eliminar_foto.ShadowDecoration.Parent = this.btn_eliminar_foto;
            this.btn_eliminar_foto.Size = new System.Drawing.Size(195, 57);
            this.btn_eliminar_foto.TabIndex = 81;
            this.btn_eliminar_foto.Text = "Quitar Foto";
            this.btn_eliminar_foto.Click += new System.EventHandler(this.btn_eliminar_foto_Click);
            // 
            // btn_cargar_foto
            // 
            this.btn_cargar_foto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cargar_foto.BorderRadius = 5;
            this.btn_cargar_foto.CheckedState.Parent = this.btn_cargar_foto;
            this.btn_cargar_foto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cargar_foto.CustomImages.Parent = this.btn_cargar_foto;
            this.btn_cargar_foto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_cargar_foto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar_foto.ForeColor = System.Drawing.Color.White;
            this.btn_cargar_foto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_cargar_foto.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_cargar_foto.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_cargar_foto.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_cargar_foto.HoverState.Parent = this.btn_cargar_foto;
            this.btn_cargar_foto.Location = new System.Drawing.Point(414, 215);
            this.btn_cargar_foto.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.btn_cargar_foto.Name = "btn_cargar_foto";
            this.btn_cargar_foto.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_cargar_foto.ShadowDecoration.Parent = this.btn_cargar_foto;
            this.btn_cargar_foto.Size = new System.Drawing.Size(188, 57);
            this.btn_cargar_foto.TabIndex = 80;
            this.btn_cargar_foto.Text = "Cargar Foto";
            this.btn_cargar_foto.Click += new System.EventHandler(this.btn_cargar_foto_Click);
            // 
            // pict_foto
            // 
            this.pict_foto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pict_foto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pict_foto.Image = global::CS_Proyecto.Properties.Resources.ImgPerfil;
            this.pict_foto.InitialImage = global::CS_Proyecto.Properties.Resources.SinFotoPerfil;
            this.pict_foto.Location = new System.Drawing.Point(57, 51);
            this.pict_foto.Name = "pict_foto";
            this.pict_foto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pict_foto.ShadowDecoration.Parent = this.pict_foto;
            this.pict_foto.Size = new System.Drawing.Size(305, 305);
            this.pict_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pict_foto.TabIndex = 36;
            this.pict_foto.TabStop = false;
            // 
            // FotoPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 411);
            this.Controls.Add(this.btn_eliminar_foto);
            this.Controls.Add(this.btn_cargar_foto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.pict_foto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FotoPerfil";
            this.Text = "FotoPerfil";
            this.Load += new System.EventHandler(this.FotoPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pict_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_descripcion;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pict_foto;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_eliminar_foto;
        public Guna.UI2.WinForms.Guna2Button btn_cargar_foto;
    }
}