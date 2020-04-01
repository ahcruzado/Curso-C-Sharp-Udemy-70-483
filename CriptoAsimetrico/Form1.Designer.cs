namespace CriptoAsimetrico
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
            this.DesencriptarButton = new System.Windows.Forms.Button();
            this.EncriptarButton = new System.Windows.Forms.Button();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MensajeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GEnerarClaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DesencriptarButton
            // 
            this.DesencriptarButton.Location = new System.Drawing.Point(401, 213);
            this.DesencriptarButton.Name = "DesencriptarButton";
            this.DesencriptarButton.Size = new System.Drawing.Size(75, 23);
            this.DesencriptarButton.TabIndex = 15;
            this.DesencriptarButton.Text = "Desencriptar";
            this.DesencriptarButton.UseVisualStyleBackColor = true;
            this.DesencriptarButton.Click += new System.EventHandler(this.DesencriptarButton_Click);
            // 
            // EncriptarButton
            // 
            this.EncriptarButton.Location = new System.Drawing.Point(322, 213);
            this.EncriptarButton.Name = "EncriptarButton";
            this.EncriptarButton.Size = new System.Drawing.Size(75, 23);
            this.EncriptarButton.TabIndex = 14;
            this.EncriptarButton.Text = "Encriptar";
            this.EncriptarButton.UseVisualStyleBackColor = true;
            this.EncriptarButton.Click += new System.EventHandler(this.EncriptarButton_Click);
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.Location = new System.Drawing.Point(12, 269);
            this.ResultadoTextBox.Multiline = true;
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.Size = new System.Drawing.Size(464, 187);
            this.ResultadoTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Resultado";
            // 
            // MensajeTextBox
            // 
            this.MensajeTextBox.Location = new System.Drawing.Point(12, 50);
            this.MensajeTextBox.Multiline = true;
            this.MensajeTextBox.Name = "MensajeTextBox";
            this.MensajeTextBox.Size = new System.Drawing.Size(464, 157);
            this.MensajeTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mensaje";
            // 
            // GEnerarClaveButton
            // 
            this.GEnerarClaveButton.Location = new System.Drawing.Point(12, 213);
            this.GEnerarClaveButton.Name = "GEnerarClaveButton";
            this.GEnerarClaveButton.Size = new System.Drawing.Size(92, 23);
            this.GEnerarClaveButton.TabIndex = 16;
            this.GEnerarClaveButton.Text = "Generar Clave";
            this.GEnerarClaveButton.UseVisualStyleBackColor = true;
            this.GEnerarClaveButton.Click += new System.EventHandler(this.GenerarClaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 463);
            this.Controls.Add(this.GEnerarClaveButton);
            this.Controls.Add(this.DesencriptarButton);
            this.Controls.Add(this.EncriptarButton);
            this.Controls.Add(this.ResultadoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MensajeTextBox);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DesencriptarButton;
        private System.Windows.Forms.Button EncriptarButton;
        private System.Windows.Forms.TextBox ResultadoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MensajeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GEnerarClaveButton;
    }
}

