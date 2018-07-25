namespace UNFV.DemoCRUD
{
    partial class frmListarRegistros
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
            this.btnVerArticulos = new System.Windows.Forms.Button();
            this.txtArticulos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVerArticulos
            // 
            this.btnVerArticulos.Location = new System.Drawing.Point(63, 33);
            this.btnVerArticulos.Name = "btnVerArticulos";
            this.btnVerArticulos.Size = new System.Drawing.Size(188, 23);
            this.btnVerArticulos.TabIndex = 0;
            this.btnVerArticulos.Text = "Ver Artículos";
            this.btnVerArticulos.UseVisualStyleBackColor = true;
            this.btnVerArticulos.Click += new System.EventHandler(this.btnVerArticulos_Click);
            // 
            // txtArticulos
            // 
            this.txtArticulos.Location = new System.Drawing.Point(31, 76);
            this.txtArticulos.Multiline = true;
            this.txtArticulos.Name = "txtArticulos";
            this.txtArticulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArticulos.Size = new System.Drawing.Size(294, 153);
            this.txtArticulos.TabIndex = 1;
            // 
            // frmListarRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 251);
            this.Controls.Add(this.txtArticulos);
            this.Controls.Add(this.btnVerArticulos);
            this.Name = "frmListarRegistros";
            this.Text = "Listar Registros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerArticulos;
        private System.Windows.Forms.TextBox txtArticulos;
    }
}