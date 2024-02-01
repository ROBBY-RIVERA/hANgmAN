using System;
using System.Collections.Generic;
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
            int select = rand.Next();
            string[] word = new string[] {"Gimmick", "Gregarious", "Garden", "Giddy", "Gargoyle", "Gaudy", "Got"};
        }
    }
}
