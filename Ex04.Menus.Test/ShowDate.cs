using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : IExecutableItem
    {
        public void Execute()
        {
            Console.WriteLine(string.Format("Current time: {0:dd-MM-yyyy}", DateTime.Now));
        }
    }
}
