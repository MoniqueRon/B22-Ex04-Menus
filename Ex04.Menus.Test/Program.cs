using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            testMenuWithInterface();
            testMenuWithDelegates();
        }

        private static void testMenuWithInterface()
        {
            Interfaces.MainMenu interfaceMainMenu = new Interfaces.MainMenu("Interface Main Menu");
            Interfaces.MenuItem showDateTimeMenu = new Interfaces.MenuItem("Show Date/Time", false);
            Interfaces.MenuItem versionAndSpacesMenu = new Interfaces.MenuItem("Version and Spaces", false);
            Interfaces.MenuItem showTimeItem = new Interfaces.MenuItem("Show Time", new ShowTime(), false);
            Interfaces.MenuItem showDateItem = new Interfaces.MenuItem("Show Date", new ShowDate(), false);
            Interfaces.MenuItem countSpacesItem = new Interfaces.MenuItem("Count Spaces", new CountSpaces(), false);
            Interfaces.MenuItem showVersionItem = new Interfaces.MenuItem("Show Version", new ShowVersion(), false);

            showDateTimeMenu.AddMenuItem(showTimeItem);
            showDateTimeMenu.AddMenuItem(showDateItem);
            versionAndSpacesMenu.AddMenuItem(countSpacesItem);
            versionAndSpacesMenu.AddMenuItem(showVersionItem);
            interfaceMainMenu.AddMenuItem(showDateTimeMenu);
            interfaceMainMenu.AddMenuItem(versionAndSpacesMenu);
            interfaceMainMenu.Display();
        }

        private static void testMenuWithDelegates()
        {
            Delegates.MainMenu delegateMainMenu = new Delegates.MainMenu("Delegate Main Menu");
            Delegates.MenuItem showDateTimeMenu = new Delegates.MenuItem("Show Date/Time", false);
            Delegates.MenuItem versionAndSpacesMenu = new Delegates.MenuItem("Version and Spaces", false);
            Delegates.MenuItem showTimeItem = new Delegates.MenuItem("Show Time", new Action(new ShowTime().Execute), false);
            Delegates.MenuItem showDateItem = new Delegates.MenuItem("Show Date", new Action(new ShowDate().Execute), false);
            Delegates.MenuItem countSpacesItem = new Delegates.MenuItem("Count Spaces", new Action(new CountSpaces().Execute), false);
            Delegates.MenuItem showVersionItem = new Delegates.MenuItem("Show Version", new Action(new ShowVersion().Execute), false);

            showDateTimeMenu.AddMenuItem(showTimeItem);
            showDateTimeMenu.AddMenuItem(showDateItem);
            versionAndSpacesMenu.AddMenuItem(countSpacesItem);
            versionAndSpacesMenu.AddMenuItem(showVersionItem);
            delegateMainMenu.AddMenuItem(showDateTimeMenu);
            delegateMainMenu.AddMenuItem(versionAndSpacesMenu);
            delegateMainMenu.Display();
        }
    }
}
