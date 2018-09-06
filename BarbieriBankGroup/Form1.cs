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
    public partial class Form1 : Form
    {

        //Conta[] contasCorrentes = new ContaCorrente[5];

        Deposito formDeposito = new Deposito();

        public Form1()
        {
            InitializeComponent();
        }

        private void botaoCadastroConta_Click(object sender, EventArgs e)
        {
            CadastroConta formCadastroConta = new CadastroConta();
            formCadastroConta.ShowDialog();
            
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            formDeposito.ShowDialog();
        }
    }
}
