namespace Presentacion
{
    partial class eEPS
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
            this.buttonE = new System.Windows.Forms.Button();
            this.labelCE = new System.Windows.Forms.Label();
            this.labelEM = new System.Windows.Forms.Label();
            this.textCedulaE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.Gray;
            this.buttonE.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonE.Location = new System.Drawing.Point(281, 216);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(75, 23);
            this.buttonE.TabIndex = 12;
            this.buttonE.Text = "Eliminar";
            this.buttonE.UseVisualStyleBackColor = false;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // labelCE
            // 
            this.labelCE.AutoSize = true;
            this.labelCE.ForeColor = System.Drawing.Color.LightYellow;
            this.labelCE.Location = new System.Drawing.Point(210, 171);
            this.labelCE.Name = "labelCE";
            this.labelCE.Size = new System.Drawing.Size(40, 13);
            this.labelCE.TabIndex = 11;
            this.labelCE.Text = "Cedula";
            // 
            // labelEM
            // 
            this.labelEM.AutoSize = true;
            this.labelEM.ForeColor = System.Drawing.Color.LightYellow;
            this.labelEM.Location = new System.Drawing.Point(255, 130);
            this.labelEM.Name = "labelEM";
            this.labelEM.Size = new System.Drawing.Size(88, 13);
            this.labelEM.TabIndex = 10;
            this.labelEM.Text = "Eliminar Paciente";
            // 
            // textCedulaE
            // 
            this.textCedulaE.Location = new System.Drawing.Point(272, 168);
            this.textCedulaE.Name = "textCedulaE";
            this.textCedulaE.Size = new System.Drawing.Size(100, 20);
            this.textCedulaE.TabIndex = 9;
            // 
            // eEPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(595, 376);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.labelCE);
            this.Controls.Add(this.labelEM);
            this.Controls.Add(this.textCedulaE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "eEPS";
            this.Text = "eEPS";
            this.Load += new System.EventHandler(this.eEPS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Label labelCE;
        private System.Windows.Forms.Label labelEM;
        private System.Windows.Forms.TextBox textCedulaE;
    }
}