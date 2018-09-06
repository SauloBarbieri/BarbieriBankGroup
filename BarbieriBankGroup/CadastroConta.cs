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
    public partial class CadastroConta : Form
    {
        Form1 formPrincipal = new Form1();
        Deposito formDeposito = new Deposito();

        //início de trecho de código que eu não entendo;
        //private Form1 formPrincipal;

        //public CadastroConta(Form1 formPrincipal)
        //{
        //    this.formPrincipal = formPrincipal;
        //    InitializeComponent();
        //}
        //final de trecho de código que eu não entendo;

        Conta[] contasCorrentes = new ContaCorrente[2];
        int arrayContas = 0;

        public CadastroConta()
        {
            InitializeComponent();
           
        }        

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            

            if (arrayContas < contasCorrentes.Length)
            {


                contasCorrentes[arrayContas] = new ContaCorrente();

                contasCorrentes[arrayContas].Cadastrar(Convert.ToInt32(textoCodigoConta.Text), (textoTitularConta.Text));

                textoCodigoConta.Clear();
                textoTitularConta.Clear();

                this.formDeposito.AdicionaIndice(arrayContas);

                arrayContas++;

                MessageBox.Show("Cadastro Realizado Com Sucesso!");

            }
            else
            {
                MessageBox.Show("Não é possível cadastrar mais contas!");
            }

        }


        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            Hide();
            //Form1 formPrincipal = new Form1();
            formPrincipal.ShowDialog();            
        }

      
    }
}
