namespace PizzariaDoZe
{
    partial class formClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formClientes));
            panel = new Panel();
            botaoVisualizarCadastros = new Button();
            textBoxIdCliente = new TextBox();
            maskedTelefone = new MaskedTextBox();
            labelIdCliente = new Label();
            maskedCPF = new MaskedTextBox();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            labelTelefone = new Label();
            labelCpf = new Label();
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
            panel.Controls.Add(botaoVisualizarCadastros);
            panel.Controls.Add(textBoxIdCliente);
            panel.Controls.Add(maskedTelefone);
            panel.Controls.Add(labelIdCliente);
            panel.Controls.Add(maskedCPF);
            panel.Controls.Add(textBoxEmail);
            panel.Controls.Add(labelEmail);
            panel.Controls.Add(labelTelefone);
            panel.Controls.Add(labelCpf);
            panel.Controls.Add(textBoxNome);
            panel.Controls.Add(labelNome);
            panel.Location = new Point(12, 29);
            panel.Name = "panel";
            panel.Size = new Size(842, 134);
            panel.TabIndex = 999;
            panel.Paint += panel_Paint;
            // 
            // botaoVisualizarCadastros
            // 
            botaoVisualizarCadastros.BackColor = Color.PaleGoldenrod;
            botaoVisualizarCadastros.Cursor = Cursors.Hand;
            botaoVisualizarCadastros.FlatStyle = FlatStyle.Flat;
            botaoVisualizarCadastros.Font = new Font("Nexa Heavy", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            botaoVisualizarCadastros.Location = new Point(594, 70);
            botaoVisualizarCadastros.Name = "botaoVisualizarCadastros";
            botaoVisualizarCadastros.Size = new Size(224, 52);
            botaoVisualizarCadastros.TabIndex = 27;
            botaoVisualizarCadastros.Text = "Visualizar Cadastros";
            botaoVisualizarCadastros.UseVisualStyleBackColor = false;
            botaoVisualizarCadastros.Click += botaoVisualizarCadastros_Click;
            // 
            // textBoxIdCliente
            // 
            textBoxIdCliente.Location = new Point(12, 29);
            textBoxIdCliente.Name = "textBoxIdCliente";
            textBoxIdCliente.Size = new Size(52, 23);
            textBoxIdCliente.TabIndex = 26;
            // 
            // maskedTelefone
            // 
            maskedTelefone.Location = new Point(406, 87);
            maskedTelefone.Mask = "+00 (00)00000-0000";
            maskedTelefone.Name = "maskedTelefone";
            maskedTelefone.Size = new Size(179, 23);
            maskedTelefone.TabIndex = 3;
            // 
            // labelIdCliente
            // 
            labelIdCliente.AutoSize = true;
            labelIdCliente.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelIdCliente.Location = new Point(22, 10);
            labelIdCliente.Name = "labelIdCliente";
            labelIdCliente.Size = new Size(20, 16);
            labelIdCliente.TabIndex = 25;
            labelIdCliente.Text = "ID";
            // 
            // maskedCPF
            // 
            maskedCPF.Location = new Point(558, 29);
            maskedCPF.Mask = "000.000.000-00";
            maskedCPF.Name = "maskedCPF";
            maskedCPF.Size = new Size(157, 23);
            maskedCPF.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 87);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(377, 23);
            textBoxEmail.TabIndex = 2;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(12, 69);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(40, 16);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Email";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTelefone.Location = new Point(415, 68);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(56, 16);
            labelTelefone.TabIndex = 6;
            labelTelefone.Text = "Telefone";
            labelTelefone.Click += labelTelefone_Click;
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCpf.Location = new Point(578, 10);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(31, 16);
            labelCpf.TabIndex = 4;
            labelCpf.Text = "CPF";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(143, 29);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(375, 23);
            textBoxNome.TabIndex = 0;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(159, 10);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(41, 16);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            labelNome.Click += labelNome_Click;
            // 
            // userControl
            // 
            userControl.BackColor = Color.Transparent;
            userControl.Location = new Point(211, 298);
            userControl.Margin = new Padding(3, 4, 3, 4);
            userControl.Name = "userControl";
            userControl.Size = new Size(481, 91);
            userControl.TabIndex = 10;
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
            panel1.Location = new Point(12, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 134);
            panel1.TabIndex = 1000;
            // 
            // buttonVisualizarEndereços
            // 
            buttonVisualizarEndereços.BackColor = Color.FromArgb(255, 192, 255);
            buttonVisualizarEndereços.Cursor = Cursors.Hand;
            buttonVisualizarEndereços.FlatStyle = FlatStyle.Flat;
            buttonVisualizarEndereços.Font = new Font("Nexa Heavy", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVisualizarEndereços.Location = new Point(661, 73);
            buttonVisualizarEndereços.Name = "buttonVisualizarEndereços";
            buttonVisualizarEndereços.Size = new Size(147, 52);
            buttonVisualizarEndereços.TabIndex = 1001;
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
            comboBoxUF.Location = new Point(158, 92);
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
            textBoxComplemento.Location = new Point(306, 92);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(302, 23);
            textBoxComplemento.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(311, 73);
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
            label3.Location = new Point(184, 73);
            label3.Name = "label3";
            label3.Size = new Size(24, 16);
            label3.TabIndex = 18;
            label3.Text = "UF";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(11, 92);
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
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(172, 21);
            labelTitle.TabIndex = 1001;
            labelTitle.Text = "Cadastro de Clientes";
            // 
            // formClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(864, 401);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel);
            Controls.Add(userControl);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "formClientes";
            Text = "Cadastro de Clientes";
            Load += formClientes_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Label labelTelefone;
        private Label labelCpf;
        private TextBox textBoxNome;
        private Label labelNome;
        private UserControl1 userControl;
        private MaskedTextBox maskedTelefone;
        private MaskedTextBox maskedCPF;
        private Panel panel1;
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
        private ComboBox comboBoxUF;
        private Label labelID;
        private TextBox textBoxIdCliente;
        private Label labelIdCliente;
        private TextBox textBoxId;
        private MaskedTextBox maskedCEP;
        private Button botaoVisualizarCadastros;
        private Button buttonVisualizarEndereços;
        private Label labelTitle;
    }
}