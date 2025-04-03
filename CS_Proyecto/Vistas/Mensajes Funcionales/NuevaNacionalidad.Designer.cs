namespace CS_Proyecto.Vistas.Mensajes_Funcionales
{
    partial class NuevaNacionalidad
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.Panel_Ingresar = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_cancelar_ = new Guna.UI2.WinForms.Guna2Button();
            this.btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.txt_nacionalidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Panel_Ingresar.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
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
            this.btn_aceptar.Location = new System.Drawing.Point(51, 259);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_aceptar.ShadowDecoration.Parent = this.btn_aceptar;
            this.btn_aceptar.Size = new System.Drawing.Size(499, 66);
            this.btn_aceptar.TabIndex = 46;
            this.btn_aceptar.Text = "Aceptar y finalizar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::CS_Proyecto.Properties.Resources.InformacionRegistrada;
            this.pictureBox2.Location = new System.Drawing.Point(51, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(499, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lbl_titulo.Location = new System.Drawing.Point(51, 153);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(499, 25);
            this.lbl_titulo.TabIndex = 43;
            this.lbl_titulo.Text = "¡Nacionalidad agregada correctamente!";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lbl_descripcion.Location = new System.Drawing.Point(51, 178);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbl_descripcion.Size = new System.Drawing.Size(499, 74);
            this.lbl_descripcion.TabIndex = 44;
            this.lbl_descripcion.Text = "La nueva nacionalidad ingresada se registro correctamente en el sistema.";
            this.lbl_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Ingresar
            // 
            this.Panel_Ingresar.BackColor = System.Drawing.Color.White;
            this.Panel_Ingresar.Controls.Add(this.lbl_error);
            this.Panel_Ingresar.Controls.Add(this.btn_cancelar_);
            this.Panel_Ingresar.Controls.Add(this.btn_guardar);
            this.Panel_Ingresar.Controls.Add(this.txt_nacionalidad);
            this.Panel_Ingresar.Controls.Add(this.label4);
            this.Panel_Ingresar.Controls.Add(this.guna2Panel2);
            this.Panel_Ingresar.Controls.Add(this.label3);
            this.Panel_Ingresar.Controls.Add(this.label2);
            this.Panel_Ingresar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Ingresar.FillColor = System.Drawing.Color.White;
            this.Panel_Ingresar.Location = new System.Drawing.Point(0, 0);
            this.Panel_Ingresar.Name = "Panel_Ingresar";
            this.Panel_Ingresar.ShadowDecoration.Parent = this.Panel_Ingresar;
            this.Panel_Ingresar.Size = new System.Drawing.Size(598, 390);
            this.Panel_Ingresar.TabIndex = 47;
            // 
            // lbl_error
            // 
            this.lbl_error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.lbl_error.Location = new System.Drawing.Point(197, 222);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(338, 25);
            this.lbl_error.TabIndex = 42;
            this.lbl_error.Text = "¡Esta nacionalidad ya esta registrada!";
            this.lbl_error.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_error.Visible = false;
            // 
            // btn_cancelar_
            // 
            this.btn_cancelar_.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar_.BorderRadius = 5;
            this.btn_cancelar_.CheckedState.Parent = this.btn_cancelar_;
            this.btn_cancelar_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar_.CustomImages.Parent = this.btn_cancelar_;
            this.btn_cancelar_.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_cancelar_.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_cancelar_.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_cancelar_.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_cancelar_.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_cancelar_.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_cancelar_.HoverState.Parent = this.btn_cancelar_;
            this.btn_cancelar_.Location = new System.Drawing.Point(56, 260);
            this.btn_cancelar_.Name = "btn_cancelar_";
            this.btn_cancelar_.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_cancelar_.ShadowDecoration.Parent = this.btn_cancelar_;
            this.btn_cancelar_.Size = new System.Drawing.Size(224, 65);
            this.btn_cancelar_.TabIndex = 40;
            this.btn_cancelar_.Text = "Cancelar ";
            this.btn_cancelar_.Click += new System.EventHandler(this.btn_cancelar__Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_guardar.BorderRadius = 5;
            this.btn_guardar.CheckedState.Parent = this.btn_guardar;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.CustomImages.Parent = this.btn_guardar;
            this.btn_guardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar.HoverState.Parent = this.btn_guardar;
            this.btn_guardar.Location = new System.Drawing.Point(300, 260);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.ShadowDecoration.Parent = this.btn_guardar;
            this.btn_guardar.Size = new System.Drawing.Size(235, 65);
            this.btn_guardar.TabIndex = 39;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_nacionalidad
            // 
            this.txt_nacionalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nacionalidad.BorderRadius = 5;
            this.txt_nacionalidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nacionalidad.DefaultText = "";
            this.txt_nacionalidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nacionalidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nacionalidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nacionalidad.DisabledState.Parent = this.txt_nacionalidad;
            this.txt_nacionalidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nacionalidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_nacionalidad.FocusedState.Parent = this.txt_nacionalidad;
            this.txt_nacionalidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nacionalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_nacionalidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_nacionalidad.HoverState.Parent = this.txt_nacionalidad;
            this.txt_nacionalidad.Location = new System.Drawing.Point(56, 169);
            this.txt_nacionalidad.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_nacionalidad.Name = "txt_nacionalidad";
            this.txt_nacionalidad.PasswordChar = '\0';
            this.txt_nacionalidad.PlaceholderText = "";
            this.txt_nacionalidad.SelectedText = "";
            this.txt_nacionalidad.ShadowDecoration.Parent = this.txt_nacionalidad;
            this.txt_nacionalidad.Size = new System.Drawing.Size(479, 48);
            this.txt_nacionalidad.TabIndex = 38;
            this.txt_nacionalidad.TextChanged += new System.EventHandler(this.txt_nacionalidad_TextChanged);
            this.txt_nacionalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nacionalidad_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(52, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nacionalidad";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.Controls.Add(this.pictureBox1);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.guna2Panel2.Location = new System.Drawing.Point(56, 50);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(70, 70);
            this.guna2Panel2.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CS_Proyecto.Properties.Resources.nivel_estudio;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(142, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Registra una nueva nacionalidad dentro del sistema";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(142, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 27);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nueva Nacionalidad";
            // 
            // NuevaNacionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 390);
            this.ControlBox = false;
            this.Controls.Add(this.Panel_Ingresar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_descripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaNacionalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NuevaNacionalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Panel_Ingresar.ResumeLayout(false);
            this.Panel_Ingresar.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button btn_aceptar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_descripcion;
        private Guna.UI2.WinForms.Guna2Panel Panel_Ingresar;
        private Guna.UI2.WinForms.Guna2Button btn_cancelar_;
        private Guna.UI2.WinForms.Guna2Button btn_guardar;
        private Guna.UI2.WinForms.Guna2TextBox txt_nacionalidad;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_error;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}