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
            panel.Location = new Point(13, 28);
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.Name = "panel";
            panel.Size = new Size(1047, 219);
            panel.TabIndex = 2;
            panel.Paint += panelFunci1_Paint;
            // 
            // textBoxObservacoes
            // 
            textBoxObservacoes.Location = new Point(16, 179);
            textBoxObservacoes.Margin = new Padding(3, 4, 3, 4);
            textBoxObservacoes.Name = "textBoxObservacoes";
            textBoxObservacoes.Size = new Size(596, 26);
            textBoxObservacoes.TabIndex = 22;
            // 
            // botaoEnderecoFunci
            // 
            botaoEnderecoFunci.BackColor = Color.PaleGoldenrod;
            botaoEnderecoFunci.Cursor = Cursors.Hand;
            botaoEnderecoFunci.FlatStyle = FlatStyle.Flat;
            botaoEnderecoFunci.Font = new Font("Nexa Heavy", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            botaoEnderecoFunci.Location = new Point(639, 139);
            botaoEnderecoFunci.Margin = new Padding(3, 4, 3, 4);
            botaoEnderecoFunci.Name = "botaoEnderecoFunci";
            botaoEnderecoFunci.Size = new Size(394, 66);
            botaoEnderecoFunci.TabIndex = 3;
            botaoEnderecoFunci.Text = "Cadastrar Endereço";
            botaoEnderecoFunci.UseVisualStyleBackColor = false;
            botaoEnderecoFunci.Click += botaoEnderecoFunci_Click;
            // 
            // labelObservacoes
            // 
            labelObservacoes.AutoSize = true;
            labelObservacoes.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelObservacoes.Location = new Point(16, 155);
            labelObservacoes.Name = "labelObservacoes";
            labelObservacoes.Size = new Size(85, 16);
            labelObservacoes.TabIndex = 21;
            labelObservacoes.Text = "Observações";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(639, 103);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(329, 26);
            textBoxEmail.TabIndex = 20;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(646, 80);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(40, 16);
            labelEmail.TabIndex = 19;
            labelEmail.Text = "Email";
            labelEmail.Click += label1_Click;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(383, 103);
            textBoxTelefone.Margin = new Padding(3, 4, 3, 4);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(215, 26);
            textBoxTelefone.TabIndex = 18;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTelefone.Location = new Point(383, 80);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(56, 16);
            labelTelefone.TabIndex = 17;
            labelTelefone.Text = "Telefone";
            // 
            // textBoxValCnh
            // 
            textBoxValCnh.Location = new Point(221, 103);
            textBoxValCnh.Margin = new Padding(3, 4, 3, 4);
            textBoxValCnh.Name = "textBoxValCnh";
            textBoxValCnh.Size = new Size(114, 26);
            textBoxValCnh.TabIndex = 16;
            // 
            // labelValidadeCNH
            // 
            labelValidadeCNH.AutoSize = true;
            labelValidadeCNH.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValidadeCNH.Location = new Point(221, 80);
            labelValidadeCNH.Name = "labelValidadeCNH";
            labelValidadeCNH.Size = new Size(89, 16);
            labelValidadeCNH.TabIndex = 15;
            labelValidadeCNH.Text = "Validade CNH";
            // 
            // radioCnhNao
            // 
            radioCnhNao.AutoSize = true;
            radioCnhNao.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioCnhNao.Location = new Point(160, 139);
            radioCnhNao.Margin = new Padding(3, 4, 3, 4);
            radioCnhNao.Name = "radioCnhNao";
            radioCnhNao.Size = new Size(49, 20);
            radioCnhNao.TabIndex = 14;
            radioCnhNao.TabStop = true;
            radioCnhNao.Text = "Não";
            radioCnhNao.UseVisualStyleBackColor = true;
            // 
            // radioCnhSim
            // 
            radioCnhSim.AutoSize = true;
            radioCnhSim.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioCnhSim.Location = new Point(160, 108);
            radioCnhSim.Margin = new Padding(3, 4, 3, 4);
            radioCnhSim.Name = "radioCnhSim";
            radioCnhSim.Size = new Size(47, 20);
            radioCnhSim.TabIndex = 13;
            radioCnhSim.TabStop = true;
            radioCnhSim.Text = "Sim";
            radioCnhSim.UseVisualStyleBackColor = true;
            // 
            // labelCNH
            // 
            labelCNH.AutoSize = true;
            labelCNH.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCNH.Location = new Point(160, 80);
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
            comboBoxGrupo.Location = new Point(16, 103);
            comboBoxGrupo.Margin = new Padding(3, 4, 3, 4);
            comboBoxGrupo.Name = "comboBoxGrupo";
            comboBoxGrupo.Size = new Size(137, 25);
            comboBoxGrupo.TabIndex = 11;
            comboBoxGrupo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelGrupo
            // 
            labelGrupo.AutoSize = true;
            labelGrupo.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGrupo.Location = new Point(16, 80);
            labelGrupo.Name = "labelGrupo";
            labelGrupo.Size = new Size(44, 16);
            labelGrupo.TabIndex = 10;
            labelGrupo.Text = "Grupo";
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(746, 34);
            textBoxSenha.Margin = new Padding(3, 4, 3, 4);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(275, 26);
            textBoxSenha.TabIndex = 9;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSenha.Location = new Point(757, 11);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(44, 16);
            labelSenha.TabIndex = 8;
            labelSenha.Text = "Senha";
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Location = new Point(587, 34);
            textBoxMatricula.Margin = new Padding(3, 4, 3, 4);
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(110, 26);
            textBoxMatricula.TabIndex = 7;
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMatricula.Location = new Point(587, 11);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(64, 16);
            labelMatricula.TabIndex = 6;
            labelMatricula.Text = "Matrícula";
            // 
            // textBoxCPF
            // 
            textBoxCPF.Location = new Point(409, 34);
            textBoxCPF.Margin = new Padding(3, 4, 3, 4);
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(162, 26);
            textBoxCPF.TabIndex = 5;
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCPF.Location = new Point(409, 11);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(31, 16);
            labelCPF.TabIndex = 4;
            labelCPF.Text = "CPF";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(82, 34);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(319, 26);
            textBoxNome.TabIndex = 3;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(82, 11);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(41, 16);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(16, 34);
            textBoxCodigo.Margin = new Padding(3, 4, 3, 4);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(52, 26);
            textBoxCodigo.TabIndex = 1;
            textBoxCodigo.TextChanged += textBoxCod_TextChanged;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodigo.Location = new Point(16, 11);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(47, 16);
            labelCodigo.TabIndex = 0;
            labelCodigo.Text = "Código";
            // 
            // userControl
            // 
            userControl.BackColor = Color.Transparent;
            userControl.Location = new Point(264, 241);
            userControl.Margin = new Padding(3, 5, 3, 5);
            userControl.Name = "userControl";
            userControl.Size = new Size(545, 115);
            userControl.TabIndex = 3;
            userControl.Load += userControl11_Load;
            // 
            // formFunci
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1073, 358);
            Controls.Add(panel);
            Controls.Add(userControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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