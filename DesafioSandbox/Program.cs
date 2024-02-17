using System;

class MinhaClasse
{
    static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(), out int timeInSeconds);
        // int timeInSeconds = 556;
        //TODO: Implementar a formula para calcular as horas.
        var hours = (int)Math.Floor(timeInSeconds / 3600.00);
        timeInSeconds = timeInSeconds % 3600;
        //TODO: Implementar a formula para calcular os minutos.
        var minutes = (int)Math.Floor(timeInSeconds / 60.00);
        var seconds = timeInSeconds % 60;

        Console.WriteLine($"{hours}:{minutes}:{seconds}");

    }
}