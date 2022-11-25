using SupermercadoMenorPreco;

Console.WriteLine("Bem vindo ao Supermercado Menor Preço!\r\n");

Cadastro dados1 = new Cadastro();
Produtos produt = new Produtos();

dados1.nome = "Anderson Duran";
dados1.fabricante = "ASUS";
Console.Write("Insira o código de barras: ");
dados1.codigoDeBarras = int.Parse(Console.ReadLine());
dados1.valorUnitario = 1.99;
dados1.valorDeCompra = 98.56;
produt.produto = "Banana";
produt.quantProduto = 156;



Console.WriteLine($"Nome: {dados1.nome}");
Console.WriteLine($"Fabricante: {dados1.fabricante}");
Console.WriteLine($"Código de Barras: {dados1.codigoDeBarras}");
Console.WriteLine($"Valor do produto {produt.produto}: {dados1.valorUnitario}");
Console.ReadKey();
    




