public class Aluno
{
    public int notas, frequencia;

    public void InserirNotas(int nota, int freq)
    {
        notas = nota;
        frequencia = freq;
    }

    

}

class program
{
    static void Main()
    {
        int nota;
        int freq;
        bool

        Aluno aluno = new Aluno();

        aluno.InserirNotas(9, 2);

        Console.WriteLine($"Nota = {aluno.notas} e faltas = {aluno.frequencia}");
    }
    
    
    
}