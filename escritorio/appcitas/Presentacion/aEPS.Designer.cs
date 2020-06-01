namespace Presentacion
{
    partial class aEPS
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
            this.button1BUSCAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cedula = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.DGbuscar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGbuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1BUSCAR
            // 
            this.button1BUSCAR.Location = new System.Drawing.Point(252, 287);
            this.button1BUSCAR.Name = "button1BUSCAR";
            this.button1BUSCAR.Size = new System.Drawing.Size(75, 23);
            this.button1BUSCAR.TabIndex = 10;
            this.button1BUSCAR.Text = "BUSCAR";
            this.button1BUSCAR.UseVisualStyleBackColor = true;
            this.button1BUSCAR.Click += new System.EventHandler(this.button1BUSCAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(237, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "BUSCAR PACIENTE";
            // 
            // Cedula
            // 
            this.Cedula.AutoSize = true;
            this.Cedula.ForeColor = System.Drawing.Color.LightYellow;
            this.Cedula.Location = new System.Drawing.Point(160, 104);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(50, 13);
            this.Cedula.TabIndex = 8;
            this.Cedula.Text = "CEDULA";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(240, 97);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(100, 20);
            this.textBuscar.TabIndex = 7;
            // 
            // DGbuscar
            // 
            this.DGbuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.DGbuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGbuscar.Location = new System.Drawing.Point(118, 149);
            this.DGbuscar.Name = "DGbuscar";
            this.DGbuscar.Size = new System.Drawing.Size(363, 117);
            this.DGbuscar.TabIndex = 6;
            // 
            // aEPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(595, 376);
            this.Controls.Add(this.button1BUSCAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cedula);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.DGbuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "aEPS";
            this.Text = "aEPS";
            ((System.ComponentModel.ISupportInitialize)(this.DGbuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1BUSCAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cedula;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.DataGridView DGbuscar;
    }
}