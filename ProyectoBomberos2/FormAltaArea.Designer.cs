namespace ProyectoBomberos2
{
    partial class FormAltaArea
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
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDarAlta = new System.Windows.Forms.Label();
            this.gpbDatosPers = new System.Windows.Forms.GroupBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gpbDatosInsti = new System.Windows.Forms.GroupBox();
            this.lblJerarquia = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbJerarquia = new System.Windows.Forms.ComboBox();
            this.cmbAreas = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gpbDatosPers.SuspendLayout();
            this.gpbDatosInsti.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.FlatAppearance.BorderSize = 0;
            this.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministracion.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAdministracion.Location = new System.Drawing.Point(33, 12);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Size = new System.Drawing.Size(74, 48);
            this.btnAdministracion.TabIndex = 0;
            this.btnAdministracion.Text = "←";
            this.btnAdministracion.UseVisualStyleBackColor = true;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(230, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Bomberos Voluntarios";
            // 
            // lblDarAlta
            // 
            this.lblDarAlta.AutoSize = true;
            this.lblDarAlta.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDarAlta.Location = new System.Drawing.Point(268, 53);
            this.lblDarAlta.Name = "lblDarAlta";
            this.lblDarAlta.Size = new System.Drawing.Size(123, 21);
            this.lblDarAlta.TabIndex = 2;
            this.lblDarAlta.Text = "Alta de Usuarios";
            // 
            // gpbDatosPers
            // 
            this.gpbDatosPers.Controls.Add(this.lblApellido);
            this.gpbDatosPers.Controls.Add(this.lblNombre);
            this.gpbDatosPers.Controls.Add(this.txtApellido);
            this.gpbDatosPers.Controls.Add(this.txtNombre);
            this.gpbDatosPers.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatosPers.ForeColor = System.Drawing.Color.Firebrick;
            this.gpbDatosPers.Location = new System.Drawing.Point(105, 110);
            this.gpbDatosPers.Name = "gpbDatosPers";
            this.gpbDatosPers.Size = new System.Drawing.Size(450, 135);
            this.gpbDatosPers.TabIndex = 3;
            this.gpbDatosPers.TabStop = false;
            this.gpbDatosPers.Text = "Datos Personales";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.ForeColor = System.Drawing.Color.Black;
            this.lblApellido.Location = new System.Drawing.Point(245, 36);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(19, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(248, 54);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(159, 27);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 54);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 27);
            this.txtNombre.TabIndex = 0;
            // 
            // gpbDatosInsti
            // 
            this.gpbDatosInsti.Controls.Add(this.lblJerarquia);
            this.gpbDatosInsti.Controls.Add(this.lblArea);
            this.gpbDatosInsti.Controls.Add(this.cmbJerarquia);
            this.gpbDatosInsti.Controls.Add(this.cmbAreas);
            this.gpbDatosInsti.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatosInsti.ForeColor = System.Drawing.Color.Firebrick;
            this.gpbDatosInsti.Location = new System.Drawing.Point(105, 280);
            this.gpbDatosInsti.Name = "gpbDatosInsti";
            this.gpbDatosInsti.Size = new System.Drawing.Size(450, 134);
            this.gpbDatosInsti.TabIndex = 4;
            this.gpbDatosInsti.TabStop = false;
            this.gpbDatosInsti.Text = "Datos de Institución";
            // 
            // lblJerarquia
            // 
            this.lblJerarquia.AutoSize = true;
            this.lblJerarquia.ForeColor = System.Drawing.Color.Black;
            this.lblJerarquia.Location = new System.Drawing.Point(245, 45);
            this.lblJerarquia.Name = "lblJerarquia";
            this.lblJerarquia.Size = new System.Drawing.Size(54, 15);
            this.lblJerarquia.TabIndex = 3;
            this.lblJerarquia.Text = "Jerarquia";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.ForeColor = System.Drawing.Color.Black;
            this.lblArea.Location = new System.Drawing.Point(22, 45);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(31, 15);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area";
            // 
            // cmbJerarquia
            // 
            this.cmbJerarquia.FormattingEnabled = true;
            this.cmbJerarquia.Items.AddRange(new object[] {
            "Bombero",
            "SubOficial"});
            this.cmbJerarquia.Location = new System.Drawing.Point(248, 63);
            this.cmbJerarquia.Name = "cmbJerarquia";
            this.cmbJerarquia.Size = new System.Drawing.Size(159, 23);
            this.cmbJerarquia.TabIndex = 1;
            // 
            // cmbAreas
            // 
            this.cmbAreas.FormattingEnabled = true;
            this.cmbAreas.Items.AddRange(new object[] {
            "Edificio",
            "Taller",
            "Furrieles",
            "Roperia",
            "Automotores",
            "Capacitación"});
            this.cmbAreas.Location = new System.Drawing.Point(25, 63);
            this.cmbAreas.Name = "cmbAreas";
            this.cmbAreas.Size = new System.Drawing.Size(159, 23);
            this.cmbAreas.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Firebrick;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(249, 420);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(169, 36);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FormAltaArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gpbDatosInsti);
            this.Controls.Add(this.gpbDatosPers);
            this.Controls.Add(this.lblDarAlta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAdministracion);
            this.Name = "FormAltaArea";
            this.Text = "Alta de Area";
            this.gpbDatosPers.ResumeLayout(false);
            this.gpbDatosPers.PerformLayout();
            this.gpbDatosInsti.ResumeLayout(false);
            this.gpbDatosInsti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDarAlta;
        private System.Windows.Forms.GroupBox gpbDatosPers;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gpbDatosInsti;
        private System.Windows.Forms.Label lblJerarquia;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbJerarquia;
        private System.Windows.Forms.ComboBox cmbAreas;
        private System.Windows.Forms.Button btnRegistrar;
    }
}