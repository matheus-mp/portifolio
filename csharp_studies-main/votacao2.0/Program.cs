using System.Text;

namespace votacao2; 
public class Program
{
    public static void Main()
    {
        //Inicia um novo dicionário de candidatos, com tipos de valor string
        Dictionary<string, string> candidatos = new Dictionary<string, string>();
        //Inicia um novo dicionário dos candidatos e a quantidade de votos
        Dictionary<string, int> votos = new Dictionary<string, int>();

        string inputVoto;
        string erro = "Dígito inválido";
        int qtdVoto = 0;

        //Repetição para a leitura dos candidatos
        while (true)
        {
            //Variável para validar um break
            bool encerrar = false;

            Console.WriteLine("----------------VOTAÇÃO----------------");
            
            string candidato;
            string inputNum;
            
            //repetição da leitura do nome do candidato para caso de dígitos inválidos
            while (true)
            {
                Console.Write("Insira um candidato (digite qualquer número para encerrar): ");
                candidato = Console.ReadLine().ToUpper();
                
                //Foreach para ler cada caracter do nome
                foreach (char c in candidato)
                {
                    if (char.IsNumber(c)) //Se tiver qualquer número o break é chamado e para o laço principal
                    {
                        encerrar = true;
                        break;
                    }
                }

                //Verifica se o nome já existe no dicionário; senão ele para o laço dos nomes
                if (candidatos.ContainsValue(candidato) || string.IsNullOrWhiteSpace(candidato))
                {
                    Console.WriteLine(erro);
                }
                else
                {
                    break;
                }
            }
            
            //Se tiver recebido um número ele para o laço
            if (encerrar)
            {
                break;
            }
            
            //Repetição da leitura do número para casos de erros
            while (true)
            {
                Console.Write("Digite o número de voto (máximo de 2 digitos): ");
                inputNum = Console.ReadLine();
                
                //Se não conseguir converter a string para um número ou for mais de dois dígitos ou já tiver no dicionário ele retorna erro
                if (!int.TryParse(inputNum, out int num) || inputNum.Length > 2 || candidatos.ContainsKey(inputNum) || string.IsNullOrWhiteSpace(inputNum) || num <= 0)
                {
                    Console.WriteLine(erro);
                }
                else //Senão ele para este laço
                {
                    break;
                }

            }
            
            //Se não tiver parado o laço ele adiciona uma nova linha ao dicionário
            candidatos.Add(inputNum, candidato);

            Console.Clear();
        }

        //Adiciona os candidatos no dicionário de votos
        foreach (var candidato in candidatos)
        {
            votos.Add(candidato.Key, 0);
        }

        while (true) //repetição para a votação
        {
            Console.WriteLine("----------------VOTAÇÃO----------------");

            if (candidatos.Count > 0) //verifica se tem candidatos
            {
                foreach (var candidato in candidatos) //mostra os candidatos
                {
                    Console.WriteLine($"Candidato {candidato.Value}: {candidato.Key}");
                }

                Console.WriteLine("Digite 0 para encerrar \n");
                Console.Write("Insira o seu voto: ");

                inputVoto = Console.ReadLine();

                if (inputVoto == "0") //Se receber 0 para a votação
                {
                    break;   
                }
                
                if (!candidatos.ContainsKey(inputVoto) || string.IsNullOrWhiteSpace(inputVoto)) //Se o numero inserido nao estiver no dicionario de candidatos ou o input estiver em branco ele retorna erro
                {
                    Console.WriteLine(erro);
                    Console.ReadKey();
                }
                else //senao ele adiciona 1 a quantidade de votos e ao valor do item de votos onde a chave é igual ao input
                {
                    qtdVoto += 1;
                    votos[inputVoto] += 1;
                }
            } else
            {
                Console.WriteLine("Nenhum candidato cadastrado!");
                break;
            }

            Console.Clear();
        }

        var ordenado = votos.OrderByDescending(x => x.Value); //recebe o dicionario de votos de forma ordenada do maior ao menor

        foreach (var voto in ordenado) //exibe os candidatos, a quantidade de votos e a porcentagem de cada um;
        {
            Console.WriteLine($"Candidato: {candidatos[voto.Key]} - {voto.Value} votos ({Converter(voto.Value, qtdVoto)}%)");
        }

        var empate = votos.Where(x => x.Value == ordenado.First().Value); //verifica se possui valores iguais

        if (empate.Count() > 1) //caso tenha ele retorna empate
        {
            Console.Write("Houve empate entre: ");
            foreach (var e in empate)
            {
                Console.Write($"{candidatos[e.Key]}, ");
            }
        }
        else //senao ele retorna o nome do candidato que tem o mesmo numero de votos do ganhador
        {
            Console.Write($"Vencedor: {candidatos[ordenado.First().Key]}");
        }
    } 

    public static double Converter (int a, int b)
    {
        double res;
        double votos = a;
        if (a != 0)
        {
            res = votos/b * 100;
        } else
        {
            res = 0;    
        }
        return res;
    }
}