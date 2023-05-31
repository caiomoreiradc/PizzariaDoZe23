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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paginaInicial));
            botaoFuncionarios = new Button();
            botaoClientes = new Button();
            botaoIngredientes = new Button();
            botaoSabores = new Button();
            labelTitulo = new Label();
            botaoValores = new Button();
            botaoProdutos = new Button();
            botaoConfig = new Button();
            contextMenuStrip = new ContextMenuStrip(components);
            cadastroDeFuncionáriosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeClientesToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeSaboresToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeValoresToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeIngredientesToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            notifyIconSystemTray = new NotifyIcon(components);
            contextMenuStripSystemTray = new ContextMenuStrip(components);
            abrirAplicaçãoToolStripMenuItem = new ToolStripMenuItem();
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip.SuspendLayout();
            contextMenuStripSystemTray.SuspendLayout();
            SuspendLayout();
            // 
            // botaoFuncionarios
            // 
            botaoFuncionarios.BackColor = Color.WhiteSmoke;
            botaoFuncionarios.Cursor = Cursors.Hand;
            botaoFuncionarios.FlatStyle = FlatStyle.Flat;
            botaoFuncionarios.Font = new Font("Microsoft Sans Serif", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            botaoFuncionarios.ForeColor = Color.Black;
            botaoFuncionarios.ImageAlign = ContentAlignment.MiddleLeft;
            botaoFuncionarios.Location = new Point(250, 454);
            botaoFuncionarios.Name = "botaoFuncionarios";
            botaoFuncionarios.Size = new Size(699, 99);
            botaoFuncionarios.TabIndex = 0;
            botaoFuncionarios.Text = "Cadastro de Funcionários";
            botaoFuncionarios.UseMnemonic = false;
            botaoFuncionarios.UseVisualStyleBackColor = false;
            botaoFuncionarios.Click += botaoFuncionarios_Click;
            // 
            // botaoClientes
            // 
            botaoClientes.BackColor = Color.WhiteSmoke;
            botaoClientes.Cursor = Cursors.Hand;
            botaoClientes.FlatStyle = FlatStyle.Flat;
            botaoClientes.Font = new Font("Microsoft Sans Serif", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            botaoClientes.ForeColor = Color.Black;
            botaoClientes.Location = new Point(250, 559);
            botaoClientes.Name = "botaoClientes";
            botaoClientes.Size = new Size(699, 99);
            botaoClientes.TabIndex = 2;
            botaoClientes.Text = "Cadastro de Clientes";
            botaoClientes.UseVisualStyleBackColor = false;
            botaoClientes.Click += botaoClientes_Click;
            // 
            // botaoIngredientes
            // 
            botaoIngredientes.BackColor = Color.WhiteSmoke;
            botaoIngredientes.Cursor = Cursors.Hand;
            botaoIngredientes.FlatStyle = FlatStyle.Flat;
            botaoIngredientes.Font = new Font("Microsoft Sans Serif", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            botaoIngredientes.ForeColor = Color.Black;
            botaoIngredientes.Location = new Point(250, 664);
            botaoIngredientes.Name = "botaoIngredientes";
            botaoIngredientes.Size = new Size(699, 99);
            botaoIngredientes.TabIndex = 4;
            botaoIngredientes.Text = "Cadastro de Ingredientes";
            botaoIngredientes.UseVisualStyleBackColor = false;
            botaoIngredientes.Click += botaoIngredientes_Click;
            // 
            // botaoSabores
            // 
            botaoSabores.BackColor = Color.WhiteSmoke;
            botaoSabores.Cursor = Cursors.Hand;
            botaoSabores.FlatStyle = FlatStyle.Flat;
            botaoSabores.Font = new Font("Microsoft Sans Serif", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            botaoSabores.ForeColor = Color.Black;
            botaoSabores.Location = new Point(955, 454);
            botaoSabores.Name = "botaoSabores";
            botaoSabores.Size = new Size(699, 99);
            botaoSabores.TabIndex = 1;
            botaoSabores.Text = "Cadastro de Sabores";
            botaoSabores.UseVisualStyleBackColor = false;
            botaoSabores.Click += botaoSabores_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Chickens Lovers", 148F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.Location = new Point(453, 204);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(998, 247);
            labelTitulo.TabIndex = 5;
            labelTitulo.Text = "Pizzaria Do Zé";
            labelTitulo.Click += labelTitulo_Click;
            // 
            // botaoValores
            // 
            botaoValores.BackColor = Color.WhiteSmoke;
            botaoValores.Cursor = Cursors.Hand;
            botaoValores.FlatStyle = FlatStyle.Flat;
            botaoValores.Font = new Font("Microsoft Sans Serif", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            botaoValores.ForeColor = Color.Black;
            botaoValores.Location = new Point(955, 559);
            botaoValores.Name = "botaoValores";
            botaoValores.Size = new Size(699, 99);
            botaoValores.TabIndex = 3;
            botaoValores.Text = "Cadastro de Valores";
            botaoValores.UseVisualStyleBackColor = false;
            botaoValores.Click += botaoValores_Click;
            // 
            // botaoProdutos
            // 
            botaoProdutos.BackColor = Color.WhiteSmoke;
            botaoProdutos.Cursor = Cursors.Hand;
            botaoProdutos.FlatStyle = FlatStyle.Flat;
            botaoProdutos.Font = new Font("Microsoft Sans Serif", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            botaoProdutos.ForeColor = Color.Black;
            botaoProdutos.Location = new Point(955, 664);
            botaoProdutos.Name = "botaoProdutos";
            botaoProdutos.Size = new Size(699, 99);
            botaoProdutos.TabIndex = 5;
            botaoProdutos.Text = "Cadastro de Produtos";
            botaoProdutos.UseVisualStyleBackColor = false;
            botaoProdutos.Click += botaoProdutos_Click;
            // 
            // botaoConfig
            // 
            botaoConfig.BackColor = Color.WhiteSmoke;
            botaoConfig.Cursor = Cursors.Hand;
            botaoConfig.FlatStyle = FlatStyle.Flat;
            botaoConfig.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            botaoConfig.Location = new Point(836, 881);
            botaoConfig.Name = "botaoConfig";
            botaoConfig.Size = new Size(233, 97);
            botaoConfig.TabIndex = 6;
            botaoConfig.Text = "CONFIGURAÇÕES";
            botaoConfig.UseVisualStyleBackColor = false;
            botaoConfig.Click += botaoConfigurações_Click;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { cadastroDeFuncionáriosToolStripMenuItem, cadastroDeClientesToolStripMenuItem, cadastroDeSaboresToolStripMenuItem, cadastroDeProdutosToolStripMenuItem, cadastroDeValoresToolStripMenuItem, cadastroDeIngredientesToolStripMenuItem, configuraçõesToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip2";
            contextMenuStrip.Size = new Size(260, 158);
            contextMenuStrip.Text = "Opções";
            contextMenuStrip.Opening += contextMenuStrip_Opening;
            // 
            // cadastroDeFuncionáriosToolStripMenuItem
            // 
            cadastroDeFuncionáriosToolStripMenuItem.Name = "cadastroDeFuncionáriosToolStripMenuItem";
            cadastroDeFuncionáriosToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F1;
            cadastroDeFuncionáriosToolStripMenuItem.Size = new Size(259, 22);
            cadastroDeFuncionáriosToolStripMenuItem.Text = "Cadastro de Funcionários";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            cadastroDeClientesToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F2;
            cadastroDeClientesToolStripMenuItem.Size = new Size(259, 22);
            cadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes";
            // 
            // cadastroDeSaboresToolStripMenuItem
            // 
            cadastroDeSaboresToolStripMenuItem.Name = "cadastroDeSaboresToolStripMenuItem";
            cadastroDeSaboresToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F3;
            cadastroDeSaboresToolStripMenuItem.Size = new Size(259, 22);
            cadastroDeSaboresToolStripMenuItem.Text = "Cadastro de Sabores";
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            cadastroDeProdutosToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F4;
            cadastroDeProdutosToolStripMenuItem.Size = new Size(259, 22);
            cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos";
            // 
            // cadastroDeValoresToolStripMenuItem
            // 
            cadastroDeValoresToolStripMenuItem.Name = "cadastroDeValoresToolStripMenuItem";
            cadastroDeValoresToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F5;
            cadastroDeValoresToolStripMenuItem.Size = new Size(259, 22);
            cadastroDeValoresToolStripMenuItem.Text = "Cadastro de Valores";
            // 
            // cadastroDeIngredientesToolStripMenuItem
            // 
            cadastroDeIngredientesToolStripMenuItem.Name = "cadastroDeIngredientesToolStripMenuItem";
            cadastroDeIngredientesToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F6;
            cadastroDeIngredientesToolStripMenuItem.Size = new Size(259, 22);
            cadastroDeIngredientesToolStripMenuItem.Text = "Cadastro de Ingredientes";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F7;
            configuraçõesToolStripMenuItem.Size = new Size(259, 22);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // notifyIconSystemTray
            // 
            notifyIconSystemTray.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconSystemTray.BalloonTipText = "Aplicação continua rodando na bandeja.";
            notifyIconSystemTray.BalloonTipTitle = "Pizzaria do Zé";
            notifyIconSystemTray.ContextMenuStrip = contextMenuStripSystemTray;
            notifyIconSystemTray.Icon = (Icon)resources.GetObject("notifyIconSystemTray.Icon");
            notifyIconSystemTray.Text = "Pizzaria do Zé";
            notifyIconSystemTray.MouseDoubleClick += NotifyIconSystemTray_MouseDoubleClick;
            // 
            // contextMenuStripSystemTray
            // 
            contextMenuStripSystemTray.Items.AddRange(new ToolStripItem[] { abrirAplicaçãoToolStripMenuItem, encerrarToolStripMenuItem, sobreToolStripMenuItem });
            contextMenuStripSystemTray.Name = "contextMenuStripSystemTray";
            contextMenuStripSystemTray.Size = new Size(156, 70);
            contextMenuStripSystemTray.Opening += contextMenuStripSystemTray_Opening;
            // 
            // abrirAplicaçãoToolStripMenuItem
            // 
            abrirAplicaçãoToolStripMenuItem.Name = "abrirAplicaçãoToolStripMenuItem";
            abrirAplicaçãoToolStripMenuItem.Size = new Size(155, 22);
            abrirAplicaçãoToolStripMenuItem.Text = "Abrir Aplicação";
            // 
            // encerrarToolStripMenuItem
            // 
            encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            encerrarToolStripMenuItem.Size = new Size(155, 22);
            encerrarToolStripMenuItem.Text = "Encerrar";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(155, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // paginaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            ContextMenuStrip = contextMenuStrip;
            Controls.Add(botaoConfig);
            Controls.Add(botaoProdutos);
            Controls.Add(botaoValores);
            Controls.Add(botaoSabores);
            Controls.Add(botaoIngredientes);
            Controls.Add(botaoClientes);
            Controls.Add(botaoFuncionarios);
            Controls.Add(labelTitulo);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "paginaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizzaria do Zé 0.4";
            TransparencyKey = Color.White;
            FormClosing += paginaInicial_FormClosing;
            Load += paginaInicial_Load;
            Resize += formInicial_Resize;
            contextMenuStrip.ResumeLayout(false);
            contextMenuStripSystemTray.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button botaoFuncionarios;
        private Button botaoClientes;
        private Button botaoIngredientes;
        private Button botaoSabores;
        private Label labelTitulo;
        private Button botaoValores;
        private Button botaoProdutos;
        private Button botaoConfig;
        private ContextMenuStrip contextMenuStripSystemTray;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem cadastroDeFuncionáriosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private ToolStripMenuItem cadastroDeSaboresToolStripMenuItem;
        private ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeValoresToolStripMenuItem;
        private ToolStripMenuItem cadastroDeIngredientesToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private NotifyIcon notifyIconSystemTray;
        private ToolStripMenuItem abrirAplicaçãoToolStripMenuItem;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}