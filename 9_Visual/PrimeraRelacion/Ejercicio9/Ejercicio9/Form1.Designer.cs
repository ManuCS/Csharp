namespace Ejercicio9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNpalabras = new System.Windows.Forms.Label();
            this.labelNletras = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNespacios = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNvocales = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelNconsonantes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBtexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mitextsoft Vord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Palabras:";
            // 
            // labelNpalabras
            // 
            this.labelNpalabras.AutoSize = true;
            this.labelNpalabras.Location = new System.Drawing.Point(71, 215);
            this.labelNpalabras.Name = "labelNpalabras";
            this.labelNpalabras.Size = new System.Drawing.Size(13, 13);
            this.labelNpalabras.TabIndex = 3;
            this.labelNpalabras.Text = "0";
            // 
            // labelNletras
            // 
            this.labelNletras.AutoSize = true;
            this.labelNletras.Location = new System.Drawing.Point(61, 237);
            this.labelNletras.Name = "labelNletras";
            this.labelNletras.Size = new System.Drawing.Size(13, 13);
            this.labelNletras.TabIndex = 5;
            this.labelNletras.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Letras:";
            // 
            // labelNespacios
            // 
            this.labelNespacios.AutoSize = true;
            this.labelNespacios.Location = new System.Drawing.Point(154, 215);
            this.labelNespacios.Name = "labelNespacios";
            this.labelNespacios.Size = new System.Drawing.Size(13, 13);
            this.labelNespacios.TabIndex = 7;
            this.labelNespacios.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Espacios:";
            // 
            // labelNvocales
            // 
            this.labelNvocales.AutoSize = true;
            this.labelNvocales.Location = new System.Drawing.Point(154, 237);
            this.labelNvocales.Name = "labelNvocales";
            this.labelNvocales.Size = new System.Drawing.Size(13, 13);
            this.labelNvocales.TabIndex = 9;
            this.labelNvocales.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Vocales:";
            // 
            // labelNconsonantes
            // 
            this.labelNconsonantes.AutoSize = true;
            this.labelNconsonantes.Location = new System.Drawing.Point(257, 226);
            this.labelNconsonantes.Name = "labelNconsonantes";
            this.labelNconsonantes.Size = new System.Drawing.Size(13, 13);
            this.labelNconsonantes.TabIndex = 11;
            this.labelNconsonantes.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Consonantes:";
            // 
            // TBtexto
            // 
            this.TBtexto.Location = new System.Drawing.Point(12, 26);
            this.TBtexto.Multiline = true;
            this.TBtexto.Name = "TBtexto";
            this.TBtexto.Size = new System.Drawing.Size(260, 177);
            this.TBtexto.TabIndex = 12;
            this.TBtexto.TextChanged += new System.EventHandler(this.TBtexto_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TBtexto);
            this.Controls.Add(this.labelNconsonantes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelNvocales);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelNespacios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelNletras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNpalabras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNpalabras;
        private System.Windows.Forms.Label labelNletras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNespacios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNvocales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelNconsonantes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBtexto;
    }
}

