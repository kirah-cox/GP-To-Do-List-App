using System;
using System.Collections.Generic;
using System.Text;

namespace GP_To_Do_List_App
{
    public class ToDoList
    {
        public List<Task> taskList = new List<Task>
        {
        };


        public void AddTask(string name, string description, string dueDate)
        {
            Task task = new Task(name, description, dueDate);
            taskList.Add(task);
        }

        public void RemoveTask(string name)
        {
            for (int i = taskList.Count - 1; i >= 0; i--)
            {
                if (taskList[i].Name == name)
                    taskList.RemoveAt(i);
            }
        }

        public void MarkAsComplete(string name)
        {
            foreach (Task task in taskList)
            {
                if (task.Name == name)
                {
                    task.IsCompleted = true;
                }
            }
        }

        public void ViewList()
        {
                Console.WriteLine($"Name | Description | Due Date | Completed");
                Console.WriteLine($"-----------------------------------------");

            foreach (Task task in taskList)
            {
                Console.WriteLine($"{task.Name} | {task.Description} | {task.DueDate} | {task.IsCompleted}");
            }
        }
    }
}
