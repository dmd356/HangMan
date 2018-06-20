using System;

namespace Week_4_Course_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] words = { "h e l l o", "1 2 3 4 5", "c a l i f o r n i a"};
            bool gameOn = true;
            while (gameOn)//if game is still playing
            {
                Menu menu = new Menu();
                int lives = 5;
                int score = 0;
                String say = "";
                //Game Starts
                menu.introStage();
                say = "0 for easy, 1 for medium, 2 for hard ";
                Console.WriteLine("--------------------------");

                int mode = menu.PickInt(say, 2);
                //Initialize the game words
                String[] truth = words[mode].Split(" ");
                String[] guesses = new String[truth.Length];
                String trueAnswer = "";
                Console.WriteLine("The word goes like ");
                for (int i = 0; i < truth.Length; i++)//print the word
                {
                    guesses[i] = "x";
                    Console.Write(guesses[i]);
                    trueAnswer += truth[i];
                }
                Console.WriteLine();

                while (lives > 0 && score < truth.Length)//game loop 2!
                {
                    score = 0;
                    Console.WriteLine("Please guess a letter");
                    String answer = menu.pickLetter();
                    int fail = 0;
                    for (int j = 0; j < truth.Length; j++)//Checking their answer if its true
                    {
                        if (truth[j] == answer.ToLower())
                        {
                            guesses[j] = guesses[j].Replace(guesses[j].Substring(0), answer);
                        }
                        else
                        {
                            fail++;
                        }
                    }//for j

                    foreach (String x in guesses) //read the guessed list
                    {
                        Console.Write(x);
                    }

                    Console.WriteLine();

                    for (int i = 0; i < truth.Length; i++)
                    {
                        if (truth[i].ToLower() == guesses[i].ToLower())
                        {
                            score++;
                        }
                    }
                    Console.WriteLine("Score : " + score + " out of " + truth.Length);
                    if (fail == truth.Length)
                    {
                        lives--;
                        Console.WriteLine("Guess again? You're lives are at " + lives);
                    }
                    Console.WriteLine();
                }//while


                Console.WriteLine("The word was " + trueAnswer+"!");
                if (lives == 0)
                {
                    Console.WriteLine("You lose!");
                }
                else
                {
                    Console.WriteLine("You win!");
                }
                Console.WriteLine();
                say = "Continue? 0 for no, 1 for yes";
                gameOn = (menu.PickInt(say, 1) > 0) ? true : false;
                Console.WriteLine();
            }//End game loop
            Console.WriteLine("Goodbye!!!");
        }
    }
}
