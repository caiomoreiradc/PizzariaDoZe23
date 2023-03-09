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
            panel1 = new Panel();
            pictureBoxPizza = new PictureBox();
            radioButtonCatupiry = new RadioButton();
            radioButtonTomate = new RadioButton();
            radioButtonBacon = new RadioButton();
            radioButtonFrango = new RadioButton();
            Pepperoni = new RadioButton();
            radioButtonQueijo = new RadioButton();
            labelIngredientes = new Label();
            comboBoxCategoriaPizza = new ComboBox();
            labelCategoriaPizza = new Label();
            comboBoxTipoPizza = new ComboBox();
            labelTipoPizza = new Label();
            textBoxCodigSabores = new TextBox();
            labelCodigSabor = new Label();
            labelTitulosSabores = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPizza).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(pictureBoxPizza);
            panel1.Controls.Add(radioButtonCatupiry);
            panel1.Controls.Add(radioButtonTomate);
            panel1.Controls.Add(radioButtonBacon);
            panel1.Controls.Add(radioButtonFrango);
            panel1.Controls.Add(Pepperoni);
            panel1.Controls.Add(radioButtonQueijo);
            panel1.Controls.Add(labelIngredientes);
            panel1.Controls.Add(comboBoxCategoriaPizza);
            panel1.Controls.Add(labelCategoriaPizza);
            panel1.Controls.Add(comboBoxTipoPizza);
            panel1.Controls.Add(labelTipoPizza);
            panel1.Controls.Add(textBoxCodigSabores);
            panel1.Controls.Add(labelCodigSabor);
            panel1.Location = new Point(12, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 262);
            panel1.TabIndex = 0;
            // 
            // pictureBoxPizza
            // 
            pictureBoxPizza.Location = new Point(14, 67);
            pictureBoxPizza.Name = "pictureBoxPizza";
            pictureBoxPizza.Size = new Size(245, 176);
            pictureBoxPizza.TabIndex = 13;
            pictureBoxPizza.TabStop = false;
            pictureBoxPizza.Click += pictureBoxPizza_Click;
            // 
            // radioButtonCatupiry
            // 
            radioButtonCatupiry.AutoSize = true;
            radioButtonCatupiry.Location = new Point(360, 110);
            radioButtonCatupiry.Name = "radioButtonCatupiry";
            radioButtonCatupiry.Size = new Size(70, 19);
            radioButtonCatupiry.TabIndex = 12;
            radioButtonCatupiry.TabStop = true;
            radioButtonCatupiry.Text = "Catupiry";
            radioButtonCatupiry.UseVisualStyleBackColor = true;
            // 
            // radioButtonTomate
            // 
            radioButtonTomate.AutoSize = true;
            radioButtonTomate.Location = new Point(281, 110);
            radioButtonTomate.Name = "radioButtonTomate";
            radioButtonTomate.Size = new Size(64, 19);
            radioButtonTomate.TabIndex = 11;
            radioButtonTomate.TabStop = true;
            radioButtonTomate.Text = "Tomate";
            radioButtonTomate.UseVisualStyleBackColor = true;
            // 
            // radioButtonBacon
            // 
            radioButtonBacon.AutoSize = true;
            radioButtonBacon.Location = new Point(445, 110);
            radioButtonBacon.Name = "radioButtonBacon";
            radioButtonBacon.Size = new Size(58, 19);
            radioButtonBacon.TabIndex = 10;
            radioButtonBacon.TabStop = true;
            radioButtonBacon.Text = "Bacon";
            radioButtonBacon.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrango
            // 
            radioButtonFrango.AutoSize = true;
            radioButtonFrango.Location = new Point(445, 145);
            radioButtonFrango.Name = "radioButtonFrango";
            radioButtonFrango.Size = new Size(62, 19);
            radioButtonFrango.TabIndex = 9;
            radioButtonFrango.TabStop = true;
            radioButtonFrango.Text = "Frango";
            radioButtonFrango.UseVisualStyleBackColor = true;
            // 
            // Pepperoni
            // 
            Pepperoni.AutoSize = true;
            Pepperoni.Location = new Point(360, 145);
            Pepperoni.Name = "Pepperoni";
            Pepperoni.Size = new Size(79, 19);
            Pepperoni.TabIndex = 8;
            Pepperoni.TabStop = true;
            Pepperoni.Text = "Pepperoni";
            Pepperoni.UseVisualStyleBackColor = true;
            // 
            // radioButtonQueijo
            // 
            radioButtonQueijo.AutoSize = true;
            radioButtonQueijo.Location = new Point(281, 145);
            radioButtonQueijo.Name = "radioButtonQueijo";
            radioButtonQueijo.Size = new Size(60, 19);
            radioButtonQueijo.TabIndex = 7;
            radioButtonQueijo.TabStop = true;
            radioButtonQueijo.Text = "Queijo";
            radioButtonQueijo.UseVisualStyleBackColor = true;
            // 
            // labelIngredientes
            // 
            labelIngredientes.AutoSize = true;
            labelIngredientes.Location = new Point(282, 85);
            labelIngredientes.Name = "labelIngredientes";
            labelIngredientes.Size = new Size(72, 15);
            labelIngredientes.TabIndex = 6;
            labelIngredientes.Text = "Ingredientes";
            // 
            // comboBoxCategoriaPizza
            // 
            comboBoxCategoriaPizza.AutoCompleteCustomSource.AddRange(new string[] { "Tradicional", "Premium" });
            comboBoxCategoriaPizza.FormattingEnabled = true;
            comboBoxCategoriaPizza.Location = new Point(349, 28);
            comboBoxCategoriaPizza.Name = "comboBoxCategoriaPizza";
            comboBoxCategoriaPizza.Size = new Size(132, 23);
            comboBoxCategoriaPizza.TabIndex = 5;
            // 
            // labelCategoriaPizza
            // 
            labelCategoriaPizza.AutoSize = true;
            labelCategoriaPizza.Location = new Point(349, 10);
            labelCategoriaPizza.Name = "labelCategoriaPizza";
            labelCategoriaPizza.Size = new Size(58, 15);
            labelCategoriaPizza.TabIndex = 4;
            labelCategoriaPizza.Text = "Categoria";
            // 
            // comboBoxTipoPizza
            // 
            comboBoxTipoPizza.AutoCompleteCustomSource.AddRange(new string[] { "Doce", "Salgada" });
            comboBoxTipoPizza.FormattingEnabled = true;
            comboBoxTipoPizza.Location = new Point(144, 28);
            comboBoxTipoPizza.Name = "comboBoxTipoPizza";
            comboBoxTipoPizza.Size = new Size(133, 23);
            comboBoxTipoPizza.TabIndex = 3;
            // 
            // labelTipoPizza
            // 
            labelTipoPizza.AutoSize = true;
            labelTipoPizza.Location = new Point(165, 10);
            labelTipoPizza.Name = "labelTipoPizza";
            labelTipoPizza.Size = new Size(30, 15);
            labelTipoPizza.TabIndex = 2;
            labelTipoPizza.Text = "Tipo";
            // 
            // textBoxCodigSabores
            // 
            textBoxCodigSabores.Location = new Point(14, 28);
            textBoxCodigSabores.Name = "textBoxCodigSabores";
            textBoxCodigSabores.Size = new Size(100, 23);
            textBoxCodigSabores.TabIndex = 1;
            // 
            // labelCodigSabor
            // 
            labelCodigSabor.AutoSize = true;
            labelCodigSabor.Location = new Point(14, 10);
            labelCodigSabor.Name = "labelCodigSabor";
            labelCodigSabor.Size = new Size(46, 15);
            labelCodigSabor.TabIndex = 0;
            labelCodigSabor.Text = "Código";
            // 
            // labelTitulosSabores
            // 
            labelTitulosSabores.AutoSize = true;
            labelTitulosSabores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulosSabores.Location = new Point(12, 9);
            labelTitulosSabores.Name = "labelTitulosSabores";
            labelTitulosSabores.Size = new Size(137, 21);
            labelTitulosSabores.TabIndex = 1;
            labelTitulosSabores.Text = "Cadastrar Sabores";
            labelTitulosSabores.Click += labelTitulosSabores_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(54, 303);
            button1.Name = "button1";
            button1.Size = new Size(497, 41);
            button1.TabIndex = 2;
            button1.Text = "Salvar Cadastro";
            button1.UseVisualStyleBackColor = false;
            // 
            // formSabores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 356);
            Controls.Add(button1);
            Controls.Add(labelTitulosSabores);
            Controls.Add(panel1);
            Name = "formSabores";
            Text = "Cadastro de Sabores";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPizza).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxPizza;
        private RadioButton radioButtonCatupiry;
        private RadioButton radioButtonTomate;
        private RadioButton radioButtonBacon;
        private RadioButton radioButtonFrango;
        private RadioButton Pepperoni;
        private RadioButton radioButtonQueijo;
        private Label labelIngredientes;
        private ComboBox comboBoxCategoriaPizza;
        private Label labelCategoriaPizza;
        private ComboBox comboBoxTipoPizza;
        private Label labelTipoPizza;
        private TextBox textBoxCodigSabores;
        private Label labelCodigSabor;
        private Label labelTitulosSabores;
        private Button button1;
    }
}