namespace PizzariaDoZe
{
    partial class formFunci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFunci));
            panel = new Panel();
            maskedSenha = new MaskedTextBox();
            maskedCNH = new MaskedTextBox();
            maskedCPF = new MaskedTextBox();
            textBoxObservacoes = new TextBox();
            botaoEnderecoFunci = new Button();
            labelObservacoes = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            labelTelefone = new Label();
            labelValidadeCNH = new Label();
            radioCnhNao = new RadioButton();
            radioCnhSim = new RadioButton();
            labelCNH = new Label();
            comboBoxGrupo = new ComboBox();
            labelGrupo = new Label();
            labelSenha = new Label();
            textBoxMatricula = new TextBox();
            labelMatricula = new Label();
            labelCPF = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
            userControl = new UserControl1();
            maskedTelefone = new MaskedTextBox();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.Silver;
            panel.Controls.Add(maskedTelefone);
            panel.Controls.Add(maskedSenha);
            panel.Controls.Add(maskedCNH);
            panel.Controls.Add(maskedCPF);
            panel.Controls.Add(textBoxObservacoes);
            panel.Controls.Add(botaoEnderecoFunci);
            panel.Controls.Add(labelObservacoes);
            panel.Controls.Add(textBoxEmail);
            panel.Controls.Add(labelEmail);
            panel.Controls.Add(labelTelefone);
            panel.Controls.Add(labelValidadeCNH);
            panel.Controls.Add(radioCnhNao);
            panel.Controls.Add(radioCnhSim);
            panel.Controls.Add(labelCNH);
            panel.Controls.Add(comboBoxGrupo);
            panel.Controls.Add(labelGrupo);
            panel.Controls.Add(labelSenha);
            panel.Controls.Add(textBoxMatricula);
            panel.Controls.Add(labelMatricula);
            panel.Controls.Add(labelCPF);
            panel.Controls.Add(textBoxNome);
            panel.Controls.Add(labelNome);
            panel.Location = new Point(11, 22);
            panel.Name = "panel";
            panel.Size = new Size(916, 173);
            panel.TabIndex = 2;
            panel.Paint += panelFunci1_Paint;
            // 
            // maskedSenha
            // 
            maskedSenha.Location = new Point(662, 28);
            maskedSenha.Name = "maskedSenha";
            maskedSenha.Size = new Size(228, 23);
            maskedSenha.TabIndex = 24;
            maskedSenha.UseSystemPasswordChar = true;
            // 
            // maskedCNH
            // 
            maskedCNH.Location = new Point(206, 81);
            maskedCNH.Mask = "00/00/0000";
            maskedCNH.Name = "maskedCNH";
            maskedCNH.Size = new Size(64, 23);
            maskedCNH.TabIndex = 23;
            maskedCNH.ValidatingType = typeof(DateTime);
            // 
            // maskedCPF
            // 
            maskedCPF.Location = new Point(349, 27);
            maskedCPF.Mask = "000.000.000-00";
            maskedCPF.Name = "maskedCPF";
            maskedCPF.Size = new Size(143, 23);
            maskedCPF.TabIndex = 22;
            // 
            // textBoxObservacoes
            // 
            textBoxObservacoes.Location = new Point(14, 141);
            textBoxObservacoes.Name = "textBoxObservacoes";
            textBoxObservacoes.Size = new Size(522, 23);
            textBoxObservacoes.TabIndex = 11;
            // 
            // botaoEnderecoFunci
            // 
            botaoEnderecoFunci.BackColor = Color.PaleGoldenrod;
            botaoEnderecoFunci.Cursor = Cursors.Hand;
            botaoEnderecoFunci.FlatStyle = FlatStyle.Flat;
            botaoEnderecoFunci.Font = new Font("Nexa Heavy", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            botaoEnderecoFunci.Location = new Point(559, 110);
            botaoEnderecoFunci.Name = "botaoEnderecoFunci";
            botaoEnderecoFunci.Size = new Size(345, 52);
            botaoEnderecoFunci.TabIndex = 12;
            botaoEnderecoFunci.Text = "Cadastrar Endereço";
            botaoEnderecoFunci.UseVisualStyleBackColor = false;
            botaoEnderecoFunci.Click += botaoEnderecoFunci_Click;
            // 
            // labelObservacoes
            // 
            labelObservacoes.AutoSize = true;
            labelObservacoes.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelObservacoes.Location = new Point(14, 122);
            labelObservacoes.Name = "labelObservacoes";
            labelObservacoes.Size = new Size(85, 16);
            labelObservacoes.TabIndex = 21;
            labelObservacoes.Text = "Observações";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(559, 81);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(288, 23);
            textBoxEmail.TabIndex = 10;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(565, 63);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(40, 16);
            labelEmail.TabIndex = 19;
            labelEmail.Text = "Email";
            labelEmail.Click += label1_Click;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTelefone.Location = new Point(335, 63);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(56, 16);
            labelTelefone.TabIndex = 17;
            labelTelefone.Text = "Telefone";
            // 
            // labelValidadeCNH
            // 
            labelValidadeCNH.AutoSize = true;
            labelValidadeCNH.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValidadeCNH.Location = new Point(193, 63);
            labelValidadeCNH.Name = "labelValidadeCNH";
            labelValidadeCNH.Size = new Size(89, 16);
            labelValidadeCNH.TabIndex = 15;
            labelValidadeCNH.Text = "Validade CNH";
            // 
            // radioCnhNao
            // 
            radioCnhNao.AutoSize = true;
            radioCnhNao.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioCnhNao.Location = new Point(140, 110);
            radioCnhNao.Name = "radioCnhNao";
            radioCnhNao.Size = new Size(49, 20);
            radioCnhNao.TabIndex = 7;
            radioCnhNao.TabStop = true;
            radioCnhNao.Text = "Não";
            radioCnhNao.UseVisualStyleBackColor = true;
            // 
            // radioCnhSim
            // 
            radioCnhSim.AutoSize = true;
            radioCnhSim.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioCnhSim.Location = new Point(140, 85);
            radioCnhSim.Name = "radioCnhSim";
            radioCnhSim.Size = new Size(47, 20);
            radioCnhSim.TabIndex = 6;
            radioCnhSim.TabStop = true;
            radioCnhSim.Text = "Sim";
            radioCnhSim.UseVisualStyleBackColor = true;
            // 
            // labelCNH
            // 
            labelCNH.AutoSize = true;
            labelCNH.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCNH.Location = new Point(140, 63);
            labelCNH.Name = "labelCNH";
            labelCNH.Size = new Size(33, 16);
            labelCNH.TabIndex = 12;
            labelCNH.Text = "CNH";
            // 
            // comboBoxGrupo
            // 
            comboBoxGrupo.Font = new Font("Nexa Heavy", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxGrupo.FormattingEnabled = true;
            comboBoxGrupo.Items.AddRange(new object[] { "Admin", "Atendente", "Entregador" });
            comboBoxGrupo.Location = new Point(14, 81);
            comboBoxGrupo.Name = "comboBoxGrupo";
            comboBoxGrupo.Size = new Size(120, 25);
            comboBoxGrupo.TabIndex = 5;
            comboBoxGrupo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelGrupo
            // 
            labelGrupo.AutoSize = true;
            labelGrupo.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGrupo.Location = new Point(14, 63);
            labelGrupo.Name = "labelGrupo";
            labelGrupo.Size = new Size(44, 16);
            labelGrupo.TabIndex = 10;
            labelGrupo.Text = "Grupo";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSenha.Location = new Point(662, 9);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(44, 16);
            labelSenha.TabIndex = 8;
            labelSenha.Text = "Senha";
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Location = new Point(514, 27);
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(97, 23);
            textBoxMatricula.TabIndex = 3;
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMatricula.Location = new Point(514, 9);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(64, 16);
            labelMatricula.TabIndex = 6;
            labelMatricula.Text = "Matrícula";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCPF.Location = new Point(349, 9);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(31, 16);
            labelCPF.TabIndex = 4;
            labelCPF.Text = "CPF";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(14, 27);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(280, 23);
            textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(17, 9);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(41, 16);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            // 
            // userControl
            // 
            userControl.BackColor = Color.Transparent;
            userControl.Location = new Point(231, 190);
            userControl.Margin = new Padding(3, 4, 3, 4);
            userControl.Name = "userControl";
            userControl.Size = new Size(477, 91);
            userControl.TabIndex = 13;
            userControl.Load += userControl11_Load;
            // 
            // maskedTelefone
            // 
            maskedTelefone.Location = new Point(335, 81);
            maskedTelefone.Mask = "+00 (00)00000-0000";
            maskedTelefone.Name = "maskedTelefone";
            maskedTelefone.Size = new Size(147, 23);
            maskedTelefone.TabIndex = 25;
            // 
            // formFunci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(939, 283);
            Controls.Add(panel);
            Controls.Add(userControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "formFunci";
            Text = "Cadastro de Funcionários";
            Load += formFunci_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel;
        private Label labelSenha;
        private TextBox textBoxMatricula;
        private Label labelMatricula;
        private Label labelCPF;
        private TextBox textBoxNome;
        private Label labelNome;
        private Label labelGrupo;
        private ComboBox comboBoxGrupo;
        private RadioButton radioCnhNao;
        private RadioButton radioCnhSim;
        private Label labelCNH;
        private Label labelEmail;
        private Label labelTelefone;
        private Label labelValidadeCNH;
        private TextBox textBoxEmail;
        private Button botaoEnderecoFunci;
        private TextBox textBoxObservacoes;
        private Label labelObservacoes;
        private UserControl1 userControl;
        private MaskedTextBox maskedSenha;
        private MaskedTextBox maskedCNH;
        private MaskedTextBox maskedCPF;
        private MaskedTextBox maskedTelefone;
    }
}