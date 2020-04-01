namespace Presentacion02
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
            this.ClasesListBox = new System.Windows.Forms.ListBox();
            this.AtributosListBox = new System.Windows.Forms.ListBox();
            this.MetodosListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ClasesListBox
            // 
            this.ClasesListBox.FormattingEnabled = true;
            this.ClasesListBox.Location = new System.Drawing.Point(2, 1);
            this.ClasesListBox.Name = "ClasesListBox";
            this.ClasesListBox.Size = new System.Drawing.Size(120, 212);
            this.ClasesListBox.TabIndex = 0;
            // 
            // AtributosListBox
            // 
            this.AtributosListBox.FormattingEnabled = true;
            this.AtributosListBox.Location = new System.Drawing.Point(128, 1);
            this.AtributosListBox.Name = "AtributosListBox";
            this.AtributosListBox.Size = new System.Drawing.Size(120, 212);
            this.AtributosListBox.TabIndex = 1;
            // 
            // MetodosListBox
            // 
            this.MetodosListBox.FormattingEnabled = true;
            this.MetodosListBox.Location = new System.Drawing.Point(254, 1);
            this.MetodosListBox.Name = "MetodosListBox";
            this.MetodosListBox.Size = new System.Drawing.Size(120, 212);
            this.MetodosListBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 283);
            this.Controls.Add(this.MetodosListBox);
            this.Controls.Add(this.AtributosListBox);
            this.Controls.Add(this.ClasesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ClasesListBox;
        private System.Windows.Forms.ListBox AtributosListBox;
        private System.Windows.Forms.ListBox MetodosListBox;
    }
}

