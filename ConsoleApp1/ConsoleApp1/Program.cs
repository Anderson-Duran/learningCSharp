using System;
class Program
{
    public class Jogador
    {
        public int energy;
        public int age;
        public string name;

        public Jogador(int idade, string nome)
        {
            energy = 100;
            age = idade;
            name = nome;
        }
    }
    public void Main()
    {
        Console.WriteLine("Digite o nome: ");
        string nome = Console.ReadLine();
        
        Console.WriteLine("Digite a idade: ");
        int idade = Convert.ToInt16(Console.ReadLine());

        Jogador jogador = new Jogador(idade, nome);
        Jogador jogador1 = new Jogador(idade, nome);
    }

    
}