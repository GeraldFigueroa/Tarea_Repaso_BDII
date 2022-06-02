namespace Centros_de_Triaje
{
    partial class fConsultas
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
            this.listBoxCentroTriajes = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.monthCalendarConsulta = new System.Windows.Forms.MonthCalendar();
            this.txtIdentidadPersonal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentidadPersona = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendarSintomas = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.richtxtComentarios = new System.Windows.Forms.RichTextBox();
            this.richtxtDiagnostico = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCovid = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 20);
            this.label9.TabIndex = 66;
            this.label9.Text = "Centros de triaje donde fue atendido";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1060, 860);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(167, 51);
            this.btnCancelar.TabIndex = 65;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // listBoxCentroTriajes
            // 
            this.listBoxCentroTriajes.FormattingEnabled = true;
            this.listBoxCentroTriajes.ItemHeight = 20;
            this.listBoxCentroTriajes.Location = new System.Drawing.Point(34, 202);
            this.listBoxCentroTriajes.Name = "listBoxCentroTriajes";
            this.listBoxCentroTriajes.Size = new System.Drawing.Size(332, 104);
            this.listBoxCentroTriajes.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "Listado de personas";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(414, 67);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 29;
            this.dgvEmpleados.Size = new System.Drawing.Size(813, 239);
            this.dgvEmpleados.TabIndex = 61;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(828, 860);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(175, 51);
            this.btnAgregar.TabIndex = 58;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Fecha de la consulta";
            // 
            // monthCalendarConsulta
            // 
            this.monthCalendarConsulta.Location = new System.Drawing.Point(34, 367);
            this.monthCalendarConsulta.MaxSelectionCount = 1;
            this.monthCalendarConsulta.Name = "monthCalendarConsulta";
            this.monthCalendarConsulta.TabIndex = 55;
            // 
            // txtIdentidadPersonal
            // 
            this.txtIdentidadPersonal.Location = new System.Drawing.Point(34, 136);
            this.txtIdentidadPersonal.MaxLength = 15;
            this.txtIdentidadPersonal.Name = "txtIdentidadPersonal";
            this.txtIdentidadPersonal.Size = new System.Drawing.Size(332, 27);
            this.txtIdentidadPersonal.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Numero de identidad del doctor";
            // 
            // txtIdentidadPersona
            // 
            this.txtIdentidadPersona.Location = new System.Drawing.Point(34, 67);
            this.txtIdentidadPersona.MaxLength = 15;
            this.txtIdentidadPersona.Name = "txtIdentidadPersona";
            this.txtIdentidadPersona.Size = new System.Drawing.Size(332, 27);
            this.txtIdentidadPersona.TabIndex = 46;
            this.txtIdentidadPersona.TextChanged += new System.EventHandler(this.txtIdentidadPersona_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Numero de identidad del paciente";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 599);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Fecha de inicio de sintomas";
            // 
            // monthCalendarSintomas
            // 
            this.monthCalendarSintomas.Location = new System.Drawing.Point(34, 628);
            this.monthCalendarSintomas.MaxSelectionCount = 1;
            this.monthCalendarSintomas.Name = "monthCalendarSintomas";
            this.monthCalendarSintomas.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Comentarios adicionales";
            // 
            // richtxtComentarios
            // 
            this.richtxtComentarios.Location = new System.Drawing.Point(379, 367);
            this.richtxtComentarios.Name = "richtxtComentarios";
            this.richtxtComentarios.Size = new System.Drawing.Size(848, 207);
            this.richtxtComentarios.TabIndex = 70;
            this.richtxtComentarios.Text = "";
            // 
            // richtxtDiagnostico
            // 
            this.richtxtDiagnostico.Location = new System.Drawing.Point(379, 628);
            this.richtxtDiagnostico.Name = "richtxtDiagnostico";
            this.richtxtDiagnostico.Size = new System.Drawing.Size(848, 207);
            this.richtxtDiagnostico.TabIndex = 72;
            this.richtxtDiagnostico.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 599);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Diagnostico final";
            // 
            // comboBoxCovid
            // 
            this.comboBoxCovid.FormattingEnabled = true;
            this.comboBoxCovid.Items.AddRange(new object[] {
            "Positivo",
            "Negativo"});
            this.comboBoxCovid.Location = new System.Drawing.Point(34, 883);
            this.comboBoxCovid.Name = "comboBoxCovid";
            this.comboBoxCovid.Size = new System.Drawing.Size(151, 28);
            this.comboBoxCovid.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 860);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "Resultado de COVID";
            // 
            // fConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 953);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxCovid);
            this.Controls.Add(this.richtxtDiagnostico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richtxtComentarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendarSintomas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.listBoxCentroTriajes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monthCalendarConsulta);
            this.Controls.Add(this.txtIdentidadPersonal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdentidadPersona);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label9;
        private Button btnCancelar;
        private ListBox listBoxCentroTriajes;
        private Label label8;
        private DataGridView dgvEmpleados;
        private Button btnAgregar;
        private Label label6;
        private MonthCalendar monthCalendarConsulta;
        private TextBox txtIdentidadPersonal;
        private Label label2;
        private TextBox txtIdentidadPersona;
        private Label label1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private Label label3;
        private MonthCalendar monthCalendarSintomas;
        private Label label4;
        private RichTextBox richtxtComentarios;
        private RichTextBox richtxtDiagnostico;
        private Label label5;
        private ComboBox comboBoxCovid;
        private Label label7;
    }
}