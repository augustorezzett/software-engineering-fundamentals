namespace Ejercicio3
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
            dtpInicio = new DateTimePicker();
            dtpFin = new DateTimePicker();
            btnIngresar = new Button();
            tbTicket = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dtpInicio
            // 
            dtpInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.Location = new Point(90, 62);
            dtpInicio.Margin = new Padding(4);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(202, 29);
            dtpInicio.TabIndex = 1;
            // 
            // dtpFin
            // 
            dtpFin.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpFin.Location = new Point(90, 139);
            dtpFin.Margin = new Padding(4);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(202, 29);
            dtpFin.TabIndex = 2;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(331, 88);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(123, 64);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Registrar Servicio";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnRegistrarServicio_Click;
            // 
            // tbTicket
            // 
            tbTicket.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTicket.Location = new Point(6, 28);
            tbTicket.Multiline = true;
            tbTicket.Name = "tbTicket";
            tbTicket.ScrollBars = ScrollBars.Both;
            tbTicket.Size = new Size(461, 345);
            tbTicket.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpInicio);
            groupBox1.Controls.Add(dtpFin);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 189);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del servicio de comunicaciones prestado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 114);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 6;
            label2.Text = "Hora de Fin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 37);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 5;
            label1.Text = "Hora de inicio";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbTicket);
            groupBox2.Location = new Point(12, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(480, 379);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle del Ticket";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 593);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFin;
        private Button btnIngresar;
        private TextBox tbTicket;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
    }
}
