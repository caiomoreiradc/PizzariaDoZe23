namespace PizzariaDoZe
{
    partial class FormVisualizarIngredientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizarIngredientes));
            dataGridViewIng = new DataGridView();
            buttonSair = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIng).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewIng
            // 
            dataGridViewIng.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIng.Location = new Point(12, 12);
            dataGridViewIng.Name = "dataGridViewIng";
            dataGridViewIng.RowTemplate.Height = 25;
            dataGridViewIng.Size = new Size(508, 344);
            dataGridViewIng.TabIndex = 0;
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.Black;
            buttonSair.Cursor = Cursors.Hand;
            buttonSair.Font = new Font("Nexa Heavy", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSair.ForeColor = Color.White;
            buttonSair.Location = new Point(210, 362);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(113, 73);
            buttonSair.TabIndex = 1;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // FormVisualizarIngredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wallpaper;
            ClientSize = new Size(532, 446);
            Controls.Add(buttonSair);
            Controls.Add(dataGridViewIng);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "FormVisualizarIngredientes";
            Text = "Visualizar Ingredientes";
            Load += FormVisualizarIngredientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewIng).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewIng;
        private Button buttonSair;
    }
}