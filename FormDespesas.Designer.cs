namespace Homes2
{
    partial class FormDespesas
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
            cbCategoria = new ComboBox();
            label1 = new Label();
            txtValor = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "Salários", "Gás", "Material", "Gasolina", "Luz ", "Água", "Uber" });
            cbCategoria.Location = new Point(186, 140);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(142, 23);
            cbCategoria.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 142);
            label1.Name = "label1";
            label1.Size = new Size(156, 21);
            label1.TabIndex = 10;
            label1.Text = "Selecione a categoria";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(186, 183);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(142, 23);
            txtValor.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 183);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 12;
            label2.Text = "Valor";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(219, 247);
            button1.Name = "button1";
            button1.Size = new Size(89, 32);
            button1.TabIndex = 13;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(148, 51);
            label3.Name = "label3";
            label3.Size = new Size(227, 34);
            label3.TabIndex = 14;
            label3.Text = "Cadastro Despesas";
            // 
            // FormDespesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 362);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Controls.Add(cbCategoria);
            Name = "FormDespesas";
            Text = "FormDespesas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbCategoria;
        private Label label1;
        private TextBox txtValor;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}