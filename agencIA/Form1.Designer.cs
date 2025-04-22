namespace agencIA
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            richTextBox1 = new RichTextBox();
            textBox3 = new TextBox();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button8 = new Button();
            textBox4 = new TextBox();
            button9 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(200, 64);
            button1.Name = "button1";
            button1.Size = new Size(188, 35);
            button1.TabIndex = 0;
            button1.Text = "Criar Agente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(18, 371);
            button2.Name = "button2";
            button2.Size = new Size(200, 35);
            button2.TabIndex = 2;
            button2.Text = "Criar Empresa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 192, 255);
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(18, 249);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nome da Empresa";
            textBox1.Size = new Size(200, 29);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 192, 255);
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(18, 284);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Descrição da Empresa";
            textBox2.Size = new Size(200, 81);
            textBox2.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 231);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Empresas";
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(200, 187);
            button7.Name = "button7";
            button7.Size = new Size(188, 35);
            button7.TabIndex = 10;
            button7.Text = "Apagar Agente";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(200, 146);
            button6.Name = "button6";
            button6.Size = new Size(188, 35);
            button6.TabIndex = 9;
            button6.Text = "Resetar Agente";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(200, 105);
            button5.Name = "button5";
            button5.Size = new Size(188, 35);
            button5.TabIndex = 8;
            button5.Text = " Selecionar Agente";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(6, 63);
            button3.Name = "button3";
            button3.Size = new Size(188, 36);
            button3.TabIndex = 7;
            button3.Text = "Atualizar Empresas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(128, 128, 255);
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.ForeColor = SystemColors.Info;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 28);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(188, 29);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(128, 128, 255);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.ForeColor = SystemColors.Info;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Planejamento", "Design", "Publicidade", "SocialMedia", "Fotografia", "Relations", "Atendimento", "Marketing" });
            comboBox1.Location = new Point(200, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 29);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(192, 192, 255);
            richTextBox1.Location = new Point(413, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(308, 300);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(192, 192, 255);
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(413, 330);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Oque quer que o agente faça?";
            textBox3.Size = new Size(308, 29);
            textBox3.TabIndex = 7;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(413, 365);
            button4.Name = "button4";
            button4.Size = new Size(308, 35);
            button4.TabIndex = 8;
            button4.Text = "Enviar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Location = new Point(727, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 12F);
            button8.ForeColor = SystemColors.ButtonFace;
            button8.Location = new Point(727, 365);
            button8.Name = "button8";
            button8.Size = new Size(155, 35);
            button8.TabIndex = 11;
            button8.Text = "Gerar ";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(192, 192, 255);
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.ForeColor = Color.Black;
            textBox4.Location = new Point(727, 330);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Descreva a imagem";
            textBox4.Size = new Size(316, 29);
            textBox4.TabIndex = 10;
            // 
            // button9
            // 
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 12F);
            button9.ForeColor = SystemColors.ButtonFace;
            button9.Location = new Point(888, 365);
            button9.Name = "button9";
            button9.Size = new Size(155, 35);
            button9.TabIndex = 12;
            button9.Text = "Salvar";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1050, 416);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(textBox4);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(textBox3);
            Controls.Add(richTextBox1);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private TextBox textBox3;
        private Button button4;
        private Button button6;
        private Button button5;
        private Button button7;
        private PictureBox pictureBox1;
        private Button button8;
        private TextBox textBox4;
        private Button button9;
    }
}
