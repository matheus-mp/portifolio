public class Program
{
    public static void Main()
    {
        int[] vetor1 = new int[5]; 
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2, 5]{{ 11, 22, 33, 44, 55}, {66, 77, 88, 99, 00}};
        
        Random random = new Random(); //Cria um array com valores aleatorios
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = random.Next(50); //Define um valor de 0 a 49 para o vetor1
        }
        
        Console.WriteLine("Elementos do vetor 1:");
        foreach (var item in vetor1)
        {
            Console.WriteLine(item);
        }
        
        //BinarySearch(array, valor)
        
    }
}