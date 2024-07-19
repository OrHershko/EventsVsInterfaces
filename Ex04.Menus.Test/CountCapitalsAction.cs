using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountCapitalsAction : IMenuAction
    {
        public void Execute()
        {
            Test.CountCapitals();
        }
    }
}
