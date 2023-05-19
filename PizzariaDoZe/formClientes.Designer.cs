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
            maskedTelefone = new MaskedTextBox();
            maskedCPF = new MaskedTextBox();
            comboBoxPais = new ComboBox();
            textBoxComplemento = new TextBox();
            labelComplemento = new Label();
            labelPais = new Label();
            comboBoxUF = new ComboBox();
            labelUF = new Label();
            textBoxCidade = new TextBox();
            labelCidade = new Label();
            textBoxNumero = new TextBox();
            labelNumero = new Label();
            textBoxLogradouro = new TextBox();
            labelLogradouro = new Label();
            labelCEP = new Label();
            textBoxEmaiL = new TextBox();
            labelEmail = new Label();
            labelTelefone = new Label();
            labelCpf = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
            userControl = new UserControl1();
            maskedCEP = new MaskedTextBox();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.Silver;
            panel.Controls.Add(maskedCEP);
            panel.Controls.Add(maskedTelefone);
            panel.Controls.Add(maskedCPF);
            panel.Controls.Add(comboBoxPais);
            panel.Controls.Add(textBoxComplemento);
            panel.Controls.Add(labelComplemento);
            panel.Controls.Add(labelPais);
            panel.Controls.Add(comboBoxUF);
            panel.Controls.Add(labelUF);
            panel.Controls.Add(textBoxCidade);
            panel.Controls.Add(labelCidade);
            panel.Controls.Add(textBoxNumero);
            panel.Controls.Add(labelNumero);
            panel.Controls.Add(textBoxLogradouro);
            panel.Controls.Add(labelLogradouro);
            panel.Controls.Add(labelCEP);
            panel.Controls.Add(textBoxEmaiL);
            panel.Controls.Add(labelEmail);
            panel.Controls.Add(labelTelefone);
            panel.Controls.Add(labelCpf);
            panel.Controls.Add(textBoxNome);
            panel.Controls.Add(labelNome);
            panel.Location = new Point(11, 17);
            panel.Name = "panel";
            panel.Size = new Size(842, 196);
            panel.TabIndex = 0;
            panel.Paint += panel_Paint;
            // 
            // maskedTelefone
            // 
            maskedTelefone.Location = new Point(607, 29);
            maskedTelefone.Mask = "+00 (00)00000-0000";
            maskedTelefone.Name = "maskedTelefone";
            maskedTelefone.Size = new Size(179, 23);
            maskedTelefone.TabIndex = 24;
            // 
            // maskedCPF
            // 
            maskedCPF.Location = new Point(406, 29);
            maskedCPF.Mask = "000.000.000-00";
            maskedCPF.Name = "maskedCPF";
            maskedCPF.Size = new Size(157, 23);
            maskedCPF.TabIndex = 23;
            // 
            // comboBoxPais
            // 
            comboBoxPais.AutoCompleteCustomSource.AddRange(new string[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua & Deps", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Rep", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Congo {Democratic Rep}", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland {Republic}", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea North", "Korea South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar, {Burma}", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russian Federation", "Rwanda", "St Kitts & Nevis", "St Lucia", "Saint Vincent & the Grenadines", "Samoa", "San Marino", "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" });
            comboBoxPais.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxPais.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxPais.Font = new Font("Nexa Heavy", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxPais.FormattingEnabled = true;
            comboBoxPais.Items.AddRange(new object[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua & Deps", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia Herzegovina", "Botswana", "Brasil", "Brunei", "Bulgaria", "Burkina", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Rep", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Congo {Democratic Rep}", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland {Republic}", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea North", "Korea South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar, {Burma}", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russian Federation", "Rwanda", "St Kitts & Nevis", "St Lucia", "Saint Vincent & the Grenadines", "Samoa", "San Marino", "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" });
            comboBoxPais.Location = new Point(247, 148);
            comboBoxPais.Name = "comboBoxPais";
            comboBoxPais.Size = new Size(190, 25);
            comboBoxPais.TabIndex = 10;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(458, 150);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(336, 23);
            textBoxComplemento.TabIndex = 11;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelComplemento.Location = new Point(475, 131);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(88, 16);
            labelComplemento.TabIndex = 22;
            labelComplemento.Text = "Complemento";
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPais.Location = new Point(247, 131);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(32, 16);
            labelPais.TabIndex = 20;
            labelPais.Text = "País";
            // 
            // comboBoxUF
            // 
            comboBoxUF.AutoCompleteCustomSource.AddRange(new string[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxUF.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxUF.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxUF.Font = new Font("Nexa Heavy", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxUF.FormattingEnabled = true;
            comboBoxUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxUF.Location = new Point(170, 149);
            comboBoxUF.Name = "comboBoxUF";
            comboBoxUF.Size = new Size(60, 25);
            comboBoxUF.TabIndex = 9;
            // 
            // labelUF
            // 
            labelUF.AutoSize = true;
            labelUF.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUF.Location = new Point(170, 130);
            labelUF.Name = "labelUF";
            labelUF.Size = new Size(24, 16);
            labelUF.TabIndex = 18;
            labelUF.Text = "UF";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(12, 149);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(137, 23);
            textBoxCidade.TabIndex = 8;
            textBoxCidade.TextChanged += textBoxCidade_TextChanged;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCidade.Location = new Point(14, 131);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(49, 16);
            labelCidade.TabIndex = 16;
            labelCidade.Text = "Cidade";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(734, 87);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(84, 23);
            textBoxNumero.TabIndex = 7;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumero.Location = new Point(732, 69);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(54, 16);
            labelNumero.TabIndex = 14;
            labelNumero.Text = "Número";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(475, 87);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(216, 23);
            textBoxLogradouro.TabIndex = 6;
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogradouro.Location = new Point(486, 68);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(77, 16);
            labelLogradouro.TabIndex = 12;
            labelLogradouro.Text = "Logradouro";
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCEP.Location = new Point(300, 68);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(31, 16);
            labelCEP.TabIndex = 10;
            labelCEP.Text = "CEP";
            // 
            // textBoxEmaiL
            // 
            textBoxEmaiL.Location = new Point(12, 87);
            textBoxEmaiL.Name = "textBoxEmaiL";
            textBoxEmaiL.Size = new Size(256, 23);
            textBoxEmaiL.TabIndex = 4;
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
            labelTelefone.Location = new Point(607, 11);
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
            labelCpf.Location = new Point(406, 11);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(31, 16);
            labelCpf.TabIndex = 4;
            labelCpf.Text = "CPF";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(14, 29);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(375, 23);
            textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(22, 10);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(41, 16);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            labelNome.Click += labelNome_Click;
            // 
            // userControl
            // 
            userControl.BackColor = Color.Transparent;
            userControl.Location = new Point(204, 208);
            userControl.Margin = new Padding(3, 4, 3, 4);
            userControl.Name = "userControl";
            userControl.Size = new Size(481, 91);
            userControl.TabIndex = 12;
            userControl.Load += userControl11_Load;
            // 
            // maskedCEP
            // 
            maskedCEP.Location = new Point(300, 87);
            maskedCEP.Mask = "00000-000";
            maskedCEP.Name = "maskedCEP";
            maskedCEP.Size = new Size(140, 23);
            maskedCEP.TabIndex = 13;
            // 
            // formClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(864, 301);
            Controls.Add(panel);
            Controls.Add(userControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "formClientes";
            Text = "Cadastro de Clientes";
            Load += formClientes_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private Label labelUF;
        private TextBox textBoxCidade;
        private Label labelCidade;
        private TextBox textBoxNumero;
        private Label labelNumero;
        private TextBox textBoxLogradouro;
        private Label labelLogradouro;
        private Label labelCEP;
        private TextBox textBoxEmaiL;
        private Label labelEmail;
        private Label labelTelefone;
        private Label labelCpf;
        private TextBox textBoxNome;
        private Label labelNome;
        private TextBox textBoxComplemento;
        private Label labelComplemento;
        private Label labelPais;
        private ComboBox comboBoxUF;
        private UserControl1 userControl;
        private ComboBox comboBoxPais;
        private MaskedTextBox maskedTelefone;
        private MaskedTextBox maskedCPF;
        private MaskedTextBox maskedCEP;
    }
}