using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTimeAction : IMenuAction
    {
        public void Execute()
        {
            Test.ShowTime();
        }
    }
}
