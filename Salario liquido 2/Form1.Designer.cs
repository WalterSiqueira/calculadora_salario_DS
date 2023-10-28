namespace Salario_liquido_2
{
    partial class cadastro
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
            Sair = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelPrevidencia = new Label();
            labelSalarioLiq = new Label();
            labelimposto = new Label();
            pictureBox1 = new PictureBox();
            Calcular = new Button();
            labelSalarioBrut = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(428, 51);
            label1.TabIndex = 1;
            label1.Text = "Calculo Salario Liquido";
            label1.Click += label1_Click;
            // 
            // Sair
            // 
            Sair.Location = new Point(488, 387);
            Sair.Name = "Sair";
            Sair.Size = new Size(136, 35);
            Sair.TabIndex = 2;
            Sair.Text = "sair";
            Sair.UseVisualStyleBackColor = true;
            Sair.Click += button1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 109);
            label2.Name = "label2";
            label2.Size = new Size(262, 39);
            label2.TabIndex = 3;
            label2.Text = "Salario Bruto:";
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(37, 168);
            label3.Name = "label3";
            label3.Size = new Size(262, 38);
            label3.TabIndex = 4;
            label3.Text = "Imposto de Renda:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(37, 237);
            label4.Name = "label4";
            label4.Size = new Size(262, 44);
            label4.TabIndex = 5;
            label4.Text = "Previdencia Privada:";
            // 
            // label5
            // 
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 306);
            label5.Name = "label5";
            label5.Size = new Size(262, 59);
            label5.TabIndex = 6;
            label5.Text = "Salario Liquido:";
            // 
            // labelPrevidencia
            // 
            labelPrevidencia.BorderStyle = BorderStyle.FixedSingle;
            labelPrevidencia.ForeColor = SystemColors.ButtonHighlight;
            labelPrevidencia.Location = new Point(295, 237);
            labelPrevidencia.Name = "labelPrevidencia";
            labelPrevidencia.Size = new Size(111, 38);
            labelPrevidencia.TabIndex = 9;
            // 
            // labelSalarioLiq
            // 
            labelSalarioLiq.BorderStyle = BorderStyle.FixedSingle;
            labelSalarioLiq.ForeColor = SystemColors.ButtonHighlight;
            labelSalarioLiq.Location = new Point(242, 306);
            labelSalarioLiq.Name = "labelSalarioLiq";
            labelSalarioLiq.Size = new Size(111, 39);
            labelSalarioLiq.TabIndex = 10;
            labelSalarioLiq.Click += label8_Click;
            // 
            // labelimposto
            // 
            labelimposto.BorderStyle = BorderStyle.FixedSingle;
            labelimposto.ForeColor = SystemColors.Control;
            labelimposto.Location = new Point(295, 170);
            labelimposto.Name = "labelimposto";
            labelimposto.Size = new Size(93, 36);
            labelimposto.TabIndex = 11;
            labelimposto.Click += label9_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.ETEC_JA;
            pictureBox1.Location = new Point(488, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(488, 346);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(136, 35);
            Calcular.TabIndex = 13;
            Calcular.Text = "&Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // labelSalarioBrut
            // 
            labelSalarioBrut.Location = new Point(253, 124);
            labelSalarioBrut.Name = "labelSalarioBrut";
            labelSalarioBrut.Size = new Size(100, 23);
            labelSalarioBrut.TabIndex = 14;
            // 
            // cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(636, 434);
            Controls.Add(labelSalarioBrut);
            Controls.Add(Calcular);
            Controls.Add(pictureBox1);
            Controls.Add(labelimposto);
            Controls.Add(labelSalarioLiq);
            Controls.Add(labelPrevidencia);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Sair);
            Controls.Add(label1);
            DoubleBuffered = true;
            MaximizeBox = false;
            MaximumSize = new Size(652, 473);
            MinimizeBox = false;
            MinimumSize = new Size(652, 473);
            Name = "cadastro";
            Text = "Salario Liquido";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Sair;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelPrevidencia;
        private Label labelSalarioLiq;
        private Label labelimposto;
        private PictureBox pictureBox1;
        private Button Calcular;
        private TextBox labelSalarioBrut;
    }
}