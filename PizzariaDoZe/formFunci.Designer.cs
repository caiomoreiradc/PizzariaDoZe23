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
            radioButtonGrupoEntregador = new RadioButton();
            botaoVisualizarCadastros = new Button();
            radioButtonGrupoAtendente = new RadioButton();
            radioButtonGrupoAdmin = new RadioButton();
            dateTimePickerValidade = new DateTimePicker();
            textBoxCNH = new TextBox();
            textBoxIdFunci = new TextBox();
            maskedTelefone = new MaskedTextBox();
            label5 = new Label();
            maskedSenha = new MaskedTextBox();
            maskedCPF = new MaskedTextBox();
            textBoxObservacoes = new TextBox();
            labelObservacoes = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            labelTelefone = new Label();
            labelValidadeCNH = new Label();
            labelCNH = new Label();
            labelGrupo = new Label();
            labelSenha = new Label();
            textBoxMatricula = new TextBox();
            labelMatricula = new Label();
            labelCPF = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
            userControl = new UserControl1();
            panel1 = new Panel();
            buttonVisualizarEndereços = new Button();
            maskedCEP = new MaskedTextBox();
            textBoxId = new TextBox();
            labelID = new Label();
            comboBoxUF = new ComboBox();
            textBoxPais = new TextBox();
            textBoxComplemento = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxCidade = new TextBox();
            label4 = new Label();
            textBoxLogradouro = new TextBox();
            label6 = new Label();
            label7 = new Label();
            labelTitle = new Label();
            panel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.Silver;
            panel.Controls.Add(radioButtonGrupoEntregador);
            panel.Controls.Add(botaoVisualizarCadastros);
            panel.Controls.Add(radioButtonGrupoAtendente);
            panel.Controls.Add(radioButtonGrupoAdmin);
            panel.Controls.Add(dateTimePickerValidade);
            panel.Controls.Add(textBoxCNH);
            panel.Controls.Add(textBoxIdFunci);
            panel.Controls.Add(maskedTelefone);
            panel.Controls.Add(label5);
            panel.Controls.Add(maskedSenha);
            panel.Controls.Add(maskedCPF);
            panel.Controls.Add(textBoxObservacoes);
            panel.Controls.Add(labelObservacoes);
            panel.Controls.Add(textBoxEmail);
            panel.Controls.Add(labelEmail);
            panel.Controls.Add(labelTelefone);
            panel.Controls.Add(labelValidadeCNH);
            panel.Controls.Add(labelCNH);
            panel.Controls.Add(labelGrupo);
            panel.Controls.Add(labelSenha);
            panel.Controls.Add(textBoxMatricula);
            panel.Controls.Add(labelMatricula);
            panel.Controls.Add(labelCPF);
            panel.Controls.Add(textBoxNome);
            panel.Controls.Add(labelNome);
            panel.Location = new Point(11, 34);
            panel.Name = "panel";
            panel.Size = new Size(916, 173);
            panel.TabIndex = 999;
            panel.Paint += panelFunci1_Paint;
            // 
            // radioButtonGrupoEntregador
            // 
            radioButtonGrupoEntregador.AutoSize = true;
            radioButtonGrupoEntregador.BackColor = Color.Transparent;
            radioButtonGrupoEntregador.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonGrupoEntregador.Location = new Point(14, 120);
            radioButtonGrupoEntregador.Name = "radioButtonGrupoEntregador";
            radioButtonGrupoEntregador.Size = new Size(94, 20);
            radioButtonGrupoEntregador.TabIndex = 33;
            radioButtonGrupoEntregador.TabStop = true;
            radioButtonGrupoEntregador.Text = "Entregador";
            radioButtonGrupoEntregador.UseVisualStyleBackColor = false;
            // 
            // botaoVisualizarCadastros
            // 
            botaoVisualizarCadastros.BackColor = Color.PaleGoldenrod;
            botaoVisualizarCadastros.Cursor = Cursors.Hand;
            botaoVisualizarCadastros.FlatStyle = FlatStyle.Flat;
            botaoVisualizarCadastros.Font = new Font("Nexa Heavy", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            botaoVisualizarCadastros.Location = new Point(680, 110);
            botaoVisualizarCadastros.Name = "botaoVisualizarCadastros";
            botaoVisualizarCadastros.Size = new Size(224, 52);
            botaoVisualizarCadastros.TabIndex = 32;
            botaoVisualizarCadastros.Text = "Visualizar Cadastros";
            botaoVisualizarCadastros.UseVisualStyleBackColor = false;
            botaoVisualizarCadastros.Click += botaoVisualizarCadastros_Click;
            // 
            // radioButtonGrupoAtendente
            // 
            radioButtonGrupoAtendente.AutoSize = true;
            radioButtonGrupoAtendente.BackColor = Color.Transparent;
            radioButtonGrupoAtendente.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonGrupoAtendente.Location = new Point(14, 99);
            radioButtonGrupoAtendente.Name = "radioButtonGrupoAtendente";
            radioButtonGrupoAtendente.Size = new Size(87, 20);
            radioButtonGrupoAtendente.TabIndex = 31;
            radioButtonGrupoAtendente.TabStop = true;
            radioButtonGrupoAtendente.Text = "Atendente";
            radioButtonGrupoAtendente.UseVisualStyleBackColor = false;
            // 
            // radioButtonGrupoAdmin
            // 
            radioButtonGrupoAdmin.AutoSize = true;
            radioButtonGrupoAdmin.BackColor = Color.Transparent;
            radioButtonGrupoAdmin.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonGrupoAdmin.Location = new Point(14, 81);
            radioButtonGrupoAdmin.Name = "radioButtonGrupoAdmin";
            radioButtonGrupoAdmin.Size = new Size(63, 20);
            radioButtonGrupoAdmin.TabIndex = 30;
            radioButtonGrupoAdmin.TabStop = true;
            radioButtonGrupoAdmin.Text = "Admin";
            radioButtonGrupoAdmin.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerValidade
            // 
            dateTimePickerValidade.CalendarFont = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerValidade.Location = new Point(224, 81);
            dateTimePickerValidade.Name = "dateTimePickerValidade";
            dateTimePickerValidade.Size = new Size(105, 23);
            dateTimePickerValidade.TabIndex = 29;
            // 
            // textBoxCNH
            // 
            textBoxCNH.Location = new Point(139, 80);
            textBoxCNH.Name = "textBoxCNH";
            textBoxCNH.Size = new Size(65, 23);
            textBoxCNH.TabIndex = 28;
            // 
            // textBoxIdFunci
            // 
            textBoxIdFunci.Location = new Point(14, 28);
            textBoxIdFunci.Name = "textBoxIdFunci";
            textBoxIdFunci.Size = new Size(71, 23);
            textBoxIdFunci.TabIndex = 27;
            // 
            // maskedTelefone
            // 
            maskedTelefone.Location = new Point(356, 81);
            maskedTelefone.Mask = "+00 (00)00000-0000";
            maskedTelefone.Name = "maskedTelefone";
            maskedTelefone.Size = new Size(147, 23);
            maskedTelefone.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(33, 8);
            label5.Name = "label5";
            label5.Size = new Size(20, 16);
            label5.TabIndex = 26;
            label5.Text = "ID";
            // 
            // maskedSenha
            // 
            maskedSenha.Location = new Point(662, 28);
            maskedSenha.Name = "maskedSenha";
            maskedSenha.Size = new Size(228, 23);
            maskedSenha.TabIndex = 3;
            maskedSenha.UseSystemPasswordChar = true;
            // 
            // maskedCPF
            // 
            maskedCPF.Location = new Point(378, 27);
            maskedCPF.Mask = "000.000.000-00";
            maskedCPF.Name = "maskedCPF";
            maskedCPF.Size = new Size(143, 23);
            maskedCPF.TabIndex = 1;
            // 
            // textBoxObservacoes
            // 
            textBoxObservacoes.Location = new Point(124, 141);
            textBoxObservacoes.Name = "textBoxObservacoes";
            textBoxObservacoes.Size = new Size(522, 23);
            textBoxObservacoes.TabIndex = 10;
            // 
            // labelObservacoes
            // 
            labelObservacoes.AutoSize = true;
            labelObservacoes.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelObservacoes.Location = new Point(124, 122);
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
            textBoxEmail.TabIndex = 9;
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
            labelTelefone.Location = new Point(353, 62);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(56, 16);
            labelTelefone.TabIndex = 17;
            labelTelefone.Text = "Telefone";
            // 
            // labelValidadeCNH
            // 
            labelValidadeCNH.AutoSize = true;
            labelValidadeCNH.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValidadeCNH.Location = new Point(224, 62);
            labelValidadeCNH.Name = "labelValidadeCNH";
            labelValidadeCNH.Size = new Size(89, 16);
            labelValidadeCNH.TabIndex = 15;
            labelValidadeCNH.Text = "Validade CNH";
            // 
            // labelCNH
            // 
            labelCNH.AutoSize = true;
            labelCNH.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCNH.Location = new Point(149, 62);
            labelCNH.Name = "labelCNH";
            labelCNH.Size = new Size(33, 16);
            labelCNH.TabIndex = 12;
            labelCNH.Text = "CNH";
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
            textBoxMatricula.Location = new Point(540, 28);
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(97, 23);
            textBoxMatricula.TabIndex = 2;
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMatricula.Location = new Point(546, 8);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(64, 16);
            labelMatricula.TabIndex = 6;
            labelMatricula.Text = "Matrícula";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCPF.Location = new Point(378, 8);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(31, 16);
            labelCPF.TabIndex = 4;
            labelCPF.Text = "CPF";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(93, 27);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(280, 23);
            textBoxNome.TabIndex = 0;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(106, 8);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(41, 16);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            // 
            // userControl
            // 
            userControl.BackColor = Color.Transparent;
            userControl.Location = new Point(231, 342);
            userControl.Margin = new Padding(3, 4, 3, 4);
            userControl.Name = "userControl";
            userControl.Size = new Size(477, 91);
            userControl.TabIndex = 11;
            userControl.Load += userControl11_Load;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(buttonVisualizarEndereços);
            panel1.Controls.Add(maskedCEP);
            panel1.Controls.Add(textBoxId);
            panel1.Controls.Add(labelID);
            panel1.Controls.Add(comboBoxUF);
            panel1.Controls.Add(textBoxPais);
            panel1.Controls.Add(textBoxComplemento);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxCidade);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxLogradouro);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(12, 213);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 134);
            panel1.TabIndex = 1001;
            // 
            // buttonVisualizarEndereços
            // 
            buttonVisualizarEndereços.BackColor = Color.FromArgb(255, 192, 255);
            buttonVisualizarEndereços.Cursor = Cursors.Hand;
            buttonVisualizarEndereços.FlatStyle = FlatStyle.Flat;
            buttonVisualizarEndereços.Font = new Font("Nexa Heavy", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVisualizarEndereços.Location = new Point(699, 73);
            buttonVisualizarEndereços.Name = "buttonVisualizarEndereços";
            buttonVisualizarEndereços.Size = new Size(190, 52);
            buttonVisualizarEndereços.TabIndex = 1002;
            buttonVisualizarEndereços.Text = "Visualizar Endereços";
            buttonVisualizarEndereços.UseVisualStyleBackColor = false;
            buttonVisualizarEndereços.Click += buttonVisualizarEndereços_Click;
            // 
            // maskedCEP
            // 
            maskedCEP.Location = new Point(138, 31);
            maskedCEP.Mask = "00000-000";
            maskedCEP.Name = "maskedCEP";
            maskedCEP.Size = new Size(110, 23);
            maskedCEP.TabIndex = 25;
            maskedCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedCEP.Leave += maskedCEP_Leave;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(21, 31);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(71, 23);
            textBoxId.TabIndex = 24;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelID.Location = new Point(43, 12);
            labelID.Name = "labelID";
            labelID.Size = new Size(20, 16);
            labelID.TabIndex = 23;
            labelID.Text = "ID";
            // 
            // comboBoxUF
            // 
            comboBoxUF.FormattingEnabled = true;
            comboBoxUF.Location = new Point(175, 92);
            comboBoxUF.Name = "comboBoxUF";
            comboBoxUF.Size = new Size(121, 23);
            comboBoxUF.TabIndex = 8;
            // 
            // textBoxPais
            // 
            textBoxPais.Location = new Point(577, 31);
            textBoxPais.Name = "textBoxPais";
            textBoxPais.Size = new Size(240, 23);
            textBoxPais.TabIndex = 6;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(311, 92);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(356, 23);
            textBoxComplemento.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(320, 73);
            label1.Name = "label1";
            label1.Size = new Size(88, 16);
            label1.TabIndex = 22;
            label1.Text = "Complemento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(577, 12);
            label2.Name = "label2";
            label2.Size = new Size(32, 16);
            label2.TabIndex = 20;
            label2.Text = "País";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(193, 73);
            label3.Name = "label3";
            label3.Size = new Size(24, 16);
            label3.TabIndex = 18;
            label3.Text = "UF";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(21, 92);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(137, 23);
            textBoxCidade.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 73);
            label4.Name = "label4";
            label4.Size = new Size(49, 16);
            label4.TabIndex = 16;
            label4.Text = "Cidade";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(306, 31);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(237, 23);
            textBoxLogradouro.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(311, 12);
            label6.Name = "label6";
            label6.Size = new Size(77, 16);
            label6.TabIndex = 12;
            label6.Text = "Logradouro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(138, 12);
            label7.Name = "label7";
            label7.Size = new Size(31, 16);
            label7.TabIndex = 10;
            label7.Text = "CEP";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Nexa Heavy", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(9, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(211, 21);
            labelTitle.TabIndex = 1002;
            labelTitle.Text = "Cadastro de Funcionários";
            // 
            // formFunci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(939, 440);
            Controls.Add(panel1);
            Controls.Add(panel);
            Controls.Add(userControl);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "formFunci";
            Text = "Cadastro de Funcionários";
            Load += formFunci_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label labelCNH;
        private Label labelEmail;
        private Label labelTelefone;
        private Label labelValidadeCNH;
        private TextBox textBoxEmail;
        private TextBox textBoxObservacoes;
        private Label labelObservacoes;
        private UserControl1 userControl;
        private MaskedTextBox maskedSenha;
        private MaskedTextBox maskedCPF;
        private MaskedTextBox maskedTelefone;
        private Panel panel1;
        private MaskedTextBox maskedCEP;
        private TextBox textBoxId;
        private Label labelID;
        private ComboBox comboBoxUF;
        private TextBox textBoxPais;
        private TextBox textBoxComplemento;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxCidade;
        private Label label4;
        private TextBox textBoxLogradouro;
        private Label label6;
        private Label label7;
        private TextBox textBoxIdFunci;
        private Label label5;
        private TextBox textBoxCNH;
        private DateTimePicker dateTimePickerValidade;
        private RadioButton radioButtonGrupoAdmin;
        private RadioButton radioButtonGrupoAtendente;
        private Button botaoVisualizarCadastros;
        private RadioButton radioButtonGrupoEntregador;
        private Button buttonVisualizarEndereços;
        private Label labelTitle;
    }
}