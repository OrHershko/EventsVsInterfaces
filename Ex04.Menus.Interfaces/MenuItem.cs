using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        public string Title { get; }
        public IMenuAction Action { get; }
        public List<MenuItem> SubMenuItems { get; }

        public MenuItem(string i_Title, IMenuAction i_Action = null)
        {
            Title = i_Title;
            Action = i_Action;
            SubMenuItems = new List<MenuItem>();
        }

        public void AddSubMenu(MenuItem i_MenuItem)
        {
            SubMenuItems.Add(i_MenuItem);
        }

        public bool HasSubMenu()
        {
            return SubMenuItems.Count > 0;
        }
    }
}
