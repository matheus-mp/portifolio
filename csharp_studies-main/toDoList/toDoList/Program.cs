public class Tarefa
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public bool Status { get; set; }
}

public class ToDoList
{
    public static List<Tarefa> tarefaLista = new List<Tarefa>();
    public static void Main()
    {
        bool v1 = true;
        int escolha;
        while (v1)
        {
            Console.Clear();
            
            Console.WriteLine("1 - Adicionar Tarefa");
            Console.WriteLine("2 - Listar Tarefas");
            Console.WriteLine("3 - Marcar Tarefa como Concluída");
            Console.WriteLine("4 - Remover Tarefa");
            Console.WriteLine("5 - Sair");
            
            escolha = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();
            
            switch (escolha)
            {
                case 1:
                    AdicionarTarefa();
                    break;
                case 2:
                    ListarTarefa();
                    break;
                case 3:
                    MarcarComoConcluida();
                    break;
                case 4:
                    RemoverTarefa();
                    break;
                case 5:
                    v1 = false;
                    
                    Console.WriteLine("Programa Finalizado");
                    
                    break;
            }
        }
    }
    
    public static string LerTexto(string nome)
    {
        do
        {
            Console.WriteLine($"Digite o/a {nome} da tarefa");
            nome = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Dígito inválido");
            }
            
            Console.Clear();
        } while (string.IsNullOrWhiteSpace(nome));

        return nome;
    }

    public static void AdicionarTarefa()
    {
        Console.WriteLine("ADICIONAR TAREFA:\n");

        Tarefa tarefa1 = new Tarefa();
    
        tarefa1.Titulo = LerTexto("título");
        
        tarefa1.Descricao = LerTexto("descrição");

        tarefa1.Status = false;

        tarefa1.Id = AutoIncrement();

        tarefaLista.Add(tarefa1);
    }

    public static void ListarTarefa()
    {
        if(tarefaLista.Count > 0)
        {
            foreach (Tarefa t in tarefaLista) 
            {
                Console.WriteLine($"Título: {t.Titulo}; Descrição: {t.Descricao}; Status: {EmAndamentoOuNao(t.Status)}; ID: {t.Id}");
            }
        }
        else
        {
            Console.WriteLine("Nenhuma tarefa cadastrada!");
        }
        Console.ReadKey();
    }

    public static void MarcarComoConcluida()
    {
        int i = 1;
        int escolha;

        foreach (Tarefa t in tarefaLista)
        {
            Console.WriteLine($"{i} - Título: {t.Titulo}; Descrição: {t.Descricao}; Status: {EmAndamentoOuNao(t.Status)}; ID: {t.Id}");
            i++;
        }
        
        Console.Write("\n Digite a tarefa a ser concluída (digite 0 para cancelar): ");
        escolha = Console.Read();

        tarefaLista[escolha].Status = true;
    }

    public static void RemoverTarefa()
    {
        int i = 1;
        int escolha;

        while (true)
        {
            foreach (Tarefa t in tarefaLista)
            {
                Console.WriteLine(
                    $"{i} - Título: {t.Titulo}; Descrição: {t.Descricao}; Status: {EmAndamentoOuNao(t.Status)}; ID: {t.Id}");
                i++;
            }

            Console.Write("\n Digite a tarefa a ser excluida (digite 0 para cancelar): ");
            escolha = Console.Read();

            if (escolha == 0)
            {
                break;
            } else if (escolha < 0 || !int.TryParse(escolha, out int e))
            {
                
            }
        }
    }
    
    public static int Id = 0;
    
    public static int AutoIncrement()
    {
        Id++;
        return Id;
    }

    public static string EmAndamentoOuNao(bool a)
    {
        if (a == false)
        {
            return "Em Andamento";
        }
        else
        {
            return "Finalizdo";
        }
    }
}

//Objetos em C#