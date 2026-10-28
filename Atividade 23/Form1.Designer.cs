namespace HelloWindowsForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            lblInterpretacao = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(275, 30);
            label1.Name = "label1";
            label1.Size = new Size(190, 37);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA IMC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(230, 89);
            label2.Name = "label2";
            label2.Size = new Size(90, 37);
            label2.TabIndex = 1;
            label2.Text = "PESO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(230, 185);
            label3.Name = "label3";
            label3.Size = new Size(128, 37);
            label3.TabIndex = 2;
            label3.Text = "ALTURA:";
            label3.Click += label3_Click;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPeso.Location = new Point(371, 90);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(123, 39);
            txtPeso.TabIndex = 3;
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAltura.Location = new Point(371, 186);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(123, 39);
            txtAltura.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(306, 265);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(138, 38);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += Calcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.Teal;
            lblResultado.Location = new Point(275, 324);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(152, 37);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado:";
            lblResultado.Click += lblResultado_Click;
            // 
            // lblInterpretacao
            // 
            lblInterpretacao.AutoSize = true;
            lblInterpretacao.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInterpretacao.ForeColor = Color.Teal;
            lblInterpretacao.Location = new Point(275, 373);
            lblInterpretacao.Name = "lblInterpretacao";
            lblInterpretacao.Size = new Size(152, 37);
            lblInterpretacao.TabIndex = 7;
            lblInterpretacao.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 430);
            Controls.Add(lblInterpretacao);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Default;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Teal;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Label lblResultado;
        private Label lblInterpretacao;
    }
}
