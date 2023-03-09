namespace PizzariaDoZe
{
    partial class formFunciEndereco
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
            panel1 = new Panel();
            comboBoxPaisFunci = new ComboBox();
            textBoxPaisFunci = new TextBox();
            labelPaisFunci = new Label();
            labelEstadoFunci = new Label();
            textBoxCidadeFunci = new TextBox();
            labelCidadeFunci = new Label();
            textBoxCompleFunci = new TextBox();
            labelComplemFunci = new Label();
            textBoxBairroFunci = new TextBox();
            labelBairroFunci = new Label();
            textBoxNumFunci = new TextBox();
            labelNumeroFunci = new Label();
            textBox1 = new TextBox();
            labelLogradouroFunci = new Label();
            textBoxCepFunci = new TextBox();
            labelCepFunci = new Label();
            buttonEnviarEndFunci = new Button();
            labelTituloCadastroEndFunci = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(comboBoxPaisFunci);
            panel1.Controls.Add(textBoxPaisFunci);
            panel1.Controls.Add(labelPaisFunci);
            panel1.Controls.Add(labelEstadoFunci);
            panel1.Controls.Add(textBoxCidadeFunci);
            panel1.Controls.Add(labelCidadeFunci);
            panel1.Controls.Add(textBoxCompleFunci);
            panel1.Controls.Add(labelComplemFunci);
            panel1.Controls.Add(textBoxBairroFunci);
            panel1.Controls.Add(labelBairroFunci);
            panel1.Controls.Add(textBoxNumFunci);
            panel1.Controls.Add(labelNumeroFunci);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(labelLogradouroFunci);
            panel1.Controls.Add(textBoxCepFunci);
            panel1.Controls.Add(labelCepFunci);
            panel1.Location = new Point(23, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(607, 150);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // comboBoxPaisFunci
            // 
            comboBoxPaisFunci.AutoCompleteCustomSource.AddRange(new string[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxPaisFunci.FormattingEnabled = true;
            comboBoxPaisFunci.Location = new Point(407, 84);
            comboBoxPaisFunci.Name = "comboBoxPaisFunci";
            comboBoxPaisFunci.Size = new Size(38, 23);
            comboBoxPaisFunci.TabIndex = 16;
            // 
            // textBoxPaisFunci
            // 
            textBoxPaisFunci.Location = new Point(451, 84);
            textBoxPaisFunci.Name = "textBoxPaisFunci";
            textBoxPaisFunci.Size = new Size(153, 23);
            textBoxPaisFunci.TabIndex = 15;
            // 
            // labelPaisFunci
            // 
            labelPaisFunci.AutoSize = true;
            labelPaisFunci.Location = new Point(451, 66);
            labelPaisFunci.Name = "labelPaisFunci";
            labelPaisFunci.Size = new Size(28, 15);
            labelPaisFunci.TabIndex = 14;
            labelPaisFunci.Text = "País";
            // 
            // labelEstadoFunci
            // 
            labelEstadoFunci.AutoSize = true;
            labelEstadoFunci.Location = new Point(407, 66);
            labelEstadoFunci.Name = "labelEstadoFunci";
            labelEstadoFunci.Size = new Size(21, 15);
            labelEstadoFunci.TabIndex = 12;
            labelEstadoFunci.Text = "UF";
            // 
            // textBoxCidadeFunci
            // 
            textBoxCidadeFunci.Location = new Point(270, 84);
            textBoxCidadeFunci.Name = "textBoxCidadeFunci";
            textBoxCidadeFunci.Size = new Size(129, 23);
            textBoxCidadeFunci.TabIndex = 11;
            // 
            // labelCidadeFunci
            // 
            labelCidadeFunci.AutoSize = true;
            labelCidadeFunci.Location = new Point(282, 66);
            labelCidadeFunci.Name = "labelCidadeFunci";
            labelCidadeFunci.Size = new Size(44, 15);
            labelCidadeFunci.TabIndex = 10;
            labelCidadeFunci.Text = "Cidade";
            // 
            // textBoxCompleFunci
            // 
            textBoxCompleFunci.Location = new Point(16, 84);
            textBoxCompleFunci.Multiline = true;
            textBoxCompleFunci.Name = "textBoxCompleFunci";
            textBoxCompleFunci.Size = new Size(248, 45);
            textBoxCompleFunci.TabIndex = 9;
            // 
            // labelComplemFunci
            // 
            labelComplemFunci.AutoSize = true;
            labelComplemFunci.Location = new Point(16, 66);
            labelComplemFunci.Name = "labelComplemFunci";
            labelComplemFunci.Size = new Size(84, 15);
            labelComplemFunci.TabIndex = 8;
            labelComplemFunci.Text = "Complemento";
            // 
            // textBoxBairroFunci
            // 
            textBoxBairroFunci.Location = new Point(510, 29);
            textBoxBairroFunci.Name = "textBoxBairroFunci";
            textBoxBairroFunci.Size = new Size(87, 23);
            textBoxBairroFunci.TabIndex = 7;
            // 
            // labelBairroFunci
            // 
            labelBairroFunci.AutoSize = true;
            labelBairroFunci.Location = new Point(510, 11);
            labelBairroFunci.Name = "labelBairroFunci";
            labelBairroFunci.Size = new Size(38, 15);
            labelBairroFunci.TabIndex = 6;
            labelBairroFunci.Text = "Bairro";
            labelBairroFunci.Click += label1_Click_1;
            // 
            // textBoxNumFunci
            // 
            textBoxNumFunci.Location = new Point(441, 29);
            textBoxNumFunci.Name = "textBoxNumFunci";
            textBoxNumFunci.Size = new Size(51, 23);
            textBoxNumFunci.TabIndex = 5;
            // 
            // labelNumeroFunci
            // 
            labelNumeroFunci.AutoSize = true;
            labelNumeroFunci.Location = new Point(441, 11);
            labelNumeroFunci.Name = "labelNumeroFunci";
            labelNumeroFunci.Size = new Size(51, 15);
            labelNumeroFunci.TabIndex = 4;
            labelNumeroFunci.Text = "Número";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 23);
            textBox1.TabIndex = 3;
            // 
            // labelLogradouroFunci
            // 
            labelLogradouroFunci.AutoSize = true;
            labelLogradouroFunci.Location = new Point(159, 11);
            labelLogradouroFunci.Name = "labelLogradouroFunci";
            labelLogradouroFunci.Size = new Size(69, 15);
            labelLogradouroFunci.TabIndex = 2;
            labelLogradouroFunci.Text = "Logradouro";
            // 
            // textBoxCepFunci
            // 
            textBoxCepFunci.Location = new Point(16, 29);
            textBoxCepFunci.Name = "textBoxCepFunci";
            textBoxCepFunci.Size = new Size(110, 23);
            textBoxCepFunci.TabIndex = 1;
            // 
            // labelCepFunci
            // 
            labelCepFunci.AutoSize = true;
            labelCepFunci.Location = new Point(16, 11);
            labelCepFunci.Name = "labelCepFunci";
            labelCepFunci.Size = new Size(28, 15);
            labelCepFunci.TabIndex = 0;
            labelCepFunci.Text = "CEP";
            labelCepFunci.Click += label1_Click;
            // 
            // buttonEnviarEndFunci
            // 
            buttonEnviarEndFunci.BackColor = Color.FromArgb(128, 255, 128);
            buttonEnviarEndFunci.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEnviarEndFunci.Location = new Point(91, 196);
            buttonEnviarEndFunci.Name = "buttonEnviarEndFunci";
            buttonEnviarEndFunci.Size = new Size(462, 41);
            buttonEnviarEndFunci.TabIndex = 1;
            buttonEnviarEndFunci.Text = "Salvar Endereço";
            buttonEnviarEndFunci.UseVisualStyleBackColor = false;
            // 
            // labelTituloCadastroEndFunci
            // 
            labelTituloCadastroEndFunci.AutoSize = true;
            labelTituloCadastroEndFunci.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTituloCadastroEndFunci.Location = new Point(23, 9);
            labelTituloCadastroEndFunci.Name = "labelTituloCadastroEndFunci";
            labelTituloCadastroEndFunci.Size = new Size(144, 21);
            labelTituloCadastroEndFunci.TabIndex = 2;
            labelTituloCadastroEndFunci.Text = "Cadastro Endereço ";
            // 
            // formFunciEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 264);
            Controls.Add(labelTituloCadastroEndFunci);
            Controls.Add(buttonEnviarEndFunci);
            Controls.Add(panel1);
            Name = "formFunciEndereco";
            Text = "Cadastro do Endereço dos Funcionários";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelCepFunci;
        private TextBox textBoxCepFunci;
        private Label labelBairroFunci;
        private TextBox textBoxNumFunci;
        private Label labelNumeroFunci;
        private TextBox textBox1;
        private Label labelLogradouroFunci;
        private Label labelEstadoFunci;
        private TextBox textBoxCidadeFunci;
        private Label labelCidadeFunci;
        private TextBox textBoxCompleFunci;
        private Label labelComplemFunci;
        private TextBox textBoxBairroFunci;
        private TextBox textBoxPaisFunci;
        private Label labelPaisFunci;
        private Button buttonEnviarEndFunci;
        private ComboBox comboBoxPaisFunci;
        private Label labelTituloCadastroEndFunci;
    }
}