namespace ThreadSample
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
            this.IniciarButton = new System.Windows.Forms.Button();
            this.MensajeButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // IniciarButton
            // 
            this.IniciarButton.Location = new System.Drawing.Point(2, 12);
            this.IniciarButton.Name = "IniciarButton";
            this.IniciarButton.Size = new System.Drawing.Size(75, 23);
            this.IniciarButton.TabIndex = 0;
            this.IniciarButton.Text = "Iniciar";
            this.IniciarButton.UseVisualStyleBackColor = true;
            this.IniciarButton.Click += new System.EventHandler(this.IniciarButton_Click);
            // 
            // MensajeButton
            // 
            this.MensajeButton.Location = new System.Drawing.Point(102, 12);
            this.MensajeButton.Name = "MensajeButton";
            this.MensajeButton.Size = new System.Drawing.Size(75, 23);
            this.MensajeButton.TabIndex = 1;
            this.MensajeButton.Text = "Mensaje";
            this.MensajeButton.UseVisualStyleBackColor = true;
            this.MensajeButton.Click += new System.EventHandler(this.MensajeButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(2, 41);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(175, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 84);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.MensajeButton);
            this.Controls.Add(this.IniciarButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IniciarButton;
        private System.Windows.Forms.Button MensajeButton;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

