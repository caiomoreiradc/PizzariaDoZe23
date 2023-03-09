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
    public partial class formFunci : Form
    {
        public formFunci()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botaoEnderecoFunci_Click(object sender, EventArgs e)
        {
            formFunciEndereco funcionarioEndereco = new formFunciEndereco();
            funcionarioEndereco.StartPosition = FormStartPosition.CenterParent;
            funcionarioEndereco.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
