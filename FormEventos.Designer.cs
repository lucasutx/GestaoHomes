namespace Homes2
{
    partial class FormEventos
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
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            txtPreco = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bntCadastrar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(210, 113);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(178, 21);
            txtNome.TabIndex = 0;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(210, 176);
            txtEndereco.Multiline = true;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(183, 21);
            txtEndereco.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(210, 243);
            txtPreco.Multiline = true;
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(183, 21);
            txtPreco.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 111);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 3;
            label1.Text = "Nome Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 174);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 4;
            label2.Text = "Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(77, 243);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 5;
            label3.Text = "Valor Evento ";
            // 
            // bntCadastrar
            // 
            bntCadastrar.BackColor = SystemColors.ControlLight;
            bntCadastrar.BackgroundImageLayout = ImageLayout.Center;
            bntCadastrar.Cursor = Cursors.Hand;
            bntCadastrar.FlatAppearance.BorderSize = 4;
            bntCadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bntCadastrar.ForeColor = SystemColors.ActiveCaptionText;
            bntCadastrar.Location = new Point(261, 301);
            bntCadastrar.Name = "bntCadastrar";
            bntCadastrar.Size = new Size(99, 38);
            bntCadastrar.TabIndex = 6;
            bntCadastrar.Text = "Cadastrar";
            bntCadastrar.UseVisualStyleBackColor = false;
            bntCadastrar.Click += bntCadastrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(176, 30);
            label4.Name = "label4";
            label4.Size = new Size(217, 34);
            label4.TabIndex = 7;
            label4.Text = "Cadastro  Eventos";
            // 
            // FormEventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(556, 376);
            Controls.Add(label4);
            Controls.Add(bntCadastrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPreco);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Name = "FormEventos";
            Text = "FormEventos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtPreco;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button bntCadastrar;
        private Label label4;
    }
}