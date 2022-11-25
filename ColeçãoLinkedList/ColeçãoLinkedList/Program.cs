
//CRIAR UMA LISTA DO TIPO LINKEDLIST

LinkedList<string> transport = new LinkedList<string> ();

//ADICIONAR ELEMENTOS A LISTA

transport.AddFirst("Carro");
transport.AddFirst("Navio");
transport.AddFirst("Avião");
transport.AddFirst("Moto");

transport.AddLast("Bicicleta");


//ADICIONAR ELEMENTO EM UMA POSIÇÃO ESPECÍFICA


LinkedListNode<string> nó;          //DEVE-SE CRIAR UMA VAR DO TIPO LINKEDLISTNODE PARA INDICAR A REFERENCIA PARA SE USAR ADDAFTER/ADDBEFORE

nó = transport.FindLast("Navio");

transport.AddAfter(nó, "Tanque");
transport.AddBefore(nó, "Patins");


foreach (string t in transport)
{
    Console.WriteLine($"Transporte: {t}");
}


//LOCALIZAR ELEMENTO NA LISTA

if (transport.Find("Avião") == null)
{
    Console.WriteLine("O elemento não está na lista");
}
else
{ 
    Console.WriteLine("O elementos foi encontrado na lista");
}

//REMOVER UM ELEMENTO DA LISTA

transport.Remove("Patins");

for (int i = 0; i < transport.Count; i++)
{
    Console.WriteLine(transport.ElementAt(i));      //RETORNA O ELEMENTO NA LISTA
}

//SELECIONAR PROXIMO OU ATERIOR AO NÓ

nó = transport.FindLast("Navio").Next;

transport.AddAfter(nó, "Sai Carro");

Console.WriteLine("------");
foreach (string t in transport)
{
    Console.WriteLine(t);
}

//LIMPAR LISTA

transport.Clear();