namespace Boleteria
{
    partial class fReserva
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            btnEnviar = new Button();
            btnVer = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtCantidad = new TextBox();
            qtyCantidad = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 32);
            label1.Name = "label1";
            label1.Size = new Size(559, 32);
            label1.TabIndex = 0;
            label1.Text = "INGRESA TUS DATOS PARA OBTENER TUS BOLETOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 86);
            label2.Name = "label2";
            label2.Size = new Size(117, 32);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 152);
            label3.Name = "label3";
            label3.Size = new Size(267, 32);
            label3.TabIndex = 2;
            label3.Text = "CORREO ELECTRÓNICO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 209);
            label4.Name = "label4";
            label4.Size = new Size(260, 32);
            label4.TabIndex = 3;
            label4.Text = "NÚMERO TELEFONICO:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(328, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(329, 39);
            txtNombre.TabIndex = 0;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(328, 145);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(329, 39);
            txtCorreo.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(328, 202);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(329, 39);
            txtTelefono.TabIndex = 2;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(390, 341);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(267, 46);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Obtener Boletos";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(52, 341);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(267, 46);
            btnVer.TabIndex = 5;
            btnVer.Text = "Ver Boletos";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 261);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 273);
            label6.Name = "label6";
            label6.Size = new Size(271, 32);
            label6.TabIndex = 10;
            label6.Text = "# DE BOLETOS (MAX. 5):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(542, 273);
            label7.Name = "label7";
            label7.Size = new Size(73, 32);
            label7.TabIndex = 11;
            label7.Text = "DISP.:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(328, 266);
            txtCantidad.MaxLength = 1;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(208, 39);
            txtCantidad.TabIndex = 3;
            // 
            // qtyCantidad
            // 
            qtyCantidad.AutoSize = true;
            qtyCantidad.Location = new Point(617, 273);
            qtyCantidad.Name = "qtyCantidad";
            qtyCantidad.Size = new Size(40, 32);
            qtyCantidad.TabIndex = 13;
            qtyCantidad.Text = "00";
            // 
            // fReserva
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 450);
            Controls.Add(qtyCantidad);
            Controls.Add(txtCantidad);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnVer);
            Controls.Add(btnEnviar);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fReserva";
            Load += fReserva_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Button btnEnviar;
        private Button btnVer;
        private Label label5;
        private Label label6;
        private Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtCantidad;
        private Label qtyCantidad;
    }
}