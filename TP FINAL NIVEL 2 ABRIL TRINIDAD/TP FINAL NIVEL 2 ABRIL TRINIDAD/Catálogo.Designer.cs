namespace TP_FINAL_NIVEL_2_ABRIL_TRINIDAD
{
    partial class Catálogo
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
            this.Botonlol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Botonlol
            // 
            this.Botonlol.Location = new System.Drawing.Point(286, 75);
            this.Botonlol.Name = "Botonlol";
            this.Botonlol.Size = new System.Drawing.Size(75, 23);
            this.Botonlol.TabIndex = 0;
            this.Botonlol.Text = "button1";
            this.Botonlol.UseVisualStyleBackColor = true;
            this.Botonlol.Click += new System.EventHandler(this.Botonlol_Click);
            // 
            // Catálogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Botonlol);
            this.Name = "Catálogo";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Botonlol;
    }
}

