namespace Proyecto_Tienda
{
    partial class FrmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
            this.groupb1 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btn_Reg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtconsu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.lb_mostrar = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtci = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncargar = new System.Windows.Forms.Button();
            this.pcb2 = new System.Windows.Forms.PictureBox();
            this.opf2 = new System.Windows.Forms.OpenFileDialog();
            this.groupb1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupb1
            // 
            this.groupb1.Controls.Add(this.btnImprimir);
            this.groupb1.Controls.Add(this.cbGenero);
            this.groupb1.Controls.Add(this.label8);
            this.groupb1.Controls.Add(this.txtApp);
            this.groupb1.Controls.Add(this.label5);
            this.groupb1.Controls.Add(this.btnNuevo);
            this.groupb1.Controls.Add(this.btnVer);
            this.groupb1.Controls.Add(this.btnModificar);
            this.groupb1.Controls.Add(this.btn_Reg);
            this.groupb1.Controls.Add(this.groupBox1);
            this.groupb1.Controls.Add(this.dg);
            this.groupb1.Controls.Add(this.lb_mostrar);
            this.groupb1.Controls.Add(this.N);
            this.groupb1.Controls.Add(this.txtCorreo);
            this.groupb1.Controls.Add(this.fecha);
            this.groupb1.Controls.Add(this.label6);
            this.groupb1.Controls.Add(this.txttel);
            this.groupb1.Controls.Add(this.label3);
            this.groupb1.Controls.Add(this.txtnom);
            this.groupb1.Controls.Add(this.label2);
            this.groupb1.Controls.Add(this.txtci);
            this.groupb1.Controls.Add(this.label1);
            this.groupb1.Controls.Add(this.btncargar);
            this.groupb1.Controls.Add(this.pcb2);
            this.groupb1.Location = new System.Drawing.Point(34, 24);
            this.groupb1.Name = "groupb1";
            this.groupb1.Size = new System.Drawing.Size(963, 504);
            this.groupb1.TabIndex = 29;
            this.groupb1.TabStop = false;
            this.groupb1.Text = "Registro de Empleado";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.Location = new System.Drawing.Point(458, 45);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(94, 23);
            this.btnImprimir.TabIndex = 63;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbGenero.Location = new System.Drawing.Point(326, 130);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Genero:";
            // 
            // txtApp
            // 
            this.txtApp.Location = new System.Drawing.Point(120, 162);
            this.txtApp.Name = "txtApp";
            this.txtApp.Size = new System.Drawing.Size(121, 20);
            this.txtApp.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Apellidos:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.Location = new System.Drawing.Point(110, 45);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 54;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVer.Location = new System.Drawing.Point(358, 45);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(94, 23);
            this.btnVer.TabIndex = 53;
            this.btnVer.Text = "VER DATOS";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(277, 45);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 51;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btn_Reg
            // 
            this.btn_Reg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Reg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reg.Location = new System.Drawing.Point(191, 45);
            this.btn_Reg.Name = "btn_Reg";
            this.btn_Reg.Size = new System.Drawing.Size(80, 23);
            this.btn_Reg.TabIndex = 50;
            this.btn_Reg.Text = "REGISTRAR";
            this.btn_Reg.UseVisualStyleBackColor = false;
            this.btn_Reg.Click += new System.EventHandler(this.btn_Reg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtconsu);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(610, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 154);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "consulta";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb1.Location = new System.Drawing.Point(109, 31);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(82, 17);
            this.lb1.TabIndex = 58;
            this.lb1.Text = "CONSULTAR";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 56;
            this.button2.Text = "Buscar por Nombre";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtconsu
            // 
            this.txtconsu.Location = new System.Drawing.Point(86, 65);
            this.txtconsu.Name = "txtconsu";
            this.txtconsu.Size = new System.Drawing.Size(142, 20);
            this.txtconsu.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "Buscar por CI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(61, 274);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(762, 206);
            this.dg.TabIndex = 45;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // lb_mostrar
            // 
            this.lb_mostrar.AutoSize = true;
            this.lb_mostrar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mostrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_mostrar.Location = new System.Drawing.Point(73, 243);
            this.lb_mostrar.Name = "lb_mostrar";
            this.lb_mostrar.Size = new System.Drawing.Size(46, 18);
            this.lb_mostrar.TabIndex = 42;
            this.lb_mostrar.Text = "label4";
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Location = new System.Drawing.Point(272, 165);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(41, 13);
            this.N.TabIndex = 41;
            this.N.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(326, 166);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(121, 20);
            this.txtCorreo.TabIndex = 40;
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(331, 96);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(116, 20);
            this.fecha.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "F-Nacimiento:";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(120, 197);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(121, 20);
            this.txttel.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Telefono:";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(120, 126);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(121, 20);
            this.txtnom.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre:";
            // 
            // txtci
            // 
            this.txtci.Location = new System.Drawing.Point(120, 94);
            this.txtci.Name = "txtci";
            this.txtci.Size = new System.Drawing.Size(121, 20);
            this.txtci.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "CI:";
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(467, 186);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(125, 23);
            this.btncargar.TabIndex = 23;
            this.btncargar.Text = "cargar imagen";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // pcb2
            // 
            this.pcb2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pcb2.Image = global::Proyecto_Tienda.Properties.Resources.usuario_registrado;
            this.pcb2.Location = new System.Drawing.Point(467, 86);
            this.pcb2.Name = "pcb2";
            this.pcb2.Size = new System.Drawing.Size(112, 96);
            this.pcb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb2.TabIndex = 22;
            this.pcb2.TabStop = false;
            // 
            // opf2
            // 
            this.opf2.FileName = "openFileDialog1";
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 544);
            this.Controls.Add(this.groupb1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.groupb1.ResumeLayout(false);
            this.groupb1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupb1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btn_Reg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtconsu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label lb_mostrar;
        private System.Windows.Forms.Label N;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.PictureBox pcb2;
        private System.Windows.Forms.OpenFileDialog opf2;

    }
}