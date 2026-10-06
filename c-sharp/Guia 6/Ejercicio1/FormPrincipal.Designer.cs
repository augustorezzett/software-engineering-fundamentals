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
            gbPersonas = new GroupBox();
            btnEliminar = new Button();
            btnAgregar = new Button();
            ltbPersonas = new ListBox();
            gbPersonas.SuspendLayout();
            SuspendLayout();
            // 
            // gbPersonas
            // 
            gbPersonas.Controls.Add(btnEliminar);
            gbPersonas.Controls.Add(btnAgregar);
            gbPersonas.Controls.Add(ltbPersonas);
            gbPersonas.Location = new Point(10, 14);
            gbPersonas.Margin = new Padding(4, 5, 4, 5);
            gbPersonas.Name = "gbPersonas";
            gbPersonas.Padding = new Padding(4, 5, 4, 5);
            gbPersonas.Size = new Size(442, 225);
            gbPersonas.TabIndex = 12;
            gbPersonas.TabStop = false;
            gbPersonas.Text = "Listado de personas";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(335, 103);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 49);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(335, 44);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 49);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // ltbPersonas
            // 
            ltbPersonas.FormattingEnabled = true;
            ltbPersonas.ItemHeight = 20;
            ltbPersonas.Location = new Point(7, 27);
            ltbPersonas.Name = "ltbPersonas";
            ltbPersonas.Size = new Size(321, 184);
            ltbPersonas.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 251);
            Controls.Add(gbPersonas);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            gbPersonas.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private GroupBox gbPersonas;
        private ListBox ltbPersonas;
        private Button btnAgregar;
        private Button btnEliminar;
    }
}

