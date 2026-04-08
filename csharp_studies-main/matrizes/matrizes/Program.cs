public class Program
{
    public static void Main()
    {
        int[,] matriz = new int[5, 4]; //altura e largura (linhas e colunas)

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = j;
            }
        }

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"[{matriz[i, j]}]");
            }
            Console.WriteLine();
        }
    }
}