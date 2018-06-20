using System;
namespace Week_4_Course_Project
{
    public class Menu
    {


        public void introStage(){
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Hello, Welcome to Hangman!");
            Console.WriteLine("please pick a mode!");
        }

      

        public void creditStage()
        {
            
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Thank you for playing Hangman!");
            Console.WriteLine("Game Designed by: Devin Distelhorst");
            Console.WriteLine("Script Designed by: Devin Distelhorst!");
            Console.WriteLine("Animations Designed by: Devin Distelhorst!");
            Console.WriteLine("Orchestra/Opera Music Designed by: Devin Distelhorst!");
            Console.WriteLine(" Designed by: Devin Distelhorst!");




        }
        public int PickInt(String say, int maxOptions)
        {
            while (true)
            {
                Console.WriteLine(say);
                String answer = Console.ReadLine();
                int num;
                if (int.TryParse(answer, out num) && num<=maxOptions)
                {
                    return num;
                }
            }
        }

        public String pickLetter()
        {
            while (true)
            {
                String answer = Console.ReadLine();
                if (answer.Length < 2 && answer.Length > 0)
                {
                    return answer;
                }
                Console.WriteLine("Please guess one alphabetical letter only.");
            }
        }//pick letter end
    }
}