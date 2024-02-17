using System;

class MinhaClasse
{
    static void Main(string[] args)
    {
        var tempo = int.Parse(Console.ReadLine());
        var horas = Math.Floor(tempo / 3600);
        tempo = tempo % 3600;
        var minutos = Math.Floor(tempo / 60);
        segundos = tempo % 60;

        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }
}