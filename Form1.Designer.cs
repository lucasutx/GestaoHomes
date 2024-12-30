namespace Homes2
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
            btnEvento = new Button();
            btnDespesa = new Button();
            btnValorLq = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEvento
            // 
            btnEvento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEvento.Location = new Point(115, 81);
            btnEvento.Name = "btnEvento";
            btnEvento.Size = new Size(240, 72);
            btnEvento.TabIndex = 0;
            btnEvento.Text = "Cadastro de Eventos ";
            btnEvento.UseVisualStyleBackColor = true;
            btnEvento.Click += btnEvento_Click;
            // 
            // btnDespesa
            // 
            btnDespesa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDespesa.Location = new Point(115, 194);
            btnDespesa.Name = "btnDespesa";
            btnDespesa.Size = new Size(240, 75);
            btnDespesa.TabIndex = 1;
            btnDespesa.Text = "Cadastro de Despesas";
            btnDespesa.UseVisualStyleBackColor = true;
            btnDespesa.Click += btnDespesa_Click;
            // 
            // btnValorLq
            // 
            btnValorLq.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnValorLq.Location = new Point(115, 314);
            btnValorLq.Name = "btnValorLq";
            btnValorLq.Size = new Size(240, 78);
            btnValorLq.TabIndex = 2;
            btnValorLq.Text = "Valor Liquído ";
            btnValorLq.UseVisualStyleBackColor = true;
            btnValorLq.Click += btnValorLq_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 20);
            label1.Name = "label1";
            label1.Size = new Size(272, 33);
            label1.TabIndex = 3;
            label1.Text = "HOME´S PIZZARIA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(470, 447);
            Controls.Add(label1);
            Controls.Add(btnValorLq);
            Controls.Add(btnDespesa);
            Controls.Add(btnEvento);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEvento;
        private Button btnDespesa;
        private Button btnValorLq;
        private Label label1;
    }
}
