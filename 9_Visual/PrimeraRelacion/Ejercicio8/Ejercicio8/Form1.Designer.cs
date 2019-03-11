namespace Ejercicio8
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
            this.labelO = new System.Windows.Forms.Label();
            this.BTarriba = new System.Windows.Forms.Button();
            this.BTabajo = new System.Windows.Forms.Button();
            this.BTizquierda = new System.Windows.Forms.Button();
            this.BTderecha = new System.Windows.Forms.Button();
            this.BTcentro = new System.Windows.Forms.Button();
            this.BTizqarriba = new System.Windows.Forms.Button();
            this.BTderarriba = new System.Windows.Forms.Button();
            this.BTizqabajo = new System.Windows.Forms.Button();
            this.BTderabajo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelO
            // 
            this.labelO.AutoSize = true;
            this.labelO.Location = new System.Drawing.Point(135, 124);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(15, 13);
            this.labelO.TabIndex = 0;
            this.labelO.Text = "O";
            this.labelO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTarriba
            // 
            this.BTarriba.Location = new System.Drawing.Point(214, 174);
            this.BTarriba.Name = "BTarriba";
            this.BTarriba.Size = new System.Drawing.Size(27, 23);
            this.BTarriba.TabIndex = 1;
            this.BTarriba.Text = " ↑";
            this.BTarriba.UseVisualStyleBackColor = true;
            this.BTarriba.Click += new System.EventHandler(this.BTarriba_Click);
            // 
            // BTabajo
            // 
            this.BTabajo.Location = new System.Drawing.Point(214, 232);
            this.BTabajo.Name = "BTabajo";
            this.BTabajo.Size = new System.Drawing.Size(27, 23);
            this.BTabajo.TabIndex = 2;
            this.BTabajo.Text = "↓";
            this.BTabajo.UseVisualStyleBackColor = true;
            this.BTabajo.Click += new System.EventHandler(this.BTabajo_Click);
            // 
            // BTizquierda
            // 
            this.BTizquierda.Location = new System.Drawing.Point(181, 203);
            this.BTizquierda.Name = "BTizquierda";
            this.BTizquierda.Size = new System.Drawing.Size(27, 23);
            this.BTizquierda.TabIndex = 3;
            this.BTizquierda.Text = "←";
            this.BTizquierda.UseVisualStyleBackColor = true;
            this.BTizquierda.Click += new System.EventHandler(this.BTizquierda_Click);
            // 
            // BTderecha
            // 
            this.BTderecha.Location = new System.Drawing.Point(245, 203);
            this.BTderecha.Name = "BTderecha";
            this.BTderecha.Size = new System.Drawing.Size(27, 23);
            this.BTderecha.TabIndex = 4;
            this.BTderecha.Text = "→";
            this.BTderecha.UseVisualStyleBackColor = true;
            this.BTderecha.Click += new System.EventHandler(this.BTderecha_Click);
            // 
            // BTcentro
            // 
            this.BTcentro.Location = new System.Drawing.Point(214, 203);
            this.BTcentro.Name = "BTcentro";
            this.BTcentro.Size = new System.Drawing.Size(27, 23);
            this.BTcentro.TabIndex = 5;
            this.BTcentro.Text = "O";
            this.BTcentro.UseVisualStyleBackColor = true;
            this.BTcentro.Click += new System.EventHandler(this.BTcentro_Click);
            // 
            // BTizqarriba
            // 
            this.BTizqarriba.Location = new System.Drawing.Point(181, 174);
            this.BTizqarriba.Name = "BTizqarriba";
            this.BTizqarriba.Size = new System.Drawing.Size(27, 23);
            this.BTizqarriba.TabIndex = 6;
            this.BTizqarriba.Text = "↖";
            this.BTizqarriba.UseVisualStyleBackColor = true;
            this.BTizqarriba.Click += new System.EventHandler(this.BTizqarriba_Click);
            // 
            // BTderarriba
            // 
            this.BTderarriba.Location = new System.Drawing.Point(245, 174);
            this.BTderarriba.Name = "BTderarriba";
            this.BTderarriba.Size = new System.Drawing.Size(27, 23);
            this.BTderarriba.TabIndex = 7;
            this.BTderarriba.Text = "↗";
            this.BTderarriba.UseVisualStyleBackColor = true;
            this.BTderarriba.Click += new System.EventHandler(this.BTderarriba_Click);
            // 
            // BTizqabajo
            // 
            this.BTizqabajo.Location = new System.Drawing.Point(181, 232);
            this.BTizqabajo.Name = "BTizqabajo";
            this.BTizqabajo.Size = new System.Drawing.Size(27, 23);
            this.BTizqabajo.TabIndex = 8;
            this.BTizqabajo.Text = "↙";
            this.BTizqabajo.UseVisualStyleBackColor = true;
            this.BTizqabajo.Click += new System.EventHandler(this.BTizqabajo_Click);
            // 
            // BTderabajo
            // 
            this.BTderabajo.Location = new System.Drawing.Point(245, 232);
            this.BTderabajo.Name = "BTderabajo";
            this.BTderabajo.Size = new System.Drawing.Size(27, 23);
            this.BTderabajo.TabIndex = 9;
            this.BTderabajo.Text = "↘";
            this.BTderabajo.UseVisualStyleBackColor = true;
            this.BTderabajo.Click += new System.EventHandler(this.BTderabajo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BTderabajo);
            this.Controls.Add(this.BTizqabajo);
            this.Controls.Add(this.BTderarriba);
            this.Controls.Add(this.BTizqarriba);
            this.Controls.Add(this.BTcentro);
            this.Controls.Add(this.BTderecha);
            this.Controls.Add(this.BTizquierda);
            this.Controls.Add(this.BTabajo);
            this.Controls.Add(this.BTarriba);
            this.Controls.Add(this.labelO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.Button BTarriba;
        private System.Windows.Forms.Button BTabajo;
        private System.Windows.Forms.Button BTizquierda;
        private System.Windows.Forms.Button BTderecha;
        private System.Windows.Forms.Button BTcentro;
        private System.Windows.Forms.Button BTizqarriba;
        private System.Windows.Forms.Button BTderarriba;
        private System.Windows.Forms.Button BTizqabajo;
        private System.Windows.Forms.Button BTderabajo;
    }
}

