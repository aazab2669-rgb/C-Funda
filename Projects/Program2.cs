namespace SecondProject
{
 public class Game
    {
        static void Main(string[] args)
        {
            string[] questions = 
            {
                "1.What is the capital of italy?",
                "2.What is the red planet?",
                "3.What is the largest animal?"

            };
            string[] answers = 
            {

                "Rome",
                "Mars",
                "Whale"
            };
            int corectAnswer = 0;

            Console.WriteLine("Welcome to the Game");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Please answer the following questions:");
           
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(questions[i]);
                string UserAnswer = Console.ReadLine();
                try
                {
                bool result = IstheAnswerCorect(UserAnswer,answers[i]);
                if (result==true)
                {
                  Console.WriteLine("Corect answer");
                  ++corectAnswer;
                }
                else
                {
                  Console.WriteLine($"sorry incorect answer , the corect answer is {answers[i]}");
                }
                }
                catch ( Exception ex )
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Your score is {corectAnswer} of 3");
            Console.WriteLine("Congrats Game Completed");
           
        }
        private static bool IstheAnswerCorect(string userInput,string corectAnswer)
        {
        if (string.IsNullOrEmpty(userInput))
        {
            throw new Exception("Answer can't be empty");
        }
         //the answer is right 
        if (userInput==corectAnswer)
         {
            return true;
         } 
        else
         {
            return false;
         }  
        }
    }
}