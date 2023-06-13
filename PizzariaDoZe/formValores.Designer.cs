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
            maskedTextValor = new MaskedTextBox();
            listBoxCategoria = new ListBox();
            listBoxTamanho = new ListBox();
            textBoxId = new TextBox();
            labelid = new Label();
            textBoxValorBorda = new TextBox();
            labelCategoria = new Label();
            labelValorBorda = new Label();
            labelValor = new Label();
            labelTamanho = new Label();
            botaoVisualizarCadastros = new Button();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // userControl
            // 
            userControl.BackColor = Color.Transparent;
            userControl.Location = new Point(28, 210);
            userControl.Margin = new Padding(3, 4, 3, 4);
            userControl.Name = "userControl";
            userControl.Size = new Size(479, 91);
            userControl.TabIndex = 0;
            userControl.Load += userControl11_Load;
            // 
            // panel
            // 
            panel.BackColor = Color.Silver;
            panel.Controls.Add(botaoVisualizarCadastros);
            panel.Controls.Add(maskedTextValor);
            panel.Controls.Add(listBoxCategoria);
            panel.Controls.Add(listBoxTamanho);
            panel.Controls.Add(textBoxId);
            panel.Controls.Add(labelid);
            panel.Controls.Add(textBoxValorBorda);
            panel.Controls.Add(labelCategoria);
            panel.Controls.Add(labelValorBorda);
            panel.Controls.Add(labelValor);
            panel.Controls.Add(labelTamanho);
            panel.Location = new Point(21, 17);
            panel.Margin = new Padding(3, 2, 3, 2);
            panel.Name = "panel";
            panel.Size = new Size(492, 197);
            panel.TabIndex = 1;
            // 
            // maskedTextValor
            // 
            maskedTextValor.Location = new Point(11, 73);
            maskedTextValor.Name = "maskedTextValor";
            maskedTextValor.Size = new Size(89, 23);
            maskedTextValor.TabIndex = 11;
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.ItemHeight = 15;
            listBoxCategoria.Location = new Point(309, 26);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(120, 94);
            listBoxCategoria.TabIndex = 10;
            // 
            // listBoxTamanho
            // 
            listBoxTamanho.FormattingEnabled = true;
            listBoxTamanho.ItemHeight = 15;
            listBoxTamanho.Location = new Point(161, 26);
            listBoxTamanho.Name = "listBoxTamanho";
            listBoxTamanho.Size = new Size(120, 94);
            listBoxTamanho.TabIndex = 9;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(12, 25);
            textBoxId.Margin = new Padding(3, 2, 3, 2);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(39, 23);
            textBoxId.TabIndex = 8;
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelid.Location = new Point(12, 7);
            labelid.Name = "labelid";
            labelid.Size = new Size(20, 16);
            labelid.TabIndex = 7;
            labelid.Text = "ID";
            // 
            // textBoxValorBorda
            // 
            textBoxValorBorda.Location = new Point(12, 117);
            textBoxValorBorda.Margin = new Padding(3, 2, 3, 2);
            textBoxValorBorda.Name = "textBoxValorBorda";
            textBoxValorBorda.Size = new Size(88, 23);
            textBoxValorBorda.TabIndex = 4;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategoria.Location = new Point(331, 7);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(66, 16);
            labelCategoria.TabIndex = 6;
            labelCategoria.Text = "Categoria";
            // 
            // labelValorBorda
            // 
            labelValorBorda.AutoSize = true;
            labelValorBorda.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValorBorda.Location = new Point(12, 99);
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
            labelValor.Location = new Point(12, 50);
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
            // botaoVisualizarCadastros
            // 
            botaoVisualizarCadastros.BackColor = Color.PaleGoldenrod;
            botaoVisualizarCadastros.Cursor = Cursors.Hand;
            botaoVisualizarCadastros.FlatStyle = FlatStyle.Flat;
            botaoVisualizarCadastros.Font = new Font("Nexa Heavy", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            botaoVisualizarCadastros.Location = new Point(173, 134);
            botaoVisualizarCadastros.Name = "botaoVisualizarCadastros";
            botaoVisualizarCadastros.Size = new Size(249, 52);
            botaoVisualizarCadastros.TabIndex = 19;
            botaoVisualizarCadastros.Text = "Visualizar Cadastros";
            botaoVisualizarCadastros.UseVisualStyleBackColor = false;
            botaoVisualizarCadastros.Click += botaoVisualizarCadastros_Click;
            // 
            // formValores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(534, 310);
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
        private Label labelCategoria;
        private Label labelValorBorda;
        private Label labelValor;
        private ListBox listBoxCategoria;
        private ListBox listBoxTamanho;
        private TextBox textBoxId;
        private Label labelid;
        private MaskedTextBox maskedTextValor;
        private Button botaoVisualizarCadastros;
    }
}