namespace Ejercicio6
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
            this.TBesp = new System.Windows.Forms.TextBox();
            this.TBingles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTesp = new System.Windows.Forms.Button();
            this.BTingles = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBesp
            // 
            this.TBesp.Location = new System.Drawing.Point(72, 146);
            this.TBesp.Name = "TBesp";
            this.TBesp.Size = new System.Drawing.Size(100, 20);
            this.TBesp.TabIndex = 0;
            // 
            // TBingles
            // 
            this.TBingles.Location = new System.Drawing.Point(72, 188);
            this.TBingles.Name = "TBingles";
            this.TBingles.Size = new System.Drawing.Size(100, 20);
            this.TBingles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Español";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingles";
            // 
            // BTesp
            // 
            this.BTesp.Location = new System.Drawing.Point(178, 144);
            this.BTesp.Name = "BTesp";
            this.BTesp.Size = new System.Drawing.Size(75, 23);
            this.BTesp.TabIndex = 4;
            this.BTesp.Text = "Traducir";
            this.BTesp.UseVisualStyleBackColor = true;
            this.BTesp.Click += new System.EventHandler(this.BTesp_Click);
            // 
            // BTingles
            // 
            this.BTingles.Location = new System.Drawing.Point(178, 186);
            this.BTingles.Name = "BTingles";
            this.BTingles.Size = new System.Drawing.Size(75, 23);
            this.BTingles.TabIndex = 5;
            this.BTingles.Text = "Translate";
            this.BTingles.UseVisualStyleBackColor = true;
            this.BTingles.Click += new System.EventHandler(this.BTingles_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 63);
            this.label3.TabIndex = 6;
            this.label3.Text = "Traductor:\r\nEspañol - Inglés\r\nInglés - Español";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTingles);
            this.Controls.Add(this.BTesp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBingles);
            this.Controls.Add(this.TBesp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBesp;
        private System.Windows.Forms.TextBox TBingles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTesp;
        private System.Windows.Forms.Button BTingles;
        private System.Windows.Forms.Label label3;
    }
}

