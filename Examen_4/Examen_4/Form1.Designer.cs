namespace Examen_4
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
            this.numsorpresa = new System.Windows.Forms.TextBox();
            this.resultados = new System.Windows.Forms.TextBox();
            this.botonSorpresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numsorpresa
            // 
            this.numsorpresa.Location = new System.Drawing.Point(121, 56);
            this.numsorpresa.Name = "numsorpresa";
            this.numsorpresa.Size = new System.Drawing.Size(100, 20);
            this.numsorpresa.TabIndex = 0;
            // 
            // resultados
            // 
            this.resultados.Location = new System.Drawing.Point(121, 82);
            this.resultados.Name = "resultados";
            this.resultados.Size = new System.Drawing.Size(100, 20);
            this.resultados.TabIndex = 1;
            // 
            // botonSorpresa
            // 
            this.botonSorpresa.Location = new System.Drawing.Point(121, 108);
            this.botonSorpresa.Name = "botonSorpresa";
            this.botonSorpresa.Size = new System.Drawing.Size(75, 23);
            this.botonSorpresa.TabIndex = 2;
            this.botonSorpresa.Text = "button1";
            this.botonSorpresa.UseVisualStyleBackColor = true;
            this.botonSorpresa.Click += new System.EventHandler(this.botonSorpresa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.botonSorpresa);
            this.Controls.Add(this.resultados);
            this.Controls.Add(this.numsorpresa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numsorpresa;
        private System.Windows.Forms.TextBox resultados;
        private System.Windows.Forms.Button botonSorpresa;
    }
}

