using PizzariaDoZe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class formClientes : Form
    {
        public formClientes()
        {
            InitializeComponent();
            this.ControlBox = false; //REMOVE BOTÕES DE MINIZAR E FECHAR
            userControl.buttonSair.Click += buttonSair_Click;

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo
            //resources
            Funcoes.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser
            //automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
        }
        public void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void formClientes_Load(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void labelTelefone_Click(object sender, EventArgs e)
        {

        }
    }
}
