//using FastFood;

//Console.WriteLine("Fast Food\n");

//Produto alface = new Produto();
////alface.valorUnitário = 1.99;
//alface.codigoProduto = 1;
//alface.quantidade = 2;

//Produto hamburguer = new Produto();
////hamburguer.valorUnitário = 5.65;
//hamburguer.codigoProduto = 2;
//hamburguer.quantidade = 2;

//Produto pao = new Produto();
////pao.valorUnitário = 2.55;
//pao.codigoProduto = 3;
//pao.quantidade = 1;

//Endereco enderecoAnderson = new Endereco();
//enderecoAnderson.rua = "Donato Armelin";
//enderecoAnderson.cep = "19013-810";
//enderecoAnderson.cidade = "Presidente Prudente";
//enderecoAnderson.numero = 306;

//Cliente cliente = new Cliente();
//cliente.nome = "Anderson Serafim Duran";
//cliente.email = "andersonduran@hotmail.com";
//cliente.telefone = "99607-8444";
//cliente.cpf = "35445896555";
//cliente.endereco = enderecoAnderson;

//ItemPedido itemPedido = new ItemPedido();
//itemPedido.produto1 = alface;
//itemPedido.produto2 = hamburguer;
//itemPedido.produto3 = pao;

//double valor1 = 5.96;
//double valor2 = 6.3;
//int valor3 = 58;

//Console.WriteLine($"A variável valor em currency = {valor1:c}\nA variável valor2 em percentage = {valor2:p}\nA variável valor3 com espaçamento 5= {valor3,5}");


class aula
{
    static void Main()
    {
    inicio:

        Console.Clear();

        int c = 0;
        double[] nota = new double[5];

        for (int i = 1; i < 6; i++)
        {
            Console.Write($"Digite a {i}º nota: ");
            nota[c] = double.Parse(Console.ReadLine());
            c++;
        }

            
        


        int media = (int)(nota[0] + nota[1] + nota[2] + nota[3] + nota[4]) / 5;

        switch (media)
        {
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
                Console.WriteLine($"Sua média foi {media}\nVocê foi aprovado!");
                break;
            case 5:
            case 4:
            case 3:
            case 2:
            case 1:
            case 0:
                Console.WriteLine($"Sua média foi {media}\nVocê foi reprovado!");
                break;
        }

        char escolha = '0';

        Console.Write("Deseja Continuar? [s/n] ");
        escolha = Convert.ToChar(Console.ReadLine());

        if (escolha == 's' | escolha == 'S')
        {
            goto inicio;
        }
        else
        {
            Console.WriteLine("Fim do programa!");
        }
    }
}

   