using System;
using System.ComponentModel;

namespace votacao; 

public class program
{
    static int qtdVoto = 0;
    public static void Main()
    {
        string? voto = null;
        int lula = 0;
        int flavio = 0;
        int renan = 0;

        while (voto == null)
        {
            Console.WriteLine("----------------VOTAÇÃO----------------");
            Console.WriteLine("Candidato Lula: 1");
            Console.WriteLine("Candidato Flávio Bolsonaro: 2");
            Console.WriteLine("Candidato Renan Santos: 3");
            Console.WriteLine("Encerrar votação: 0");
            

            voto = Console.ReadLine();

            if (voto == "1")
            {
                qtdVoto++;
                lula++;
                voto = null;
                Console.Clear();
            } else if (voto == "2")
            {
                qtdVoto++;
                flavio++;
                voto = null;
                Console.Clear();
            } else if (voto == "3")
            {
                qtdVoto++;
                renan++;
                voto = null;
                Console.Clear();
            } else if (voto == "0")
            {
                Console.Clear();
                break;
            } else
            {
                Console.WriteLine("Digito inválido");
                voto = null;
            }
        }

        Console.WriteLine("Total de votos: " + qtdVoto);

        Console.WriteLine("\nCandidato Lula: " + lula + " (" +Converter(lula)+"%)");
        Console.WriteLine("Candidato Flávio Bolsonaro: " + flavio + " (" +Converter(flavio)+"%)");
        Console.WriteLine("Candidato Renan Santos: " + renan + " (" +Converter(renan)+"%)");

        Console.Write("\nVencedor: ");

        if (lula > flavio && lula > renan)
        {
            Console.WriteLine("Lula.");
        } else if (lula > flavio && lula == renan)
        {
            Console.WriteLine("Empate entre Lula e Renan Santos");
        } else if (lula > renan && lula == flavio)
        {
            Console.WriteLine("Empate entre Lula e Flávio Bolsonaro");
        } else if (flavio > lula && flavio > renan) 
        {
            Console.WriteLine("Flávio Bolsonaro.");
        } else if (flavio > lula && flavio == renan)
        {
            Console.WriteLine("Empate entre Flávio Bolsonaro e Renan Santos");
        } else if (renan > lula  && renan > flavio)
        {
            Console.WriteLine("Renan Santos.");
        } else if (renan == lula && lula == flavio)
        {
            Console.WriteLine("Empate entre os três");           
        }
    }

    public static double Converter (int a)
    {
        double res;

        if (a != 0)
        {
            res = Convert.ToDouble(a)/Convert.ToDouble(qtdVoto) * 100;
        } else
        {
            res = 0;    
        }
        return res;
    }
}