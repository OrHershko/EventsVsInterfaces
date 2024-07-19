using System;
using System.Collections.Generic;

namespace Ex04.Menus.Events
{
    public class MainMenu
    {
        private readonly string r_Title;
        private readonly List<MenuItem> r_MenuItems;
        private const int k_ExitOrBack = 0;
        private bool m_IsPressedExit;
        private bool m_IsPressedBack;

        public MainMenu(string i_Title)
        {
            r_Title = i_Title;
            r_MenuItems = new List<MenuItem>();
        }

        public void Show()
        {
            showMenu(r_MenuItems, r_Title);
        }

        private void showMenu(List<MenuItem> i_MenuItems, string i_Title)
        {
            while (!m_IsPressedExit)
            {
                string userChoice;

                Console.Clear();
                printMenu(i_MenuItems, i_Title);
                userChoice = Console.ReadLine();

                if (isValidInput(userChoice, i_MenuItems.Count))
                {
                    executeUserChoice(userChoice, i_Title, i_MenuItems);

                    if (m_IsPressedBack)
                    {
                        m_IsPressedBack = false;
                        break;
                    }
                }
                else
                {
                    announceInvalidInput();
                }
            }
        }

        private void printMenu(List<MenuItem> i_MenuItems, string i_Title)
        {
            string titleUnderscore = new string('=', i_Title.Length);

            Console.WriteLine($@"{i_Title}
{titleUnderscore}");

            for (int i = 0; i < r_MenuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {i_MenuItems[i].Title}");
            }

            Console.WriteLine(string.Equals(i_Title, r_Title) ? "0. Exit" : "0. Back");
            Console.Write("Choose an option: ");
        }

        private bool isValidInput(string i_UserChoiceStr, int i_NumOfOptions)
        {
            return int.TryParse(i_UserChoiceStr, out int userChoice) && userChoice >= 0 && userChoice <= i_NumOfOptions;
        }

        private void announceInvalidInput()
        {
            Console.WriteLine("Invalid choice, please try again.");
            System.Threading.Thread.Sleep(1000);
        }

        private void executeUserChoice(string i_UserChoice, string i_Title, List<MenuItem> i_CurrentMenuItems)
        {
            int userChoice = int.Parse(i_UserChoice);

            if (userChoice == k_ExitOrBack)
            {
                if (string.Equals(i_Title, r_Title))
                {
                    m_IsPressedExit = true;
                }
                else
                {
                    m_IsPressedBack = true;
                }
            }
            else
            {
                MenuItem selectedItem = i_CurrentMenuItems[userChoice - 1];

                if (selectedItem.HasSubMenu())
                {
                    showMenu(selectedItem.SubMenuItems, selectedItem.Title);
                }
                else
                {
                    Console.Clear();
                    selectedItem.OnSelected();
                }
            }
        }

        public void AddMenuItem(MenuItem i_MenuItemToAdd)
        {
            r_MenuItems.Add(i_MenuItemToAdd);
        }
    }
}
