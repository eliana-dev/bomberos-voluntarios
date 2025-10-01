namespace ProyectoBomberos2
{
    partial class FormAsistenciaRoperia
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
            this.dgvAsistenciaRoperia = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblRoperia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaRoperia)).BeginInit();
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
            // dgvAsistenciaRoperia
            // 
            this.dgvAsistenciaRoperia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistenciaRoperia.Location = new System.Drawing.Point(28, 111);
            this.dgvAsistenciaRoperia.Name = "dgvAsistenciaRoperia";
            this.dgvAsistenciaRoperia.Size = new System.Drawing.Size(598, 340);
            this.dgvAsistenciaRoperia.TabIndex = 1;
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
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(230, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(165, 25);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Asistencia al Area";
            // 
            // lblRoperia
            // 
            this.lblRoperia.AutoSize = true;
            this.lblRoperia.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoperia.Location = new System.Drawing.Point(282, 53);
            this.lblRoperia.Name = "lblRoperia";
            this.lblRoperia.Size = new System.Drawing.Size(64, 21);
            this.lblRoperia.TabIndex = 6;
            this.lblRoperia.Text = "Roperia";
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
            // FormAsistenciaRoperia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblRoperia);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmbAño);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dgvAsistenciaRoperia);
            this.Controls.Add(this.btnVolverRoperia);
            this.Name = "FormAsistenciaRoperia";
            this.Text = "FormAsistenciaRoperia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaRoperia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverRoperia;
        private System.Windows.Forms.DataGridView dgvAsistenciaRoperia;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblRoperia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAño;
    }
}