List<string> nomeDaLista = new List<string>();
List<string> carros = new List<string>();

// METODO ADD ADICIONA UM ELEMENTO A LISTA

carros.Add("verona");
carros.Add("ferrari");
carros.Add("fusca");
carros.Add("opala");
carros.Add("ferrari");

// METODO INSERT INSERE EM UMA POSICAO ESPECIFICA UM ELEMENTO

carros.Insert(1, "cruser");

// REMOVE AT REMOVE O ELEMENTO DA POSICAO PASSADA

carros.RemoveAt(0);


// METODO REMOVE REMOVE UM ELEMENTO ESPECIFICO

if (carros.Remove("cruser"))
{
    Console.WriteLine("cruser foi removido");
}



// METODO LAST INDEX OF RETORNA UTLIMA POSICAO DO ELEMENTO PASSADO

int posFerr = carros.LastIndexOf("ferrari");


// METODO ADDRANGE OS ELEMENTOS DE UMA LISTA A OUTRA

nomeDaLista.AddRange(carros);

// METODO CONTAIN VERIFICA SE HA UM ELEMENTO CONTIDO NA LISTA

if (nomeDaLista.Contains("ferrari"))
{
    Console.WriteLine("O nome esta na lista");
}
else
{
    Console.WriteLine("O nome nao esta na lista");
}

// METODO COPYTO COPIA PARA UM ARRAY ELEMENTOS DE UMA LISTA A PARTIR DO INDICE PASSADO

string[] carros1=new string[nomeDaLista.Count];
nomeDaLista.CopyTo(0,carros1,0,2);

foreach (string s in carros1)
{
    Console.WriteLine(s);
}
// METODO REVERSE REVERTE E SORT ORDENA

carros.Reverse();
carros.Sort();

// METODO CAPACITY DETERMINAR CAPACIDADE DA LISTA

carros.Capacity = 20;

// METODO COUNT RETORNA O TAMANHO

int tamanho = carros.Count;

// METODO CAPACIDADE

int capacidade = carros.Capacity;



//METODO INDEX OF RETORNA POSICAO DO ELEMENTO

string car = "ferrari";
int pos = nomeDaLista.IndexOf(car);
Console.WriteLine($"O carro ferrari esta na posicao {pos}");
Console.WriteLine($"A ultima posicao da ferrari e {posFerr}");
Console.WriteLine($"O tamanho da lista carros: {tamanho}");
Console.WriteLine($"A capacidade da lista {capacidade}");

foreach (string carro in carros)
{
    Console.WriteLine(carro);
}



// METODO CLEAR

nomeDaLista.Clear();

inicio:

char resp = 'S';

while (resp == 'S')
{
    try
    {
        Console.Write("Digite um modelo de carro: ");
        nomeDaLista.Add(Console.ReadLine());

        resposta:

        while (resp != 'S' || resp != 'N')
        {
            try
            {
                Console.Write($"Deseja continuar?[S/N]: ");
                resp = Convert.ToChar(Console.ReadLine().ToUpper()[0]);
                if (resp == 'S')
                {
                    goto inicio;
                }
                else if (resp == 'N')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Respota invalida!");
                    goto resposta;
                }
            }
            catch
            {
                Console.WriteLine("O valor digitado e invalido!");
                goto resposta;
            }
            
        }
     
        
    }   
    catch (ArgumentException erro)
    {
        Console.WriteLine($"Erro: {erro.Message}");
        
    }
}

foreach (string i in nomeDaLista)
{
    Console.WriteLine("Modelo: " + i);
}