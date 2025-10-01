namespace ProyectoBomberos2
{
    partial class FormAsistenciaCapacit
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
            this.btnVolverCapacit = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCapacitacion = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvAsistenciaCapacit = new System.Windows.Forms.DataGridView();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaCapacit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverCapacit
            // 
            this.btnVolverCapacit.FlatAppearance.BorderSize = 0;
            this.btnVolverCapacit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverCapacit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCapacit.ForeColor = System.Drawing.Color.Firebrick;
            this.btnVolverCapacit.Location = new System.Drawing.Point(13, 13);
            this.btnVolverCapacit.Name = "btnVolverCapacit";
            this.btnVolverCapacit.Size = new System.Drawing.Size(74, 48);
            this.btnVolverCapacit.TabIndex = 0;
            this.btnVolverCapacit.Text = "←";
            this.btnVolverCapacit.UseVisualStyleBackColor = true;
            this.btnVolverCapacit.Click += new System.EventHandler(this.btnVolverCapacit_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(230, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(165, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Asistencia al Area";
            // 
            // lblCapacitacion
            // 
            this.lblCapacitacion.AutoSize = true;
            this.lblCapacitacion.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacitacion.Location = new System.Drawing.Point(264, 53);
            this.lblCapacitacion.Name = "lblCapacitacion";
            this.lblCapacitacion.Size = new System.Drawing.Size(98, 21);
            this.lblCapacitacion.TabIndex = 2;
            this.lblCapacitacion.Text = "Capacitación";
            // 
            // cmbMes
            // 
            this.cmbMes.ForeColor = System.Drawing.Color.Firebrick;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(159, 84);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 3;
            // 
            // cmbAño
            // 
            this.cmbAño.ForeColor = System.Drawing.Color.Firebrick;
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(332, 84);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(81, 21);
            this.cmbAño.TabIndex = 4;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Firebrick;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(438, 82);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // dgvAsistenciaCapacit
            // 
            this.dgvAsistenciaCapacit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistenciaCapacit.Location = new System.Drawing.Point(28, 111);
            this.dgvAsistenciaCapacit.Name = "dgvAsistenciaCapacit";
            this.dgvAsistenciaCapacit.Size = new System.Drawing.Size(598, 340);
            this.dgvAsistenciaCapacit.TabIndex = 6;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(124, 87);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(29, 15);
            this.lblMes.TabIndex = 7;
            this.lblMes.Text = "Mes";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(297, 87);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 15);
            this.lblAño.TabIndex = 8;
            this.lblAño.Text = "Año";
            // 
            // FormAsistenciaCapacit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.dgvAsistenciaCapacit);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cmbAño);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.lblCapacitacion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVolverCapacit);
            this.Name = "FormAsistenciaCapacit";
            this.Text = "FormAsistenciaCapacit";
            this.Load += new System.EventHandler(this.FormAsistenciaCapacit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaCapacit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverCapacit;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCapacitacion;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvAsistenciaCapacit;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAño;
    }
}