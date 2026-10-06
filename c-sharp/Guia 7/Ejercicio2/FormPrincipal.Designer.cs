namespace Ejercicio2
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
            btnGenerarListado = new Button();
            nudAnio = new NumericUpDown();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            lsbFechas = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudAnio).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnGenerarListado
            // 
            btnGenerarListado.Location = new Point(435, 167);
            btnGenerarListado.Margin = new Padding(6, 8, 6, 8);
            btnGenerarListado.Name = "btnGenerarListado";
            btnGenerarListado.Size = new Size(110, 73);
            btnGenerarListado.TabIndex = 13;
            btnGenerarListado.Text = "Generar Listado";
            btnGenerarListado.UseVisualStyleBackColor = true;
            btnGenerarListado.Click += btnGenerarListado_Click;
            // 
            // nudAnio
            // 
            nudAnio.Location = new Point(193, 50);
            nudAnio.Margin = new Padding(3, 5, 3, 5);
            nudAnio.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nudAnio.Name = "nudAnio";
            nudAnio.Size = new Size(117, 26);
            nudAnio.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsbFechas);
            groupBox1.Controls.Add(btnGenerarListado);
            groupBox1.Location = new Point(12, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(554, 379);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Días relevantes de cada mes";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(nudAnio);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(554, 100);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seleccionar el año para generar fechas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 52);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Año";
            // 
            // lsbFechas
            // 
            lsbFechas.FormattingEnabled = true;
            lsbFechas.ItemHeight = 20;
            lsbFechas.Location = new Point(6, 25);
            lsbFechas.Name = "lsbFechas";
            lsbFechas.Size = new Size(420, 344);
            lsbFechas.TabIndex = 15;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 502);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 2";
            ((System.ComponentModel.ISupportInitialize)nudAnio).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGenerarListado;
        private NumericUpDown nudAnio;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private ListBox lsbFechas;
    }
}

