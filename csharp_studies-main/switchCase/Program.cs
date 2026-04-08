using System;

public class Program
{
    public static void Main()
    {  
        //Console.WriteLine("Digite um número");
        //int number = Convert.ToInt32(Console.ReadLine());
        
        //switch (number)
        //{
        //    case 1: //recebe true ou false, mesma coisa que if
        //        Console.WriteLine("O número é 1");
        //        break;
        //    
        //    case 2:
        //        Console.WriteLine("O número é 2");
        //        break;
        //}   
        
        Console.WriteLine("====Dias da Semana====");
        Console.WriteLine("Digite um número de 1 a 7:");

        string input = Console.ReadLine();

        var name = "jorge";
        
        if (int.TryParse(input, out int day)) //entra a variável input do tipo string e retorna uma variavel day do tipo int se no input vier uma string
        {
            switch (day)
            {
                case 1:
                    Console.WriteLine("Segunda");
                    break;
                case 2:
                    Console.WriteLine("Terça");
                    break;
                case 3:
                    Console.WriteLine("Quarta");
                    break;
                case 4:
                    Console.WriteLine("Quinta");
                    break;
                case 5:
                    Console.WriteLine("Sexta");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Dia inválido");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida");
        }
        
        //Console.WriteLine("====Desempenho Escolar====");
        //Console.Write("Digite a sua nota: ");
        //double score = Convert.ToDouble(Console.ReadLine());
//
        //switch (score)
        //{
        //    case 10d:
        //    case 9d:
        //        Console.WriteLine("Ótimo");
        //        break;
        //    case 8d:
        //    case 7d:
        //        Console.WriteLine("Bom");
        //        break;
        //    case 6d:
        //        Console.WriteLine("OK");
        //        break;
        //   default:
        //       Console.WriteLine("Horrível");
        //       break;
        //}
    }
}