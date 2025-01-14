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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnEvento = new Button();
            btnDespesa = new Button();
            btnValorLq = new Button();
            btnAgendamentos = new Button();
            pb1 = new PictureBox();
            dt1 = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            SuspendLayout();
            // 
            // btnEvento
            // 
            btnEvento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEvento.Location = new Point(504, 411);
            btnEvento.Name = "btnEvento";
            btnEvento.Size = new Size(11, 15);
            btnEvento.TabIndex = 0;
            btnEvento.Text = "Cadastro de Eventos ";
            btnEvento.UseVisualStyleBackColor = true;
            btnEvento.Click += btnEvento_Click;
            // 
            // btnDespesa
            // 
            btnDespesa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDespesa.Location = new Point(262, 145);
            btnDespesa.Name = "btnDespesa";
            btnDespesa.Size = new Size(177, 61);
            btnDespesa.TabIndex = 1;
            btnDespesa.Text = "Cadastro de Despesas";
            btnDespesa.UseVisualStyleBackColor = true;
            btnDespesa.Click += btnDespesa_Click;
            // 
            // btnValorLq
            // 
            btnValorLq.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnValorLq.Location = new Point(147, 237);
            btnValorLq.Name = "btnValorLq";
            btnValorLq.Size = new Size(177, 65);
            btnValorLq.TabIndex = 2;
            btnValorLq.Text = "Valor Liquído ";
            btnValorLq.UseVisualStyleBackColor = true;
            btnValorLq.Click += btnValorLq_Click;
            // 
            // btnAgendamentos
            // 
            btnAgendamentos.FlatAppearance.BorderSize = 5;
            btnAgendamentos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgendamentos.Location = new Point(28, 145);
            btnAgendamentos.Name = "btnAgendamentos";
            btnAgendamentos.Size = new Size(177, 61);
            btnAgendamentos.TabIndex = 4;
            btnAgendamentos.Text = "Agendamentos";
            btnAgendamentos.UseVisualStyleBackColor = true;
            btnAgendamentos.Click += btnAgendamentos_Click;
            // 
            // pb1
            // 
            pb1.BackColor = Color.SeaShell;
            pb1.BackgroundImage = (Image)resources.GetObject("pb1.BackgroundImage");
            pb1.Image = (Image)resources.GetObject("pb1.Image");
            pb1.Location = new Point(330, 45);
            pb1.Name = "pb1";
            pb1.Size = new Size(37, 23);
            pb1.SizeMode = PictureBoxSizeMode.Zoom;
            pb1.TabIndex = 6;
            pb1.TabStop = false;
            pb1.Click += pb1_Click;
            // 
            // dt1
            // 
            dt1.Format = DateTimePickerFormat.Short;
            dt1.Location = new Point(156, 45);
            dt1.Name = "dt1";
            dt1.Size = new Size(168, 23);
            dt1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 21);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 8;
            label1.Text = "Pesquisar Eventos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(477, 375);
            Controls.Add(label1);
            Controls.Add(dt1);
            Controls.Add(pb1);
            Controls.Add(btnAgendamentos);
            Controls.Add(btnValorLq);
            Controls.Add(btnDespesa);
            Controls.Add(btnEvento);
            Cursor = Cursors.Hand;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEvento;
        private Button btnDespesa;
        private Button btnValorLq;
        private Button btnAgendamentos;
        private PictureBox pb1;
        private DateTimePicker dt1;
        private Label label1;
    }
}
