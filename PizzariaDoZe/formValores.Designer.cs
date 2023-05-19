namespace PizzariaDoZe
{
    partial class formValores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formValores));
            userControl = new UserControl1();
            panel = new Panel();
            textBoxValorBorda = new TextBox();
            textBoxValor = new TextBox();
            comboBoxCategoria = new ComboBox();
            labelCategoria = new Label();
            comboBoxTamanho = new ComboBox();
            labelValorBorda = new Label();
            labelValor = new Label();
            labelTamanho = new Label();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // userControl
            // 
            userControl.BackColor = Color.Transparent;
            userControl.Location = new Point(24, 163);
            userControl.Margin = new Padding(3, 4, 3, 4);
            userControl.Name = "userControl";
            userControl.Size = new Size(479, 91);
            userControl.TabIndex = 0;
            userControl.Load += userControl11_Load;
            // 
            // panel
            // 
            panel.BackColor = Color.Silver;
            panel.Controls.Add(textBoxValorBorda);
            panel.Controls.Add(textBoxValor);
            panel.Controls.Add(comboBoxCategoria);
            panel.Controls.Add(labelCategoria);
            panel.Controls.Add(comboBoxTamanho);
            panel.Controls.Add(labelValorBorda);
            panel.Controls.Add(labelValor);
            panel.Controls.Add(labelTamanho);
            panel.Location = new Point(21, 17);
            panel.Margin = new Padding(3, 2, 3, 2);
            panel.Name = "panel";
            panel.Size = new Size(492, 148);
            panel.TabIndex = 1;
            // 
            // textBoxValorBorda
            // 
            textBoxValorBorda.Location = new Point(12, 79);
            textBoxValorBorda.Margin = new Padding(3, 2, 3, 2);
            textBoxValorBorda.Name = "textBoxValorBorda";
            textBoxValorBorda.Size = new Size(88, 23);
            textBoxValorBorda.TabIndex = 4;
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(12, 23);
            textBoxValor.Margin = new Padding(3, 2, 3, 2);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(88, 23);
            textBoxValor.TabIndex = 3;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Items.AddRange(new object[] { "T - TRADICIONAL", "E - ESPECIAL" });
            comboBoxCategoria.Location = new Point(325, 22);
            comboBoxCategoria.Margin = new Padding(3, 2, 3, 2);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(127, 24);
            comboBoxCategoria.TabIndex = 2;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategoria.Location = new Point(325, 7);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(66, 16);
            labelCategoria.TabIndex = 6;
            labelCategoria.Text = "Categoria";
            // 
            // comboBoxTamanho
            // 
            comboBoxTamanho.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxTamanho.FormattingEnabled = true;
            comboBoxTamanho.Items.AddRange(new object[] { "P - PEQUENA", "M - MÉDIA", "G - GRANDE", "F - FAMÍLIA" });
            comboBoxTamanho.Location = new Point(163, 22);
            comboBoxTamanho.Margin = new Padding(3, 2, 3, 2);
            comboBoxTamanho.Name = "comboBoxTamanho";
            comboBoxTamanho.Size = new Size(134, 24);
            comboBoxTamanho.TabIndex = 1;
            // 
            // labelValorBorda
            // 
            labelValorBorda.AutoSize = true;
            labelValorBorda.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValorBorda.Location = new Point(12, 61);
            labelValorBorda.Name = "labelValorBorda";
            labelValorBorda.Size = new Size(99, 16);
            labelValorBorda.TabIndex = 4;
            labelValorBorda.Text = "Valor da Borda";
            labelValorBorda.Click += labelValorBorda_Click;
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValor.Location = new Point(20, 8);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(39, 16);
            labelValor.TabIndex = 3;
            labelValor.Text = "Valor";
            // 
            // labelTamanho
            // 
            labelTamanho.AutoSize = true;
            labelTamanho.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTamanho.Location = new Point(173, 7);
            labelTamanho.Name = "labelTamanho";
            labelTamanho.Size = new Size(61, 16);
            labelTamanho.TabIndex = 2;
            labelTamanho.Text = "Tamanho";
            // 
            // formValores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(534, 262);
            Controls.Add(panel);
            Controls.Add(userControl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "formValores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Valores";
            Load += formValores_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private UserControl1 userControl;
        private Panel panel;
        private Label labelTamanho;
        private TextBox textBoxValorBorda;
        private TextBox textBoxValor;
        private ComboBox comboBoxCategoria;
        private Label labelCategoria;
        private ComboBox comboBoxTamanho;
        private Label labelValorBorda;
        private Label labelValor;
    }
}