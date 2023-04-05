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
            userControl.Location = new Point(50, 160);
            userControl.Margin = new Padding(3, 4, 3, 4);
            userControl.Name = "userControl";
            userControl.Size = new Size(479, 91);
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
            panel.Location = new Point(11, 23);
            panel.Margin = new Padding(3, 2, 3, 2);
            panel.Name = "panel";
            panel.Size = new Size(564, 143);
            panel.TabIndex = 1;
            panel.Paint += panel_Paint;
            // 
            // comboBoxML
            // 
            comboBoxML.Font = new Font("Nexa Heavy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxML.FormattingEnabled = true;
            comboBoxML.Items.AddRange(new object[] { "150", "300", "600", "1000", "1500", "2000" });
            comboBoxML.Location = new Point(438, 23);
            comboBoxML.Margin = new Padding(3, 2, 3, 2);
            comboBoxML.Name = "comboBoxML";
            comboBoxML.Size = new Size(106, 25);
            comboBoxML.TabIndex = 6;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.Font = new Font("Nexa Heavy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "R - REFRIGERANTE", "C - CERVEJA ", "S - SUCO", "A - ÁGUA", "O - OUTROS" });
            comboBoxTipo.Location = new Point(269, 23);
            comboBoxTipo.Margin = new Padding(3, 2, 3, 2);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(149, 25);
            comboBoxTipo.TabIndex = 5;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(130, 23);
            textBoxNome.Margin = new Padding(3, 2, 3, 2);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(108, 23);
            textBoxNome.TabIndex = 3;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(130, 8);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(41, 16);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(10, 23);
            textBoxCodigo.Margin = new Padding(3, 2, 3, 2);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(88, 23);
            textBoxCodigo.TabIndex = 0;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodigo.Location = new Point(10, 5);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(47, 16);
            labelCodigo.TabIndex = 1;
            labelCodigo.Text = "Código";
            // 
            // labelML
            // 
            labelML.AutoSize = true;
            labelML.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelML.Location = new Point(438, 8);
            labelML.Name = "labelML";
            labelML.Size = new Size(25, 16);
            labelML.TabIndex = 7;
            labelML.Text = "ML";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipo.Location = new Point(269, 8);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(32, 16);
            labelTipo.TabIndex = 4;
            labelTipo.Text = "Tipo";
            // 
            // formProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(586, 254);
            Controls.Add(panel);
            Controls.Add(userControl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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