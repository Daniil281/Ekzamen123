using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TaskList
    {
        public string name;
        public List<Task> tasks;

        /// <summary>
        /// Создает объект класса
        /// </summary>
        /// <param name="name"></param>
        public TaskList(string name)
        {
            this.name = name;
            tasks = new List<Task>();
        }
        /// <summary>
        /// Возвращает имя списка задач
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }
        /// <summary>
        /// Добавляет задачу в список задач
        /// </summary>
        /// <param name="task"></param>
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }
        /// <summary>
        /// Возвращает список всех задач
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasks()
        {
            return tasks;
        }
        /// <summary>
        /// Удаляет задачу
        /// </summary>
        /// <param name="task"></param>
        public void Remove(Task task)
        {
            tasks.Remove(task);
        }
    }
}
