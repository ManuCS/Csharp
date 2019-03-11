namespace Ejercicio14
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
            this.CBnom2 = new System.Windows.Forms.ComboBox();
            this.BTgenera = new System.Windows.Forms.Button();
            this.BTaleat = new System.Windows.Forms.Button();
            this.ltitulo = new System.Windows.Forms.Label();
            this.CBnom1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CBnom2
            // 
            this.CBnom2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBnom2.FormattingEnabled = true;
            this.CBnom2.Location = new System.Drawing.Point(32, 210);
            this.CBnom2.Name = "CBnom2";
            this.CBnom2.Size = new System.Drawing.Size(121, 21);
            this.CBnom2.TabIndex = 1;
            // 
            // BTgenera
            // 
            this.BTgenera.Location = new System.Drawing.Point(182, 171);
            this.BTgenera.Name = "BTgenera";
            this.BTgenera.Size = new System.Drawing.Size(75, 23);
            this.BTgenera.TabIndex = 2;
            this.BTgenera.Text = "Genera";
            this.BTgenera.UseVisualStyleBackColor = true;
            this.BTgenera.Click += new System.EventHandler(this.BTgenera_Click);
            // 
            // BTaleat
            // 
            this.BTaleat.Location = new System.Drawing.Point(182, 210);
            this.BTaleat.Name = "BTaleat";
            this.BTaleat.Size = new System.Drawing.Size(75, 23);
            this.BTaleat.TabIndex = 3;
            this.BTaleat.Text = "Aleatorio";
            this.BTaleat.UseVisualStyleBackColor = true;
            this.BTaleat.Click += new System.EventHandler(this.BTaleat_Click);
            // 
            // ltitulo
            // 
            this.ltitulo.AutoSize = true;
            this.ltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ltitulo.Location = new System.Drawing.Point(96, 73);
            this.ltitulo.Name = "ltitulo";
            this.ltitulo.Size = new System.Drawing.Size(57, 20);
            this.ltitulo.TabIndex = 4;
            this.ltitulo.Text = "label1";
            this.ltitulo.Visible = false;
            // 
            // CBnom1
            // 
            this.CBnom1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBnom1.FormattingEnabled = true;
            this.CBnom1.Location = new System.Drawing.Point(32, 173);
            this.CBnom1.Name = "CBnom1";
            this.CBnom1.Size = new System.Drawing.Size(121, 21);
            this.CBnom1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CBnom1);
            this.Controls.Add(this.ltitulo);
            this.Controls.Add(this.BTaleat);
            this.Controls.Add(this.BTgenera);
            this.Controls.Add(this.CBnom2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CBnom2;
        private System.Windows.Forms.Button BTgenera;
        private System.Windows.Forms.Button BTaleat;
        private System.Windows.Forms.Label ltitulo;
        private System.Windows.Forms.ComboBox CBnom1;
    }
}

