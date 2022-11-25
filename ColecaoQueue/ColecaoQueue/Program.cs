
// PODE-SE INICIALIZAR UMA FILA QUEUE DIRETAMENTE PASSANDO O PARAMETRO NA INSTANCIACAO

string[] cars = { "Carro", "Moto", "Barco", "Aviao" };

Queue<string> queue = new Queue<string>(cars);

Console.WriteLine($"Tamanho da fila: {queue.Count}");

// ADICIONAR A PARTIR DA CRIACAO

Queue<string> queue2 = new Queue<string>(cars);

queue2.Enqueue("Moto");
queue2.Enqueue("Carro");
queue2.Enqueue("Aviao");
queue2.Enqueue("Navio");
queue2.Enqueue("Bicicleta");

Console.WriteLine("Tamanho da fila: {0}",queue2.Count);

// VERIFICAR SE ESTA CONTIDO

string procurar = "Aviao";

if (queue2.Contains(procurar))
{
    Console.WriteLine($"O veiculo {procurar} esta na fila");
}
else
{
    Console.WriteLine($"O veiculo {procurar} nao esta na fila");
}

// LIMPAR COM CLEAR()

// RETORNAR O PRIMEIRO ELEMENTO E EXCLUILO COM DEQUEUE
Console.WriteLine("==========");
Console.WriteLine($"Primeiro veiculo : {queue2.Peek()}");           //PEEK RETORNA O PRIMEIRO ELEMENTO SEM EXCLUI-LO
Console.WriteLine("Primeiro veiculo "+queue2.Dequeue());            //DEQUEUE RETORNA E EXCLUI O PRIMEIRO ELEMENTO DA FILA
Console.WriteLine("Primeiro veiculo " + queue2.Dequeue());
Console.WriteLine("Tamanho da fila: {0}", queue2.Count);


// IMPRIMINDO REMOVENDO OS ELEMENTOS DA FILA

Console.WriteLine("Removendo...");
while (queue2.Count > 0)
{
    Console.WriteLine(queue2.Dequeue());
}
Console.WriteLine("Tamnho fila: " + queue2.Count);