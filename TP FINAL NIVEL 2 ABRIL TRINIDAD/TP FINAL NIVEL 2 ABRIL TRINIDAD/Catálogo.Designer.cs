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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Botonlol
            // 
            this.Botonlol.Location = new System.Drawing.Point(341, 33);
            this.Botonlol.Name = "Botonlol";
            this.Botonlol.Size = new System.Drawing.Size(75, 23);
            this.Botonlol.TabIndex = 0;
            this.Botonlol.Text = "button1";
            this.Botonlol.UseVisualStyleBackColor = true;
            this.Botonlol.Click += new System.EventHandler(this.Botonlol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AGRESSIVE", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catalogo";
            // 
            // Catálogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1203, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Botonlol);
            this.Name = "Catálogo";
            this.Text = "Catalogo <3";
            this.Load += new System.EventHandler(this.Catálogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Botonlol;
        private System.Windows.Forms.Label label1;
    }
}

