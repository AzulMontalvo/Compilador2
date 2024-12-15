namespace Compilador2
{
    partial class Compilador
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
            this.txtBoxOutputL = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.txtBoxOutputSint = new System.Windows.Forms.TextBox();
            this.txtBoxOutputSem = new System.Windows.Forms.TextBox();
            this.txtBoxCI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxOutputL
            // 
            this.txtBoxOutputL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBoxOutputL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOutputL.Location = new System.Drawing.Point(406, 133);
            this.txtBoxOutputL.Multiline = true;
            this.txtBoxOutputL.Name = "txtBoxOutputL";
            this.txtBoxOutputL.ReadOnly = true;
            this.txtBoxOutputL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxOutputL.Size = new System.Drawing.Size(353, 337);
            this.txtBoxOutputL.TabIndex = 0;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.AutoEllipsis = true;
            this.btnAnalyze.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyze.Font = new System.Drawing.Font("Gabarito", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyze.ForeColor = System.Drawing.Color.White;
            this.btnAnalyze.Location = new System.Drawing.Point(496, 633);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(161, 61);
            this.btnAnalyze.TabIndex = 1;
            this.btnAnalyze.Text = "Ejecutar";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxInput.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInput.Location = new System.Drawing.Point(32, 133);
            this.txtBoxInput.Multiline = true;
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxInput.Size = new System.Drawing.Size(353, 337);
            this.txtBoxInput.TabIndex = 2;
            // 
            // txtBoxOutputSint
            // 
            this.txtBoxOutputSint.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBoxOutputSint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOutputSint.Location = new System.Drawing.Point(32, 524);
            this.txtBoxOutputSint.Multiline = true;
            this.txtBoxOutputSint.Name = "txtBoxOutputSint";
            this.txtBoxOutputSint.ReadOnly = true;
            this.txtBoxOutputSint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxOutputSint.Size = new System.Drawing.Size(538, 83);
            this.txtBoxOutputSint.TabIndex = 3;
            // 
            // txtBoxOutputSem
            // 
            this.txtBoxOutputSem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBoxOutputSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOutputSem.Location = new System.Drawing.Point(600, 524);
            this.txtBoxOutputSem.Multiline = true;
            this.txtBoxOutputSem.Name = "txtBoxOutputSem";
            this.txtBoxOutputSem.ReadOnly = true;
            this.txtBoxOutputSem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxOutputSem.Size = new System.Drawing.Size(538, 83);
            this.txtBoxOutputSem.TabIndex = 4;
            // 
            // txtBoxCI
            // 
            this.txtBoxCI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxCI.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCI.Location = new System.Drawing.Point(785, 133);
            this.txtBoxCI.Multiline = true;
            this.txtBoxCI.Name = "txtBoxCI";
            this.txtBoxCI.ReadOnly = true;
            this.txtBoxCI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxCI.Size = new System.Drawing.Size(353, 337);
            this.txtBoxCI.TabIndex = 5;
            this.txtBoxCI.TextChanged += new System.EventHandler(this.txtBoxCI_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabarito", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 87);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chaotic Compiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabarito", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código Fuente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabarito", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Análisis Léxico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gabarito", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(794, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Generación de código intermedio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gabarito", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Análisis Sintáctico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gabarito", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(614, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Análisis Semántico";
            // 
            // Compilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 730);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxCI);
            this.Controls.Add(this.txtBoxOutputSem);
            this.Controls.Add(this.txtBoxOutputSint);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.txtBoxOutputL);
            this.Name = "Compilador";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxOutputL;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.TextBox txtBoxOutputSint;
        private System.Windows.Forms.TextBox txtBoxOutputSem;
        private System.Windows.Forms.TextBox txtBoxCI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

