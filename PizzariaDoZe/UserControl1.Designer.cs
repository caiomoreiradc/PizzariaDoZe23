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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            buttonSalvar = new Button();
            buttonEditar = new Button();
            buttonExcluir = new Button();
            buttonSair = new Button();
            SuspendLayout();
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.Lime;
            buttonSalvar.Cursor = Cursors.Hand;
            buttonSalvar.FlatStyle = FlatStyle.Flat;
            buttonSalvar.Font = new Font("Nexa Heavy", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.Image = (Image)resources.GetObject("buttonSalvar.Image");
            buttonSalvar.Location = new Point(4, 10);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(113, 73);
            buttonSalvar.TabIndex = 0;
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.Cyan;
            buttonEditar.Cursor = Cursors.Hand;
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Font = new Font("Nexa Heavy", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditar.Image = (Image)resources.GetObject("buttonEditar.Image");
            buttonEditar.Location = new Point(122, 10);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(113, 73);
            buttonEditar.TabIndex = 1;
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.Red;
            buttonExcluir.Cursor = Cursors.Hand;
            buttonExcluir.FlatStyle = FlatStyle.Flat;
            buttonExcluir.Font = new Font("Nexa Heavy", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExcluir.Image = (Image)resources.GetObject("buttonExcluir.Image");
            buttonExcluir.Location = new Point(241, 10);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(113, 73);
            buttonExcluir.TabIndex = 2;
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.Black;
            buttonSair.Cursor = Cursors.Hand;
            buttonSair.FlatStyle = FlatStyle.Flat;
            buttonSair.Font = new Font("Nexa Heavy", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSair.ForeColor = Color.Ivory;
            buttonSair.Image = (Image)resources.GetObject("buttonSair.Image");
            buttonSair.Location = new Point(359, 10);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(113, 73);
            buttonSair.TabIndex = 3;
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
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
            Size = new Size(479, 91);
            ResumeLayout(false);
        }

        #endregion
        public Button buttonEditar;
        public Button buttonExcluir;
        public Button buttonSair;
        public Button buttonSalvar;
    }
}
