namespace CriptoSimetrico
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
            this.ClaceTextBox = new System.Windows.Forms.TextBox();
            this.MensajeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EncriptarButton = new System.Windows.Forms.Button();
            this.DesencriptarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave";
            // 
            // ClaceTextBox
            // 
            this.ClaceTextBox.Location = new System.Drawing.Point(62, 7);
            this.ClaceTextBox.Name = "ClaceTextBox";
            this.ClaceTextBox.Size = new System.Drawing.Size(412, 20);
            this.ClaceTextBox.TabIndex = 1;
            // 
            // MensajeTextBox
            // 
            this.MensajeTextBox.Location = new System.Drawing.Point(10, 53);
            this.MensajeTextBox.Multiline = true;
            this.MensajeTextBox.Name = "MensajeTextBox";
            this.MensajeTextBox.Size = new System.Drawing.Size(464, 157);
            this.MensajeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mensaje";
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.Location = new System.Drawing.Point(10, 272);
            this.ResultadoTextBox.Multiline = true;
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.Size = new System.Drawing.Size(464, 187);
            this.ResultadoTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado";
            // 
            // EncriptarButton
            // 
            this.EncriptarButton.Location = new System.Drawing.Point(146, 216);
            this.EncriptarButton.Name = "EncriptarButton";
            this.EncriptarButton.Size = new System.Drawing.Size(75, 23);
            this.EncriptarButton.TabIndex = 6;
            this.EncriptarButton.Text = "Encriptar";
            this.EncriptarButton.UseVisualStyleBackColor = true;
            this.EncriptarButton.Click += new System.EventHandler(this.EncriptarButton_Click);
            // 
            // DesencriptarButton
            // 
            this.DesencriptarButton.Location = new System.Drawing.Point(225, 216);
            this.DesencriptarButton.Name = "DesencriptarButton";
            this.DesencriptarButton.Size = new System.Drawing.Size(75, 23);
            this.DesencriptarButton.TabIndex = 7;
            this.DesencriptarButton.Text = "Desencriptar";
            this.DesencriptarButton.UseVisualStyleBackColor = true;
            this.DesencriptarButton.Click += new System.EventHandler(this.DesencriptarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 462);
            this.Controls.Add(this.DesencriptarButton);
            this.Controls.Add(this.EncriptarButton);
            this.Controls.Add(this.ResultadoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MensajeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClaceTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClaceTextBox;
        private System.Windows.Forms.TextBox MensajeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ResultadoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EncriptarButton;
        private System.Windows.Forms.Button DesencriptarButton;
    }
}

