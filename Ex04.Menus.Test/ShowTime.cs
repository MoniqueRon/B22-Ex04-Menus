using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : IExecutableItem
    {
        public void Execute()
        {
            Console.WriteLine(String.Format("Current time: {0:HH:mm:ss}", DateTime.Now));
        }
    }
}
