namespace PizzariaDoZe
{
    partial class formConfiguracoes
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
            Button buttonSalvar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConfiguracoes));
            panel1 = new Panel();
            checkBoxReiniciarCFG = new CheckBox();
            comboBoxIdioma = new ComboBox();
            labelIdioma = new Label();
            buttonSalvarConfig = new Button();
            labelBanco = new Label();
            comboBoxProvider = new ComboBox();
            labelProvider = new Label();
            panel2 = new Panel();
            textBoxStringDeConexao = new TextBox();
            labelString = new Label();
            buttonSalvar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.PaleGoldenrod;
            buttonSalvar.Cursor = Cursors.Hand;
            buttonSalvar.FlatStyle = FlatStyle.Flat;
            buttonSalvar.Font = new Font("Nexa Heavy", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.Location = new Point(215, 89);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(187, 47);
            buttonSalvar.TabIndex = 6;
            buttonSalvar.Text = "Salvar Banco";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSalvarConfig);
            panel1.Controls.Add(checkBoxReiniciarCFG);
            panel1.Controls.Add(comboBoxIdioma);
            panel1.Controls.Add(labelIdioma);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 64);
            panel1.TabIndex = 0;
            // 
            // checkBoxReiniciarCFG
            // 
            checkBoxReiniciarCFG.AutoSize = true;
            checkBoxReiniciarCFG.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxReiniciarCFG.Location = new Point(150, 32);
            checkBoxReiniciarCFG.Name = "checkBoxReiniciarCFG";
            checkBoxReiniciarCFG.Size = new Size(220, 20);
            checkBoxReiniciarCFG.TabIndex = 1;
            checkBoxReiniciarCFG.Text = "Reiniciar Aplicação para salvar?";
            checkBoxReiniciarCFG.UseVisualStyleBackColor = true;
            // 
            // comboBoxIdioma
            // 
            comboBoxIdioma.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxIdioma.FormattingEnabled = true;
            comboBoxIdioma.Items.AddRange(new object[] { "pt-BR", "en-US", "es" });
            comboBoxIdioma.Location = new Point(12, 28);
            comboBoxIdioma.Name = "comboBoxIdioma";
            comboBoxIdioma.Size = new Size(121, 24);
            comboBoxIdioma.TabIndex = 0;
            comboBoxIdioma.SelectedIndexChanged += comboBoxIdioma_SelectedIndexChanged;
            // 
            // labelIdioma
            // 
            labelIdioma.AutoSize = true;
            labelIdioma.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelIdioma.Location = new Point(12, 9);
            labelIdioma.Name = "labelIdioma";
            labelIdioma.Size = new Size(98, 16);
            labelIdioma.TabIndex = 0;
            labelIdioma.Text = "Idioma/ Região";
            // 
            // buttonSalvarConfig
            // 
            buttonSalvarConfig.BackColor = Color.FromArgb(0, 192, 0);
            buttonSalvarConfig.Cursor = Cursors.Hand;
            buttonSalvarConfig.FlatStyle = FlatStyle.Flat;
            buttonSalvarConfig.Font = new Font("Nexa Heavy", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvarConfig.Location = new Point(451, 18);
            buttonSalvarConfig.Name = "buttonSalvarConfig";
            buttonSalvarConfig.Size = new Size(114, 36);
            buttonSalvarConfig.TabIndex = 2;
            buttonSalvarConfig.Text = "Salvar";
            buttonSalvarConfig.UseVisualStyleBackColor = false;
            buttonSalvarConfig.Click += buttonSalvarConfig_Click;
            // 
            // labelBanco
            // 
            labelBanco.AutoSize = true;
            labelBanco.BackColor = Color.Transparent;
            labelBanco.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBanco.Location = new Point(7, 0);
            labelBanco.Name = "labelBanco";
            labelBanco.Size = new Size(103, 16);
            labelBanco.TabIndex = 2;
            labelBanco.Text = "Banco de Dados";
            // 
            // comboBoxProvider
            // 
            comboBoxProvider.FormattingEnabled = true;
            comboBoxProvider.Location = new Point(12, 45);
            comboBoxProvider.Name = "comboBoxProvider";
            comboBoxProvider.Size = new Size(183, 23);
            comboBoxProvider.TabIndex = 3;
            // 
            // labelProvider
            // 
            labelProvider.AutoSize = true;
            labelProvider.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelProvider.Location = new Point(12, 26);
            labelProvider.Name = "labelProvider";
            labelProvider.Size = new Size(59, 16);
            labelProvider.TabIndex = 4;
            labelProvider.Text = "Provider";
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonSalvar);
            panel2.Controls.Add(textBoxStringDeConexao);
            panel2.Controls.Add(labelString);
            panel2.Controls.Add(labelBanco);
            panel2.Controls.Add(labelProvider);
            panel2.Controls.Add(comboBoxProvider);
            panel2.Location = new Point(12, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(620, 147);
            panel2.TabIndex = 5;
            // 
            // textBoxStringDeConexao
            // 
            textBoxStringDeConexao.Location = new Point(244, 45);
            textBoxStringDeConexao.Name = "textBoxStringDeConexao";
            textBoxStringDeConexao.Size = new Size(350, 23);
            textBoxStringDeConexao.TabIndex = 6;
            // 
            // labelString
            // 
            labelString.AutoSize = true;
            labelString.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelString.Location = new Point(244, 26);
            labelString.Name = "labelString";
            labelString.Size = new Size(113, 16);
            labelString.TabIndex = 5;
            labelString.Text = "String de conexão";
            // 
            // formConfiguracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wallpaper;
            ClientSize = new Size(644, 264);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "formConfiguracoes";
            Text = "Configurações";
            Load += formConfiguracoes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxIdioma;
        private Label labelIdioma;
        private Button buttonSalvarConfig;
        private CheckBox checkBoxReiniciarCFG;
        private Label labelBanco;
        private ComboBox comboBoxProvider;
        private Label labelProvider;
        private Panel panel2;
        private TextBox textBoxStringDeConexao;
        private Label labelString;
    }
}