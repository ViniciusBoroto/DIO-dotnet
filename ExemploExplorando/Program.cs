using System;

class MinhaClasse
{
    static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(), out int timeInSeconds);
        //TODO: Implementar a formula para calcular as horas.
        var hours = (int)timeInSeconds / 3600;
        timeInSeconds = timeInSeconds % (hours * 3600);
        //TODO: Implementar a formula para calcular as horas.
        var minutes = (int)timeInSeconds / 60;
        var seconds = timeInSeconds % 60;

        Console.WriteLine($"{hours}:{minutes}:{seconds}");

    }
}