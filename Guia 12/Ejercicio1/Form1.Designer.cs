namespace Ejercicio1
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
            btnSolicitar = new Button();
            label1 = new Label();
            lbMostrarValor = new TextBox();
            SuspendLayout();
            // 
            // btnSolicitar
            // 
            btnSolicitar.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSolicitar.Location = new Point(151, 65);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(136, 38);
            btnSolicitar.TabIndex = 0;
            btnSolicitar.Text = "Solicitar valor";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Adobe Heiti Std R", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 136);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 1;
            label1.Text = "Resultado: ";
            // 
            // lbMostrarValor
            // 
            lbMostrarValor.BackColor = SystemColors.ActiveCaption;
            lbMostrarValor.Location = new Point(151, 133);
            lbMostrarValor.Name = "lbMostrarValor";
            lbMostrarValor.Size = new Size(136, 23);
            lbMostrarValor.TabIndex = 2;
            lbMostrarValor.TextChanged += lbMostrarValor_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 190);
            Controls.Add(lbMostrarValor);
            Controls.Add(label1);
            Controls.Add(btnSolicitar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSolicitar;
        private Label label1;
        private TextBox lbMostrarValor;
    }
}
