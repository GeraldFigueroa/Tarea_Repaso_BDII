namespace Centros_de_Triaje
{
    partial class fUsuarios
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
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtConfContra = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentidadEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDusuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxNivel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(44, 331);
            this.txtContrasenia.MaxLength = 50;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(332, 27);
            this.txtContrasenia.TabIndex = 39;
            // 
            // txtConfContra
            // 
            this.txtConfContra.Location = new System.Drawing.Point(44, 417);
            this.txtConfContra.MaxLength = 50;
            this.txtConfContra.Name = "txtConfContra";
            this.txtConfContra.Size = new System.Drawing.Size(332, 27);
            this.txtConfContra.TabIndex = 38;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(44, 249);
            this.txtNombreUsuario.MaxLength = 20;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(239, 27);
            this.txtNombreUsuario.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Confirmar contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombre del usuario";
            // 
            // txtIdentidadEmpleado
            // 
            this.txtIdentidadEmpleado.Location = new System.Drawing.Point(44, 164);
            this.txtIdentidadEmpleado.MaxLength = 15;
            this.txtIdentidadEmpleado.Name = "txtIdentidadEmpleado";
            this.txtIdentidadEmpleado.Size = new System.Drawing.Size(332, 27);
            this.txtIdentidadEmpleado.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Numero de identidad del empleado";
            // 
            // txtIDusuario
            // 
            this.txtIDusuario.Location = new System.Drawing.Point(44, 78);
            this.txtIDusuario.MaxLength = 5;
            this.txtIDusuario.Name = "txtIDusuario";
            this.txtIDusuario.Size = new System.Drawing.Size(126, 27);
            this.txtIDusuario.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "ID para el usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Nivel de acceso";
            // 
            // comboBoxNivel
            // 
            this.comboBoxNivel.FormattingEnabled = true;
            this.comboBoxNivel.Items.AddRange(new object[] {
            "Basico",
            "Administrador"});
            this.comboBoxNivel.Location = new System.Drawing.Point(44, 513);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(151, 28);
            this.comboBoxNivel.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "Listado de usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(476, 78);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 29;
            this.dgvUsuarios.Size = new System.Drawing.Size(588, 179);
            this.dgvUsuarios.TabIndex = 63;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(897, 513);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(167, 51);
            this.btnCancelar.TabIndex = 67;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(665, 513);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(175, 51);
            this.btnAgregar.TabIndex = 66;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 69;
            this.label7.Text = "Listado de empleados";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(476, 301);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 29;
            this.dgvEmpleados.Size = new System.Drawing.Size(588, 179);
            this.dgvEmpleados.TabIndex = 68;
            // 
            // fUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 592);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.comboBoxNivel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIDusuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtConfContra);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdentidadEmpleado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtContrasenia;
        private TextBox txtConfContra;
        private TextBox txtNombreUsuario;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtIdentidadEmpleado;
        private Label label1;
        private TextBox txtIDusuario;
        private Label label6;
        private Label label5;
        private ComboBox comboBoxNivel;
        private Label label8;
        private DataGridView dgvUsuarios;
        private Button btnCancelar;
        private Button btnAgregar;
        private Label label7;
        private DataGridView dgvEmpleados;
    }
}