namespace Ejercicio3
{
    partial class Form1
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
            lbCantidad = new Label();
            label2 = new Label();
            lsbListado = new ListBox();
            label1 = new Label();
            btnSolicitar = new Button();
            SuspendLayout();
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.Location = new Point(215, 63);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(38, 15);
            lbCantidad.TabIndex = 10;
            lbCantidad.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 63);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 9;
            label2.Text = "Cantidad:";
            // 
            // lsbListado
            // 
            lsbListado.FormattingEnabled = true;
            lsbListado.ItemHeight = 15;
            lsbListado.Location = new Point(17, 81);
            lsbListado.Name = "lsbListado";
            lsbListado.Size = new Size(254, 109);
            lsbListado.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 63);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 7;
            label1.Text = "Listado";
            // 
            // btnSolicitar
            // 
            btnSolicitar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSolicitar.Location = new Point(83, 12);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(126, 32);
            btnSolicitar.TabIndex = 6;
            btnSolicitar.Text = "Solicitar Valor";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 207);
            Controls.Add(lbCantidad);
            Controls.Add(label2);
            Controls.Add(lsbListado);
            Controls.Add(label1);
            Controls.Add(btnSolicitar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCantidad;
        private Label label2;
        private ListBox lsbListado;
        private Label label1;
        private Button btnSolicitar;
    }
}
