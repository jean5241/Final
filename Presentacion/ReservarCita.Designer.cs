namespace Presentacion
{
    partial class ReservarCita
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
            this.dataGridViewCitas = new System.Windows.Forms.DataGridView();
            this.comboBoxNombreCentro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCitas = new System.Windows.Forms.Button();
            this.buttonReservarCita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCitas
            // 
            this.dataGridViewCitas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dataGridViewCitas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCitas.Location = new System.Drawing.Point(20, 132);
            this.dataGridViewCitas.Name = "dataGridViewCitas";
            this.dataGridViewCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCitas.Size = new System.Drawing.Size(548, 150);
            this.dataGridViewCitas.TabIndex = 0;
            this.dataGridViewCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBoxNombreCentro
            // 
            this.comboBoxNombreCentro.FormattingEnabled = true;
            this.comboBoxNombreCentro.Location = new System.Drawing.Point(229, 55);
            this.comboBoxNombreCentro.Name = "comboBoxNombreCentro";
            this.comboBoxNombreCentro.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNombreCentro.TabIndex = 1;
            this.comboBoxNombreCentro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NombreCentroMedico";
            // 
            // buttonCitas
            // 
            this.buttonCitas.Location = new System.Drawing.Point(243, 91);
            this.buttonCitas.Name = "buttonCitas";
            this.buttonCitas.Size = new System.Drawing.Size(97, 23);
            this.buttonCitas.TabIndex = 3;
            this.buttonCitas.Text = "Mostrar citas ";
            this.buttonCitas.UseVisualStyleBackColor = true;
            this.buttonCitas.Click += new System.EventHandler(this.buttonCitas_Click);
            // 
            // buttonReservarCita
            // 
            this.buttonReservarCita.Location = new System.Drawing.Point(243, 302);
            this.buttonReservarCita.Name = "buttonReservarCita";
            this.buttonReservarCita.Size = new System.Drawing.Size(97, 23);
            this.buttonReservarCita.TabIndex = 4;
            this.buttonReservarCita.Text = "Reservar cita";
            this.buttonReservarCita.UseVisualStyleBackColor = true;
            this.buttonReservarCita.Click += new System.EventHandler(this.buttonReservarCita_Click);
            // 
            // ReservarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(595, 376);
            this.Controls.Add(this.buttonReservarCita);
            this.Controls.Add(this.buttonCitas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNombreCentro);
            this.Controls.Add(this.dataGridViewCitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservarCita";
            this.Text = "ReservarCita";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCitas;
        private System.Windows.Forms.ComboBox comboBoxNombreCentro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCitas;
        private System.Windows.Forms.Button buttonReservarCita;
    }
}