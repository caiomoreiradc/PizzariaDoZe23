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
            Titulo = new Label();
            botaoFuncionarios = new Button();
            botaoClientes = new Button();
            botaoIngredientes = new Button();
            botaoSabores = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            Titulo.Location = new Point(336, 104);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(699, 128);
            Titulo.TabIndex = 0;
            Titulo.Text = "Pizzaria D     Zé";
            Titulo.Click += Titulo_Click;
            // 
            // botaoFuncionarios
            // 
            botaoFuncionarios.BackColor = SystemColors.ActiveCaption;
            botaoFuncionarios.Cursor = Cursors.Hand;
            botaoFuncionarios.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            botaoFuncionarios.ForeColor = Color.Black;
            botaoFuncionarios.Location = new Point(336, 231);
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
            botaoClientes.BackColor = SystemColors.ActiveCaption;
            botaoClientes.Cursor = Cursors.Hand;
            botaoClientes.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            botaoClientes.ForeColor = Color.Black;
            botaoClientes.Location = new Point(336, 336);
            botaoClientes.Name = "botaoClientes";
            botaoClientes.Size = new Size(699, 99);
            botaoClientes.TabIndex = 2;
            botaoClientes.Text = "Cadastro de Clientes";
            botaoClientes.UseVisualStyleBackColor = false;
            botaoClientes.Click += button2_Click;
            // 
            // botaoIngredientes
            // 
            botaoIngredientes.BackColor = SystemColors.ActiveCaption;
            botaoIngredientes.Cursor = Cursors.Hand;
            botaoIngredientes.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            botaoIngredientes.ForeColor = Color.Black;
            botaoIngredientes.Location = new Point(336, 441);
            botaoIngredientes.Name = "botaoIngredientes";
            botaoIngredientes.Size = new Size(699, 99);
            botaoIngredientes.TabIndex = 3;
            botaoIngredientes.Text = "Cadastro de Ingredientes";
            botaoIngredientes.UseVisualStyleBackColor = false;
            botaoIngredientes.Click += botaoIngredientes_Click;
            // 
            // botaoSabores
            // 
            botaoSabores.BackColor = SystemColors.ActiveCaption;
            botaoSabores.Cursor = Cursors.Hand;
            botaoSabores.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            botaoSabores.ForeColor = Color.Black;
            botaoSabores.Location = new Point(336, 546);
            botaoSabores.Name = "botaoSabores";
            botaoSabores.Size = new Size(699, 99);
            botaoSabores.TabIndex = 4;
            botaoSabores.Text = "Cadastro de Sabores";
            botaoSabores.UseVisualStyleBackColor = false;
            botaoSabores.Click += botaoSabores_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(777, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // paginaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 749);
            Controls.Add(pictureBox1);
            Controls.Add(botaoSabores);
            Controls.Add(botaoIngredientes);
            Controls.Add(botaoClientes);
            Controls.Add(botaoFuncionarios);
            Controls.Add(Titulo);
            Name = "paginaInicial";
            Text = "Pizzaria do Zé 0.1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        //TESTE
        private Label Titulo;
        private Button botaoFuncionarios;
        private Button botaoClientes;
        private Button botaoIngredientes;
        private Button botaoSabores;
        private PictureBox pictureBox1;
    }
}