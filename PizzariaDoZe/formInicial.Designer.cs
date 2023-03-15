﻿namespace PizzariaDoZe
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
            Titulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Titulo.Location = new Point(23, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(352, 65);
            Titulo.TabIndex = 0;
            Titulo.Text = "Pizzaria D     Zé";
            Titulo.Click += Titulo_Click;
            // 
            // botaoFuncionarios
            // 
            botaoFuncionarios.BackColor = SystemColors.ScrollBar;
            botaoFuncionarios.Cursor = Cursors.Hand;
            botaoFuncionarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            botaoFuncionarios.Location = new Point(12, 77);
            botaoFuncionarios.Name = "botaoFuncionarios";
            botaoFuncionarios.Size = new Size(363, 44);
            botaoFuncionarios.TabIndex = 1;
            botaoFuncionarios.Text = "Cadastro de Funcinários";
            botaoFuncionarios.UseMnemonic = false;
            botaoFuncionarios.UseVisualStyleBackColor = false;
            botaoFuncionarios.Click += botaoFuncionarios_Click;
            // 
            // botaoClientes
            // 
            botaoClientes.BackColor = SystemColors.ScrollBar;
            botaoClientes.Cursor = Cursors.Hand;
            botaoClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            botaoClientes.Location = new Point(12, 127);
            botaoClientes.Name = "botaoClientes";
            botaoClientes.Size = new Size(363, 44);
            botaoClientes.TabIndex = 2;
            botaoClientes.Text = "Cadastro de Clientes";
            botaoClientes.UseVisualStyleBackColor = false;
            botaoClientes.Click += button2_Click;
            // 
            // botaoIngredientes
            // 
            botaoIngredientes.BackColor = SystemColors.ScrollBar;
            botaoIngredientes.Cursor = Cursors.Hand;
            botaoIngredientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            botaoIngredientes.Location = new Point(12, 177);
            botaoIngredientes.Name = "botaoIngredientes";
            botaoIngredientes.Size = new Size(363, 44);
            botaoIngredientes.TabIndex = 3;
            botaoIngredientes.Text = "Cadastro de Ingredientes";
            botaoIngredientes.UseVisualStyleBackColor = false;
            botaoIngredientes.Click += botaoIngredientes_Click;
            // 
            // botaoSabores
            // 
            botaoSabores.BackColor = SystemColors.ScrollBar;
            botaoSabores.Cursor = Cursors.Hand;
            botaoSabores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            botaoSabores.Location = new Point(12, 227);
            botaoSabores.Name = "botaoSabores";
            botaoSabores.Size = new Size(363, 44);
            botaoSabores.TabIndex = 4;
            botaoSabores.Text = "Cadastro de Sabores";
            botaoSabores.UseVisualStyleBackColor = false;
            botaoSabores.Click += botaoSabores_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(240, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 56);
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
            ClientSize = new Size(387, 284);
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