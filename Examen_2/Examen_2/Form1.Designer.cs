namespace Examen_2
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
            this.primer_operando = new System.Windows.Forms.TextBox();
            this.segundo_operando = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // primer_operando
            // 
            this.primer_operando.Location = new System.Drawing.Point(105, 23);
            this.primer_operando.Name = "primer_operando";
            this.primer_operando.Size = new System.Drawing.Size(100, 20);
            this.primer_operando.TabIndex = 0;
            // 
            // segundo_operando
            // 
            this.segundo_operando.Location = new System.Drawing.Point(105, 49);
            this.segundo_operando.Name = "segundo_operando";
            this.segundo_operando.Size = new System.Drawing.Size(100, 20);
            this.segundo_operando.TabIndex = 1;
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(105, 75);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(100, 20);
            this.resultado.TabIndex = 2;
            // 
            // botonCalcular
            // 
            this.botonCalcular.Location = new System.Drawing.Point(130, 113);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(75, 23);
            this.botonCalcular.TabIndex = 3;
            this.botonCalcular.Text = "CALCULAR";
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.segundo_operando);
            this.Controls.Add(this.primer_operando);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox primer_operando;
        private System.Windows.Forms.TextBox segundo_operando;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button botonCalcular;
    }
}

