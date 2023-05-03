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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFunciEndereco));
            panel = new Panel();
            comboBoxPais = new ComboBox();
            comboBoxUF = new ComboBox();
            labelPais = new Label();
            labelUF = new Label();
            textBoxCidade = new TextBox();
            labelCidade = new Label();
            textBoxComplemento = new TextBox();
            labelComplemento = new Label();
            textBoxBairro = new TextBox();
            labelBairro = new Label();
            textBoxNumero = new TextBox();
            labelNumero = new Label();
            textBoxLogradouro = new TextBox();
            labelLogradouro = new Label();
            textBoxCep = new TextBox();
            labelCEP = new Label();
            userControl = new UserControl1();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.Silver;
            panel.Controls.Add(comboBoxPais);
            panel.Controls.Add(comboBoxUF);
            panel.Controls.Add(labelPais);
            panel.Controls.Add(labelUF);
            panel.Controls.Add(textBoxCidade);
            panel.Controls.Add(labelCidade);
            panel.Controls.Add(textBoxComplemento);
            panel.Controls.Add(labelComplemento);
            panel.Controls.Add(textBoxBairro);
            panel.Controls.Add(labelBairro);
            panel.Controls.Add(textBoxNumero);
            panel.Controls.Add(labelNumero);
            panel.Controls.Add(textBoxLogradouro);
            panel.Controls.Add(labelLogradouro);
            panel.Controls.Add(textBoxCep);
            panel.Controls.Add(labelCEP);
            panel.Location = new Point(12, 7);
            panel.Name = "panel";
            panel.Size = new Size(694, 160);
            panel.TabIndex = 0;
            panel.Paint += panel1_Paint;
            // 
            // comboBoxPais
            // 
            comboBoxPais.AutoCompleteCustomSource.AddRange(new string[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua & Deps", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia Herzegovina", "Botswana", "Brasil", "Brunei", "Bulgaria", "Burkina", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Rep", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Congo {Democratic Rep}", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland {Republic}", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea North", "Korea South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar, {Burma}", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russian Federation", "Rwanda", "St Kitts & Nevis", "St Lucia", "Saint Vincent & the Grenadines", "Samoa", "San Marino", "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" });
            comboBoxPais.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxPais.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxPais.FormattingEnabled = true;
            comboBoxPais.Items.AddRange(new object[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua & Deps", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia Herzegovina", "Botswana", "Brasil", "Brunei", "Bulgaria", "Burkina", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Rep", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Congo {Democratic Rep}", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland {Republic}", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea North", "Korea South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar, {Burma}", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russian Federation", "Rwanda", "Saint Vincent & the Grenadines", "Samoa", "San Marino", "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "St Kitts & Nevis", "St Lucia", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" });
            comboBoxPais.Location = new Point(515, 89);
            comboBoxPais.Name = "comboBoxPais";
            comboBoxPais.Size = new Size(167, 24);
            comboBoxPais.TabIndex = 7;
            comboBoxPais.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBoxUF
            // 
            comboBoxUF.AutoCompleteCustomSource.AddRange(new string[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxUF.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxUF.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxUF.FormattingEnabled = true;
            comboBoxUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxUF.Location = new Point(453, 90);
            comboBoxUF.Name = "comboBoxUF";
            comboBoxUF.Size = new Size(56, 24);
            comboBoxUF.TabIndex = 6;
            comboBoxUF.SelectedIndexChanged += comboBoxUFFunci_SelectedIndexChanged;
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPais.Location = new Point(515, 70);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(32, 16);
            labelPais.TabIndex = 14;
            labelPais.Text = "País";
            // 
            // labelUF
            // 
            labelUF.AutoSize = true;
            labelUF.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUF.Location = new Point(465, 70);
            labelUF.Name = "labelUF";
            labelUF.Size = new Size(24, 16);
            labelUF.TabIndex = 12;
            labelUF.Text = "UF";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(300, 90);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(147, 26);
            textBoxCidade.TabIndex = 5;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCidade.Location = new Point(300, 71);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(49, 16);
            labelCidade.TabIndex = 10;
            labelCidade.Text = "Cidade";
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(18, 90);
            textBoxComplemento.Multiline = true;
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(263, 48);
            textBoxComplemento.TabIndex = 4;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelComplemento.Location = new Point(18, 70);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(88, 16);
            labelComplemento.TabIndex = 8;
            labelComplemento.Text = "Complemento";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(583, 31);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(99, 26);
            textBoxBairro.TabIndex = 3;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBairro.Location = new Point(583, 12);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(46, 16);
            labelBairro.TabIndex = 6;
            labelBairro.Text = "Bairro";
            labelBairro.Click += label1_Click_1;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(504, 31);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(58, 26);
            textBoxNumero.TabIndex = 2;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumero.Location = new Point(504, 12);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(54, 16);
            labelNumero.TabIndex = 4;
            labelNumero.Text = "Número";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(182, 31);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(305, 26);
            textBoxLogradouro.TabIndex = 1;
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogradouro.Location = new Point(182, 12);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(77, 16);
            labelLogradouro.TabIndex = 2;
            labelLogradouro.Text = "Logradouro";
            // 
            // textBoxCep
            // 
            textBoxCep.Location = new Point(18, 31);
            textBoxCep.Name = "textBoxCep";
            textBoxCep.Size = new Size(125, 26);
            textBoxCep.TabIndex = 0;
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCEP.Location = new Point(18, 12);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(31, 16);
            labelCEP.TabIndex = 0;
            labelCEP.Text = "CEP";
            labelCEP.Click += label1_Click;
            // 
            // userControl
            // 
            userControl.BackColor = Color.Transparent;
            userControl.Location = new Point(79, 163);
            userControl.Margin = new Padding(3, 4, 3, 4);
            userControl.Name = "userControl";
            userControl.Size = new Size(547, 89);
            userControl.TabIndex = 8;
            userControl.Load += userControl11_Load;
            // 
            // formFunciEndereco
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(719, 265);
            Controls.Add(panel);
            Controls.Add(userControl);
            Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "formFunciEndereco";
            Text = "Cadastro de Endereço dos Funcionários";
            Load += formFunciEndereco_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private Label labelCEP;
        private TextBox textBoxCep;
        private Label labelBairro;
        private TextBox textBoxNumero;
        private Label labelNumero;
        private TextBox textBoxLogradouro;
        private Label labelLogradouro;
        private Label labelUF;
        private TextBox textBoxCidade;
        private Label labelCidade;
        private TextBox textBoxComplemento;
        private Label labelComplemento;
        private TextBox textBoxBairro;
        private Label labelPais;
        private ComboBox comboBoxUF;
        private UserControl1 userControl;
        private ComboBox comboBoxPais;
    }
}