namespace PizzariaDoZe
{
    partial class formIngredientes
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
            labelCodigoIngre = new Label();
            panel1 = new Panel();
            textBoxDataVali = new TextBox();
            labelDataIngre = new Label();
            textBoxNomeIngre = new TextBox();
            labelNomeIngre = new Label();
            textBox1 = new TextBox();
            labelTituloIngredi = new Label();
            buttonCadastraIngre = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelCodigoIngre
            // 
            labelCodigoIngre.AutoSize = true;
            labelCodigoIngre.Location = new Point(16, 13);
            labelCodigoIngre.Name = "labelCodigoIngre";
            labelCodigoIngre.Size = new Size(46, 15);
            labelCodigoIngre.TabIndex = 0;
            labelCodigoIngre.Text = "Código";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(textBoxDataVali);
            panel1.Controls.Add(labelDataIngre);
            panel1.Controls.Add(textBoxNomeIngre);
            panel1.Controls.Add(labelNomeIngre);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(labelCodigoIngre);
            panel1.Location = new Point(12, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 87);
            panel1.TabIndex = 1;
            // 
            // textBoxDataVali
            // 
            textBoxDataVali.Location = new Point(368, 31);
            textBoxDataVali.Name = "textBoxDataVali";
            textBoxDataVali.Size = new Size(154, 23);
            textBoxDataVali.TabIndex = 5;
            // 
            // labelDataIngre
            // 
            labelDataIngre.AutoSize = true;
            labelDataIngre.Location = new Point(377, 13);
            labelDataIngre.Name = "labelDataIngre";
            labelDataIngre.Size = new Size(94, 15);
            labelDataIngre.TabIndex = 4;
            labelDataIngre.Text = "Data de Validade";
            // 
            // textBoxNomeIngre
            // 
            textBoxNomeIngre.Location = new Point(137, 31);
            textBoxNomeIngre.Name = "textBoxNomeIngre";
            textBoxNomeIngre.Size = new Size(208, 23);
            textBoxNomeIngre.TabIndex = 3;
            // 
            // labelNomeIngre
            // 
            labelNomeIngre.AutoSize = true;
            labelNomeIngre.Location = new Point(137, 13);
            labelNomeIngre.Name = "labelNomeIngre";
            labelNomeIngre.Size = new Size(40, 15);
            labelNomeIngre.TabIndex = 2;
            labelNomeIngre.Text = "Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(79, 23);
            textBox1.TabIndex = 1;
            // 
            // labelTituloIngredi
            // 
            labelTituloIngredi.AutoSize = true;
            labelTituloIngredi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTituloIngredi.Location = new Point(12, 9);
            labelTituloIngredi.Name = "labelTituloIngredi";
            labelTituloIngredi.Size = new Size(167, 21);
            labelTituloIngredi.TabIndex = 2;
            labelTituloIngredi.Text = "Cadastrar Ingredientes";
            // 
            // buttonCadastraIngre
            // 
            buttonCadastraIngre.BackColor = Color.FromArgb(128, 255, 128);
            buttonCadastraIngre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCadastraIngre.Location = new Point(65, 132);
            buttonCadastraIngre.Name = "buttonCadastraIngre";
            buttonCadastraIngre.Size = new Size(433, 40);
            buttonCadastraIngre.TabIndex = 3;
            buttonCadastraIngre.Text = "Salvar Cadastro";
            buttonCadastraIngre.UseVisualStyleBackColor = false;
            // 
            // formIngredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 184);
            Controls.Add(buttonCadastraIngre);
            Controls.Add(labelTituloIngredi);
            Controls.Add(panel1);
            Name = "formIngredientes";
            Text = "Cadastro de Ingredientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCodigoIngre;
        private Panel panel1;
        private Label labelTituloIngredi;
        private TextBox textBoxDataVali;
        private Label labelDataIngre;
        private TextBox textBoxNomeIngre;
        private Label labelNomeIngre;
        private TextBox textBox1;
        private Button buttonCadastraIngre;
    }
}