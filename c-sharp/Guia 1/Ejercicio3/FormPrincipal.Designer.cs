
namespace Ejercicio3
{
    partial class FormPrincipal
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
            this.btnRegistrarPeaje = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.lbVer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRegistrarPeaje
            // 
            this.btnRegistrarPeaje.Location = new System.Drawing.Point(589, 40);
            this.btnRegistrarPeaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrarPeaje.Name = "btnRegistrarPeaje";
            this.btnRegistrarPeaje.Size = new System.Drawing.Size(177, 63);
            this.btnRegistrarPeaje.TabIndex = 0;
            this.btnRegistrarPeaje.Text = "RegistrarPeaje";
            this.btnRegistrarPeaje.UseVisualStyleBackColor = true;
            this.btnRegistrarPeaje.Click += new System.EventHandler(this.btnRegistrarPeaje_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(589, 113);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(177, 61);
            this.btnVer.TabIndex = 1;
            this.btnVer.Text = "Ver Resumen";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // lbVer
            // 
            this.lbVer.FormattingEnabled = true;
            this.lbVer.ItemHeight = 20;
            this.lbVer.Location = new System.Drawing.Point(18, 40);
            this.lbVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(563, 424);
            this.lbVer.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 475);
            this.Controls.Add(this.lbVer);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnRegistrarPeaje);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarPeaje;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.ListBox lbVer;
    }
}

