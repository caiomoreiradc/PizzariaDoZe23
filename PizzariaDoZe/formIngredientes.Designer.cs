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
            labelCodigo = new Label();
            panel = new Panel();
            textBoxValidade = new TextBox();
            labelValidade = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
            textBoxCodigo = new TextBox();
            userControl = new UserControl1();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodigo.Location = new Point(18, 16);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(47, 16);
            labelCodigo.TabIndex = 0;
            labelCodigo.Text = "Código";
            // 
            // panel
            // 
            panel.BackColor = Color.Silver;
            panel.Controls.Add(textBoxValidade);
            panel.Controls.Add(labelValidade);
            panel.Controls.Add(textBoxNome);
            panel.Controls.Add(labelNome);
            panel.Controls.Add(textBoxCodigo);
            panel.Controls.Add(labelCodigo);
            panel.Location = new Point(11, 13);
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.Name = "panel";
            panel.Size = new Size(629, 110);
            panel.TabIndex = 1;
            panel.Paint += panel_Paint;
            // 
            // textBoxValidade
            // 
            textBoxValidade.Location = new Point(421, 39);
            textBoxValidade.Margin = new Padding(3, 4, 3, 4);
            textBoxValidade.Name = "textBoxValidade";
            textBoxValidade.Size = new Size(175, 26);
            textBoxValidade.TabIndex = 5;
            // 
            // labelValidade
            // 
            labelValidade.AutoSize = true;
            labelValidade.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValidade.Location = new Point(431, 16);
            labelValidade.Name = "labelValidade";
            labelValidade.Size = new Size(111, 16);
            labelValidade.TabIndex = 4;
            labelValidade.Text = "Data de Validade";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(157, 39);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(237, 26);
            textBoxNome.TabIndex = 3;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(157, 16);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(41, 16);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(18, 39);
            textBoxCodigo.Margin = new Padding(3, 4, 3, 4);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(90, 26);
            textBoxCodigo.TabIndex = 1;
            // 
            // userControl
            // 
            userControl.BackColor = Color.Transparent;
            userControl.Location = new Point(50, 114);
            userControl.Margin = new Padding(3, 5, 3, 5);
            userControl.Name = "userControl";
            userControl.Size = new Size(558, 118);
            userControl.TabIndex = 3;
            userControl.Load += userControl11_Load;
            // 
            // formIngredientes
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(651, 233);
            Controls.Add(panel);
            Controls.Add(userControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "formIngredientes";
            Text = "Cadastro de Ingredientes";
            Load += formIngredientes_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelCodigo;
        private Panel panel;
        private TextBox textBoxValidade;
        private Label labelValidade;
        private TextBox textBoxNome;
        private Label labelNome;
        private TextBox textBoxCodigo;
        private UserControl1 userControl;
    }
}