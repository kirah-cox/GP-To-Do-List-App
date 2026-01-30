

using GP_To_Do_List_App;

public class Program
{
    static void Main()
    {
        ToDoList toDoList = new ToDoList();


        bool runProgram = true;
        
        while (runProgram)
        {
            WriteMenu();

            if (int.TryParse(Console.ReadLine(), out int option))
            {
                switch (option)
                {
                    case 1:
                        ActionOne(toDoList);
                        break;
                    case 2:
                        ActionTwo(toDoList);
                        break;
                    case 3:
                        ActionThree(toDoList);
                        break;
                    case 4:
                        ActionFour(toDoList);
                        break;
                    case 5:
                        runProgram = ActionFive();
                        break;
                    default:
                        InvalidOption();
                        break;
                }
            }
            else
            {
                InvalidOption();
            }
        }
    }

    private static void WriteMenu()
    {
        Console.WriteLine("Welcome to your To-Do List! Select an option:");
        Console.WriteLine("1: Add a Task");
        Console.WriteLine("2: Remove a Task");
        Console.WriteLine("3: Mark a Task as Complete");
        Console.WriteLine("4: View Tasks");
        Console.WriteLine("5: Exit");
    }

    private static void InvalidOption()
    {
        Console.WriteLine("That is not a valid option.\n");
    }

    private static bool ActionFive()
    {
        bool runProgram;
        Console.WriteLine("Thank you for using this program!");
        runProgram = false;
        return runProgram;
    }

    private static void ActionFour(ToDoList toDoList)
    {
        if (toDoList.taskList.Count != 0)
        {
            Console.WriteLine("Here is your complete To-Do list:\n");

            toDoList.ViewList();

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Your To-Do list is empty.\n");
        }
    }

    private static void ActionThree(ToDoList toDoList)
    {
        if (toDoList.taskList.Count != 0)
        {
            Console.WriteLine("What task do you want to mark as complete?");
            string taskName3 = Console.ReadLine();

            toDoList.MarkAsComplete(taskName3);

            Console.WriteLine("This task has been marked as complete.\n");
        }
        else
        {
            Console.WriteLine("You have no tasks to mark as complete.\n");
        }
    }

    private static void ActionTwo(ToDoList toDoList)
    {
        if (toDoList.taskList.Count != 0)
        {
            Console.WriteLine("What task do you want to remove?");
            string taskName2 = Console.ReadLine();

            toDoList.RemoveTask(taskName2);

            Console.WriteLine("The task has been removed from to the To-do list.\n");
        }
        else
        {
            Console.WriteLine("You have no tasks to remove.\n");
        }
    }

    private static void ActionOne(ToDoList toDoList)
    {
        Console.WriteLine("What is the task name?");
        string taskName1 = Console.ReadLine();

        Console.WriteLine("What is the task description?");
        string taskDescription = Console.ReadLine();

        Console.WriteLine("When is the task due?");
        string dueDate = Console.ReadLine();

        toDoList.AddTask(taskName1, taskDescription, dueDate);

        Console.WriteLine("The task has been added to the To-do list.\n");
    }
}