namespace _5ConversorPulgadas
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
            this.TBcentimetros = new System.Windows.Forms.TextBox();
            this.TBpulgadas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBcentimetros
            // 
            this.TBcentimetros.Location = new System.Drawing.Point(94, 71);
            this.TBcentimetros.Name = "TBcentimetros";
            this.TBcentimetros.Size = new System.Drawing.Size(100, 20);
            this.TBcentimetros.TabIndex = 0;
            this.TBcentimetros.TextChanged += new System.EventHandler(this.TBcentimetros_TextChanged);
            // 
            // TBpulgadas
            // 
            this.TBpulgadas.Location = new System.Drawing.Point(94, 141);
            this.TBpulgadas.Name = "TBpulgadas";
            this.TBpulgadas.Size = new System.Drawing.Size(100, 20);
            this.TBpulgadas.TabIndex = 1;
            this.TBpulgadas.TextChanged += new System.EventHandler(this.TBpulgadas_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Centimetros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pulgadas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBpulgadas);
            this.Controls.Add(this.TBcentimetros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBcentimetros;
        private System.Windows.Forms.TextBox TBpulgadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

