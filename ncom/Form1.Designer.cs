namespace ncom
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.butSuma = new System.Windows.Forms.Button();
            this.butResta = new System.Windows.Forms.Button();
            this.butMultiplic = new System.Windows.Forms.Button();
            this.butDivision = new System.Windows.Forms.Button();
            this.butPolar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butBinomic = new System.Windows.Forms.Button();
            this.lblPolar = new System.Windows.Forms.Label();
            this.lblResul = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtEntrada2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butSuma
            // 
            this.butSuma.Location = new System.Drawing.Point(43, 206);
            this.butSuma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butSuma.Name = "butSuma";
            this.butSuma.Size = new System.Drawing.Size(110, 60);
            this.butSuma.TabIndex = 0;
            this.butSuma.Text = "+";
            this.butSuma.UseVisualStyleBackColor = true;
            this.butSuma.Click += new System.EventHandler(this.ButSuma_Click);
            // 
            // butResta
            // 
            this.butResta.Location = new System.Drawing.Point(189, 206);
            this.butResta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butResta.Name = "butResta";
            this.butResta.Size = new System.Drawing.Size(114, 62);
            this.butResta.TabIndex = 1;
            this.butResta.Text = "-";
            this.butResta.UseVisualStyleBackColor = true;
            this.butResta.Click += new System.EventHandler(this.ButResta_Click);
            // 
            // butMultiplic
            // 
            this.butMultiplic.Location = new System.Drawing.Point(43, 296);
            this.butMultiplic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butMultiplic.Name = "butMultiplic";
            this.butMultiplic.Size = new System.Drawing.Size(110, 68);
            this.butMultiplic.TabIndex = 2;
            this.butMultiplic.Text = "X";
            this.butMultiplic.UseVisualStyleBackColor = true;
            this.butMultiplic.Click += new System.EventHandler(this.ButMultiplic_Click);
            // 
            // butDivision
            // 
            this.butDivision.Location = new System.Drawing.Point(189, 296);
            this.butDivision.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butDivision.Name = "butDivision";
            this.butDivision.Size = new System.Drawing.Size(114, 71);
            this.butDivision.TabIndex = 3;
            this.butDivision.Text = "/";
            this.butDivision.UseVisualStyleBackColor = true;
            this.butDivision.Click += new System.EventHandler(this.ButDivision_Click);
            // 
            // butPolar
            // 
            this.butPolar.Location = new System.Drawing.Point(311, 54);
            this.butPolar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butPolar.Name = "butPolar";
            this.butPolar.Size = new System.Drawing.Size(172, 55);
            this.butPolar.TabIndex = 4;
            this.butPolar.Text = "Pasar Num A a forma polar";
            this.butPolar.UseVisualStyleBackColor = true;
            this.butPolar.Click += new System.EventHandler(this.butPolar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero B";
            // 
            // butBinomic
            // 
            this.butBinomic.Location = new System.Drawing.Point(501, 53);
            this.butBinomic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butBinomic.Name = "butBinomic";
            this.butBinomic.Size = new System.Drawing.Size(172, 56);
            this.butBinomic.TabIndex = 10;
            this.butBinomic.Text = "Pasar Num A a forma binomica";
            this.butBinomic.UseVisualStyleBackColor = true;
            this.butBinomic.Click += new System.EventHandler(this.ButBinomic_Click);
            // 
            // lblPolar
            // 
            this.lblPolar.AutoSize = true;
            this.lblPolar.Location = new System.Drawing.Point(712, 71);
            this.lblPolar.Name = "lblPolar";
            this.lblPolar.Size = new System.Drawing.Size(134, 20);
            this.lblPolar.TabIndex = 11;
            this.lblPolar.Text = "Cambio de forma!";
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Location = new System.Drawing.Point(54, 425);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(86, 20);
            this.lblResul.TabIndex = 15;
            this.lblResul.Text = "Resultado!";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(130, 71);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(149, 26);
            this.txtEntrada.TabIndex = 16;
            // 
            // txtEntrada2
            // 
            this.txtEntrada2.Location = new System.Drawing.Point(130, 122);
            this.txtEntrada2.Name = "txtEntrada2";
            this.txtEntrada2.Size = new System.Drawing.Size(149, 26);
            this.txtEntrada2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 880);
            this.Controls.Add(this.txtEntrada2);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.lblPolar);
            this.Controls.Add(this.butBinomic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butPolar);
            this.Controls.Add(this.butDivision);
            this.Controls.Add(this.butMultiplic);
            this.Controls.Add(this.butResta);
            this.Controls.Add(this.butSuma);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSuma;
        private System.Windows.Forms.Button butResta;
        private System.Windows.Forms.Button butMultiplic;
        private System.Windows.Forms.Button butDivision;
        private System.Windows.Forms.Button butPolar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butBinomic;
        private System.Windows.Forms.Label lblPolar;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtEntrada2;
    }
}

