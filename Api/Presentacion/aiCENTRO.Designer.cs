namespace Presentacion
{
    partial class aiCENTRO
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
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textAPELLIDO = new System.Windows.Forms.TextBox();
            this.textCEDULA = new System.Windows.Forms.TextBox();
            this.textNOMBRE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonInsert.Location = new System.Drawing.Point(276, 286);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "ACEPTAR";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textAPELLIDO
            // 
            this.textAPELLIDO.Location = new System.Drawing.Point(276, 202);
            this.textAPELLIDO.Name = "textAPELLIDO";
            this.textAPELLIDO.Size = new System.Drawing.Size(100, 20);
            this.textAPELLIDO.TabIndex = 1;
            this.textAPELLIDO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAPELLIDO_KeyPress);
            // 
            // textCEDULA
            // 
            this.textCEDULA.Location = new System.Drawing.Point(276, 236);
            this.textCEDULA.Name = "textCEDULA";
            this.textCEDULA.Size = new System.Drawing.Size(100, 20);
            this.textCEDULA.TabIndex = 2;
            // 
            // textNOMBRE
            // 
            this.textNOMBRE.Location = new System.Drawing.Point(276, 167);
            this.textNOMBRE.Name = "textNOMBRE";
            this.textNOMBRE.Size = new System.Drawing.Size(100, 20);
            this.textNOMBRE.TabIndex = 3;
            this.textNOMBRE.TextChanged += new System.EventHandler(this.textNOMBRE_TextChanged);
            this.textNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNOMBRE_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(233, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ACTUALIZAR O INSERTAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.LightYellow;
            this.label4.Location = new System.Drawing.Point(164, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cedula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.LightYellow;
            this.label5.Location = new System.Drawing.Point(164, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.LightYellow;
            this.label7.Location = new System.Drawing.Point(164, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nombre";
            // 
            // aiCENTRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(633, 485);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNOMBRE);
            this.Controls.Add(this.textCEDULA);
            this.Controls.Add(this.textAPELLIDO);
            this.Controls.Add(this.buttonInsert);
            this.ForeColor = System.Drawing.Color.LightYellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "aiCENTRO";
            this.Text = "aiCENTRO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textAPELLIDO;
        private System.Windows.Forms.TextBox textCEDULA;
        private System.Windows.Forms.TextBox textNOMBRE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}