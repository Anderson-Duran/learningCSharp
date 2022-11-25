using ByteBank;
using ByteBank.Titular;

Console.WriteLine("Bem Vindo ao seu banco, ByteBank!\r\n");

//AtividadeContaCorrente contaTeste = new AtividadeContaCorrente();

//Console.WriteLine($"Titular atividade: {contaTeste.titular}");
//Console.WriteLine($"Conta: {contaTeste.conta}");
//Console.WriteLine($"Agência: {contaTeste.agencia}");
//Console.WriteLine($"Saldo: {contaTeste.saldo}");
//Console.WriteLine($"Verify: {contaTeste.verify}");

//Tecla de atalhos Ctrl+K+C comenta e Ctrl+K+U descomenta

////Conta Corrente 1

//ContaCorrente conta1 = new ContaCorrente(); // Uma classe serve para criar um objeto através do modelo criado na classe

//conta1.titular = "Anderson Serafim Duran";
//conta1.conta = "123456-x";
//conta1.numeroAgencia = 1234;
//conta1.nomeAgencia = "Agência Central";
//conta1.saldo = 196.59;

////Conta Corrente 2

//ContaCorrente conta2 = new ContaCorrente();

//conta2.titular = "Leticia Cristina M Duran";
//conta2.conta = "123456-x";
//conta2.numeroAgencia = 1234;
//conta2.nomeAgencia = "Agência Central";
//conta2.saldo = 19600.59;

//Console.WriteLine($"Titular: {conta1.titular}");
//Console.WriteLine($"Conta: {conta1.conta}");
//Console.WriteLine($"Número Agência: {conta1.numeroAgencia}");
//Console.WriteLine($"Nome Agência: {conta1.nomeAgencia}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta1.saldo)}\r\n");

//Console.WriteLine($"Saldo Letícia pré-saque R$ {String.Format("{0:0.00}", conta2.saldo)}");

//bool verificaSaque = conta2.Sacar(56.55);

//if (verificaSaque == true)
//{
//    Console.WriteLine($"Saque realizado com sucesso!");
//}
//else
//{
//    Console.WriteLine($"Houve um problema durante o saque!");
//}

//Console.WriteLine($"Saldo Letícia pós-saque R$ {String.Format("{0:0.00}", conta2.saldo)}");

//conta2.Depositar(25000);

//Console.WriteLine($"Saldo Letícia pós-depósito R$ {String.Format("{0:0.00}", conta2.saldo)}");

//conta2.Transferir(1000, conta1);

//Console.WriteLine($"Saldo Letícia pós-transferência R$ {String.Format("{0:0.00}", conta2.saldo)} e o saldo de Anderson é R$ {String.Format("{0:0.00}", conta1.saldo)}");


//Cliente cliente = new Cliente();

//cliente.nome = "Anderson Serafim Duran";
//cliente.cpf = "34444444455";
//cliente.profissao = "Programador c#";
//cliente.endereço = "Av Manoel Goulart, 680";
//cliente.cnpj = "00115654000155";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1234-x";
//conta.numeroAgencia = 1234;
//conta.saldo = 1566898.55;

//cliente.ExibirInformação();

ContaCorrente conta4 = new ContaCorrente();

conta4.DefinirSaldo(10.56);


Console.WriteLine($"Saldo R$ {conta4.ObterSaldo()}");


Console.ReadKey();
