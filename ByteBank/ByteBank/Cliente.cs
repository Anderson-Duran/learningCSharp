namespace ByteBank.Titular
{
    public class Cliente
    {
        public string nome;
        public string profissao;
        public string cpf;
        public string cnpj;
        public string endereço;
        

        public void ExibirInformação()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Profissão: {profissao}");
            Console.WriteLine($"CPF: {FormatCpf(cpf)}");
            Console.WriteLine($"Endereço: {endereço}");
            Console.WriteLine($"CNPJ: {FormatCnpj(cnpj)}");
        }

        public static string FormatCpf(string cpf)
        {
            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }

        public static string FormatCnpj(string cnpj)
        {
            return Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000-00");
        }
    }
}
