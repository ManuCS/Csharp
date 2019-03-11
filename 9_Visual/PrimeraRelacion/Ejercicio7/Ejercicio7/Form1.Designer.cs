namespace Ejercicio7
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
            this.TBagenda = new System.Windows.Forms.TextBox();
            this.BTsiguiente = new System.Windows.Forms.Button();
            this.BTanterior = new System.Windows.Forms.Button();
            this.TBdia = new System.Windows.Forms.TextBox();
            this.TBmes = new System.Windows.Forms.TextBox();
            this.TByear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBagenda
            // 
            this.TBagenda.Location = new System.Drawing.Point(12, 38);
            this.TBagenda.Multiline = true;
            this.TBagenda.Name = "TBagenda";
            this.TBagenda.Size = new System.Drawing.Size(260, 188);
            this.TBagenda.TabIndex = 0;
            // 
            // BTsiguiente
            // 
            this.BTsiguiente.Location = new System.Drawing.Point(197, 232);
            this.BTsiguiente.Name = "BTsiguiente";
            this.BTsiguiente.Size = new System.Drawing.Size(75, 23);
            this.BTsiguiente.TabIndex = 1;
            this.BTsiguiente.Text = "Siguiente";
            this.BTsiguiente.UseVisualStyleBackColor = true;
            // 
            // BTanterior
            // 
            this.BTanterior.Location = new System.Drawing.Point(12, 232);
            this.BTanterior.Name = "BTanterior";
            this.BTanterior.Size = new System.Drawing.Size(75, 23);
            this.BTanterior.TabIndex = 2;
            this.BTanterior.Text = "Anterior";
            this.BTanterior.UseVisualStyleBackColor = true;
            this.BTanterior.Click += new System.EventHandler(this.BTanterior_Click);
            // 
            // TBdia
            // 
            this.TBdia.Location = new System.Drawing.Point(148, 12);
            this.TBdia.Name = "TBdia";
            this.TBdia.Size = new System.Drawing.Size(33, 20);
            this.TBdia.TabIndex = 3;
            // 
            // TBmes
            // 
            this.TBmes.Location = new System.Drawing.Point(187, 12);
            this.TBmes.Name = "TBmes";
            this.TBmes.Size = new System.Drawing.Size(33, 20);
            this.TBmes.TabIndex = 4;
            // 
            // TByear
            // 
            this.TByear.Location = new System.Drawing.Point(226, 12);
            this.TByear.Name = "TByear";
            this.TByear.Size = new System.Drawing.Size(46, 20);
            this.TByear.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mini-Agenda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TByear);
            this.Controls.Add(this.TBmes);
            this.Controls.Add(this.TBdia);
            this.Controls.Add(this.BTanterior);
            this.Controls.Add(this.BTsiguiente);
            this.Controls.Add(this.TBagenda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBagenda;
        private System.Windows.Forms.Button BTsiguiente;
        private System.Windows.Forms.Button BTanterior;
        private System.Windows.Forms.TextBox TBdia;
        private System.Windows.Forms.TextBox TBmes;
        private System.Windows.Forms.TextBox TByear;
        private System.Windows.Forms.Label label1;
    }
}

