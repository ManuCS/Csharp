namespace Ejercicio11
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
            this.UpDdados = new System.Windows.Forms.NumericUpDown();
            this.UpDcaras = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTtirar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBsuma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpDdados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDcaras)).BeginInit();
            this.SuspendLayout();
            // 
            // UpDdados
            // 
            this.UpDdados.Location = new System.Drawing.Point(30, 25);
            this.UpDdados.Name = "UpDdados";
            this.UpDdados.Size = new System.Drawing.Size(42, 20);
            this.UpDdados.TabIndex = 0;
            // 
            // UpDcaras
            // 
            this.UpDcaras.Location = new System.Drawing.Point(208, 25);
            this.UpDcaras.Name = "UpDcaras";
            this.UpDcaras.Size = new System.Drawing.Size(39, 20);
            this.UpDcaras.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de dados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de caras:";
            // 
            // BTtirar
            // 
            this.BTtirar.Location = new System.Drawing.Point(104, 226);
            this.BTtirar.Name = "BTtirar";
            this.BTtirar.Size = new System.Drawing.Size(75, 23);
            this.BTtirar.TabIndex = 4;
            this.BTtirar.Text = "Tirar";
            this.BTtirar.UseVisualStyleBackColor = true;
            this.BTtirar.Click += new System.EventHandler(this.BTtirar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 95);
            this.listBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tiradas:";
            // 
            // TBsuma
            // 
            this.TBsuma.Location = new System.Drawing.Point(13, 192);
            this.TBsuma.Name = "TBsuma";
            this.TBsuma.Size = new System.Drawing.Size(59, 20);
            this.TBsuma.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Suma:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBsuma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BTtirar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpDcaras);
            this.Controls.Add(this.UpDdados);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UpDdados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDcaras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown UpDdados;
        private System.Windows.Forms.NumericUpDown UpDcaras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTtirar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBsuma;
        private System.Windows.Forms.Label label4;
    }
}

