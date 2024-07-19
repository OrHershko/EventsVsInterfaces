namespace Ex04.Menus.Test
{
    internal class Program
    {
        public static void Main()
        {
            Ex04.Menus.Interfaces.MainMenu firstMenu = new Ex04.Menus.Interfaces.MainMenu("First Menu");
            Ex04.Menus.Interfaces.MenuItem capitalsAndVersionMenu = new Ex04.Menus.Interfaces.MenuItem("Capitals and Version");
            Ex04.Menus.Interfaces.MenuItem timeDateMenu = new Ex04.Menus.Interfaces.MenuItem("Show Time/Date");

            capitalsAndVersionMenu.AddSubMenu(new Ex04.Menus.Interfaces.MenuItem("Show Version", new ShowVersionAction()));
            capitalsAndVersionMenu.AddSubMenu(new Ex04.Menus.Interfaces.MenuItem("Count Capitals", new CountCapitalsAction()));
            timeDateMenu.AddSubMenu(new Ex04.Menus.Interfaces.MenuItem("Show Time", new ShowTimeAction()));
            timeDateMenu.AddSubMenu(new Ex04.Menus.Interfaces.MenuItem("Show Date", new ShowDateAction()));
            firstMenu.AddMenuItem(capitalsAndVersionMenu);
            firstMenu.AddMenuItem(timeDateMenu);
            firstMenu.Show();

            Ex04.Menus.Events.MainMenu secondMenu = new Ex04.Menus.Events.MainMenu("Second Menu");
            Ex04.Menus.Events.MenuItem secondCapitalsAndVersionMenu = new Ex04.Menus.Events.MenuItem("Capitals and Version");
            Ex04.Menus.Events.MenuItem secondShowVersionItem = new Ex04.Menus.Events.MenuItem("Show Version");
            Ex04.Menus.Events.MenuItem secondCountCapitalsItem = new Ex04.Menus.Events.MenuItem("Count Capitals");
            Ex04.Menus.Events.MenuItem secondTimeDateMenu = new Ex04.Menus.Events.MenuItem("Show Time/Date");
            Ex04.Menus.Events.MenuItem secondShowTimeItem = new Ex04.Menus.Events.MenuItem("Show Time");
            Ex04.Menus.Events.MenuItem secondShowDateItem = new Ex04.Menus.Events.MenuItem("Show Date");

            secondShowVersionItem.Selected += Test.ShowVersion;
            secondCountCapitalsItem.Selected += Test.CountCapitals;
            secondCapitalsAndVersionMenu.AddSubMenu(secondShowVersionItem);
            secondCapitalsAndVersionMenu.AddSubMenu(secondCountCapitalsItem);
            secondShowTimeItem.Selected += Test.ShowTime;
            secondShowDateItem.Selected += Test.ShowDate;
            secondTimeDateMenu.AddSubMenu(secondShowTimeItem);
            secondTimeDateMenu.AddSubMenu(secondShowDateItem);
            secondMenu.AddMenuItem(secondCapitalsAndVersionMenu);
            secondMenu.AddMenuItem(secondTimeDateMenu);
            secondMenu.Show();
        }
    }
}
