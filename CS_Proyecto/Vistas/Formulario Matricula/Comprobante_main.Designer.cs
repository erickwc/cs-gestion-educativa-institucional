namespace CS_Proyecto.Vistas.Formulario_Matricula
{
    partial class Comprobante_main
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
            this.Panel_Contenedor = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Contenedor_Secciones = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_guardar_registro = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_identificacion = new Guna.UI2.WinForms.Guna2Button();
            this.btn_pago = new Guna.UI2.WinForms.Guna2Button();
            this.ActualizarFormulario = new System.Windows.Forms.Timer(this.components);
            this.Panel_Contenedor.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Contenedor
            // 
            this.Panel_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.Panel_Contenedor.Controls.Add(this.guna2Panel1);
            this.Panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Contenedor.Location = new System.Drawing.Point(0, 0);
            this.Panel_Contenedor.Name = "Panel_Contenedor";
            this.Panel_Contenedor.Size = new System.Drawing.Size(1170, 607);
            this.Panel_Contenedor.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.Controls.Add(this.tableLayoutPanel2);
            this.guna2Panel1.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1170, 607);
            this.guna2Panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Panel_Contenedor_Secciones, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 61);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1160, 541);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Panel_Contenedor_Secciones
            // 
            this.Panel_Contenedor_Secciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Contenedor_Secciones.Location = new System.Drawing.Point(3, 3);
            this.Panel_Contenedor_Secciones.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Panel_Contenedor_Secciones.Name = "Panel_Contenedor_Secciones";
            this.Panel_Contenedor_Secciones.Size = new System.Drawing.Size(1154, 402);
            this.Panel_Contenedor_Secciones.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_cancelar);
            this.panel2.Controls.Add(this.btn_guardar_registro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 405);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 136);
            this.panel2.TabIndex = 1;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.BackColor = System.Drawing.Color.White;
            this.btn_cancelar.BorderRadius = 5;
            this.btn_cancelar.CheckedState.Parent = this.btn_cancelar;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.CustomImages.Parent = this.btn_cancelar;
            this.btn_cancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_cancelar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_cancelar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_cancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_cancelar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_cancelar.HoverState.Parent = this.btn_cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(848, 32);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btn_cancelar.ShadowDecoration.Parent = this.btn_cancelar;
            this.btn_cancelar.Size = new System.Drawing.Size(276, 57);
            this.btn_cancelar.TabIndex = 80;
            this.btn_cancelar.Text = "Cancelar Comprobante";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar_registro
            // 
            this.btn_guardar_registro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar_registro.BorderRadius = 5;
            this.btn_guardar_registro.CheckedState.Parent = this.btn_guardar_registro;
            this.btn_guardar_registro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar_registro.CustomImages.Parent = this.btn_guardar_registro;
            this.btn_guardar_registro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar_registro.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_registro.ForeColor = System.Drawing.Color.White;
            this.btn_guardar_registro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar_registro.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar_registro.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar_registro.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_guardar_registro.HoverState.Parent = this.btn_guardar_registro;
            this.btn_guardar_registro.Location = new System.Drawing.Point(547, 32);
            this.btn_guardar_registro.Name = "btn_guardar_registro";
            this.btn_guardar_registro.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.btn_guardar_registro.ShadowDecoration.Parent = this.btn_guardar_registro;
            this.btn_guardar_registro.Size = new System.Drawing.Size(276, 57);
            this.btn_guardar_registro.TabIndex = 19;
            this.btn_guardar_registro.Text = "Guardar Comprobante";
            this.btn_guardar_registro.Click += new System.EventHandler(this.btn_guardar_registro_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btn_identificacion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_pago, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(450, 0, 450, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1160, 56);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_identificacion
            // 
            this.btn_identificacion.BackColor = System.Drawing.Color.Transparent;
            this.btn_identificacion.BorderRadius = 5;
            this.btn_identificacion.CheckedState.Parent = this.btn_identificacion;
            this.btn_identificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_identificacion.CustomImages.Parent = this.btn_identificacion;
            this.btn_identificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_identificacion.FillColor = System.Drawing.Color.White;
            this.btn_identificacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_identificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_identificacion.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_identificacion.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_identificacion.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_identificacion.HoverState.Parent = this.btn_identificacion;
            this.btn_identificacion.Location = new System.Drawing.Point(585, 5);
            this.btn_identificacion.Margin = new System.Windows.Forms.Padding(5);
            this.btn_identificacion.Name = "btn_identificacion";
            this.btn_identificacion.PressedColor = System.Drawing.Color.White;
            this.btn_identificacion.ShadowDecoration.Parent = this.btn_identificacion;
            this.btn_identificacion.Size = new System.Drawing.Size(120, 46);
            this.btn_identificacion.TabIndex = 8;
            this.btn_identificacion.Text = "Identificación";
            this.btn_identificacion.Click += new System.EventHandler(this.btn_identificacion_Click);
            // 
            // btn_pago
            // 
            this.btn_pago.BackColor = System.Drawing.Color.Transparent;
            this.btn_pago.BorderRadius = 5;
            this.btn_pago.CheckedState.Parent = this.btn_pago;
            this.btn_pago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pago.CustomImages.Parent = this.btn_pago;
            this.btn_pago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_pago.FillColor = System.Drawing.Color.White;
            this.btn_pago.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_pago.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_pago.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_pago.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_pago.HoverState.Parent = this.btn_pago;
            this.btn_pago.Location = new System.Drawing.Point(455, 5);
            this.btn_pago.Margin = new System.Windows.Forms.Padding(5);
            this.btn_pago.Name = "btn_pago";
            this.btn_pago.PressedColor = System.Drawing.Color.White;
            this.btn_pago.ShadowDecoration.Parent = this.btn_pago;
            this.btn_pago.Size = new System.Drawing.Size(120, 46);
            this.btn_pago.TabIndex = 7;
            this.btn_pago.Text = "Pago";
            this.btn_pago.Click += new System.EventHandler(this.btn_pago_Click);
            // 
            // ActualizarFormulario
            // 
            this.ActualizarFormulario.Enabled = true;
            this.ActualizarFormulario.Interval = 1;
            this.ActualizarFormulario.Tick += new System.EventHandler(this.ActualizarFormulario_Tick);
            // 
            // Comprobante_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 607);
            this.Controls.Add(this.Panel_Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Comprobante_main";
            this.Text = "Comprobante_main";
            this.Load += new System.EventHandler(this.Comprobante_main_Load);
            this.Panel_Contenedor.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Contenedor;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        public Guna.UI2.WinForms.Guna2Button btn_guardar_registro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btn_identificacion;
        private Guna.UI2.WinForms.Guna2Button btn_pago;
        private Guna.UI2.WinForms.Guna2Button btn_cancelar;
        private System.Windows.Forms.Timer ActualizarFormulario;
        public System.Windows.Forms.Panel Panel_Contenedor_Secciones;
    }
}