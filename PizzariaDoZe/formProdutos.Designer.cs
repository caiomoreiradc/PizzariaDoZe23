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
            listBoxMl = new ListBox();
            listBoxTipo = new ListBox();
            labelValor = new Label();
            textBoxValor = new TextBox();
            textBoxNome = new TextBox();
            labelNome = new Label();
            labelML = new Label();
            labelTipo = new Label();
            botaoVisualizarCadastros = new Button();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // userControl
            // 
            userControl.BackColor = Color.Transparent;
            userControl.Location = new Point(50, 190);
            userControl.Margin = new Padding(3, 4, 3, 4);
            userControl.Name = "userControl";
            userControl.Size = new Size(479, 91);
            userControl.TabIndex = 4;
            userControl.Load += userControl11_Load;
            // 
            // panel
            // 
            panel.BackColor = Color.Silver;
            panel.Controls.Add(botaoVisualizarCadastros);
            panel.Controls.Add(listBoxMl);
            panel.Controls.Add(listBoxTipo);
            panel.Controls.Add(labelValor);
            panel.Controls.Add(textBoxValor);
            panel.Controls.Add(textBoxNome);
            panel.Controls.Add(labelNome);
            panel.Controls.Add(labelML);
            panel.Controls.Add(labelTipo);
            panel.Location = new Point(11, 23);
            panel.Margin = new Padding(3, 2, 3, 2);
            panel.Name = "panel";
            panel.Size = new Size(564, 168);
            panel.TabIndex = 1;
            panel.Paint += panel_Paint;
            // 
            // listBoxMl
            // 
            listBoxMl.FormattingEnabled = true;
            listBoxMl.ItemHeight = 15;
            listBoxMl.Items.AddRange(new object[] { "150", "300", "600", "1000", "1500", "2000" });
            listBoxMl.Location = new Point(420, 27);
            listBoxMl.Name = "listBoxMl";
            listBoxMl.Size = new Size(120, 109);
            listBoxMl.TabIndex = 11;
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 15;
            listBoxTipo.Location = new Point(269, 27);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(120, 94);
            listBoxTipo.TabIndex = 10;
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValor.Location = new Point(39, 57);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(39, 16);
            labelValor.TabIndex = 9;
            labelValor.Text = "Valor";
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(20, 75);
            textBoxValor.Margin = new Padding(3, 2, 3, 2);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(215, 23);
            textBoxValor.TabIndex = 8;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(20, 23);
            textBoxNome.Margin = new Padding(3, 2, 3, 2);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(215, 23);
            textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(39, 8);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(41, 16);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
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
            // botaoVisualizarCadastros
            // 
            botaoVisualizarCadastros.BackColor = Color.PaleGoldenrod;
            botaoVisualizarCadastros.Cursor = Cursors.Hand;
            botaoVisualizarCadastros.FlatStyle = FlatStyle.Flat;
            botaoVisualizarCadastros.Font = new Font("Nexa Heavy", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            botaoVisualizarCadastros.Location = new Point(14, 108);
            botaoVisualizarCadastros.Name = "botaoVisualizarCadastros";
            botaoVisualizarCadastros.Size = new Size(249, 52);
            botaoVisualizarCadastros.TabIndex = 14;
            botaoVisualizarCadastros.Text = "Visualizar Cadastros";
            botaoVisualizarCadastros.UseVisualStyleBackColor = false;
            botaoVisualizarCadastros.Click += botaoVisualizarCadastros_Click;
            // 
            // formProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(586, 294);
            Controls.Add(panel);
            Controls.Add(userControl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
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
        private Label labelTipo;
        private TextBox textBoxNome;
        private Label labelNome;
        private Label labelValor;
        private TextBox textBoxValor;
        private ListBox listBoxMl;
        private ListBox listBoxTipo;
        private Button botaoVisualizarCadastros;
    }
}