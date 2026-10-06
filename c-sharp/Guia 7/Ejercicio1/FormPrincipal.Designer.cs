namespace Ejercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            dtpFechaNacimiento = new DateTimePicker();
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            lsbFechas = new ListBox();
            label3 = new Label();
            lbEdad = new Label();
            SuspendLayout();
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.Location = new Point(74, 36);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(158, 26);
            dtpFechaNacimiento.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(271, 22);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 57);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar Fecha";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 24);
            label1.TabIndex = 3;
            label1.Text = "Fecha y hora de nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 4;
            label2.Text = "Salida";
            // 
            // lsbFechas
            // 
            lsbFechas.FormattingEnabled = true;
            lsbFechas.ItemHeight = 20;
            lsbFechas.Location = new Point(12, 105);
            lsbFechas.Name = "lsbFechas";
            lsbFechas.Size = new Size(220, 144);
            lsbFechas.TabIndex = 5;
            lsbFechas.SelectedValueChanged += listBox1_SelectedValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 165);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 7;
            label3.Text = "Edad:";
            // 
            // lbEdad
            // 
            lbEdad.BackColor = SystemColors.ActiveCaption;
            lbEdad.ForeColor = SystemColors.ActiveCaptionText;
            lbEdad.Location = new Point(295, 165);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(81, 20);
            lbEdad.TabIndex = 8;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 266);
            Controls.Add(lbEdad);
            Controls.Add(label3);
            Controls.Add(lsbFechas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(dtpFechaNacimiento);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DateTimePicker dtpFechaNacimiento;
        private TextBox textBox1;
        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private ListBox lsbFechas;
        private Label label3;
        private Label lbEdad;
    }
}

