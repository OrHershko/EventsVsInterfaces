using System.Collections.Generic;

namespace Ex04.Menus.Events
{
    public delegate void EventHandler();

    public class MenuItem
    {
        public string Title { get; }
        public event EventHandler Selected;
        public List<MenuItem> SubMenuItems { get; }

        public MenuItem(string i_Title)
        {
            Title = i_Title;
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

        public void OnSelected()
        {
            if(Selected != null)
            {
                Selected.Invoke();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
