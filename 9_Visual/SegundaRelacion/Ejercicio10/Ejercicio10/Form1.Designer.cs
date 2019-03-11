namespace Ejercicio10
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
            this.LBdiccionario = new System.Windows.Forms.ListBox();
            this.TBesp = new System.Windows.Forms.TextBox();
            this.TBingles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTborrar = new System.Windows.Forms.Button();
            this.BTanadir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBdiccionario
            // 
            this.LBdiccionario.FormattingEnabled = true;
            this.LBdiccionario.Location = new System.Drawing.Point(12, 12);
            this.LBdiccionario.Name = "LBdiccionario";
            this.LBdiccionario.Size = new System.Drawing.Size(260, 121);
            this.LBdiccionario.TabIndex = 0;
            this.LBdiccionario.SelectedIndexChanged += new System.EventHandler(this.LBdiccionario_SelectedIndexChanged);
            // 
            // TBesp
            // 
            this.TBesp.Location = new System.Drawing.Point(12, 150);
            this.TBesp.Name = "TBesp";
            this.TBesp.Size = new System.Drawing.Size(100, 20);
            this.TBesp.TabIndex = 1;
            this.TBesp.TextChanged += new System.EventHandler(this.TBesp_TextChanged);
            // 
            // TBingles
            // 
            this.TBingles.Location = new System.Drawing.Point(172, 150);
            this.TBingles.Name = "TBingles";
            this.TBingles.Size = new System.Drawing.Size(100, 20);
            this.TBingles.TabIndex = 2;
            this.TBingles.TextChanged += new System.EventHandler(this.TBingles_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Español";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingles";
            // 
            // BTborrar
            // 
            this.BTborrar.Enabled = false;
            this.BTborrar.Location = new System.Drawing.Point(138, 213);
            this.BTborrar.Name = "BTborrar";
            this.BTborrar.Size = new System.Drawing.Size(75, 23);
            this.BTborrar.TabIndex = 6;
            this.BTborrar.Text = "Borrar";
            this.BTborrar.UseVisualStyleBackColor = true;
            this.BTborrar.Click += new System.EventHandler(this.BTborrar_Click);
            // 
            // BTanadir
            // 
            this.BTanadir.Enabled = false;
            this.BTanadir.Location = new System.Drawing.Point(57, 213);
            this.BTanadir.Name = "BTanadir";
            this.BTanadir.Size = new System.Drawing.Size(75, 23);
            this.BTanadir.TabIndex = 7;
            this.BTanadir.Text = "Añadir";
            this.BTanadir.UseVisualStyleBackColor = true;
            this.BTanadir.Click += new System.EventHandler(this.BTanadir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BTanadir);
            this.Controls.Add(this.BTborrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBingles);
            this.Controls.Add(this.TBesp);
            this.Controls.Add(this.LBdiccionario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBdiccionario;
        private System.Windows.Forms.TextBox TBesp;
        private System.Windows.Forms.TextBox TBingles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTborrar;
        private System.Windows.Forms.Button BTanadir;
    }
}

