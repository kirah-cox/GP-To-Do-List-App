using System;
using System.Collections.Generic;
using System.Text;

namespace GP_To_Do_List_App
{
    public class ToDoList
    {
        List<Task> taskList = new List<Task>
        {
           //new Task {Name = "Make bed", Description = "do it", DueDate = "12/12/12", IsCompleted = false}
        };
        public void AddTask(string name, string description, string dueDate)
        {
            Task task = new Task(name, description, dueDate);
            taskList.Add(task);
        }

    }
}
