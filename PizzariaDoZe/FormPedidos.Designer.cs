namespace PizzariaDoZe
{
    partial class FormPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidos));
            userBotoes = new UserControl1();
            panel = new Panel();
            botaoVisualizarCadastros = new Button();
            textBoxIdCliente = new TextBox();
            maskedTelefone = new MaskedTextBox();
            labelIdCliente = new Label();
            maskedCPF = new MaskedTextBox();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            labelTelefone = new Label();
            labelCpf = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
            textBoxIdFuncionario = new TextBox();
            label5 = new Label();
            label8 = new Label();
            cmbStatus = new ComboBox();
            panel1 = new Panel();
            txtIdPedido = new TextBox();
            label3 = new Label();
            cmbPagamento = new ComboBox();
            label1 = new Label();
            txtValorTotal = new TextBox();
            label2 = new Label();
            dataGridViewDados = new DataGridView();
            btnPdfComp = new Button();
            btnPdfSelecionado = new Button();
            panel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // userBotoes
            // 
            userBotoes.BackColor = Color.Transparent;
            userBotoes.Location = new Point(204, 569);
            userBotoes.Name = "userBotoes";
            userBotoes.Size = new Size(479, 91);
            userBotoes.TabIndex = 0;
            // 
            // panel
            // 
            panel.BackColor = Color.Silver;
            panel.Controls.Add(botaoVisualizarCadastros);
            panel.Controls.Add(textBoxIdCliente);
            panel.Controls.Add(maskedTelefone);
            panel.Controls.Add(labelIdCliente);
            panel.Controls.Add(maskedCPF);
            panel.Controls.Add(textBoxEmail);
            panel.Controls.Add(labelEmail);
            panel.Controls.Add(labelTelefone);
            panel.Controls.Add(labelCpf);
            panel.Controls.Add(textBoxNome);
            panel.Controls.Add(labelNome);
            panel.Location = new Point(22, 62);
            panel.Name = "panel";
            panel.Size = new Size(842, 134);
            panel.TabIndex = 1002;
            // 
            // botaoVisualizarCadastros
            // 
            botaoVisualizarCadastros.BackColor = Color.PaleGoldenrod;
            botaoVisualizarCadastros.Cursor = Cursors.Hand;
            botaoVisualizarCadastros.FlatStyle = FlatStyle.Flat;
            botaoVisualizarCadastros.Font = new Font("Nexa Heavy", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            botaoVisualizarCadastros.Location = new Point(594, 70);
            botaoVisualizarCadastros.Name = "botaoVisualizarCadastros";
            botaoVisualizarCadastros.Size = new Size(224, 52);
            botaoVisualizarCadastros.TabIndex = 27;
            botaoVisualizarCadastros.Text = "Visualizar Cadastros";
            botaoVisualizarCadastros.UseVisualStyleBackColor = false;
            botaoVisualizarCadastros.Click += botaoVisualizarCadastros_Click;
            // 
            // textBoxIdCliente
            // 
            textBoxIdCliente.Location = new Point(12, 29);
            textBoxIdCliente.Name = "textBoxIdCliente";
            textBoxIdCliente.Size = new Size(52, 23);
            textBoxIdCliente.TabIndex = 26;
            // 
            // maskedTelefone
            // 
            maskedTelefone.Location = new Point(406, 87);
            maskedTelefone.Mask = "+00 (00)00000-0000";
            maskedTelefone.Name = "maskedTelefone";
            maskedTelefone.Size = new Size(179, 23);
            maskedTelefone.TabIndex = 3;
            // 
            // labelIdCliente
            // 
            labelIdCliente.AutoSize = true;
            labelIdCliente.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelIdCliente.Location = new Point(22, 10);
            labelIdCliente.Name = "labelIdCliente";
            labelIdCliente.Size = new Size(20, 16);
            labelIdCliente.TabIndex = 25;
            labelIdCliente.Text = "ID";
            // 
            // maskedCPF
            // 
            maskedCPF.CutCopyMaskFormat = MaskFormat.IncludePromptAndLiterals;
            maskedCPF.Location = new Point(558, 29);
            maskedCPF.Mask = "000.000.000-00";
            maskedCPF.Name = "maskedCPF";
            maskedCPF.Size = new Size(157, 23);
            maskedCPF.TabIndex = 1;
            maskedCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 87);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(200, 23);
            textBoxEmail.TabIndex = 2;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(12, 69);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(40, 16);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Email";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTelefone.Location = new Point(415, 68);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(56, 16);
            labelTelefone.TabIndex = 6;
            labelTelefone.Text = "Telefone";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCpf.Location = new Point(578, 10);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(31, 16);
            labelCpf.TabIndex = 4;
            labelCpf.Text = "CPF";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(143, 29);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(375, 23);
            textBoxNome.TabIndex = 0;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(159, 10);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(41, 16);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            // 
            // textBoxIdFuncionario
            // 
            textBoxIdFuncionario.Location = new Point(48, 14);
            textBoxIdFuncionario.Name = "textBoxIdFuncionario";
            textBoxIdFuncionario.PlaceholderText = "0";
            textBoxIdFuncionario.Size = new Size(52, 23);
            textBoxIdFuncionario.TabIndex = 29;
            textBoxIdFuncionario.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 17);
            label5.Name = "label5";
            label5.Size = new Size(20, 16);
            label5.TabIndex = 28;
            label5.Text = "ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(126, 17);
            label8.Name = "label8";
            label8.Size = new Size(46, 16);
            label8.TabIndex = 1003;
            label8.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Ativo", "Entregue" });
            cmbStatus.Location = new Point(181, 14);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 1004;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(txtIdPedido);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbPagamento);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtValorTotal);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(22, 202);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 134);
            panel1.TabIndex = 1003;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(775, 12);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.PlaceholderText = "0";
            txtIdPedido.Size = new Size(52, 23);
            txtIdPedido.TabIndex = 1007;
            txtIdPedido.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(749, 15);
            label3.Name = "label3";
            label3.Size = new Size(20, 16);
            label3.TabIndex = 1006;
            label3.Text = "ID";
            // 
            // cmbPagamento
            // 
            cmbPagamento.FormattingEnabled = true;
            cmbPagamento.Items.AddRange(new object[] { "Dinheiro", "PIX", "Cartão" });
            cmbPagamento.Location = new Point(12, 88);
            cmbPagamento.Name = "cmbPagamento";
            cmbPagamento.Size = new Size(121, 23);
            cmbPagamento.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(209, 69);
            label1.Name = "label1";
            label1.Size = new Size(71, 16);
            label1.TabIndex = 9;
            label1.Text = "Valor Total";
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(209, 88);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(167, 23);
            txtValorTotal.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(136, 16);
            label2.TabIndex = 8;
            label2.Text = "Forma de Pagamento";
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.AllowUserToAddRows = false;
            dataGridViewDados.AllowUserToDeleteRows = false;
            dataGridViewDados.AllowUserToResizeRows = false;
            dataGridViewDados.BackgroundColor = SystemColors.InactiveCaption;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewDados.Location = new Point(22, 351);
            dataGridViewDados.MultiSelect = false;
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDados.Size = new Size(842, 190);
            dataGridViewDados.TabIndex = 1005;
            dataGridViewDados.MouseDoubleClick += dataGridViewDados_MouseDoubleClick;
            // 
            // btnPdfComp
            // 
            btnPdfComp.Cursor = Cursors.Hand;
            btnPdfComp.FlatStyle = FlatStyle.Flat;
            btnPdfComp.Location = new Point(781, 578);
            btnPdfComp.Name = "btnPdfComp";
            btnPdfComp.Size = new Size(83, 41);
            btnPdfComp.TabIndex = 1006;
            btnPdfComp.Text = "PDF Completo";
            btnPdfComp.UseVisualStyleBackColor = true;
            btnPdfComp.Click += btnPdfComp_Click;
            // 
            // btnPdfSelecionado
            // 
            btnPdfSelecionado.Cursor = Cursors.Hand;
            btnPdfSelecionado.FlatStyle = FlatStyle.Flat;
            btnPdfSelecionado.Location = new Point(781, 625);
            btnPdfSelecionado.Name = "btnPdfSelecionado";
            btnPdfSelecionado.Size = new Size(83, 41);
            btnPdfSelecionado.TabIndex = 1007;
            btnPdfSelecionado.Text = "PDF Selecionado";
            btnPdfSelecionado.UseVisualStyleBackColor = true;
            btnPdfSelecionado.Click += btnPdfSelecionado_Click;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(886, 672);
            Controls.Add(btnPdfSelecionado);
            Controls.Add(btnPdfComp);
            Controls.Add(dataGridViewDados);
            Controls.Add(panel1);
            Controls.Add(cmbStatus);
            Controls.Add(label8);
            Controls.Add(textBoxIdFuncionario);
            Controls.Add(label5);
            Controls.Add(panel);
            Controls.Add(userBotoes);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPedidos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Pedidos";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControl1 userBotoes;
        private Panel panel;
        private Button botaoVisualizarCadastros;
        private TextBox textBoxIdCliente;
        private MaskedTextBox maskedTelefone;
        private Label labelIdCliente;
        private MaskedTextBox maskedCPF;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Label labelTelefone;
        private Label labelCpf;
        private TextBox textBoxNome;
        private Label labelNome;
        private TextBox textBoxIdFuncionario;
        private Label label5;
        private Label label8;
        private ComboBox cmbStatus;
        private Panel panel1;
        private TextBox txtValorTotal;
        private Label label2;
        private ComboBox cmbPagamento;
        private Label label1;
        private DataGridView dataGridViewDados;
        private TextBox txtIdPedido;
        private Label label3;
        private Button btnPdfComp;
        private Button btnPdfSelecionado;
    }
}