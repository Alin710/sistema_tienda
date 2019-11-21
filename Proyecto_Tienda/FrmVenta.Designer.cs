namespace Proyecto_Tienda
{
    partial class FrmVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lb_usuario = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.Btn_buscar_cliente = new System.Windows.Forms.Button();
            this.lbNombreT = new System.Windows.Forms.Label();
            this.Empleado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.lbN = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dg_lista = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_ventar = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ImgBusca_Productos = new System.Windows.Forms.PictureBox();
            this.dg_inventario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cantida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtBuscarCE = new System.Windows.Forms.TextBox();
            this.dgBuscarCE = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ventar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBusca_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_inventario)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuscarCE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lb_usuario);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.Btn_buscar_cliente);
            this.groupBox1.Controls.Add(this.lbNombreT);
            this.groupBox1.Controls.Add(this.Empleado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbEmpleado);
            this.groupBox1.Controls.Add(this.lbN);
            this.groupBox1.Controls.Add(this.btn);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.lb_fecha);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.splitContainer2);
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 575);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Lb_usuario
            // 
            this.Lb_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_usuario.AutoSize = true;
            this.Lb_usuario.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_usuario.Location = new System.Drawing.Point(33, 16);
            this.Lb_usuario.Name = "Lb_usuario";
            this.Lb_usuario.Size = new System.Drawing.Size(51, 17);
            this.Lb_usuario.TabIndex = 70;
            this.Lb_usuario.Text = "Usuario";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb1.Location = new System.Drawing.Point(33, 312);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(46, 18);
            this.lb1.TabIndex = 23;
            this.lb1.Text = "label5";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(63, 527);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "SALIR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(731, 62);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(125, 20);
            this.txtCliente.TabIndex = 21;
            // 
            // Btn_buscar_cliente
            // 
            this.Btn_buscar_cliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_buscar_cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_buscar_cliente.Location = new System.Drawing.Point(872, 43);
            this.Btn_buscar_cliente.Name = "Btn_buscar_cliente";
            this.Btn_buscar_cliente.Size = new System.Drawing.Size(41, 23);
            this.Btn_buscar_cliente.TabIndex = 20;
            this.Btn_buscar_cliente.Text = ">>";
            this.Btn_buscar_cliente.UseVisualStyleBackColor = false;
            this.Btn_buscar_cliente.Click += new System.EventHandler(this.Btn_buscar_cliente_Click);
            // 
            // lbNombreT
            // 
            this.lbNombreT.AutoSize = true;
            this.lbNombreT.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreT.ForeColor = System.Drawing.Color.Black;
            this.lbNombreT.Location = new System.Drawing.Point(336, 22);
            this.lbNombreT.Name = "lbNombreT";
            this.lbNombreT.Size = new System.Drawing.Size(219, 20);
            this.lbNombreT.TabIndex = 19;
            this.lbNombreT.Text = "TIENDA DE CALZADOS 2016";
            // 
            // Empleado
            // 
            this.Empleado.AutoSize = true;
            this.Empleado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Empleado.Location = new System.Drawing.Point(613, 46);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(92, 13);
            this.Empleado.TabIndex = 18;
            this.Empleado.Text = "Empleado/Cajero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(762, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cliente:";
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(594, 62);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(131, 21);
            this.cbEmpleado.TabIndex = 15;
            // 
            // lbN
            // 
            this.lbN.AutoSize = true;
            this.lbN.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbN.Location = new System.Drawing.Point(33, 77);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(111, 18);
            this.lbN.TabIndex = 12;
            this.lbN.Text = "Buscar Producto:";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(340, 75);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(108, 23);
            this.btn.TabIndex = 11;
            this.btn.Text = "POR  NOMBRE";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(150, 75);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(177, 20);
            this.txtBuscar.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(454, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "POR CODIGO";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.Location = new System.Drawing.Point(498, 304);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(91, 23);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lb_fecha
            // 
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_fecha.Location = new System.Drawing.Point(33, 33);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(44, 18);
            this.lb_fecha.TabIndex = 4;
            this.lb_fecha.Text = "label1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(396, 304);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "REGISTRAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(24, 333);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dg_lista);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dg_ventar);
            this.splitContainer2.Size = new System.Drawing.Size(940, 183);
            this.splitContainer2.SplitterDistance = 547;
            this.splitContainer2.TabIndex = 2;
            // 
            // dg_lista
            // 
            this.dg_lista.AllowUserToDeleteRows = false;
            this.dg_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.cantidad,
            this.cantidad_stock});
            this.dg_lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_lista.Location = new System.Drawing.Point(0, 0);
            this.dg_lista.Name = "dg_lista";
            this.dg_lista.Size = new System.Drawing.Size(547, 183);
            this.dg_lista.TabIndex = 0;
            this.dg_lista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_lista_CellClick);
            this.dg_lista.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_lista_CellEndEdit);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Producto";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nro entrega";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Codigo";
            this.Column7.Name = "Column7";
            // 
            // cantidad
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // cantidad_stock
            // 
            this.cantidad_stock.HeaderText = "cantidad_stock";
            this.cantidad_stock.Name = "cantidad_stock";
            // 
            // dg_ventar
            // 
            this.dg_ventar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ventar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_ventar.Location = new System.Drawing.Point(0, 0);
            this.dg_ventar.Name = "dg_ventar";
            this.dg_ventar.Size = new System.Drawing.Size(389, 183);
            this.dg_ventar.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(24, 115);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ImgBusca_Productos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dg_inventario);
            this.splitContainer1.Size = new System.Drawing.Size(940, 183);
            this.splitContainer1.SplitterDistance = 99;
            this.splitContainer1.TabIndex = 1;
            // 
            // ImgBusca_Productos
            // 
            this.ImgBusca_Productos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ImgBusca_Productos.Image = global::Proyecto_Tienda.Properties.Resources.botines;
            this.ImgBusca_Productos.Location = new System.Drawing.Point(3, 3);
            this.ImgBusca_Productos.Name = "ImgBusca_Productos";
            this.ImgBusca_Productos.Size = new System.Drawing.Size(92, 177);
            this.ImgBusca_Productos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgBusca_Productos.TabIndex = 0;
            this.ImgBusca_Productos.TabStop = false;
            this.ImgBusca_Productos.Click += new System.EventHandler(this.ImgBusca_Productos_Click);
            // 
            // dg_inventario
            // 
            this.dg_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_inventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Cantida});
            this.dg_inventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_inventario.Location = new System.Drawing.Point(0, 0);
            this.dg_inventario.Name = "dg_inventario";
            this.dg_inventario.Size = new System.Drawing.Size(837, 183);
            this.dg_inventario.TabIndex = 0;
            this.dg_inventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_inventario_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Elegir Producto";
            this.Column1.Name = "Column1";
            // 
            // Cantida
            // 
            this.Cantida.HeaderText = "cantidad";
            this.Cantida.Name = "Cantida";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.btn1);
            this.groupBox3.Controls.Add(this.txtBuscarCE);
            this.groupBox3.Controls.Add(this.dgBuscarCE);
            this.groupBox3.Location = new System.Drawing.Point(1008, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 575);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda de Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(74, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "BUSQUEDA DE CLIENTES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Introduzca el Nombre del Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Tienda.Properties.Resources.icone_verte;
            this.pictureBox1.Location = new System.Drawing.Point(103, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 527);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Location = new System.Drawing.Point(198, 304);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(110, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Buscar";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtBuscarCE
            // 
            this.txtBuscarCE.Location = new System.Drawing.Point(48, 304);
            this.txtBuscarCE.Name = "txtBuscarCE";
            this.txtBuscarCE.Size = new System.Drawing.Size(144, 20);
            this.txtBuscarCE.TabIndex = 1;
            // 
            // dgBuscarCE
            // 
            this.dgBuscarCE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuscarCE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dgBuscarCE.Location = new System.Drawing.Point(22, 333);
            this.dgBuscarCE.Name = "dgBuscarCE";
            this.dgBuscarCE.Size = new System.Drawing.Size(308, 183);
            this.dgBuscarCE.TabIndex = 0;
            this.dgBuscarCE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBuscarCE_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "seleccione";
            this.Column2.Name = "Column2";
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 603);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMUARIO VENTA";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ventar)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgBusca_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_inventario)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuscarCE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button Btn_buscar_cliente;
        private System.Windows.Forms.Label lbNombreT;
        private System.Windows.Forms.Label Empleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dg_lista;
        private System.Windows.Forms.DataGridView dg_ventar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox ImgBusca_Productos;
        private System.Windows.Forms.DataGridView dg_inventario;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantida;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtBuscarCE;
        private System.Windows.Forms.DataGridView dgBuscarCE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Lb_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_stock;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}