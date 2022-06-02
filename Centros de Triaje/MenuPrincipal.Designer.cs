namespace Centros_de_Triaje
{
    partial class MenuPrincipal
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
            this.btnRegistrarPersona = new System.Windows.Forms.Button();
            this.btnRegistrarEmpleado = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRegistrarConsulta = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPruebas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarPersona
            // 
            this.btnRegistrarPersona.Location = new System.Drawing.Point(2, 7);
            this.btnRegistrarPersona.Name = "btnRegistrarPersona";
            this.btnRegistrarPersona.Size = new System.Drawing.Size(341, 73);
            this.btnRegistrarPersona.TabIndex = 0;
            this.btnRegistrarPersona.Text = "REGISTRAR PERSONA";
            this.btnRegistrarPersona.UseVisualStyleBackColor = true;
            this.btnRegistrarPersona.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistrarEmpleado
            // 
            this.btnRegistrarEmpleado.Location = new System.Drawing.Point(3, 229);
            this.btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            this.btnRegistrarEmpleado.Size = new System.Drawing.Size(340, 73);
            this.btnRegistrarEmpleado.TabIndex = 1;
            this.btnRegistrarEmpleado.Text = "REGISTRAR EMPLEADO";
            this.btnRegistrarEmpleado.UseVisualStyleBackColor = true;
            this.btnRegistrarEmpleado.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(2, 377);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(341, 73);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRegistrarConsulta
            // 
            this.btnRegistrarConsulta.Location = new System.Drawing.Point(2, 81);
            this.btnRegistrarConsulta.Name = "btnRegistrarConsulta";
            this.btnRegistrarConsulta.Size = new System.Drawing.Size(341, 73);
            this.btnRegistrarConsulta.TabIndex = 3;
            this.btnRegistrarConsulta.Text = "REGISTRAR CONSULTA";
            this.btnRegistrarConsulta.UseVisualStyleBackColor = true;
            this.btnRegistrarConsulta.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(3, 303);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(340, 73);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnPruebas
            // 
            this.btnPruebas.Location = new System.Drawing.Point(2, 155);
            this.btnPruebas.Name = "btnPruebas";
            this.btnPruebas.Size = new System.Drawing.Size(341, 73);
            this.btnPruebas.TabIndex = 5;
            this.btnPruebas.Text = "REGISTRAR PRUEBA";
            this.btnPruebas.UseVisualStyleBackColor = true;
            this.btnPruebas.Click += new System.EventHandler(this.btnPruebas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Centros_de_Triaje.Properties.Resources.gobhn;
            this.pictureBox1.Location = new System.Drawing.Point(346, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(699, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cerrar sesion";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPruebas);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnRegistrarConsulta);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistrarEmpleado);
            this.Controls.Add(this.btnRegistrarPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegistrarPersona;
        private Button btnRegistrarEmpleado;
        private Button btnCerrar;
        private Button btnRegistrarConsulta;
        private Button btnUsuarios;
        private Button btnPruebas;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
    }
}