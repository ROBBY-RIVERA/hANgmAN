using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hANgmAN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hang the Man!");
            Console.WriteLine("Pick a letter than pick more until you have enough or this guy gets it.");
            Random rand = new Random();

            string[] word = new string[] { "gimmick", "gregarious", "garden", "giddy", "gargoyle", "gaudy", "got" };
            int select = rand.Next(word.Length);
            //Console.WriteLine(word[select]);
            string guess = (word[select]);
            foreach (string ch in word)
            {
                Console.Write("_");
            }
            Console.WriteLine(" Choose Wisely, the letters count only amount to " + guess.Length);
            char[] answer = new char[guess.Length];
            for (int answerIndex = 0; answerIndex < answer.Length; answerIndex++)
            {
                answer[answerIndex] = '_';
            }
            int lives = guess.Length + 1;
            while (true)
            {

                for (int answerIndex = 0; answerIndex < answer.Length; answerIndex++)
                {
                    Console.Write(answer[answerIndex]);

                }
                Console.WriteLine(" Lives: " + lives);
                string input = Console.ReadLine().ToLower();

                if (input != null && word[select].Contains(input[0]))
                {
                    Console.WriteLine($"yes");

                    int currentindex = guess.IndexOf(input[0]);
                    answer[currentindex] = input[0];
                    for (int multipleCheckIndex = 0; multipleCheckIndex < guess.Length; multipleCheckIndex++)
                    {
                        if (multipleCheckIndex != currentindex && guess[multipleCheckIndex] == input[0])
                        {
                            answer[multipleCheckIndex] = input[0];
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"no");
                    lives--;
                }

                if (lives == 0)
                {
                    Console.WriteLine("Thanks for hanging around! ahahahaha");
                    break;
                }

                //if (guess == new string(answer))

                if (Array.IndexOf(answer, '_') == -1)
                {
                    Console.WriteLine("Dang you got me there");
                    break;
                }

                //if (answer.Contains("_") == false)
                //{
                //Console.WriteLine("Dang you got me there");
                //break;

                //}


                //if (input == "g" || input == "a" || input == "r" || input == "d" || input == "e" || input == "n")
                //{
                //Console.WriteLine($"yes");
                //}
                //else
                //{
                //Console.WriteLine($"no");
                //}
            }

        }
    }
}