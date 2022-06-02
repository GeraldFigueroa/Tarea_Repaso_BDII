namespace Centros_de_Triaje
{
    partial class fPruebas
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
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.listBoxTiposPrueba = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvPruebas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtIdentidadDoctor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.richtxtResultadoPrueba = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPruebas)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 65;
            this.label9.Text = "Tipos de prueba";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1105, 767);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(169, 53);
            this.btnCancelar.TabIndex = 64;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // listBoxTiposPrueba
            // 
            this.listBoxTiposPrueba.FormattingEnabled = true;
            this.listBoxTiposPrueba.ItemHeight = 20;
            this.listBoxTiposPrueba.Location = new System.Drawing.Point(26, 459);
            this.listBoxTiposPrueba.Name = "listBoxTiposPrueba";
            this.listBoxTiposPrueba.Size = new System.Drawing.Size(262, 104);
            this.listBoxTiposPrueba.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "Listado de pruebas";
            // 
            // dgvPruebas
            // 
            this.dgvPruebas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPruebas.Location = new System.Drawing.Point(434, 52);
            this.dgvPruebas.Name = "dgvPruebas";
            this.dgvPruebas.RowHeadersWidth = 51;
            this.dgvPruebas.RowTemplate.Height = 29;
            this.dgvPruebas.Size = new System.Drawing.Size(840, 468);
            this.dgvPruebas.TabIndex = 61;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(874, 767);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(169, 53);
            this.btnAgregar.TabIndex = 58;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Fecha de realización de la prueba";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(26, 124);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 55;
            // 
            // txtIdentidadDoctor
            // 
            this.txtIdentidadDoctor.Location = new System.Drawing.Point(26, 383);
            this.txtIdentidadDoctor.MaxLength = 20;
            this.txtIdentidadDoctor.Name = "txtIdentidadDoctor";
            this.txtIdentidadDoctor.Size = new System.Drawing.Size(332, 27);
            this.txtIdentidadDoctor.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 590);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Resultado de la prueba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Identidad del doctor";
            // 
            // txtNumConsulta
            // 
            this.txtNumConsulta.Location = new System.Drawing.Point(26, 52);
            this.txtNumConsulta.MaxLength = 15;
            this.txtNumConsulta.Name = "txtNumConsulta";
            this.txtNumConsulta.Size = new System.Drawing.Size(143, 27);
            this.txtNumConsulta.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Número de consulta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 590);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Fecha del resultado";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(26, 613);
            this.monthCalendar2.MaxSelectionCount = 1;
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 66;
            // 
            // richtxtResultadoPrueba
            // 
            this.richtxtResultadoPrueba.Location = new System.Drawing.Point(348, 613);
            this.richtxtResultadoPrueba.Name = "richtxtResultadoPrueba";
            this.richtxtResultadoPrueba.Size = new System.Drawing.Size(487, 207);
            this.richtxtResultadoPrueba.TabIndex = 68;
            this.richtxtResultadoPrueba.Text = "";
            // 
            // fPruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 852);
            this.Controls.Add(this.richtxtResultadoPrueba);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.listBoxTiposPrueba);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvPruebas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txtIdentidadDoctor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumConsulta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fPruebas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fPruebas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPruebas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label9;
        private Button btnCancelar;
        private ListBox listBoxTiposPrueba;
        private Label label8;
        private DataGridView dgvPruebas;
        private Button btnAgregar;
        private Label label6;
        private MonthCalendar monthCalendar1;
        private TextBox txtIdentidadDoctor;
        private Label label4;
        private Label label2;
        private TextBox txtNumConsulta;
        private Label label1;
        private Label label3;
        private MonthCalendar monthCalendar2;
        private RichTextBox richtxtResultadoPrueba;
    }
}