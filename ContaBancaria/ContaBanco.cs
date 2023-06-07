using System.Globalization;

namespace ContaBancaria
{
    public class ContaBanco
    {
        public int NumeroDaConta { get; private set; }
        public string TitularDaConta { get; set; }
        public double Saldo { get; private set; }


        public ContaBanco(int numero, string titular)
        {
            NumeroDaConta = numero;
            TitularDaConta = titular;
        }

        public ContaBanco(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public override string ToString()
        {
            return "Conta " + NumeroDaConta + ", Titular: " + TitularDaConta + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}