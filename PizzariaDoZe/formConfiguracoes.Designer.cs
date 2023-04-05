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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConfiguracoes));
            panel1 = new Panel();
            checkBoxReiniciarCFG = new CheckBox();
            comboBoxIdioma = new ComboBox();
            labelIdioma = new Label();
            buttonSalvarConfig = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxReiniciarCFG);
            panel1.Controls.Add(comboBoxIdioma);
            panel1.Controls.Add(labelIdioma);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 258);
            panel1.TabIndex = 0;
            // 
            // checkBoxReiniciarCFG
            // 
            checkBoxReiniciarCFG.AutoSize = true;
            checkBoxReiniciarCFG.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxReiniciarCFG.Location = new Point(150, 32);
            checkBoxReiniciarCFG.Name = "checkBoxReiniciarCFG";
            checkBoxReiniciarCFG.Size = new Size(220, 20);
            checkBoxReiniciarCFG.TabIndex = 2;
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
            comboBoxIdioma.TabIndex = 1;
            comboBoxIdioma.SelectedIndexChanged += comboBoxIdioma_SelectedIndexChanged;
            // 
            // labelIdioma
            // 
            labelIdioma.AutoSize = true;
            labelIdioma.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelIdioma.Location = new Point(21, 9);
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
            buttonSalvarConfig.Location = new Point(265, 285);
            buttonSalvarConfig.Name = "buttonSalvarConfig";
            buttonSalvarConfig.Size = new Size(114, 71);
            buttonSalvarConfig.TabIndex = 2;
            buttonSalvarConfig.Text = "Salvar";
            buttonSalvarConfig.UseVisualStyleBackColor = false;
            buttonSalvarConfig.Click += buttonSalvarConfig_Click;
            // 
            // formConfiguracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wallpaper;
            ClientSize = new Size(644, 368);
            Controls.Add(buttonSalvarConfig);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formConfiguracoes";
            Text = "Configurações";
            Load += formConfiguracoes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxIdioma;
        private Label labelIdioma;
        private Button buttonSalvarConfig;
        private CheckBox checkBoxReiniciarCFG;
    }
}