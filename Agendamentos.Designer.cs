namespace Homes2
{
    partial class Agendamentos
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
            label4 = new Label();
            data = new DateTimePicker();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEndereco = new TextBox();
            cbStatus = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCadastrar = new Button();
            txtValor = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(1, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 37);
            label4.TabIndex = 8;
            label4.Text = "Agenda";
            // 
            // data
            // 
            data.CalendarTrailingForeColor = SystemColors.MenuBar;
            data.Format = DateTimePickerFormat.Short;
            data.Location = new Point(184, 85);
            data.Name = "data";
            data.Size = new Size(139, 23);
            data.TabIndex = 9;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(184, 120);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(139, 23);
            txtNome.TabIndex = 10;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(184, 159);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(139, 23);
            txtTelefone.TabIndex = 11;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(184, 197);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(139, 23);
            txtEndereco.TabIndex = 12;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Confirmado\t", "Pendente" });
            cbStatus.Location = new Point(184, 237);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(139, 23);
            cbStatus.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 89);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 14;
            label1.Text = "Data Evento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 126);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 15;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 165);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 16;
            label3.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 203);
            label5.Name = "label5";
            label5.Size = new Size(63, 17);
            label5.TabIndex = 17;
            label5.Text = "Endereço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(59, 243);
            label6.Name = "label6";
            label6.Size = new Size(106, 17);
            label6.TabIndex = 18;
            label6.Text = "Status do Evento";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(204, 324);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(87, 32);
            btnCadastrar.TabIndex = 19;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(184, 276);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(139, 23);
            txtValor.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(59, 282);
            label7.Name = "label7";
            label7.Size = new Size(38, 17);
            label7.TabIndex = 21;
            label7.Text = "Valor";
            // 
            // Agendamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 368);
            Controls.Add(label7);
            Controls.Add(txtValor);
            Controls.Add(btnCadastrar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbStatus);
            Controls.Add(txtEndereco);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(data);
            Controls.Add(label4);
            Name = "Agendamentos";
            Text = "Agendamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DateTimePicker data;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEndereco;
        private ComboBox cbStatus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button btnCadastrar;
        private TextBox txtValor;
        private Label label7;
    }
}