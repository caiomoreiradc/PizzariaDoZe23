﻿namespace PizzariaDoZe
{
    partial class FormVisualizarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizarProdutos));
            buttonSair = new Button();
            dataGridViewDados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.Black;
            buttonSair.Cursor = Cursors.Hand;
            buttonSair.Font = new Font("Nexa Heavy", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSair.ForeColor = Color.White;
            buttonSair.Location = new Point(413, 316);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(221, 73);
            buttonSair.TabIndex = 5;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.AllowUserToAddRows = false;
            dataGridViewDados.AllowUserToDeleteRows = false;
            dataGridViewDados.AllowUserToResizeColumns = false;
            dataGridViewDados.AllowUserToResizeRows = false;
            dataGridViewDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Dock = DockStyle.Top;
            dataGridViewDados.Location = new Point(0, 0);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(1051, 299);
            dataGridViewDados.TabIndex = 4;
            dataGridViewDados.CellFormatting += DataGridViewDados_CellFormatting;
            // 
            // FormVisualizarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1051, 397);
            ControlBox = false;
            Controls.Add(buttonSair);
            Controls.Add(dataGridViewDados);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormVisualizarProdutos";
            Text = "Lista de Produtos Cadastrados";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSair;
        private DataGridView dataGridViewDados;
    }
}