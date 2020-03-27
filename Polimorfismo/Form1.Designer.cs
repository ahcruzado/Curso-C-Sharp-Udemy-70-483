namespace Polimorfismo
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
            this.AregarElementoLabel = new System.Windows.Forms.Label();
            this.ElementoTextBox = new System.Windows.Forms.TextBox();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ObtenerElementoButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AregarElementoLabel
            // 
            this.AregarElementoLabel.AutoSize = true;
            this.AregarElementoLabel.Location = new System.Drawing.Point(12, 9);
            this.AregarElementoLabel.Name = "AregarElementoLabel";
            this.AregarElementoLabel.Size = new System.Drawing.Size(91, 13);
            this.AregarElementoLabel.TabIndex = 0;
            this.AregarElementoLabel.Text = "Agregar Elemento";
            // 
            // ElementoTextBox
            // 
            this.ElementoTextBox.Location = new System.Drawing.Point(109, 9);
            this.ElementoTextBox.Name = "ElementoTextBox";
            this.ElementoTextBox.Size = new System.Drawing.Size(205, 20);
            this.ElementoTextBox.TabIndex = 1;
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.Location = new System.Drawing.Point(239, 35);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(75, 23);
            this.Aceptarbutton.TabIndex = 2;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Indice";
            // 
            // ObtenerElementoButton
            // 
            this.ObtenerElementoButton.Location = new System.Drawing.Point(213, 104);
            this.ObtenerElementoButton.Name = "ObtenerElementoButton";
            this.ObtenerElementoButton.Size = new System.Drawing.Size(101, 23);
            this.ObtenerElementoButton.TabIndex = 4;
            this.ObtenerElementoButton.Text = "Obtenet Elemento";
            this.ObtenerElementoButton.UseVisualStyleBackColor = true;
            this.ObtenerElementoButton.Click += new System.EventHandler(this.ObtenerElementoButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 20);
            this.textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 141);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ObtenerElementoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.ElementoTextBox);
            this.Controls.Add(this.AregarElementoLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AregarElementoLabel;
        private System.Windows.Forms.TextBox ElementoTextBox;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ObtenerElementoButton;
        private System.Windows.Forms.TextBox textBox2;
    }
}

