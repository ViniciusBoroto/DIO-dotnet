using System;

//TODO: Complete os espaços em branco com uma possível solução para o problema.
class Desafio
{
    static void Main()
    {
        Int32.TryParse(Console.ReadLine(), out int limit);
        for (int i = 0; i < limit; i++)
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            if (Y != 0.0)
            {
                double r = X / Y;
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine("divisao imposivel");
            }
        }
    }
}