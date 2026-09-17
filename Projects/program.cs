namespace FristProject
{
    public class TaskTraker
    {
         static string[] Tasks = new string[10];
         static int TaskIndex= 0;
         public static void Main()
        {
            Console.WriteLine("Welcome  ");
            Console.WriteLine("------------");
            Console.WriteLine("Enter from 1 to 5 only");

            while (true)
            {
            string UserChoice = Console.ReadLine();
            switch (UserChoice)
            {
                case "1":
                AddTask();
                break;

                case "2":
                ViewTasks();
                break;

                case "3":
                CompletedTasks();
                break;

                case "4":
                RemoveTask();
                break; 

                case "5":
                Environment.Exit(0);
                break;

                default:
                Console.WriteLine("Enrer a number from 1 to 5 only");
                break;
            }
            }        
        }
         public static void AddTask()
        {
           Console.WriteLine("Enter Task Title");
           string TaskTitle = Console.ReadLine();
           Tasks[TaskIndex]=TaskTitle;
            ++TaskIndex;
            Console.WriteLine("Task added");
        }
         public static void ViewTasks()
        {
            Console.WriteLine(" Tasks List : ");
            for (int i = 0; i < TaskIndex; i++)
            {
               Console.WriteLine($"{i+1} TaskTitle : {Tasks[i]}") ;
            }
        }
         public static void CompletedTasks()
        {
            Console.WriteLine("TaskNumber");
            int TaskId = Convert.ToInt32(Console.ReadLine());
            Tasks[TaskId-1]= Tasks[TaskId-1] + ": is COMPLETED";
        }
         public static void RemoveTask()
        {
            Console.WriteLine("TaskNumber");
            int TaskId = Convert.ToInt32(Console.ReadLine());
            Tasks[TaskId-1]= " "; 
        }
    }
}
