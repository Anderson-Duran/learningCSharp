using TransferenciaBancária;

{
    Console.WriteLine("Bem Vindo ao Banco Inter!\r\n");

    //conta 1

    Conta_Corrente cliente1 = new Conta_Corrente();

    cliente1.nome = "Anderson S Duran";
    cliente1.agencia = 1234;
    cliente1.conta = 1505;
    cliente1.saldo = 18697.65;

    Conta_Corrente cliente2 = new Conta_Corrente();

    cliente2.nome = "Leticia Cristina M Duran";
    cliente2.agencia = 123;
    cliente2.conta = 2901;
    cliente2.saldo = 97.65;

    Console.WriteLine($"Saldo atual de {cliente1.nome} é de R$ {String.Format("{0:0.00}", cliente1.saldo)}");
    Console.WriteLine($"Saldo atual de {cliente2.nome} é de R$ {String.Format("{0:0.00}", cliente2.saldo)}\r\n");

    Console.Write("Qual o valor deseja transferir R$ ");
    double valortransferir = double.Parse(Console.ReadLine());

    bool status = cliente1.Tranferencia(valortransferir, cliente2);

    if (status == true)
    {
        string destino = cliente2.nome;
        double destinoSaldo = cliente2.saldo;
        Console.WriteLine($"Valor de R$ {valortransferir} foi tranferido para {cliente2.nome}");
    }
    else
    {
        Console.WriteLine("Digite um valor válido!");
    }


    Console.WriteLine($"Saldo de {cliente1.nome} R$ {String.Format("{0:0.00}", cliente1.saldo)}\r\n");

    cliente1.Informações();
  
    Console.ReadKey();

}


