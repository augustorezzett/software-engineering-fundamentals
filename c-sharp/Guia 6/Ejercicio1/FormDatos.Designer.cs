namespace Ejercicio1
{
    partial class FormDatos
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
            gbDatosPersona = new GroupBox();
            lbMensajeNombre = new Label();
            lbMensajeCUIT = new Label();
            groupBox1 = new GroupBox();
            rbFisica = new RadioButton();
            rbJuridica = new RadioButton();
            label1 = new Label();
            tbCUIT = new TextBox();
            lbDescripcionPeriodo = new Label();
            tbNombre = new TextBox();
            btnIniciarPrespuesto = new Button();
            btnBorrarProducto = new Button();
            gbDatosPersona.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbDatosPersona
            // 
            gbDatosPersona.Controls.Add(lbMensajeNombre);
            gbDatosPersona.Controls.Add(lbMensajeCUIT);
            gbDatosPersona.Controls.Add(groupBox1);
            gbDatosPersona.Controls.Add(label1);
            gbDatosPersona.Controls.Add(tbCUIT);
            gbDatosPersona.Controls.Add(lbDescripcionPeriodo);
            gbDatosPersona.Controls.Add(tbNombre);
            gbDatosPersona.Location = new Point(13, 14);
            gbDatosPersona.Margin = new Padding(4, 5, 4, 5);
            gbDatosPersona.Name = "gbDatosPersona";
            gbDatosPersona.Padding = new Padding(4, 5, 4, 5);
            gbDatosPersona.Size = new Size(467, 253);
            gbDatosPersona.TabIndex = 12;
            gbDatosPersona.TabStop = false;
            gbDatosPersona.Text = "Datos de la Persona";
            // 
            // lbMensajeNombre
            // 
            lbMensajeNombre.BackColor = SystemColors.ActiveCaption;
            lbMensajeNombre.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbMensajeNombre.Location = new Point(115, 60);
            lbMensajeNombre.Margin = new Padding(4, 0, 4, 0);
            lbMensajeNombre.Name = "lbMensajeNombre";
            lbMensajeNombre.Size = new Size(344, 36);
            lbMensajeNombre.TabIndex = 17;
            // 
            // lbMensajeCUIT
            // 
            lbMensajeCUIT.BackColor = SystemColors.ActiveCaption;
            lbMensajeCUIT.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbMensajeCUIT.Location = new Point(115, 132);
            lbMensajeCUIT.Margin = new Padding(4, 0, 4, 0);
            lbMensajeCUIT.Name = "lbMensajeCUIT";
            lbMensajeCUIT.Size = new Size(344, 40);
            lbMensajeCUIT.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFisica);
            groupBox1.Controls.Add(rbJuridica);
            groupBox1.Location = new Point(115, 177);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(276, 67);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de persona";
            // 
            // rbFisica
            // 
            rbFisica.AutoSize = true;
            rbFisica.Location = new Point(64, 27);
            rbFisica.Name = "rbFisica";
            rbFisica.Size = new Size(68, 24);
            rbFisica.TabIndex = 22;
            rbFisica.TabStop = true;
            rbFisica.Text = "Física";
            rbFisica.UseVisualStyleBackColor = true;
            rbFisica.CheckedChanged += rbFisica_CheckedChanged;
            // 
            // rbJuridica
            // 
            rbJuridica.AutoSize = true;
            rbJuridica.Location = new Point(170, 27);
            rbJuridica.Name = "rbJuridica";
            rbJuridica.Size = new Size(81, 24);
            rbJuridica.TabIndex = 23;
            rbJuridica.TabStop = true;
            rbJuridica.Text = "Jurídica";
            rbJuridica.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 104);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 14;
            label1.Text = "CUIT";
            // 
            // tbCUIT
            // 
            tbCUIT.Location = new Point(115, 101);
            tbCUIT.Margin = new Padding(4, 5, 4, 5);
            tbCUIT.Name = "tbCUIT";
            tbCUIT.Size = new Size(152, 26);
            tbCUIT.TabIndex = 13;
            // 
            // lbDescripcionPeriodo
            // 
            lbDescripcionPeriodo.AutoSize = true;
            lbDescripcionPeriodo.Location = new Point(29, 32);
            lbDescripcionPeriodo.Margin = new Padding(4, 0, 4, 0);
            lbDescripcionPeriodo.Name = "lbDescripcionPeriodo";
            lbDescripcionPeriodo.Size = new Size(65, 20);
            lbDescripcionPeriodo.TabIndex = 12;
            lbDescripcionPeriodo.Text = "Nombre";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(115, 29);
            tbNombre.Margin = new Padding(4, 5, 4, 5);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(152, 26);
            tbNombre.TabIndex = 11;
            // 
            // btnIniciarPrespuesto
            // 
            btnIniciarPrespuesto.DialogResult = DialogResult.OK;
            btnIniciarPrespuesto.Location = new Point(71, 277);
            btnIniciarPrespuesto.Margin = new Padding(4, 5, 4, 5);
            btnIniciarPrespuesto.Name = "btnIniciarPrespuesto";
            btnIniciarPrespuesto.Size = new Size(121, 53);
            btnIniciarPrespuesto.TabIndex = 5;
            btnIniciarPrespuesto.Text = "Confirmar";
            btnIniciarPrespuesto.UseVisualStyleBackColor = true;
            // 
            // btnBorrarProducto
            // 
            btnBorrarProducto.DialogResult = DialogResult.Cancel;
            btnBorrarProducto.Location = new Point(286, 277);
            btnBorrarProducto.Margin = new Padding(4, 5, 4, 5);
            btnBorrarProducto.Name = "btnBorrarProducto";
            btnBorrarProducto.Size = new Size(118, 53);
            btnBorrarProducto.TabIndex = 3;
            btnBorrarProducto.Text = "Cancelar";
            btnBorrarProducto.UseVisualStyleBackColor = true;
            // 
            // FormDatos
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 335);
            Controls.Add(gbDatosPersona);
            Controls.Add(btnBorrarProducto);
            Controls.Add(btnIniciarPrespuesto);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormDatos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Datos";
            gbDatosPersona.ResumeLayout(false);
            gbDatosPersona.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private GroupBox gbDatosPersona;
        private Label label1;
        private Label lbDescripcionPeriodo;
        private Button btnIniciarPrespuesto;
        private GroupBox groupBox1;
        private Button btnBorrarProducto;
        public RadioButton rbJuridica;
        public RadioButton rbFisica;
        public TextBox tbCUIT;
        public TextBox tbNombre;
        public Label lbMensajeCUIT;
        public Label lbMensajeNombre;
    }
}