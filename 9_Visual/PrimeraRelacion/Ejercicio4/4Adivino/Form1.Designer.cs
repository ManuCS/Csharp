namespace _4Adivino
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
            this.labelTextNum = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.BTmayor = new System.Windows.Forms.Button();
            this.BTmenor = new System.Windows.Forms.Button();
            this.BTdios = new System.Windows.Forms.Button();
            this.BTpatata = new System.Windows.Forms.Button();
            this.labelDios = new System.Windows.Forms.Label();
            this.labelPatata = new System.Windows.Forms.Label();
            this.BTaceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soy Adivineitor, adivinaré el número que pienses del 1 al 100.\r\n";
            // 
            // labelTextNum
            // 
            this.labelTextNum.AutoSize = true;
            this.labelTextNum.Location = new System.Drawing.Point(15, 79);
            this.labelTextNum.Name = "labelTextNum";
            this.labelTextNum.Size = new System.Drawing.Size(71, 13);
            this.labelTextNum.TabIndex = 1;
            this.labelTextNum.Text = "El número es:";
            this.labelTextNum.Visible = false;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(93, 79);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(13, 13);
            this.labelNumero.TabIndex = 2;
            this.labelNumero.Text = "n";
            this.labelNumero.Visible = false;
            // 
            // BTmayor
            // 
            this.BTmayor.Location = new System.Drawing.Point(31, 127);
            this.BTmayor.Name = "BTmayor";
            this.BTmayor.Size = new System.Drawing.Size(91, 23);
            this.BTmayor.TabIndex = 3;
            this.BTmayor.Text = "Es mayor";
            this.BTmayor.UseVisualStyleBackColor = true;
            this.BTmayor.Visible = false;
            this.BTmayor.Click += new System.EventHandler(this.BTmayor_Click);
            // 
            // BTmenor
            // 
            this.BTmenor.Location = new System.Drawing.Point(31, 156);
            this.BTmenor.Name = "BTmenor";
            this.BTmenor.Size = new System.Drawing.Size(91, 23);
            this.BTmenor.TabIndex = 4;
            this.BTmenor.Text = "Es menor";
            this.BTmenor.UseVisualStyleBackColor = true;
            this.BTmenor.Visible = false;
            this.BTmenor.Click += new System.EventHandler(this.BTmenor_Click);
            // 
            // BTdios
            // 
            this.BTdios.Location = new System.Drawing.Point(128, 127);
            this.BTdios.Name = "BTdios";
            this.BTdios.Size = new System.Drawing.Size(62, 52);
            this.BTdios.TabIndex = 5;
            this.BTdios.Text = "Sí, eres Dios";
            this.BTdios.UseVisualStyleBackColor = true;
            this.BTdios.Visible = false;
            this.BTdios.Click += new System.EventHandler(this.BTdios_Click);
            // 
            // BTpatata
            // 
            this.BTpatata.Location = new System.Drawing.Point(196, 127);
            this.BTpatata.Name = "BTpatata";
            this.BTpatata.Size = new System.Drawing.Size(62, 53);
            this.BTpatata.TabIndex = 6;
            this.BTpatata.Text = "Sí, pero eres un patata";
            this.BTpatata.UseVisualStyleBackColor = true;
            this.BTpatata.Visible = false;
            this.BTpatata.Click += new System.EventHandler(this.BTpatata_Click);
            // 
            // labelDios
            // 
            this.labelDios.AutoSize = true;
            this.labelDios.Location = new System.Drawing.Point(18, 197);
            this.labelDios.Name = "labelDios";
            this.labelDios.Size = new System.Drawing.Size(262, 13);
            this.labelDios.TabIndex = 7;
            this.labelDios.Text = "Gracias, lo sé, vuelve cuando quieras jugar de nuevo.\r\n";
            this.labelDios.Visible = false;
            // 
            // labelPatata
            // 
            this.labelPatata.AutoSize = true;
            this.labelPatata.Location = new System.Drawing.Point(18, 224);
            this.labelPatata.Name = "labelPatata";
            this.labelPatata.Size = new System.Drawing.Size(209, 13);
            this.labelPatata.TabIndex = 8;
            this.labelPatata.Text = "Ins, qué dices si soy Dios, no vuelvas más.\r\n";
            this.labelPatata.Visible = false;
            // 
            // BTaceptar
            // 
            this.BTaceptar.Location = new System.Drawing.Point(12, 44);
            this.BTaceptar.Name = "BTaceptar";
            this.BTaceptar.Size = new System.Drawing.Size(75, 23);
            this.BTaceptar.TabIndex = 9;
            this.BTaceptar.Text = "Aceptar";
            this.BTaceptar.UseVisualStyleBackColor = true;
            this.BTaceptar.Click += new System.EventHandler(this.BTaceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BTaceptar);
            this.Controls.Add(this.labelPatata);
            this.Controls.Add(this.labelDios);
            this.Controls.Add(this.BTpatata);
            this.Controls.Add(this.BTdios);
            this.Controls.Add(this.BTmenor);
            this.Controls.Add(this.BTmayor);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelTextNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTextNum;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Button BTmayor;
        private System.Windows.Forms.Button BTmenor;
        private System.Windows.Forms.Button BTdios;
        private System.Windows.Forms.Button BTpatata;
        private System.Windows.Forms.Label labelDios;
        private System.Windows.Forms.Label labelPatata;
        private System.Windows.Forms.Button BTaceptar;
    }
}

