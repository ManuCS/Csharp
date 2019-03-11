namespace Ejercicio13
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
            this.lpreguntas = new System.Windows.Forms.Label();
            this.BTmuestra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBres1 = new System.Windows.Forms.RadioButton();
            this.RBres2 = new System.Windows.Forms.RadioButton();
            this.RBres3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lpreguntas
            // 
            this.lpreguntas.AutoSize = true;
            this.lpreguntas.Location = new System.Drawing.Point(12, 39);
            this.lpreguntas.Name = "lpreguntas";
            this.lpreguntas.Size = new System.Drawing.Size(223, 26);
            this.lpreguntas.TabIndex = 0;
            this.lpreguntas.Text = "El SuperTest consta de 5 preguntas tipo test. \r\n¿Empezamos?";
            // 
            // BTmuestra
            // 
            this.BTmuestra.Location = new System.Drawing.Point(102, 204);
            this.BTmuestra.Name = "BTmuestra";
            this.BTmuestra.Size = new System.Drawing.Size(75, 23);
            this.BTmuestra.TabIndex = 1;
            this.BTmuestra.Text = "Empezar";
            this.BTmuestra.UseVisualStyleBackColor = true;
            this.BTmuestra.Click += new System.EventHandler(this.BTmuestra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBres3);
            this.groupBox1.Controls.Add(this.RBres2);
            this.groupBox1.Controls.Add(this.RBres1);
            this.groupBox1.Location = new System.Drawing.Point(32, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 104);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SuperTest";
            this.groupBox1.Visible = false;
            // 
            // RBres1
            // 
            this.RBres1.AutoSize = true;
            this.RBres1.Location = new System.Drawing.Point(7, 20);
            this.RBres1.Name = "RBres1";
            this.RBres1.Size = new System.Drawing.Size(85, 17);
            this.RBres1.TabIndex = 0;
            this.RBres1.TabStop = true;
            this.RBres1.Text = "radioButton1";
            this.RBres1.UseVisualStyleBackColor = true;
            // 
            // RBres2
            // 
            this.RBres2.AutoSize = true;
            this.RBres2.Location = new System.Drawing.Point(7, 44);
            this.RBres2.Name = "RBres2";
            this.RBres2.Size = new System.Drawing.Size(85, 17);
            this.RBres2.TabIndex = 1;
            this.RBres2.TabStop = true;
            this.RBres2.Text = "radioButton2";
            this.RBres2.UseVisualStyleBackColor = true;
            // 
            // RBres3
            // 
            this.RBres3.AutoSize = true;
            this.RBres3.Location = new System.Drawing.Point(7, 68);
            this.RBres3.Name = "RBres3";
            this.RBres3.Size = new System.Drawing.Size(85, 17);
            this.RBres3.TabIndex = 2;
            this.RBres3.TabStop = true;
            this.RBres3.Text = "radioButton3";
            this.RBres3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTmuestra);
            this.Controls.Add(this.lpreguntas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lpreguntas;
        private System.Windows.Forms.Button BTmuestra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBres3;
        private System.Windows.Forms.RadioButton RBres2;
        private System.Windows.Forms.RadioButton RBres1;
    }
}

