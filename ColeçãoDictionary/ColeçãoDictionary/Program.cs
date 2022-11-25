Dictionary <int, string> veiculos = new Dictionary<int, string> ();



veiculos.Add(10, "carro");          //ADICIONA A KEY 10 E O VALUE CARRO AO DICIONARIO VEICULOS
veiculos.Add(20, "navio");
veiculos.Add(30, "aviao");
veiculos.Add(2, "Motocicle");


int key = 30;
string valor = "bicicleta";         
veiculos.Remove(key);               //REMOVE A CHAVE KEY
/*veiculos.Clear(); */              //LIMPA O DICIONARIO

veiculos[2] = "bicicleta";


if (veiculos.ContainsKey(30))
{
    Console.WriteLine($"A coleção contem a key {key}");
}
else
{
    Console.WriteLine($"A coleção não contem a key {key}");
}

if (veiculos.ContainsValue(valor))
{
    Console.WriteLine($"Contem o valor {valor}");
}
else
{
    Console.WriteLine($"Não contem o valor {valor}");
}



Console.WriteLine($"O dicionario contem {veiculos.Count} elementos");

//1º FORMA DE IMPRIMIR OS VALORES

foreach (KeyValuePair<int, string> v in veiculos)
{
    Console.WriteLine(v);               //IMPRIME TODOS OS VALORES CONTIDOS NO DICIONARIO, KEY E VALUE
    Console.WriteLine(v.Key);           //IMPRIME OS VALORES DA KEY CONTIDOS NO DICIONARIO
    Console.WriteLine(v.Value);         //IMPRIME OS VALORES DO VALUE CONTIDOS NO DICIONARIO
    Console.WriteLine("=======\n");
}

//2º FORMA DE IMPRIMIR OS VALORES

Dictionary<int, string>.ValueCollection valores = veiculos.Values;

foreach (string v in valores)
{
    Console.WriteLine(v);               //IMPRIMIRÁ APENAS OS VALORES 
}

Dictionary<int, string>.KeyCollection chaves = veiculos.Keys;

foreach (int v in chaves)
{
    Console.WriteLine(v);               //IMPRIMIRA APENAS AS KEYS
}