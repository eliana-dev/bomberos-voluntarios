namespace ProyectoBomberos2
{
    partial class FormTareasEdificio
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
            this.btnVolverEdificio = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEdificio = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtJerarquia = new System.Windows.Forms.TextBox();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.lblJerarquia = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.chkTareaCompleta = new System.Windows.Forms.CheckBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnFirmar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverEdificio
            // 
            this.btnVolverEdificio.FlatAppearance.BorderSize = 0;
            this.btnVolverEdificio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverEdificio.ForeColor = System.Drawing.Color.Firebrick;
            this.btnVolverEdificio.Location = new System.Drawing.Point(13, 13);
            this.btnVolverEdificio.Name = "btnVolverEdificio";
            this.btnVolverEdificio.Size = new System.Drawing.Size(74, 48);
            this.btnVolverEdificio.TabIndex = 0;
            this.btnVolverEdificio.Text = "←";
            this.btnVolverEdificio.UseVisualStyleBackColor = true;
            this.btnVolverEdificio.Click += new System.EventHandler(this.btnVolverEdificio_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(230, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(147, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Tareas del Area";
            // 
            // lblEdificio
            // 
            this.lblEdificio.AutoSize = true;
            this.lblEdificio.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdificio.Location = new System.Drawing.Point(272, 53);
            this.lblEdificio.Name = "lblEdificio";
            this.lblEdificio.Size = new System.Drawing.Size(60, 21);
            this.lblEdificio.TabIndex = 2;
            this.lblEdificio.Text = "Edificio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 334);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Firebrick;
            this.txtID.Location = new System.Drawing.Point(456, 98);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(168, 23);
            this.txtID.TabIndex = 4;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Firebrick;
            this.txtNombre.Location = new System.Drawing.Point(456, 137);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 23);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.Firebrick;
            this.txtApellido.Location = new System.Drawing.Point(456, 176);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(168, 23);
            this.txtApellido.TabIndex = 6;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(459, 85);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(456, 124);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(453, 163);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido";
            // 
            // txtJerarquia
            // 
            this.txtJerarquia.Enabled = false;
            this.txtJerarquia.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJerarquia.ForeColor = System.Drawing.Color.Firebrick;
            this.txtJerarquia.Location = new System.Drawing.Point(456, 218);
            this.txtJerarquia.Name = "txtJerarquia";
            this.txtJerarquia.Size = new System.Drawing.Size(168, 23);
            this.txtJerarquia.TabIndex = 10;
            this.txtJerarquia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTarea
            // 
            this.txtTarea.Enabled = false;
            this.txtTarea.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarea.ForeColor = System.Drawing.Color.Firebrick;
            this.txtTarea.Location = new System.Drawing.Point(459, 294);
            this.txtTarea.Multiline = true;
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(168, 34);
            this.txtTarea.TabIndex = 11;
            this.txtTarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblJerarquia
            // 
            this.lblJerarquia.AutoSize = true;
            this.lblJerarquia.Location = new System.Drawing.Point(453, 202);
            this.lblJerarquia.Name = "lblJerarquia";
            this.lblJerarquia.Size = new System.Drawing.Size(50, 13);
            this.lblJerarquia.TabIndex = 12;
            this.lblJerarquia.Text = "Jerarquia";
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Location = new System.Drawing.Point(456, 281);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(35, 13);
            this.lblTarea.TabIndex = 13;
            this.lblTarea.Text = "Tarea";
            // 
            // chkTareaCompleta
            // 
            this.chkTareaCompleta.AutoSize = true;
            this.chkTareaCompleta.Location = new System.Drawing.Point(459, 334);
            this.chkTareaCompleta.Name = "chkTareaCompleta";
            this.chkTareaCompleta.Size = new System.Drawing.Size(113, 17);
            this.chkTareaCompleta.TabIndex = 14;
            this.chkTareaCompleta.Text = "Tarea Completada";
            this.chkTareaCompleta.UseVisualStyleBackColor = true;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(459, 354);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(67, 13);
            this.lblObservacion.TabIndex = 15;
            this.lblObservacion.Text = "Observación";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.ForeColor = System.Drawing.Color.Firebrick;
            this.txtObservacion.Location = new System.Drawing.Point(460, 370);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(168, 51);
            this.txtObservacion.TabIndex = 16;
            // 
            // btnFirmar
            // 
            this.btnFirmar.BackColor = System.Drawing.Color.Firebrick;
            this.btnFirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirmar.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirmar.ForeColor = System.Drawing.Color.White;
            this.btnFirmar.Location = new System.Drawing.Point(13, 430);
            this.btnFirmar.Name = "btnFirmar";
            this.btnFirmar.Size = new System.Drawing.Size(439, 23);
            this.btnFirmar.TabIndex = 17;
            this.btnFirmar.Text = "Firmar";
            this.btnFirmar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(462, 430);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Firebrick;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(552, 430);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.Firebrick;
            this.txtFecha.Location = new System.Drawing.Point(456, 255);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(168, 23);
            this.txtFecha.TabIndex = 20;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(456, 244);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 21;
            this.lblFecha.Text = "Fecha";
            // 
            // FormTareasEdificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnFirmar);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.chkTareaCompleta);
            this.Controls.Add(this.lblTarea);
            this.Controls.Add(this.lblJerarquia);
            this.Controls.Add(this.txtTarea);
            this.Controls.Add(this.txtJerarquia);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblEdificio);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVolverEdificio);
            this.Name = "FormTareasEdificio";
            this.Text = "TareasEdificio";
            this.Load += new System.EventHandler(this.TareasEdificio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverEdificio;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEdificio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtJerarquia;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Label lblJerarquia;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.CheckBox chkTareaCompleta;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnFirmar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblFecha;
    }
}