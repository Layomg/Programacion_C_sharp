namespace Examen_1
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
            this.cantidadFruta = new System.Windows.Forms.TextBox();
            this.tipoAlimento = new System.Windows.Forms.ComboBox();
            this.listaFruta = new System.Windows.Forms.ListBox();
            this.listaBolleria = new System.Windows.Forms.ListBox();
            this.listaLacteos = new System.Windows.Forms.ListBox();
            this.resumen = new System.Windows.Forms.RichTextBox();
            this.botonAñadir = new System.Windows.Forms.Button();
            this.botonResultados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cantidadFruta
            // 
            this.cantidadFruta.Location = new System.Drawing.Point(154, 84);
            this.cantidadFruta.Name = "cantidadFruta";
            this.cantidadFruta.Size = new System.Drawing.Size(100, 20);
            this.cantidadFruta.TabIndex = 0;
            // 
            // tipoAlimento
            // 
            this.tipoAlimento.FormattingEnabled = true;
            this.tipoAlimento.Items.AddRange(new object[] {
            "fruta",
            "bollería",
            "lácteos"});
            this.tipoAlimento.Location = new System.Drawing.Point(202, 39);
            this.tipoAlimento.Name = "tipoAlimento";
            this.tipoAlimento.Size = new System.Drawing.Size(121, 21);
            this.tipoAlimento.TabIndex = 1;
            // 
            // listaFruta
            // 
            this.listaFruta.FormattingEnabled = true;
            this.listaFruta.Location = new System.Drawing.Point(34, 123);
            this.listaFruta.Name = "listaFruta";
            this.listaFruta.Size = new System.Drawing.Size(90, 95);
            this.listaFruta.TabIndex = 2;
            // 
            // listaBolleria
            // 
            this.listaBolleria.FormattingEnabled = true;
            this.listaBolleria.Location = new System.Drawing.Point(130, 123);
            this.listaBolleria.Name = "listaBolleria";
            this.listaBolleria.Size = new System.Drawing.Size(90, 95);
            this.listaBolleria.TabIndex = 3;
            // 
            // listaLacteos
            // 
            this.listaLacteos.FormattingEnabled = true;
            this.listaLacteos.Location = new System.Drawing.Point(226, 123);
            this.listaLacteos.Name = "listaLacteos";
            this.listaLacteos.Size = new System.Drawing.Size(90, 95);
            this.listaLacteos.TabIndex = 4;
            // 
            // resumen
            // 
            this.resumen.Location = new System.Drawing.Point(34, 224);
            this.resumen.Name = "resumen";
            this.resumen.Size = new System.Drawing.Size(282, 96);
            this.resumen.TabIndex = 5;
            this.resumen.Text = "";
            // 
            // botonAñadir
            // 
            this.botonAñadir.Location = new System.Drawing.Point(357, 171);
            this.botonAñadir.Name = "botonAñadir";
            this.botonAñadir.Size = new System.Drawing.Size(75, 23);
            this.botonAñadir.TabIndex = 6;
            this.botonAñadir.Text = "button1";
            this.botonAñadir.UseVisualStyleBackColor = true;
            this.botonAñadir.Click += new System.EventHandler(this.botonAñadir_Click);
            // 
            // botonResultados
            // 
            this.botonResultados.Location = new System.Drawing.Point(357, 222);
            this.botonResultados.Name = "botonResultados";
            this.botonResultados.Size = new System.Drawing.Size(75, 23);
            this.botonResultados.TabIndex = 7;
            this.botonResultados.Text = "button1";
            this.botonResultados.UseVisualStyleBackColor = true;
            this.botonResultados.Click += new System.EventHandler(this.botonResultados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 370);
            this.Controls.Add(this.botonResultados);
            this.Controls.Add(this.botonAñadir);
            this.Controls.Add(this.resumen);
            this.Controls.Add(this.listaLacteos);
            this.Controls.Add(this.listaBolleria);
            this.Controls.Add(this.listaFruta);
            this.Controls.Add(this.tipoAlimento);
            this.Controls.Add(this.cantidadFruta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cantidadFruta;
        private System.Windows.Forms.ComboBox tipoAlimento;
        private System.Windows.Forms.ListBox listaFruta;
        private System.Windows.Forms.ListBox listaBolleria;
        private System.Windows.Forms.ListBox listaLacteos;
        private System.Windows.Forms.RichTextBox resumen;
        private System.Windows.Forms.Button botonAñadir;
        private System.Windows.Forms.Button botonResultados;
    }
}

