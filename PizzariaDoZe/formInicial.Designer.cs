namespace PizzariaDoZe
{
    partial class paginaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paginaInicial));
            botaoFuncionarios = new Button();
            botaoClientes = new Button();
            botaoIngredientes = new Button();
            botaoSabores = new Button();
            labelTitulo = new Label();
            SuspendLayout();
            // 
            // botaoFuncionarios
            // 
            botaoFuncionarios.BackColor = Color.WhiteSmoke;
            botaoFuncionarios.Cursor = Cursors.Hand;
            botaoFuncionarios.FlatStyle = FlatStyle.Flat;
            botaoFuncionarios.Font = new Font("Nexa Heavy", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            botaoFuncionarios.ForeColor = Color.Black;
            botaoFuncionarios.ImageAlign = ContentAlignment.MiddleLeft;
            botaoFuncionarios.Location = new Point(603, 377);
            botaoFuncionarios.Name = "botaoFuncionarios";
            botaoFuncionarios.Size = new Size(699, 99);
            botaoFuncionarios.TabIndex = 1;
            botaoFuncionarios.Text = "Cadastro de Funcinários";
            botaoFuncionarios.UseMnemonic = false;
            botaoFuncionarios.UseVisualStyleBackColor = false;
            botaoFuncionarios.Click += botaoFuncionarios_Click;
            // 
            // botaoClientes
            // 
            botaoClientes.BackColor = Color.WhiteSmoke;
            botaoClientes.Cursor = Cursors.Hand;
            botaoClientes.FlatStyle = FlatStyle.Flat;
            botaoClientes.Font = new Font("Nexa Heavy", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            botaoClientes.ForeColor = Color.Black;
            botaoClientes.Location = new Point(603, 482);
            botaoClientes.Name = "botaoClientes";
            botaoClientes.Size = new Size(699, 99);
            botaoClientes.TabIndex = 2;
            botaoClientes.Text = "Cadastro de Clientes";
            botaoClientes.UseVisualStyleBackColor = false;
            botaoClientes.Click += button2_Click;
            // 
            // botaoIngredientes
            // 
            botaoIngredientes.BackColor = Color.WhiteSmoke;
            botaoIngredientes.Cursor = Cursors.Hand;
            botaoIngredientes.FlatStyle = FlatStyle.Flat;
            botaoIngredientes.Font = new Font("Nexa Heavy", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            botaoIngredientes.ForeColor = Color.Black;
            botaoIngredientes.Location = new Point(603, 587);
            botaoIngredientes.Name = "botaoIngredientes";
            botaoIngredientes.Size = new Size(699, 99);
            botaoIngredientes.TabIndex = 3;
            botaoIngredientes.Text = "Cadastro de Ingredientes";
            botaoIngredientes.UseVisualStyleBackColor = false;
            botaoIngredientes.Click += botaoIngredientes_Click;
            // 
            // botaoSabores
            // 
            botaoSabores.BackColor = Color.WhiteSmoke;
            botaoSabores.Cursor = Cursors.Hand;
            botaoSabores.FlatStyle = FlatStyle.Flat;
            botaoSabores.Font = new Font("Nexa Heavy", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            botaoSabores.ForeColor = Color.Black;
            botaoSabores.Location = new Point(603, 692);
            botaoSabores.Name = "botaoSabores";
            botaoSabores.Size = new Size(699, 99);
            botaoSabores.TabIndex = 4;
            botaoSabores.Text = "Cadastro de Sabores";
            botaoSabores.UseVisualStyleBackColor = false;
            botaoSabores.Click += botaoSabores_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Chickens Lovers", 124F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.Location = new Point(535, 167);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(834, 207);
            labelTitulo.TabIndex = 5;
            labelTitulo.Text = "Pizzaria Do Zé";
            labelTitulo.Click += labelTitulo_Click;
            // 
            // paginaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(labelTitulo);
            Controls.Add(botaoSabores);
            Controls.Add(botaoIngredientes);
            Controls.Add(botaoClientes);
            Controls.Add(botaoFuncionarios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "paginaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizzaria do Zé 0.2";
            TransparencyKey = Color.White;
            Load += paginaInicial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button botaoFuncionarios;
        private Button botaoClientes;
        private Button botaoIngredientes;
        private Button botaoSabores;
        private Label labelTitulo;
    }
}