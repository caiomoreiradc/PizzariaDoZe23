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
            textBoxObservacoes = new TextBox();
            botaoEnderecoFunci = new Button();
            labelObservacoes = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxTelefone = new TextBox();
            labelTelefone = new Label();
            textBoxValCnh = new TextBox();
            labelValidadeCNH = new Label();
            radioCnhNao = new RadioButton();
            radioCnhSim = new RadioButton();
            labelCNH = new Label();
            comboBoxGrupo = new ComboBox();
            labelGrupo = new Label();
            textBoxSenha = new TextBox();
            labelSenha = new Label();
            textBoxMatricula = new TextBox();
            labelMatricula = new Label();
            textBoxCPF = new TextBox();
            labelCPF = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
            textBoxCodigo = new TextBox();
            labelCodigo = new Label();
            userControl = new UserControl1();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.Silver;
            panel.Controls.Add(textBoxObservacoes);
            panel.Controls.Add(botaoEnderecoFunci);
            panel.Controls.Add(labelObservacoes);
            panel.Controls.Add(textBoxEmail);
            panel.Controls.Add(labelEmail);
            panel.Controls.Add(textBoxTelefone);
            panel.Controls.Add(labelTelefone);
            panel.Controls.Add(textBoxValCnh);
            panel.Controls.Add(labelValidadeCNH);
            panel.Controls.Add(radioCnhNao);
            panel.Controls.Add(radioCnhSim);
            panel.Controls.Add(labelCNH);
            panel.Controls.Add(comboBoxGrupo);
            panel.Controls.Add(labelGrupo);
            panel.Controls.Add(textBoxSenha);
            panel.Controls.Add(labelSenha);
            panel.Controls.Add(textBoxMatricula);
            panel.Controls.Add(labelMatricula);
            panel.Controls.Add(textBoxCPF);
            panel.Controls.Add(labelCPF);
            panel.Controls.Add(textBoxNome);
            panel.Controls.Add(labelNome);
            panel.Controls.Add(textBoxCodigo);
            panel.Controls.Add(labelCodigo);
            panel.Location = new Point(11, 22);
            panel.Name = "panel";
            panel.Size = new Size(916, 173);
            panel.TabIndex = 2;
            panel.Paint += panelFunci1_Paint;
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
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(335, 81);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(189, 23);
            textBoxTelefone.TabIndex = 9;
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
            // textBoxValCnh
            // 
            textBoxValCnh.Location = new Point(193, 81);
            textBoxValCnh.Name = "textBoxValCnh";
            textBoxValCnh.Size = new Size(100, 23);
            textBoxValCnh.TabIndex = 8;
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
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(653, 27);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(241, 23);
            textBoxSenha.TabIndex = 4;
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
            // textBoxCPF
            // 
            textBoxCPF.Location = new Point(358, 27);
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(142, 23);
            textBoxCPF.TabIndex = 2;
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCPF.Location = new Point(358, 9);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(31, 16);
            labelCPF.TabIndex = 4;
            labelCPF.Text = "CPF";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(72, 27);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(280, 23);
            textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(72, 9);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(41, 16);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(14, 27);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(46, 23);
            textBoxCodigo.TabIndex = 0;
            textBoxCodigo.TextChanged += textBoxCod_TextChanged;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodigo.Location = new Point(14, 9);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(47, 16);
            labelCodigo.TabIndex = 0;
            labelCodigo.Text = "Código";
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
        private TextBox textBoxSenha;
        private Label labelSenha;
        private TextBox textBoxMatricula;
        private Label labelMatricula;
        private TextBox textBoxCPF;
        private Label labelCPF;
        private TextBox textBoxNome;
        private Label labelNome;
        private TextBox textBoxCodigo;
        private Label labelCodigo;
        private Label labelGrupo;
        private ComboBox comboBoxGrupo;
        private RadioButton radioCnhNao;
        private RadioButton radioCnhSim;
        private Label labelCNH;
        private Label labelEmail;
        private TextBox textBoxTelefone;
        private Label labelTelefone;
        private TextBox textBoxValCnh;
        private Label labelValidadeCNH;
        private TextBox textBoxEmail;
        private Button botaoEnderecoFunci;
        private TextBox textBoxObservacoes;
        private Label labelObservacoes;
        private UserControl1 userControl;
    }
}