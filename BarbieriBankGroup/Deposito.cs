using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbieriBankGroup
{
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }

        public void AdicionaIndice(int indice)
        {
            comboIndice.Items.Add(Convert.ToString(indice));

            //adicionando valor no comboIndice para teste
            //não está funcionando meu indice =/
            comboIndice.Items.Add(100);
        }

        private void botaoDepositar_Click(object sender, EventArgs e)
        {

        }

        public void comboIndice_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboIndice.SelectedIndex;
        
        }
    }
}
