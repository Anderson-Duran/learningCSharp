class Jogador
{
    private string name;            //DECLARAÇÃO DAS VAR ACESSO PRIVATE
    private int energy = 100;

    public Jogador(string name)     //CRIAÇÃO DO CONSTRUTOR
    {
        this.name = name;
    }

    public string getName()         //CRIAÇÃO DE MÉTODO DE ACESSO/RETORNO GETNAME
    {
        return name;
    }

    public int getEnergy()          //CRIAÇÃO DE MÉTODO DE ACESSO/RETORNO GETENERGY
    {
        return energy;
    }

    public void setEnergy(int e)    //CRIAÇÃO DO MÉTODO DE ACESSO E REDEFINIÇÃO DE VALORES
    {
        if (e < 0)
        {
            if (energy + e < 0)
            {
               energy = 0;
            }
            else
            {
                energy += e;
            }
        }
        else if (e > 0)
        {
            if (energy + e > 100)
            {
                energy = 100;
            }
            else
            {
                energy += e;
            }
        }
    }

    public void setName(string n)   //CRIAÇÃO DE MÉTODO SEM RETORNO
    {
        name = n;
    }

}

class Program                       //CLASSE PRINCIPAL
{
    static void Main()
    {
           
        Jogador jogador = new Jogador("Anderson"); //CRIAÇÃO DO OBEJTO jogador DA CLASSE JOGADOR

        jogador.setEnergy(-68);                    //ACRESCENTA O VALOR -68 À VAR ENERGY
        jogador.setEnergy(-68);
        jogador.setEnergy(8);
        jogador.setEnergy(68);


        Console.WriteLine($"{jogador.getName()} a energia de seu jogador é: {jogador.getEnergy()}%");
    }
}