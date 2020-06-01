namespace Presentacion
{
    partial class eCENTRO
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
            this.buttonE.Location = new System.Drawing.Point(267, 271);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(75, 23);
            this.buttonE.TabIndex = 17;
            this.buttonE.Text = "Eliminar";
            this.buttonE.UseVisualStyleBackColor = false;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // labelCE
            // 
            this.labelCE.AutoSize = true;
            this.labelCE.ForeColor = System.Drawing.Color.LightYellow;
            this.labelCE.Location = new System.Drawing.Point(186, 226);
            this.labelCE.Name = "labelCE";
            this.labelCE.Size = new System.Drawing.Size(40, 13);
            this.labelCE.TabIndex = 16;
            this.labelCE.Text = "Cedula";
            // 
            // labelEM
            // 
            this.labelEM.AutoSize = true;
            this.labelEM.ForeColor = System.Drawing.Color.LightYellow;
            this.labelEM.Location = new System.Drawing.Point(261, 185);
            this.labelEM.Name = "labelEM";
            this.labelEM.Size = new System.Drawing.Size(81, 13);
            this.labelEM.TabIndex = 15;
            this.labelEM.Text = "Eliminar Medico";
            // 
            // textCedulaE
            // 
            this.textCedulaE.Location = new System.Drawing.Point(252, 223);
            this.textCedulaE.Name = "textCedulaE";
            this.textCedulaE.Size = new System.Drawing.Size(100, 20);
            this.textCedulaE.TabIndex = 14;
            // 
            // eCENTRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(633, 485);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.labelCE);
            this.Controls.Add(this.labelEM);
            this.Controls.Add(this.textCedulaE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "eCENTRO";
            this.Text = "eCENTRO";
            this.Load += new System.EventHandler(this.eCENTRO_Load);
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