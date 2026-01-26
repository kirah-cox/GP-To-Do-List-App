using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace GP_To_Do_List_App
{
    public class Task
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string DueDate { get; set; }

        public bool IsCompleted { get; set; } = false;

        public Task(string name, string description, string dueDate)
        {
            Name = name;
            Description = description;
            DueDate = dueDate;
        }
    }


  


}
