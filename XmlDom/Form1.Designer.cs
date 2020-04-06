namespace XmlDom
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
            this.BuscarButton = new System.Windows.Forms.Button();
            this.CargarButton = new System.Windows.Forms.Button();
            this.CargaTextBox = new System.Windows.Forms.TextBox();
            this.BuscarNodoButton = new System.Windows.Forms.Button();
            this.BuscarNodoTextBox = new System.Windows.Forms.TextBox();
            this.BuscarNodoListBox = new System.Windows.Forms.ListBox();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.ModifocacionTextBox = new System.Windows.Forms.TextBox();
            this.AgregarNodoTextBox = new System.Windows.Forms.TextBox();
            this.AgregarNodoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(11, 7);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(56, 23);
            this.BuscarButton.TabIndex = 0;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // CargarButton
            // 
            this.CargarButton.Location = new System.Drawing.Point(253, 8);
            this.CargarButton.Name = "CargarButton";
            this.CargarButton.Size = new System.Drawing.Size(75, 23);
            this.CargarButton.TabIndex = 1;
            this.CargarButton.Text = "Cargar";
            this.CargarButton.UseVisualStyleBackColor = true;
            this.CargarButton.Click += new System.EventHandler(this.CargarButton_Click);
            // 
            // CargaTextBox
            // 
            this.CargaTextBox.Location = new System.Drawing.Point(11, 36);
            this.CargaTextBox.Multiline = true;
            this.CargaTextBox.Name = "CargaTextBox";
            this.CargaTextBox.Size = new System.Drawing.Size(317, 329);
            this.CargaTextBox.TabIndex = 2;
            // 
            // BuscarNodoButton
            // 
            this.BuscarNodoButton.Location = new System.Drawing.Point(334, 8);
            this.BuscarNodoButton.Name = "BuscarNodoButton";
            this.BuscarNodoButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarNodoButton.TabIndex = 4;
            this.BuscarNodoButton.Text = "Buscar Nodo";
            this.BuscarNodoButton.UseVisualStyleBackColor = true;
            this.BuscarNodoButton.Click += new System.EventHandler(this.BuscarNodoButton_Click);
            // 
            // BuscarNodoTextBox
            // 
            this.BuscarNodoTextBox.Location = new System.Drawing.Point(416, 10);
            this.BuscarNodoTextBox.Name = "BuscarNodoTextBox";
            this.BuscarNodoTextBox.Size = new System.Drawing.Size(167, 20);
            this.BuscarNodoTextBox.TabIndex = 5;
            // 
            // BuscarNodoListBox
            // 
            this.BuscarNodoListBox.FormattingEnabled = true;
            this.BuscarNodoListBox.Location = new System.Drawing.Point(334, 36);
            this.BuscarNodoListBox.Name = "BuscarNodoListBox";
            this.BuscarNodoListBox.Size = new System.Drawing.Size(249, 82);
            this.BuscarNodoListBox.TabIndex = 6;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(334, 124);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(249, 23);
            this.ModificarButton.TabIndex = 7;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // ModifocacionTextBox
            // 
            this.ModifocacionTextBox.Location = new System.Drawing.Point(334, 153);
            this.ModifocacionTextBox.Multiline = true;
            this.ModifocacionTextBox.Name = "ModifocacionTextBox";
            this.ModifocacionTextBox.Size = new System.Drawing.Size(249, 212);
            this.ModifocacionTextBox.TabIndex = 8;
            // 
            // AgregarNodoTextBox
            // 
            this.AgregarNodoTextBox.Location = new System.Drawing.Point(589, 36);
            this.AgregarNodoTextBox.Multiline = true;
            this.AgregarNodoTextBox.Name = "AgregarNodoTextBox";
            this.AgregarNodoTextBox.Size = new System.Drawing.Size(249, 329);
            this.AgregarNodoTextBox.TabIndex = 10;
            // 
            // AgregarNodoButton
            // 
            this.AgregarNodoButton.Location = new System.Drawing.Point(589, 7);
            this.AgregarNodoButton.Name = "AgregarNodoButton";
            this.AgregarNodoButton.Size = new System.Drawing.Size(249, 23);
            this.AgregarNodoButton.TabIndex = 9;
            this.AgregarNodoButton.Text = "Agregar Nodo";
            this.AgregarNodoButton.UseVisualStyleBackColor = true;
            this.AgregarNodoButton.Click += new System.EventHandler(this.AgregarNodoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 377);
            this.Controls.Add(this.AgregarNodoTextBox);
            this.Controls.Add(this.AgregarNodoButton);
            this.Controls.Add(this.ModifocacionTextBox);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.BuscarNodoListBox);
            this.Controls.Add(this.BuscarNodoTextBox);
            this.Controls.Add(this.BuscarNodoButton);
            this.Controls.Add(this.CargaTextBox);
            this.Controls.Add(this.CargarButton);
            this.Controls.Add(this.BuscarButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button CargarButton;
        private System.Windows.Forms.TextBox CargaTextBox;
        private System.Windows.Forms.Button BuscarNodoButton;
        private System.Windows.Forms.TextBox BuscarNodoTextBox;
        private System.Windows.Forms.ListBox BuscarNodoListBox;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.TextBox ModifocacionTextBox;
        private System.Windows.Forms.TextBox AgregarNodoTextBox;
        private System.Windows.Forms.Button AgregarNodoButton;
    }
}

