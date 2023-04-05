namespace PizzariaDoZe
{
    partial class formSabores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSabores));
            panel = new Panel();
            ingredientes = new CheckedListBox();
            pictureBoxPizza = new PictureBox();
            labelIngredientes = new Label();
            comboBoxCategoria = new ComboBox();
            labelCategoria = new Label();
            comboBoxTipo = new ComboBox();
            labelTipo = new Label();
            textBoxCodigo = new TextBox();
            labelCodigo = new Label();
            userControl = new UserControl1();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPizza).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.Silver;
            panel.Controls.Add(ingredientes);
            panel.Controls.Add(pictureBoxPizza);
            panel.Controls.Add(labelIngredientes);
            panel.Controls.Add(comboBoxCategoria);
            panel.Controls.Add(labelCategoria);
            panel.Controls.Add(comboBoxTipo);
            panel.Controls.Add(labelTipo);
            panel.Controls.Add(textBoxCodigo);
            panel.Controls.Add(labelCodigo);
            panel.Location = new Point(14, 15);
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.Name = "panel";
            panel.Size = new Size(626, 391);
            panel.TabIndex = 0;
            // 
            // ingredientes
            // 
            ingredientes.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ingredientes.FormattingEnabled = true;
            ingredientes.Items.AddRange(new object[] { "Tomate", "Catupiry", "Bacon", "Queijo", "Rúcula", "Frango", "Cebola", "Alho", "Ovo", "Lombo", "Pepperoni", "Pimentão", "Presunto", "Queijo", "Calabresa" });
            ingredientes.Location = new Point(455, 28);
            ingredientes.Margin = new Padding(3, 4, 3, 4);
            ingredientes.Name = "ingredientes";
            ingredientes.Size = new Size(137, 319);
            ingredientes.TabIndex = 29;
            ingredientes.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // pictureBoxPizza
            // 
            pictureBoxPizza.Image = (Image)resources.GetObject("pictureBoxPizza.Image");
            pictureBoxPizza.InitialImage = (Image)resources.GetObject("pictureBoxPizza.InitialImage");
            pictureBoxPizza.Location = new Point(45, 81);
            pictureBoxPizza.Margin = new Padding(3, 4, 3, 4);
            pictureBoxPizza.Name = "pictureBoxPizza";
            pictureBoxPizza.Size = new Size(205, 202);
            pictureBoxPizza.TabIndex = 13;
            pictureBoxPizza.TabStop = false;
            pictureBoxPizza.Click += pictureBoxPizza_Click;
            // 
            // labelIngredientes
            // 
            labelIngredientes.AutoSize = true;
            labelIngredientes.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelIngredientes.Location = new Point(455, 6);
            labelIngredientes.Name = "labelIngredientes";
            labelIngredientes.Size = new Size(81, 16);
            labelIngredientes.TabIndex = 6;
            labelIngredientes.Text = "Ingredientes";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.AutoCompleteCustomSource.AddRange(new string[] { "Tradicional", "Premium" });
            comboBoxCategoria.Font = new Font("Nexa Heavy", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Items.AddRange(new object[] { "Tradicional", "Premium" });
            comboBoxCategoria.Location = new Point(287, 81);
            comboBoxCategoria.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(150, 25);
            comboBoxCategoria.TabIndex = 5;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategoria.Location = new Point(287, 57);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(66, 16);
            labelCategoria.TabIndex = 4;
            labelCategoria.Text = "Categoria";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.AutoCompleteCustomSource.AddRange(new string[] { "Doce", "Salgada" });
            comboBoxTipo.Font = new Font("Nexa Heavy", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Doce", "Salgada" });
            comboBoxTipo.Location = new Point(286, 198);
            comboBoxTipo.Margin = new Padding(3, 4, 3, 4);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(151, 25);
            comboBoxTipo.TabIndex = 3;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipo.Location = new Point(287, 174);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(32, 16);
            labelTipo.TabIndex = 2;
            labelTipo.Text = "Tipo";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(105, 20);
            textBoxCodigo.Margin = new Padding(3, 4, 3, 4);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(114, 26);
            textBoxCodigo.TabIndex = 1;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodigo.Location = new Point(45, 20);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(47, 16);
            labelCodigo.TabIndex = 0;
            labelCodigo.Text = "Código";
            // 
            // userControl
            // 
            userControl.BackColor = Color.Transparent;
            userControl.Location = new Point(58, 399);
            userControl.Margin = new Padding(3, 5, 3, 5);
            userControl.Name = "userControl";
            userControl.Size = new Size(547, 115);
            userControl.TabIndex = 2;
            userControl.Load += userControl11_Load;
            // 
            // formSabores
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(649, 514);
            Controls.Add(panel);
            Controls.Add(userControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "formSabores";
            Text = "Cadastro de Sabores";
            Load += formSabores_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPizza).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private PictureBox pictureBoxPizza;
        private Label labelIngredientes;
        private ComboBox comboBoxCategoria;
        private Label labelCategoria;
        private ComboBox comboBoxTipo;
        private Label labelTipo;
        private TextBox textBoxCodigo;
        private Label labelCodigo;
        private UserControl1 userControl;
        private CheckedListBox ingredientes;
    }
}