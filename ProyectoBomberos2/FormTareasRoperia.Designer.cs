namespace ProyectoBomberos2
{
    partial class FormTareasRoperia
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
            this.btnVolverRoperia = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblRoperia = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.chkTareaCompleta = new System.Windows.Forms.CheckBox();
            this.lblTarea = new System.Windows.Forms.Label();
            this.lblJerarquia = new System.Windows.Forms.Label();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.txtJerarquia = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnFirmar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverRoperia
            // 
            this.btnVolverRoperia.FlatAppearance.BorderSize = 0;
            this.btnVolverRoperia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverRoperia.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverRoperia.ForeColor = System.Drawing.Color.Firebrick;
            this.btnVolverRoperia.Location = new System.Drawing.Point(13, 13);
            this.btnVolverRoperia.Name = "btnVolverRoperia";
            this.btnVolverRoperia.Size = new System.Drawing.Size(74, 48);
            this.btnVolverRoperia.TabIndex = 0;
            this.btnVolverRoperia.Text = "←";
            this.btnVolverRoperia.UseVisualStyleBackColor = true;
            this.btnVolverRoperia.Click += new System.EventHandler(this.btnVolverRoperia_Click);
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
            // lblRoperia
            // 
            this.lblRoperia.AutoSize = true;
            this.lblRoperia.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoperia.Location = new System.Drawing.Point(272, 53);
            this.lblRoperia.Name = "lblRoperia";
            this.lblRoperia.Size = new System.Drawing.Size(64, 21);
            this.lblRoperia.TabIndex = 2;
            this.lblRoperia.Text = "Roperia";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 334);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(456, 244);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 36;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.Firebrick;
            this.txtFecha.Location = new System.Drawing.Point(456, 255);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(168, 23);
            this.txtFecha.TabIndex = 35;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.ForeColor = System.Drawing.Color.Firebrick;
            this.txtObservacion.Location = new System.Drawing.Point(460, 370);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(168, 51);
            this.txtObservacion.TabIndex = 34;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(459, 354);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(67, 13);
            this.lblObservacion.TabIndex = 33;
            this.lblObservacion.Text = "Observación";
            // 
            // chkTareaCompleta
            // 
            this.chkTareaCompleta.AutoSize = true;
            this.chkTareaCompleta.Location = new System.Drawing.Point(459, 334);
            this.chkTareaCompleta.Name = "chkTareaCompleta";
            this.chkTareaCompleta.Size = new System.Drawing.Size(113, 17);
            this.chkTareaCompleta.TabIndex = 32;
            this.chkTareaCompleta.Text = "Tarea Completada";
            this.chkTareaCompleta.UseVisualStyleBackColor = true;
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Location = new System.Drawing.Point(456, 281);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(35, 13);
            this.lblTarea.TabIndex = 31;
            this.lblTarea.Text = "Tarea";
            // 
            // lblJerarquia
            // 
            this.lblJerarquia.AutoSize = true;
            this.lblJerarquia.Location = new System.Drawing.Point(453, 202);
            this.lblJerarquia.Name = "lblJerarquia";
            this.lblJerarquia.Size = new System.Drawing.Size(50, 13);
            this.lblJerarquia.TabIndex = 30;
            this.lblJerarquia.Text = "Jerarquia";
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
            this.txtTarea.TabIndex = 29;
            this.txtTarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtJerarquia
            // 
            this.txtJerarquia.Enabled = false;
            this.txtJerarquia.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJerarquia.ForeColor = System.Drawing.Color.Firebrick;
            this.txtJerarquia.Location = new System.Drawing.Point(456, 218);
            this.txtJerarquia.Name = "txtJerarquia";
            this.txtJerarquia.Size = new System.Drawing.Size(168, 23);
            this.txtJerarquia.TabIndex = 28;
            this.txtJerarquia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(453, 163);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 27;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(456, 124);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(459, 85);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "ID";
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.Firebrick;
            this.txtApellido.Location = new System.Drawing.Point(456, 176);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(168, 23);
            this.txtApellido.TabIndex = 24;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Firebrick;
            this.txtNombre.Location = new System.Drawing.Point(456, 137);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 23);
            this.txtNombre.TabIndex = 23;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Firebrick;
            this.txtID.Location = new System.Drawing.Point(456, 98);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(168, 23);
            this.txtID.TabIndex = 22;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnFirmar.TabIndex = 37;
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
            this.btnEditar.TabIndex = 38;
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
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // FormTareasRoperia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnFirmar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtFecha);
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
            this.Controls.Add(this.lblRoperia);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVolverRoperia);
            this.Name = "FormTareasRoperia";
            this.Text = "FormTareasRoperia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverRoperia;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblRoperia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.CheckBox chkTareaCompleta;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Label lblJerarquia;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.TextBox txtJerarquia;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnFirmar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
    }
}