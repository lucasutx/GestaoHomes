namespace Homes2
{
    partial class FormValorLiquido
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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            dtInicio = new DateTimePicker();
            dtFim = new DateTimePicker();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(1, 0);
            label3.Name = "label3";
            label3.Size = new Size(183, 37);
            label3.TabIndex = 15;
            label3.Text = "Lucro Mensal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 84);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 16;
            label1.Text = "Data Inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 152);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 17;
            label2.Text = "Data Final";
            // 
            // dtInicio
            // 
            dtInicio.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInicio.CalendarForeColor = SystemColors.ActiveCaptionText;
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(163, 82);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(110, 23);
            dtInicio.TabIndex = 18;
            // 
            // dtFim
            // 
            dtFim.AllowDrop = true;
            dtFim.CalendarMonthBackground = SystemColors.ButtonHighlight;
            dtFim.Format = DateTimePickerFormat.Short;
            dtFim.Location = new Point(163, 152);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(110, 23);
            dtFim.TabIndex = 19;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(172, 206);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(87, 28);
            btnCalcular.TabIndex = 20;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FormValorLiquido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 328);
            Controls.Add(btnCalcular);
            Controls.Add(dtFim);
            Controls.Add(dtInicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "FormValorLiquido";
            Text = "FormValorLiquido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private DateTimePicker dtInicio;
        private DateTimePicker dtFim;
        private Button btnCalcular;
    }
}