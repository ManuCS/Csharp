namespace Ejercicio3
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
            this.TBoperador2 = new System.Windows.Forms.TextBox();
            this.TBresultado = new System.Windows.Forms.TextBox();
            this.TBoperador1 = new System.Windows.Forms.TextBox();
            this.BTsuma = new System.Windows.Forms.Button();
            this.BTresta = new System.Windows.Forms.Button();
            this.BTmulti = new System.Windows.Forms.Button();
            this.BTdivi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lsimbolo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBoperador2
            // 
            this.TBoperador2.Location = new System.Drawing.Point(95, 94);
            this.TBoperador2.Name = "TBoperador2";
            this.TBoperador2.Size = new System.Drawing.Size(100, 20);
            this.TBoperador2.TabIndex = 0;
            // 
            // TBresultado
            // 
            this.TBresultado.Enabled = false;
            this.TBresultado.Location = new System.Drawing.Point(95, 164);
            this.TBresultado.Name = "TBresultado";
            this.TBresultado.Size = new System.Drawing.Size(100, 20);
            this.TBresultado.TabIndex = 1;
            // 
            // TBoperador1
            // 
            this.TBoperador1.Location = new System.Drawing.Point(95, 42);
            this.TBoperador1.Name = "TBoperador1";
            this.TBoperador1.Size = new System.Drawing.Size(100, 20);
            this.TBoperador1.TabIndex = 2;
            // 
            // BTsuma
            // 
            this.BTsuma.Location = new System.Drawing.Point(215, 84);
            this.BTsuma.Name = "BTsuma";
            this.BTsuma.Size = new System.Drawing.Size(30, 74);
            this.BTsuma.TabIndex = 3;
            this.BTsuma.Text = "+";
            this.BTsuma.UseVisualStyleBackColor = true;
            this.BTsuma.Click += new System.EventHandler(this.BTsuma_Click);
            // 
            // BTresta
            // 
            this.BTresta.Location = new System.Drawing.Point(251, 84);
            this.BTresta.Name = "BTresta";
            this.BTresta.Size = new System.Drawing.Size(30, 74);
            this.BTresta.TabIndex = 4;
            this.BTresta.Text = "-";
            this.BTresta.UseVisualStyleBackColor = true;
            this.BTresta.Click += new System.EventHandler(this.BTresta_Click);
            // 
            // BTmulti
            // 
            this.BTmulti.Location = new System.Drawing.Point(251, 164);
            this.BTmulti.Name = "BTmulti";
            this.BTmulti.Size = new System.Drawing.Size(30, 74);
            this.BTmulti.TabIndex = 5;
            this.BTmulti.Text = "*";
            this.BTmulti.UseVisualStyleBackColor = true;
            this.BTmulti.Click += new System.EventHandler(this.BTmulti_Click);
            // 
            // BTdivi
            // 
            this.BTdivi.Location = new System.Drawing.Point(215, 164);
            this.BTdivi.Name = "BTdivi";
            this.BTdivi.Size = new System.Drawing.Size(30, 74);
            this.BTdivi.TabIndex = 6;
            this.BTdivi.Text = "/";
            this.BTdivi.UseVisualStyleBackColor = true;
            this.BTdivi.Click += new System.EventHandler(this.BTdivi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Operador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Operador 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "========";
            // 
            // Lsimbolo
            // 
            this.Lsimbolo.AutoSize = true;
            this.Lsimbolo.Location = new System.Drawing.Point(139, 68);
            this.Lsimbolo.Name = "Lsimbolo";
            this.Lsimbolo.Size = new System.Drawing.Size(12, 13);
            this.Lsimbolo.TabIndex = 11;
            this.Lsimbolo.Text = "s";
            this.Lsimbolo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Lsimbolo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTdivi);
            this.Controls.Add(this.BTmulti);
            this.Controls.Add(this.BTresta);
            this.Controls.Add(this.BTsuma);
            this.Controls.Add(this.TBoperador1);
            this.Controls.Add(this.TBresultado);
            this.Controls.Add(this.TBoperador2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBoperador2;
        private System.Windows.Forms.TextBox TBresultado;
        private System.Windows.Forms.TextBox TBoperador1;
        private System.Windows.Forms.Button BTsuma;
        private System.Windows.Forms.Button BTresta;
        private System.Windows.Forms.Button BTmulti;
        private System.Windows.Forms.Button BTdivi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lsimbolo;
    }
}

