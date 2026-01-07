using System;

public class Programa1
{
    public static void Main(string[]args)
    {
        Console.WriteLine("ingresa un numero");
        string numero = Console.ReadLine();

        Console.WriteLine($"Encontraré los divisores de {numero}, quieres continuar? Di S o N: ");
        string decision = Console.ReadLine();

        if (decision == "S")
        {
            Console.WriteLine("si");
        }
        else
        {
            Console.WriteLine("nO");
        }
    }
}