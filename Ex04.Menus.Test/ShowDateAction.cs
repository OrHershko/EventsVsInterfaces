using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDateAction : IMenuAction
    {
        public void Execute()
        {
            Test.ShowDate();
        }
    }
}
