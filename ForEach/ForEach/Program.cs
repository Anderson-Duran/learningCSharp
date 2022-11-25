using System;

class Aula22
{
    static void Main()
    {
        int[] num = new int[3] { 11, 22, 33 };

        //for (int i = 0; i < num.Length; i++)
        //{
        //    Console.WriteLine(num[i]);
        //}

        foreach (int i in num)
        {
            Console.WriteLine(i);
        }
    }
}