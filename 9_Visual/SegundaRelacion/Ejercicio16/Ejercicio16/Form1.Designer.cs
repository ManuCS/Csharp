namespace Ejercicio16
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
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.TBpelo = new System.Windows.Forms.TextBox();
            this.TBraza = new System.Windows.Forms.TextBox();
            this.TBpeso = new System.Windows.Forms.TextBox();
            this.TBtamano = new System.Windows.Forms.TextBox();
            this.TBojos = new System.Windows.Forms.TextBox();
            this.BTnuevo = new System.Windows.Forms.Button();
            this.BTguardar = new System.Windows.Forms.Button();
            this.BTmodif = new System.Windows.Forms.Button();
            this.BTborrar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBnombre
            // 
            this.TBnombre.Enabled = false;
            this.TBnombre.Location = new System.Drawing.Point(69, 292);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(100, 20);
            this.TBnombre.TabIndex = 1;
            // 
            // TBpelo
            // 
            this.TBpelo.Enabled = false;
            this.TBpelo.Location = new System.Drawing.Point(69, 320);
            this.TBpelo.Name = "TBpelo";
            this.TBpelo.Size = new System.Drawing.Size(100, 20);
            this.TBpelo.TabIndex = 2;
            // 
            // TBraza
            // 
            this.TBraza.Enabled = false;
            this.TBraza.Location = new System.Drawing.Point(293, 292);
            this.TBraza.Name = "TBraza";
            this.TBraza.Size = new System.Drawing.Size(100, 20);
            this.TBraza.TabIndex = 3;
            // 
            // TBpeso
            // 
            this.TBpeso.Enabled = false;
            this.TBpeso.Location = new System.Drawing.Point(293, 320);
            this.TBpeso.Name = "TBpeso";
            this.TBpeso.Size = new System.Drawing.Size(100, 20);
            this.TBpeso.TabIndex = 4;
            // 
            // TBtamano
            // 
            this.TBtamano.Enabled = false;
            this.TBtamano.Location = new System.Drawing.Point(528, 292);
            this.TBtamano.Name = "TBtamano";
            this.TBtamano.Size = new System.Drawing.Size(100, 20);
            this.TBtamano.TabIndex = 5;
            // 
            // TBojos
            // 
            this.TBojos.Enabled = false;
            this.TBojos.Location = new System.Drawing.Point(528, 320);
            this.TBojos.Name = "TBojos";
            this.TBojos.Size = new System.Drawing.Size(100, 20);
            this.TBojos.TabIndex = 6;
            // 
            // BTnuevo
            // 
            this.BTnuevo.Location = new System.Drawing.Point(565, 52);
            this.BTnuevo.Name = "BTnuevo";
            this.BTnuevo.Size = new System.Drawing.Size(75, 23);
            this.BTnuevo.TabIndex = 7;
            this.BTnuevo.Text = "Nuevo";
            this.BTnuevo.UseVisualStyleBackColor = true;
            this.BTnuevo.Click += new System.EventHandler(this.BTnuevo_Click);
            // 
            // BTguardar
            // 
            this.BTguardar.Enabled = false;
            this.BTguardar.Location = new System.Drawing.Point(565, 81);
            this.BTguardar.Name = "BTguardar";
            this.BTguardar.Size = new System.Drawing.Size(75, 23);
            this.BTguardar.TabIndex = 8;
            this.BTguardar.Text = "Guardar";
            this.BTguardar.UseVisualStyleBackColor = true;
            this.BTguardar.Click += new System.EventHandler(this.BTguardar_Click);
            // 
            // BTmodif
            // 
            this.BTmodif.Enabled = false;
            this.BTmodif.Location = new System.Drawing.Point(565, 110);
            this.BTmodif.Name = "BTmodif";
            this.BTmodif.Size = new System.Drawing.Size(75, 23);
            this.BTmodif.TabIndex = 9;
            this.BTmodif.Text = "Modificar";
            this.BTmodif.UseVisualStyleBackColor = true;
            this.BTmodif.Click += new System.EventHandler(this.BTmodif_Click);
            // 
            // BTborrar
            // 
            this.BTborrar.Enabled = false;
            this.BTborrar.Location = new System.Drawing.Point(565, 139);
            this.BTborrar.Name = "BTborrar";
            this.BTborrar.Size = new System.Drawing.Size(75, 23);
            this.BTborrar.TabIndex = 10;
            this.BTborrar.Text = "Borrar";
            this.BTborrar.UseVisualStyleBackColor = true;
            this.BTborrar.Click += new System.EventHandler(this.BTborrar_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 43);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(547, 243);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Color pelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tamaño";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Color ojos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(11, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Caterinario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 352);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BTborrar);
            this.Controls.Add(this.BTmodif);
            this.Controls.Add(this.BTguardar);
            this.Controls.Add(this.BTnuevo);
            this.Controls.Add(this.TBojos);
            this.Controls.Add(this.TBtamano);
            this.Controls.Add(this.TBpeso);
            this.Controls.Add(this.TBraza);
            this.Controls.Add(this.TBpelo);
            this.Controls.Add(this.TBnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.TextBox TBpelo;
        private System.Windows.Forms.TextBox TBraza;
        private System.Windows.Forms.TextBox TBpeso;
        private System.Windows.Forms.TextBox TBtamano;
        private System.Windows.Forms.TextBox TBojos;
        private System.Windows.Forms.Button BTnuevo;
        private System.Windows.Forms.Button BTguardar;
        private System.Windows.Forms.Button BTmodif;
        private System.Windows.Forms.Button BTborrar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

