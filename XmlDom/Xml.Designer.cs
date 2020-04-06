namespace XmlDom
{
    partial class Xml
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CargarButton = new System.Windows.Forms.Button();
            this.CargaTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CargarButton
            // 
            this.CargarButton.Location = new System.Drawing.Point(254, 8);
            this.CargarButton.Name = "CargarButton";
            this.CargarButton.Size = new System.Drawing.Size(75, 23);
            this.CargarButton.TabIndex = 8;
            this.CargarButton.Text = "Cargar";
            this.CargarButton.UseVisualStyleBackColor = true;
            this.CargarButton.Click += new System.EventHandler(this.CargarButton_Click);
            // 
            // CargaTextBox
            // 
            this.CargaTextBox.Location = new System.Drawing.Point(12, 37);
            this.CargaTextBox.Multiline = true;
            this.CargaTextBox.Name = "CargaTextBox";
            this.CargaTextBox.Size = new System.Drawing.Size(317, 329);
            this.CargaTextBox.TabIndex = 7;
            this.CargaTextBox.TextChanged += new System.EventHandler(this.CargaTextBox_TextChanged);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(12, 8);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(56, 23);
            this.BuscarButton.TabIndex = 6;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // Xml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 373);
            this.Controls.Add(this.CargarButton);
            this.Controls.Add(this.CargaTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Name = "Xml";
            this.Text = "Xml";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CargarButton;
        private System.Windows.Forms.TextBox CargaTextBox;
        private System.Windows.Forms.Button BuscarButton;
    }
}