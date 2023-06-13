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
            textBoxNome = new TextBox();
            labelNome = new Label();
            listBoxTipo = new ListBox();
            listBoxCategoria = new ListBox();
            checkedListBoxIngredientes = new CheckedListBox();
            pictureBoxImagem = new PictureBox();
            labelIngredientes = new Label();
            labelCategoria = new Label();
            labelTipo = new Label();
            userControl = new UserControl1();
            botaoVisualizarCadastros = new Button();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.Silver;
            panel.Controls.Add(botaoVisualizarCadastros);
            panel.Controls.Add(textBoxNome);
            panel.Controls.Add(labelNome);
            panel.Controls.Add(listBoxTipo);
            panel.Controls.Add(listBoxCategoria);
            panel.Controls.Add(checkedListBoxIngredientes);
            panel.Controls.Add(pictureBoxImagem);
            panel.Controls.Add(labelIngredientes);
            panel.Controls.Add(labelCategoria);
            panel.Controls.Add(labelTipo);
            panel.Location = new Point(12, 12);
            panel.Name = "panel";
            panel.Size = new Size(548, 309);
            panel.TabIndex = 0;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(21, 24);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(148, 23);
            textBoxNome.TabIndex = 17;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(21, 5);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(41, 16);
            labelNome.TabIndex = 16;
            labelNome.Text = "Nome";
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 15;
            listBoxTipo.Location = new Point(251, 137);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(120, 94);
            listBoxTipo.TabIndex = 15;
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.ItemHeight = 15;
            listBoxCategoria.Location = new Point(251, 24);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(120, 94);
            listBoxCategoria.TabIndex = 14;
            // 
            // checkedListBoxIngredientes
            // 
            checkedListBoxIngredientes.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkedListBoxIngredientes.FormattingEnabled = true;
            checkedListBoxIngredientes.Items.AddRange(new object[] { "Tomate", "Catupiry", "Bacon", "Queijo", "Rúcula", "Frango", "Cebola", "Alho", "Ovo", "Lombo", "Pepperoni", "Pimentão", "Presunto", "Queijo", "Calabresa" });
            checkedListBoxIngredientes.Location = new Point(398, 22);
            checkedListBoxIngredientes.Name = "checkedListBoxIngredientes";
            checkedListBoxIngredientes.Size = new Size(120, 235);
            checkedListBoxIngredientes.TabIndex = 3;
            checkedListBoxIngredientes.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // pictureBoxImagem
            // 
            pictureBoxImagem.BackColor = Color.White;
            pictureBoxImagem.InitialImage = (Image)resources.GetObject("pictureBoxImagem.InitialImage");
            pictureBoxImagem.Location = new Point(21, 64);
            pictureBoxImagem.Name = "pictureBoxImagem";
            pictureBoxImagem.Size = new Size(179, 159);
            pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagem.TabIndex = 13;
            pictureBoxImagem.TabStop = false;
            pictureBoxImagem.Click += pictureBoxPizza_Click;
            // 
            // labelIngredientes
            // 
            labelIngredientes.AutoSize = true;
            labelIngredientes.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelIngredientes.Location = new Point(398, 5);
            labelIngredientes.Name = "labelIngredientes";
            labelIngredientes.Size = new Size(81, 16);
            labelIngredientes.TabIndex = 6;
            labelIngredientes.Text = "Ingredientes";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategoria.Location = new Point(251, 5);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(66, 16);
            labelCategoria.TabIndex = 4;
            labelCategoria.Text = "Categoria";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipo.Location = new Point(251, 121);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(32, 16);
            labelTipo.TabIndex = 2;
            labelTipo.Text = "Tipo";
            labelTipo.Click += labelTipo_Click;
            // 
            // userControl
            // 
            userControl.BackColor = Color.Transparent;
            userControl.Location = new Point(51, 315);
            userControl.Margin = new Padding(3, 4, 3, 4);
            userControl.Name = "userControl";
            userControl.Size = new Size(479, 91);
            userControl.TabIndex = 4;
            userControl.Load += userControl11_Load;
            // 
            // botaoVisualizarCadastros
            // 
            botaoVisualizarCadastros.BackColor = Color.PaleGoldenrod;
            botaoVisualizarCadastros.Cursor = Cursors.Hand;
            botaoVisualizarCadastros.FlatStyle = FlatStyle.Flat;
            botaoVisualizarCadastros.Font = new Font("Nexa Heavy", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            botaoVisualizarCadastros.Location = new Point(21, 237);
            botaoVisualizarCadastros.Name = "botaoVisualizarCadastros";
            botaoVisualizarCadastros.Size = new Size(249, 52);
            botaoVisualizarCadastros.TabIndex = 18;
            botaoVisualizarCadastros.Text = "Visualizar Cadastros";
            botaoVisualizarCadastros.UseVisualStyleBackColor = false;
            botaoVisualizarCadastros.Click += botaoVisualizarCadastros_Click;
            // 
            // formSabores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(568, 406);
            Controls.Add(panel);
            Controls.Add(userControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "formSabores";
            Text = "Cadastro de Sabores";
            Load += formSabores_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private PictureBox pictureBoxImagem;
        private Label labelIngredientes;
        private Label labelCategoria;
        private Label labelTipo;
        private UserControl1 userControl;
        private CheckedListBox checkedListBoxIngredientes;
        private ListBox listBoxTipo;
        private ListBox listBoxCategoria;
        private TextBox textBoxNome;
        private Label labelNome;
        private Button botaoVisualizarCadastros;
    }
}