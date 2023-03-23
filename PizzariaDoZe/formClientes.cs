using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
