using System.Threading.Tasks;

namespace CS_TP1.Aula7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gerenciador de Tarefas
            //-Adicionar tarefa
            //-Listar tarefas
            //-Remover tarefa
            var gerenciador = new GerenciadorDeTarefas();

            while (true)
            {
                Console.WriteLine("Gerenciador de Tarefas");
                Console.WriteLine("1 - Adicionar tarefa");
                Console.WriteLine("2 - Listar tarefas");
                Console.WriteLine("3 - Remover tarefa");
                Console.WriteLine("4 - Sair");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Digite a tarefa a ser adicionada:");
                        var retorno = gerenciador.AddTask(Console.ReadLine());
                        break;
                    case 2:
                        var lista = gerenciador.ListTasks();
                        Console.WriteLine("Lista de tarefas:");
                        foreach (string task in lista)
                        {
                            Console.WriteLine($"- {task}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Digite o índice da tarefa a ser removida:");
                        var retornoRemove = gerenciador.RemoveTask(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }        
    }
}