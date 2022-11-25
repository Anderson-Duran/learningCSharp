namespace TransferenciaBancária
{
    public class Conta_Corrente
    {
        public string nome;
        public int agencia;
        public int conta;
        public double saldo;


        public bool Tranferencia(double valor, Conta_Corrente destino)
        {
            if (valor > 0 && saldo >= valor)
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


        public void Informações()
        {
            Console.WriteLine($"Titular: {nome}");
            Console.WriteLine($"Agência: {agencia}");
            Console.WriteLine($"Conta: {conta}");
            Console.WriteLine($"Saldo R$ {saldo}");
        }
    }
    
}