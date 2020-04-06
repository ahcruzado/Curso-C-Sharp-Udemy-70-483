namespace XmlDom
{
    partial class Form2
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
            this.CargaTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.CargarButton = new System.Windows.Forms.Button();
            this.BuscarNodoTextBox = new System.Windows.Forms.TextBox();
            this.BuscarNodoButton = new System.Windows.Forms.Button();
            this.BuscarNodoResultTextBox = new System.Windows.Forms.TextBox();
            this.BusquedaCursoResultTextBox = new System.Windows.Forms.TextBox();
            this.BuscarCursoButton = new System.Windows.Forms.Button();
            this.AgregarNodoTextBox = new System.Windows.Forms.TextBox();
            this.AgregarNodoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CargaTextBox
            // 
            this.CargaTextBox.Location = new System.Drawing.Point(12, 38);
            this.CargaTextBox.Multiline = true;
            this.CargaTextBox.Name = "CargaTextBox";
            this.CargaTextBox.Size = new System.Drawing.Size(317, 329);
            this.CargaTextBox.TabIndex = 4;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(12, 9);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(56, 23);
            this.BuscarButton.TabIndex = 3;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // CargarButton
            // 
            this.CargarButton.Location = new System.Drawing.Point(254, 9);
            this.CargarButton.Name = "CargarButton";
            this.CargarButton.Size = new System.Drawing.Size(75, 23);
            this.CargarButton.TabIndex = 5;
            this.CargarButton.Text = "Cargar";
            this.CargarButton.UseVisualStyleBackColor = true;
            this.CargarButton.Click += new System.EventHandler(this.CargarButton_Click);
            // 
            // BuscarNodoTextBox
            // 
            this.BuscarNodoTextBox.Location = new System.Drawing.Point(417, 12);
            this.BuscarNodoTextBox.Name = "BuscarNodoTextBox";
            this.BuscarNodoTextBox.Size = new System.Drawing.Size(156, 20);
            this.BuscarNodoTextBox.TabIndex = 8;
            // 
            // BuscarNodoButton
            // 
            this.BuscarNodoButton.Location = new System.Drawing.Point(335, 10);
            this.BuscarNodoButton.Name = "BuscarNodoButton";
            this.BuscarNodoButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarNodoButton.TabIndex = 7;
            this.BuscarNodoButton.Text = "Buscar Nodo";
            this.BuscarNodoButton.UseVisualStyleBackColor = true;
            this.BuscarNodoButton.Click += new System.EventHandler(this.BuscarNodoButton_Click);
            // 
            // BuscarNodoResultTextBox
            // 
            this.BuscarNodoResultTextBox.Location = new System.Drawing.Point(335, 39);
            this.BuscarNodoResultTextBox.Multiline = true;
            this.BuscarNodoResultTextBox.Name = "BuscarNodoResultTextBox";
            this.BuscarNodoResultTextBox.Size = new System.Drawing.Size(238, 160);
            this.BuscarNodoResultTextBox.TabIndex = 9;
            // 
            // BusquedaCursoResultTextBox
            // 
            this.BusquedaCursoResultTextBox.Location = new System.Drawing.Point(335, 234);
            this.BusquedaCursoResultTextBox.Multiline = true;
            this.BusquedaCursoResultTextBox.Name = "BusquedaCursoResultTextBox";
            this.BusquedaCursoResultTextBox.Size = new System.Drawing.Size(238, 133);
            this.BusquedaCursoResultTextBox.TabIndex = 11;
            // 
            // BuscarCursoButton
            // 
            this.BuscarCursoButton.Location = new System.Drawing.Point(335, 207);
            this.BuscarCursoButton.Name = "BuscarCursoButton";
            this.BuscarCursoButton.Size = new System.Drawing.Size(238, 23);
            this.BuscarCursoButton.TabIndex = 10;
            this.BuscarCursoButton.Text = "Buscar Curso";
            this.BuscarCursoButton.UseVisualStyleBackColor = true;
            // 
            // AgregarNodoTextBox
            // 
            this.AgregarNodoTextBox.Location = new System.Drawing.Point(579, 39);
            this.AgregarNodoTextBox.Multiline = true;
            this.AgregarNodoTextBox.Name = "AgregarNodoTextBox";
            this.AgregarNodoTextBox.Size = new System.Drawing.Size(238, 328);
            this.AgregarNodoTextBox.TabIndex = 13;
            // 
            // AgregarNodoButton
            // 
            this.AgregarNodoButton.Location = new System.Drawing.Point(579, 11);
            this.AgregarNodoButton.Name = "AgregarNodoButton";
            this.AgregarNodoButton.Size = new System.Drawing.Size(238, 23);
            this.AgregarNodoButton.TabIndex = 12;
            this.AgregarNodoButton.Text = "Agregar Nodo";
            this.AgregarNodoButton.UseVisualStyleBackColor = true;
            this.AgregarNodoButton.Click += new System.EventHandler(this.AgregarNodoButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 377);
            this.Controls.Add(this.AgregarNodoTextBox);
            this.Controls.Add(this.AgregarNodoButton);
            this.Controls.Add(this.BusquedaCursoResultTextBox);
            this.Controls.Add(this.BuscarCursoButton);
            this.Controls.Add(this.BuscarNodoResultTextBox);
            this.Controls.Add(this.BuscarNodoTextBox);
            this.Controls.Add(this.BuscarNodoButton);
            this.Controls.Add(this.CargarButton);
            this.Controls.Add(this.CargaTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CargaTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button CargarButton;
        private System.Windows.Forms.TextBox BuscarNodoTextBox;
        private System.Windows.Forms.Button BuscarNodoButton;
        private System.Windows.Forms.TextBox BuscarNodoResultTextBox;
        private System.Windows.Forms.TextBox BusquedaCursoResultTextBox;
        private System.Windows.Forms.Button BuscarCursoButton;
        private System.Windows.Forms.TextBox AgregarNodoTextBox;
        private System.Windows.Forms.Button AgregarNodoButton;
    }
}