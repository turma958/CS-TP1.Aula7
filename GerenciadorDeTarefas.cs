using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_TP1.Aula7
{
    public class GerenciadorDeTarefas
    {
        public List<string>? tasks { get; set; }

        public GerenciadorDeTarefas()
        {
            tasks = new();
        }

        public string RemoveTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                string task = tasks[index];
                tasks.RemoveAt(index);
                return $"Tarefa '{task}' removida com sucesso.";
            }            
            
            return "Índice inválido. Tente novamente.";            
        }

        public List<string> ListTasks()
        {
            return tasks;
        }

        public string AddTask(string task)
        {
            tasks.Add(task);
            return $"Tarefa '{task}' adicionada com sucesso.";
        }
    }
}
