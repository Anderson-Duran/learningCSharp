using Cadastro;

Console.WriteLine("Consultório não interessa!\r\n");

CadastroPessoa paciente1 = new CadastroPessoa();

paciente1.nome = "Graudiosvar da Silva";
paciente1.idade = 85;
paciente1.altura = 1.68;
paciente1.peso = 78;

Console.WriteLine($"Nome do paciênte: {paciente1.nome}");
Console.WriteLine($"Idade do paciênte: {paciente1.idade} anos");
Console.WriteLine($"Altura: {String.Format("{0:0.00}", paciente1.altura)}");
Console.WriteLine($"Peso do paciênte: {String.Format("{0:0.00}", paciente1.peso)} KG");

Console.ReadKey();


