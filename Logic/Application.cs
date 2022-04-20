using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Application
    {
        public Application application;
        public List<TaskList> taskLists;

        /// <summary>
        /// Создает объект класса
        /// </summary>
        public Application()
        {
            var TaskList = new TaskList("Входящие");
            taskLists = new List<TaskList>();

            taskLists.Add(TaskList);
        }

        /// <summary>
        /// Создает список с задачами и добавляет его в список со списками задач
        /// </summary>
        /// <param name="name"></param>
        public void CreateTaskList(string name)
        {
            var TaskList = new TaskList(name);
            taskLists.Add(TaskList);
        }

        /// <summary>
        /// Возвращает имена списков задач.
        /// </summary>
        public List<string> GetTaskListNames()
        {
            List<string> listName = new List<string>();

            foreach (TaskList lst in taskLists)
            {
                listName.Add(lst.name);
            }

            return listName;
        }
    }
}
