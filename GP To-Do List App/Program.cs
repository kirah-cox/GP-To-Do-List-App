

using GP_To_Do_List_App;

public class Program
{
    static void Main()
    {
        ToDoList toDoList = new ToDoList();


        bool runProgram = true;
        
        while (runProgram)
        {
            Console.WriteLine("Welcome to your To-Do List! Select an option:");
            Console.WriteLine("1: Add a Task");
            Console.WriteLine("2: Remove a Task");
            Console.WriteLine("3: Mark a Task as Complete");
            Console.WriteLine("4: View Tasks");
            Console.WriteLine("5: Exit");


            if (int.TryParse(Console.ReadLine(), out int option))
            {
                if (option == 1)
                {
                    Console.WriteLine("What is the task name?");
                    string taskName = Console.ReadLine();

                    Console.WriteLine("What is the task description?");
                    string taskDescription = Console.ReadLine();

                    Console.WriteLine("When is the task due?");
                    string dueDate = Console.ReadLine();

                    toDoList.AddTask(taskName, taskDescription, dueDate);

                    Console.WriteLine("The task has been added to the To-do list.");
                }
                else if (option == 2)
                {
                    Console.WriteLine("What task do you want to remove?");
                }
                else if (option == 3)
                {
                    Console.WriteLine("What task do you want to mark as complete?");
                    string taskName = Console.ReadLine();

                    toDoList.MarkAsComplete(taskName);

                    Console.WriteLine("This task has been marked as complete.");
                }
                else if (option == 4)
                {
                    Console.WriteLine("Here is your complete To-Do list:");
                }
                else if (option == 5)
                {
                    Console.WriteLine("Thank you for using this program!");
                    runProgram = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid option.");
                }
            }
            else
            {
                Console.WriteLine("That is not a valid option.");
            }
        }
    }
}