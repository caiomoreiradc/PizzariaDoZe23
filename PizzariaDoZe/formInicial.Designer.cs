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
            Titulo = new Label();
            botaoFuncionarios = new Button();
            botaoClientes = new Button();
            botaoIngredientes = new Button();
            botaoSabores = new Button();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Titulo.Location = new Point(30, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(328, 65);
            Titulo.TabIndex = 0;
            Titulo.Text = "Pizzaria Do Zé";
            // 
            // botaoFuncionarios
            // 
            botaoFuncionarios.Location = new Point(12, 77);
            botaoFuncionarios.Name = "botaoFuncionarios";
            botaoFuncionarios.Size = new Size(363, 44);
            botaoFuncionarios.TabIndex = 1;
            botaoFuncionarios.Text = "Cadastro de Funcinários";
            botaoFuncionarios.UseMnemonic = false;
            botaoFuncionarios.UseVisualStyleBackColor = true;
            botaoFuncionarios.Click += botaoFuncionarios_Click;
            // 
            // botaoClientes
            // 
            botaoClientes.Location = new Point(12, 127);
            botaoClientes.Name = "botaoClientes";
            botaoClientes.Size = new Size(363, 44);
            botaoClientes.TabIndex = 2;
            botaoClientes.Text = "Cadastro de Clientes";
            botaoClientes.UseVisualStyleBackColor = true;
            botaoClientes.Click += button2_Click;
            // 
            // botaoIngredientes
            // 
            botaoIngredientes.Location = new Point(12, 177);
            botaoIngredientes.Name = "botaoIngredientes";
            botaoIngredientes.Size = new Size(363, 44);
            botaoIngredientes.TabIndex = 3;
            botaoIngredientes.Text = "Cadastro de Ingredientes";
            botaoIngredientes.UseVisualStyleBackColor = true;
            botaoIngredientes.Click += botaoIngredientes_Click;
            // 
            // botaoSabores
            // 
            botaoSabores.Location = new Point(12, 227);
            botaoSabores.Name = "botaoSabores";
            botaoSabores.Size = new Size(363, 44);
            botaoSabores.TabIndex = 4;
            botaoSabores.Text = "Cadastro de Sabores";
            botaoSabores.UseVisualStyleBackColor = true;
            botaoSabores.Click += botaoSabores_Click;
            // 
            // paginaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 293);
            Controls.Add(botaoSabores);
            Controls.Add(botaoIngredientes);
            Controls.Add(botaoClientes);
            Controls.Add(botaoFuncionarios);
            Controls.Add(Titulo);
            Name = "paginaInicial";
            Text = "Inicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Button botaoFuncionarios;
        private Button botaoClientes;
        private Button botaoIngredientes;
        private Button botaoSabores;
    }
}