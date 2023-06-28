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
            textBoxId = new TextBox();
            label1 = new Label();
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
            dataGridViewDados = new DataGridView();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.Silver;
            panel.Controls.Add(textBoxId);
            panel.Controls.Add(label1);
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
            panel.Size = new Size(548, 270);
            panel.TabIndex = 0;
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Location = new Point(21, 22);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(52, 23);
            textBoxId.TabIndex = 0;
            textBoxId.Text = "0";
            textBoxId.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 3);
            label1.Name = "label1";
            label1.Size = new Size(20, 16);
            label1.TabIndex = 18;
            label1.Text = "ID";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(21, 69);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(148, 23);
            textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(21, 50);
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
            checkedListBoxIngredientes.TabIndex = 4;
            checkedListBoxIngredientes.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // pictureBoxImagem
            // 
            pictureBoxImagem.BackColor = Color.White;
            pictureBoxImagem.InitialImage = (Image)resources.GetObject("pictureBoxImagem.InitialImage");
            pictureBoxImagem.Location = new Point(21, 98);
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
            userControl.Location = new Point(51, 484);
            userControl.Margin = new Padding(3, 4, 3, 4);
            userControl.Name = "userControl";
            userControl.Size = new Size(479, 91);
            userControl.TabIndex = 4;
            userControl.Load += userControl11_Load;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.AllowUserToAddRows = false;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewDados.Location = new Point(12, 299);
            dataGridViewDados.MultiSelect = false;
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDados.Size = new Size(548, 178);
            dataGridViewDados.TabIndex = 5;
            dataGridViewDados.CellContentDoubleClick += dataGridViewDados_CellContentDoubleClick;
            dataGridViewDados.CellFormatting += dataGridViewDados_CellFormatting;
            // 
            // formSabores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(568, 588);
            Controls.Add(dataGridViewDados);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
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
        private DataGridView dataGridViewDados;
        private TextBox textBoxId;
        private Label label1;
    }
}