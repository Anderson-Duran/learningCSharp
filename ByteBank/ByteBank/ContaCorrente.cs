using ByteBank.Titular;

namespace ByteBank
{
    public class ContaCorrente // CLASSES SÃO MODELOS PARA CRIAR OBJETOS
    {
        public Cliente titular;
        public string conta;
        public int numeroAgencia;
        public string nomeAgencia;
        private double saldo;

        public bool Sacar(double valor)
        {
            if (saldo >= valor && valor > 0)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Depositar(double valor) //Método sem retorno é do tipo void
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo > valor && valor > 0)
            {
                saldo -= valor;
                destino.saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DefinirSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
                saldo += valor;
           
        }
        public double ObterSaldo()
        {
            return saldo;
        }
    }
}