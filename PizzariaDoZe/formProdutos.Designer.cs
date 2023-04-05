namespace PizzariaDoZe
{
    partial class formProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProdutos));
            userControl = new UserControl1();
            panel = new Panel();
            comboBoxML = new ComboBox();
            comboBoxTipo = new ComboBox();
            textBoxNome = new TextBox();
            labelNome = new Label();
            textBoxCodigo = new TextBox();
            labelCodigo = new Label();
            labelML = new Label();
            labelTipo = new Label();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // userControl
            // 
            userControl.BackColor = Color.Transparent;
            userControl.Location = new Point(57, 203);
            userControl.Margin = new Padding(3, 5, 3, 5);
            userControl.Name = "userControl";
            userControl.Size = new Size(547, 115);
            userControl.TabIndex = 0;
            userControl.Load += userControl11_Load;
            // 
            // panel
            // 
            panel.BackColor = Color.Silver;
            panel.Controls.Add(comboBoxML);
            panel.Controls.Add(comboBoxTipo);
            panel.Controls.Add(textBoxNome);
            panel.Controls.Add(labelNome);
            panel.Controls.Add(textBoxCodigo);
            panel.Controls.Add(labelCodigo);
            panel.Controls.Add(labelML);
            panel.Controls.Add(labelTipo);
            panel.Location = new Point(13, 29);
            panel.Name = "panel";
            panel.Size = new Size(645, 181);
            panel.TabIndex = 1;
            panel.Paint += panel_Paint;
            // 
            // comboBoxML
            // 
            comboBoxML.Font = new Font("Nexa Heavy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxML.FormattingEnabled = true;
            comboBoxML.Items.AddRange(new object[] { "150", "300", "600", "1000", "1500", "2000" });
            comboBoxML.Location = new Point(501, 29);
            comboBoxML.Name = "comboBoxML";
            comboBoxML.Size = new Size(121, 25);
            comboBoxML.TabIndex = 6;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.Font = new Font("Nexa Heavy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "R - REFRIGERANTE", "C - CERVEJA ", "S - SUCO", "A - ÁGUA", "O - OUTROS" });
            comboBoxTipo.Location = new Point(307, 29);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(170, 25);
            comboBoxTipo.TabIndex = 5;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(149, 29);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(123, 26);
            textBoxNome.TabIndex = 3;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(149, 10);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(41, 16);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(11, 29);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(100, 26);
            textBoxCodigo.TabIndex = 0;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodigo.Location = new Point(11, 6);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(47, 16);
            labelCodigo.TabIndex = 1;
            labelCodigo.Text = "Código";
            // 
            // labelML
            // 
            labelML.AutoSize = true;
            labelML.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelML.Location = new Point(501, 10);
            labelML.Name = "labelML";
            labelML.Size = new Size(25, 16);
            labelML.TabIndex = 7;
            labelML.Text = "ML";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipo.Location = new Point(307, 10);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(32, 16);
            labelTipo.TabIndex = 4;
            labelTipo.Text = "Tipo";
            // 
            // formProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(670, 322);
            Controls.Add(panel);
            Controls.Add(userControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formProdutos";
            Text = "Cadastro de Produtos";
            Load += formProdutos_Load_1;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private UserControl1 userControl;
        private Panel panel;
        private Label labelML;
        private ComboBox comboBoxML;
        private ComboBox comboBoxTipo;
        private Label labelTipo;
        private TextBox textBoxNome;
        private Label labelNome;
        private Label labelCodigo;
        private TextBox textBoxCodigo;
    }
}