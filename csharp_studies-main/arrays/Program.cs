using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        //mesma coisa que array associativo
        Dictionary<string, float> pizza = new Dictionary<string, float>();

        pizza.Add("Pizza de Calabresa", 20.00f);
        pizza.Add("Pizza de Quatro Queijos", 30.00f);

        int[] numeros = [1, 2, 3 ,4];

        Console.WriteLine(pizza["Pizza de Calabresa"]);

        foreach (int c in numeros)
        {
            Console.WriteLine(c);
        }

        foreach (KeyValuePair<string, float> item in pizza)
        {
            Console.WriteLine($"Pizza: {item.Key}, Valor: {item.Value:F2}");
        }
    }
}