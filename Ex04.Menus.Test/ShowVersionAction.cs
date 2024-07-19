using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersionAction : IMenuAction
    {
        public void Execute()
        {
            Test.ShowVersion();
        }
    }
}
