namespace Boletin_experto
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
            this.label_nameplayer_1 = new System.Windows.Forms.Label();
            this.label_nameplayer_2 = new System.Windows.Forms.Label();
            this.label_nameplayer_3 = new System.Windows.Forms.Label();
            this.namePlayer_1 = new System.Windows.Forms.TextBox();
            this.namePlayer_2 = new System.Windows.Forms.TextBox();
            this.namePlayer_3 = new System.Windows.Forms.TextBox();
            this.boton_añadir = new System.Windows.Forms.Button();
            this.boton_borrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nameplayer_1
            // 
            this.label_nameplayer_1.AutoSize = true;
            this.label_nameplayer_1.Location = new System.Drawing.Point(75, 43);
            this.label_nameplayer_1.Name = "label_nameplayer_1";
            this.label_nameplayer_1.Size = new System.Drawing.Size(125, 13);
            this.label_nameplayer_1.TabIndex = 0;
            this.label_nameplayer_1.Text = "NOMBRE 1º JUGADOR:";
            // 
            // label_nameplayer_2
            // 
            this.label_nameplayer_2.AutoSize = true;
            this.label_nameplayer_2.Location = new System.Drawing.Point(75, 105);
            this.label_nameplayer_2.Name = "label_nameplayer_2";
            this.label_nameplayer_2.Size = new System.Drawing.Size(125, 13);
            this.label_nameplayer_2.TabIndex = 1;
            this.label_nameplayer_2.Text = "NOMBRE 2º JUGADOR:";
            // 
            // label_nameplayer_3
            // 
            this.label_nameplayer_3.AutoSize = true;
            this.label_nameplayer_3.Location = new System.Drawing.Point(72, 165);
            this.label_nameplayer_3.Name = "label_nameplayer_3";
            this.label_nameplayer_3.Size = new System.Drawing.Size(128, 13);
            this.label_nameplayer_3.TabIndex = 2;
            this.label_nameplayer_3.Text = "NOMBRE 3º JUGADOR: ";
            // 
            // namePlayer_1
            // 
            this.namePlayer_1.Location = new System.Drawing.Point(78, 59);
            this.namePlayer_1.Name = "namePlayer_1";
            this.namePlayer_1.Size = new System.Drawing.Size(284, 20);
            this.namePlayer_1.TabIndex = 3;
            // 
            // namePlayer_2
            // 
            this.namePlayer_2.Location = new System.Drawing.Point(78, 121);
            this.namePlayer_2.Name = "namePlayer_2";
            this.namePlayer_2.Size = new System.Drawing.Size(284, 20);
            this.namePlayer_2.TabIndex = 4;
            // 
            // namePlayer_3
            // 
            this.namePlayer_3.Location = new System.Drawing.Point(78, 181);
            this.namePlayer_3.Name = "namePlayer_3";
            this.namePlayer_3.Size = new System.Drawing.Size(284, 20);
            this.namePlayer_3.TabIndex = 5;
            // 
            // boton_añadir
            // 
            this.boton_añadir.Location = new System.Drawing.Point(109, 248);
            this.boton_añadir.Name = "boton_añadir";
            this.boton_añadir.Size = new System.Drawing.Size(75, 23);
            this.boton_añadir.TabIndex = 6;
            this.boton_añadir.Text = "AÑADIR";
            this.boton_añadir.UseVisualStyleBackColor = true;
            this.boton_añadir.Click += new System.EventHandler(this.boton_añadir_Click);
            // 
            // boton_borrar
            // 
            this.boton_borrar.Location = new System.Drawing.Point(246, 248);
            this.boton_borrar.Name = "boton_borrar";
            this.boton_borrar.Size = new System.Drawing.Size(75, 23);
            this.boton_borrar.TabIndex = 7;
            this.boton_borrar.Text = "BORRAR";
            this.boton_borrar.UseVisualStyleBackColor = true;
            this.boton_borrar.Click += new System.EventHandler(this.boton_borrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 312);
            this.Controls.Add(this.boton_borrar);
            this.Controls.Add(this.boton_añadir);
            this.Controls.Add(this.namePlayer_3);
            this.Controls.Add(this.namePlayer_2);
            this.Controls.Add(this.namePlayer_1);
            this.Controls.Add(this.label_nameplayer_3);
            this.Controls.Add(this.label_nameplayer_2);
            this.Controls.Add(this.label_nameplayer_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nameplayer_1;
        private System.Windows.Forms.Label label_nameplayer_2;
        private System.Windows.Forms.Label label_nameplayer_3;
        private System.Windows.Forms.TextBox namePlayer_1;
        private System.Windows.Forms.TextBox namePlayer_2;
        private System.Windows.Forms.TextBox namePlayer_3;
        private System.Windows.Forms.Button boton_añadir;
        private System.Windows.Forms.Button boton_borrar;
    }
}

