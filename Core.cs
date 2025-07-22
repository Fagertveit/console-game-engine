namespace ConsoleGameEngine
{
    class Core
    {
        Screen screen = new Screen(80, 60);
        bool running = true;
        private ActionBar navigation;

        public void Init()
        {
            screen.Init();
        }
        public void Run()
        {
            ActionItem item1 = new ActionItem("Use shovel", "shovel");
            ActionItem item2 = new ActionItem("Use gun", "gun", true);
            ActionItem item3 = new ActionItem("Walk forward", "gun");
            ActionItem item4 = new ActionItem("Walk left", "gun");
            ActionItem item5 = new ActionItem("Walk right", "gun");
            List<ActionItem> navigationItems = new List<ActionItem>(0);

            navigationItems.Add(item1);
            navigationItems.Add(item2);
            navigationItems.Add(item3);
            navigationItems.Add(item4);
            navigationItems.Add(item5);

            navigation = new ActionBar(navigationItems);

            while (running)
            {
                Update();
                Render();
                ConsoleKey command = AwaitCommand();

                if (command == ConsoleKey.Escape)
                {
                    running = false;
                }
                else if (command == ConsoleKey.LeftArrow)
                {
                    navigation.NavigateLeft();
                }
                else if (command == ConsoleKey.RightArrow)
                {
                    navigation.NavigateRight();
                }
            }
        }

        public void Update()
        {

        }

        public void Render()
        {
            screen.ClearScreen();

            navigation.Render(screen.GetWidth(), screen.GetHeight());
        }

        public ConsoleKey AwaitCommand()
        {
            return Console.ReadKey().Key;
        }
    }
}