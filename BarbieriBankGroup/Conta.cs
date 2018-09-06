namespace BarbieriBankGroup
{
    public class Conta
    {
        public int CodigoConta { get; private set; }
        public string TitularConta { get; private set; }
        public double SaldoConta { get; private set; }

        public void Cadastrar(int codigoConta, string titularConta)
        {
            this.CodigoConta = codigoConta;
            this.TitularConta = TitularConta;
        }

    }

    
}