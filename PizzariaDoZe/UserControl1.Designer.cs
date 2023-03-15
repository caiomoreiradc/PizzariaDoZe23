namespace PizzariaDoZe
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSalvar = new Button();
            buttonEditar = new Button();
            buttonExcluir = new Button();
            buttonSair = new Button();
            SuspendLayout();
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.Lime;
            buttonSalvar.FlatStyle = FlatStyle.Flat;
            buttonSalvar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalvar.Location = new Point(4, 10);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(169, 113);
            buttonSalvar.TabIndex = 0;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += button1_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.Cyan;
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditar.Location = new Point(179, 10);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(169, 113);
            buttonEditar.TabIndex = 1;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.Red;
            buttonExcluir.FlatStyle = FlatStyle.Flat;
            buttonExcluir.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExcluir.Location = new Point(354, 10);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(169, 113);
            buttonExcluir.TabIndex = 2;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.Black;
            buttonSair.FlatStyle = FlatStyle.Flat;
            buttonSair.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSair.ForeColor = Color.White;
            buttonSair.Location = new Point(529, 10);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(169, 113);
            buttonSair.TabIndex = 3;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = false;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonSair);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(buttonSalvar);
            Name = "UserControl1";
            Size = new Size(702, 132);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSalvar;
        private Button buttonEditar;
        private Button buttonExcluir;
        private Button buttonSair;
    }
}
