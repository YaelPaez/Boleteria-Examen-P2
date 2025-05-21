namespace Boleteria
{
    partial class fVista
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
            dgBoletos = new DataGridView();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgBoletos).BeginInit();
            SuspendLayout();
            // 
            // dgBoletos
            // 
            dgBoletos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBoletos.Location = new Point(69, 12);
            dgBoletos.Name = "dgBoletos";
            dgBoletos.RowHeadersWidth = 82;
            dgBoletos.Size = new Size(1185, 557);
            dgBoletos.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(517, 634);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(150, 46);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // fVista
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 710);
            Controls.Add(btnCerrar);
            Controls.Add(dgBoletos);
            Name = "fVista";
            Text = "fVista";
            Load += fVista_Load;
            ((System.ComponentModel.ISupportInitialize)dgBoletos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgBoletos;
        private Button btnCerrar;
    }
}