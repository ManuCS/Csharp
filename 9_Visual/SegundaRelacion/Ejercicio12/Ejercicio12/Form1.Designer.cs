namespace Ejercicio12
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
            this.TBunidades = new System.Windows.Forms.TextBox();
            this.TBconver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RByard1 = new System.Windows.Forms.RadioButton();
            this.RBpul1 = new System.Windows.Forms.RadioButton();
            this.RBcent1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RByard2 = new System.Windows.Forms.RadioButton();
            this.RBpul2 = new System.Windows.Forms.RadioButton();
            this.RBcent2 = new System.Windows.Forms.RadioButton();
            this.Luni = new System.Windows.Forms.Label();
            this.lconver = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBunidades
            // 
            this.TBunidades.Location = new System.Drawing.Point(23, 88);
            this.TBunidades.Name = "TBunidades";
            this.TBunidades.Size = new System.Drawing.Size(100, 20);
            this.TBunidades.TabIndex = 0;
            this.TBunidades.TextChanged += new System.EventHandler(this.TBunidades_TextChanged);
            // 
            // TBconver
            // 
            this.TBconver.Location = new System.Drawing.Point(149, 88);
            this.TBconver.Name = "TBconver";
            this.TBconver.Size = new System.Drawing.Size(100, 20);
            this.TBconver.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Multiconversor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RByard1);
            this.groupBox1.Controls.Add(this.RBpul1);
            this.groupBox1.Controls.Add(this.RBcent1);
            this.groupBox1.Location = new System.Drawing.Point(23, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "uMedida";
            // 
            // RByard1
            // 
            this.RByard1.AutoSize = true;
            this.RByard1.Location = new System.Drawing.Point(7, 68);
            this.RByard1.Name = "RByard1";
            this.RByard1.Size = new System.Drawing.Size(58, 17);
            this.RByard1.TabIndex = 2;
            this.RByard1.TabStop = true;
            this.RByard1.Text = "Yardas";
            this.RByard1.UseVisualStyleBackColor = true;
            this.RByard1.CheckedChanged += new System.EventHandler(this.RBcent1_CheckedChanged);
            // 
            // RBpul1
            // 
            this.RBpul1.AutoSize = true;
            this.RBpul1.Location = new System.Drawing.Point(7, 44);
            this.RBpul1.Name = "RBpul1";
            this.RBpul1.Size = new System.Drawing.Size(69, 17);
            this.RBpul1.TabIndex = 1;
            this.RBpul1.TabStop = true;
            this.RBpul1.Text = "Pulgadas";
            this.RBpul1.UseVisualStyleBackColor = true;
            this.RBpul1.CheckedChanged += new System.EventHandler(this.RBcent1_CheckedChanged);
            // 
            // RBcent1
            // 
            this.RBcent1.AutoSize = true;
            this.RBcent1.Checked = true;
            this.RBcent1.Location = new System.Drawing.Point(7, 20);
            this.RBcent1.Name = "RBcent1";
            this.RBcent1.Size = new System.Drawing.Size(80, 17);
            this.RBcent1.TabIndex = 0;
            this.RBcent1.TabStop = true;
            this.RBcent1.Text = "Centimetros";
            this.RBcent1.UseVisualStyleBackColor = true;
            this.RBcent1.CheckedChanged += new System.EventHandler(this.RBcent1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RByard2);
            this.groupBox2.Controls.Add(this.RBpul2);
            this.groupBox2.Controls.Add(this.RBcent2);
            this.groupBox2.Location = new System.Drawing.Point(149, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 99);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "uConversion";
            // 
            // RByard2
            // 
            this.RByard2.AutoSize = true;
            this.RByard2.Location = new System.Drawing.Point(7, 68);
            this.RByard2.Name = "RByard2";
            this.RByard2.Size = new System.Drawing.Size(58, 17);
            this.RByard2.TabIndex = 2;
            this.RByard2.TabStop = true;
            this.RByard2.Text = "Yardas";
            this.RByard2.UseVisualStyleBackColor = true;
            // 
            // RBpul2
            // 
            this.RBpul2.AutoSize = true;
            this.RBpul2.Location = new System.Drawing.Point(7, 44);
            this.RBpul2.Name = "RBpul2";
            this.RBpul2.Size = new System.Drawing.Size(69, 17);
            this.RBpul2.TabIndex = 1;
            this.RBpul2.TabStop = true;
            this.RBpul2.Text = "Pulgadas";
            this.RBpul2.UseVisualStyleBackColor = true;
            // 
            // RBcent2
            // 
            this.RBcent2.AutoSize = true;
            this.RBcent2.Checked = true;
            this.RBcent2.Location = new System.Drawing.Point(6, 19);
            this.RBcent2.Name = "RBcent2";
            this.RBcent2.Size = new System.Drawing.Size(80, 17);
            this.RBcent2.TabIndex = 0;
            this.RBcent2.TabStop = true;
            this.RBcent2.Text = "Centimetros";
            this.RBcent2.UseVisualStyleBackColor = true;
            // 
            // Luni
            // 
            this.Luni.AutoSize = true;
            this.Luni.Location = new System.Drawing.Point(97, 111);
            this.Luni.Name = "Luni";
            this.Luni.Size = new System.Drawing.Size(21, 13);
            this.Luni.TabIndex = 5;
            this.Luni.Text = "cm";
            // 
            // lconver
            // 
            this.lconver.AutoSize = true;
            this.lconver.Location = new System.Drawing.Point(222, 111);
            this.lconver.Name = "lconver";
            this.lconver.Size = new System.Drawing.Size(21, 13);
            this.lconver.TabIndex = 6;
            this.lconver.Text = "cm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lconver);
            this.Controls.Add(this.Luni);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBconver);
            this.Controls.Add(this.TBunidades);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBunidades;
        private System.Windows.Forms.TextBox TBconver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RByard1;
        private System.Windows.Forms.RadioButton RBpul1;
        private System.Windows.Forms.RadioButton RBcent1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RByard2;
        private System.Windows.Forms.RadioButton RBpul2;
        private System.Windows.Forms.RadioButton RBcent2;
        private System.Windows.Forms.Label Luni;
        private System.Windows.Forms.Label lconver;
    }
}

