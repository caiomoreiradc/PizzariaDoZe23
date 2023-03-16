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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formIngredientes));
            labelCodigoIngre = new Label();
            panel1 = new Panel();
            textBoxDataVali = new TextBox();
            labelDataIngre = new Label();
            textBoxNomeIngre = new TextBox();
            labelNomeIngre = new Label();
            textBox1 = new TextBox();
            userControl11 = new UserControl1();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelCodigoIngre
            // 
            labelCodigoIngre.AutoSize = true;
            labelCodigoIngre.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodigoIngre.Location = new Point(16, 13);
            labelCodigoIngre.Name = "labelCodigoIngre";
            labelCodigoIngre.Size = new Size(47, 16);
            labelCodigoIngre.TabIndex = 0;
            labelCodigoIngre.Text = "Código";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LemonChiffon;
            panel1.Controls.Add(textBoxDataVali);
            panel1.Controls.Add(labelDataIngre);
            panel1.Controls.Add(textBoxNomeIngre);
            panel1.Controls.Add(labelNomeIngre);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(labelCodigoIngre);
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 87);
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
            labelDataIngre.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDataIngre.Location = new Point(377, 13);
            labelDataIngre.Name = "labelDataIngre";
            labelDataIngre.Size = new Size(111, 16);
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
            labelNomeIngre.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomeIngre.Location = new Point(137, 13);
            labelNomeIngre.Name = "labelNomeIngre";
            labelNomeIngre.Size = new Size(41, 16);
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
            // userControl11
            // 
            userControl11.BackColor = Color.Transparent;
            userControl11.Location = new Point(41, 103);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(488, 93);
            userControl11.TabIndex = 3;
            userControl11.Load += userControl11_Load;
            // 
            // formIngredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(570, 196);
            Controls.Add(userControl11);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "formIngredientes";
            Text = "Cadastro de Ingredientes";
            Load += formIngredientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelCodigoIngre;
        private Panel panel1;
        private TextBox textBoxDataVali;
        private Label labelDataIngre;
        private TextBox textBoxNomeIngre;
        private Label labelNomeIngre;
        private TextBox textBox1;
        private UserControl1 userControl11;
    }
}