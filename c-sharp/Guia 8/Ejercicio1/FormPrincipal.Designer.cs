namespace Ejercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMostrar = new TextBox();
            btnImportar = new Button();
            btnExportar = new Button();
            SuspendLayout();
            // 
            // txtMostrar
            // 
            txtMostrar.Location = new Point(15, 17);
            txtMostrar.Margin = new Padding(4, 4, 4, 4);
            txtMostrar.Multiline = true;
            txtMostrar.Name = "txtMostrar";
            txtMostrar.Size = new Size(448, 406);
            txtMostrar.TabIndex = 0;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(472, 132);
            btnImportar.Margin = new Padding(4, 4, 4, 4);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(126, 95);
            btnImportar.TabIndex = 1;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += Listar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(472, 235);
            btnExportar.Margin = new Padding(4, 4, 4, 4);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(126, 95);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 437);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(txtMostrar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMostrar;
        private Button btnImportar;
        private Button btnExportar;
    }
}
