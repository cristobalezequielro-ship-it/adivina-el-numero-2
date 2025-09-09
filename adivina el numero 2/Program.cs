using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Adivinaremos tu número entre el 1 y el 100");
        Console.WriteLine("Para empezar escribe 'Listo'");
        string respuesta = Console.ReadLine();
        if (respuesta.ToLower() != "listo")
        {
            Console.WriteLine("Por favor, escribe 'Listo' para comenzar.");
            return;
        }
        bool adivinado = false;
        int intentos = 0;
        int min = 1;
        int max = 100;
        while (!adivinado)
        {
            int intento = min + (max - min) / 2;
            if (min > max)
            {
                Console.WriteLine("¡Ups! Parece que hiciste trampa. No puedo adivinar tu número.");
                break;
            }
            intentos++;
            Console.WriteLine($"¿Tu número es {intento}? (responde: si, mayor, menor)");
            respuesta = Console.ReadLine().ToLower();
            if (respuesta == "si")
            {
                adivinado = true;
                Console.WriteLine($"¡Genial! He adivinado tu número en {intentos} intentos.");
            }
            else if (respuesta == "mayor")
            {
                min = intento + 1;
            }
            else if (respuesta == "menor")
            {
                max = intento - 1;
            }
            else
            {
                Console.WriteLine("Respuesta no válida. Por favor, usa 'si', 'mayor' o 'menor'.");
                intentos--;
            }
        }
    }
}