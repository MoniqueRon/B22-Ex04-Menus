using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountSpaces : IExecutableItem
    {
        public void Execute()
        {
            int count = 0;
            string userInput;

            Console.WriteLine("Please enter your sentence:");
            userInput = Console.ReadLine();
            foreach (char c in userInput)
            {
                if (c == ' ')
                {
                    count++;
                }
            }

            Console.WriteLine(String.Format("There are {0} spaces in your sentence", count));
        }
    }
}
