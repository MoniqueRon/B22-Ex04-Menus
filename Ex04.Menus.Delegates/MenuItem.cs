using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        public Action ExecutableItem;
        private string m_Title;
        private List<MenuItem> m_Items;
        private bool m_IsMainMenu;

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public List<MenuItem> Items
        {
            get { return m_Items; }
            set { m_Items = value; }
        }

        public bool IsMainMenu
        {
            get { return m_IsMainMenu; }
        }

        public MenuItem(string i_Title, bool i_IsMainMenu)
        {
            m_Title = i_Title;
            m_Items = new List<MenuItem>();
            m_IsMainMenu = i_IsMainMenu;
        }

        public MenuItem(string i_Title, Action i_ExecutableItem, bool i_IsMainMenu)
        {
            m_Title = i_Title;
            m_Items = new List<MenuItem>();
            ExecutableItem = i_ExecutableItem;
            m_IsMainMenu = i_IsMainMenu;
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            m_Items.Add(i_MenuItem);
        }

        public void Display()
        {
            int userInput;

            while (true)
            {
                displayMenu();
                userInput = getValidUserInput();
                if (userInput == 0)
                {
                    break;
                }

                displayUserChoise(userInput - 1);
            }
        }

        private void displayMenu()
        {
            StringBuilder menu = new StringBuilder();
            int optionNumber = 1;

            menu.AppendLine();
            menu.AppendLine(m_Title);
            menu.AppendLine(new string('-', m_Title.Length));
            foreach (MenuItem menuItem in m_Items)
            {
                menu.AppendLine(String.Format("{0} -> {1}", optionNumber, menuItem.Title));
                optionNumber++;
            }

            menu.AppendLine(String.Format("0 -> {0}", m_IsMainMenu ? "Exit" : "Back"));
            menu.AppendLine(String.Format("Please enter your request: (1 to {0} or press '0' to {1})", optionNumber - 1, m_IsMainMenu ? "exit" : "go back"));
            Console.WriteLine(menu.ToString());
        }

        private int getValidUserInput()
        {
            int userInput;
            string userInputString;

            userInputString = Console.ReadLine();
            while (!int.TryParse(userInputString, out userInput) || userInput < 0 || userInput > m_Items.Count())
            {
                Console.WriteLine("Invalid input. Please enter your request");
                userInputString = Console.ReadLine();
            }

            return userInput;
        }

        private void displayUserChoise(int i_UserChoise)
        {
            Console.Clear();
            if (m_Items[i_UserChoise].Items.Count() == 0)
            {
                m_Items[i_UserChoise].Execute();
            }

            else if (m_Items[i_UserChoise].Items.Count() != 0)
            {
                m_Items[i_UserChoise].Display();
            }
        }

        public void Execute()
        {
            if (ExecutableItem != null)
            {
                ExecutableItem.Invoke();
            }
        }
    }
}
