using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MainMenu : MenuItem
    {
        private const bool k_IsMainMenu = true;

        public MainMenu(string i_Title) : base(i_Title, k_IsMainMenu)
        {
        }
    }
}
