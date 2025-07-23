namespace ConsoleGameEngine
{
    class Core
    {
        Screen screen = new Screen(80, 60);
        bool running = true;
        private ActionBar navigation;

        private string action;

        public void Init()
        {
            screen.Init();
            screen.SetColor(ConsoleColor.White, ConsoleColor.Black);
        }
        public void Run()
        {
            ActionItem item1 = new ActionItem("Use shovel", "dig");
            ActionItem item2 = new ActionItem("Use gun", "shoot", true);
            ActionItem item3 = new ActionItem("Walk forward", "walk_forward");
            ActionItem item4 = new ActionItem("Walk left", "walk_left");
            ActionItem item5 = new ActionItem("Walk right", "walk_right");
            List<ActionItem> navigationItems = new List<ActionItem>(0);

            navigationItems.Add(item1);
            navigationItems.Add(item2);
            navigationItems.Add(item3);
            navigationItems.Add(item4);
            navigationItems.Add(item5);

            navigation = new ActionBar(navigationItems);

            while (running)
            {
                Render();
                Update();
            }
        }

        public void Update()
        {
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
            else if (command == ConsoleKey.Enter)
            {
                action = navigation.ActivateAction();
            }
        }

        public void Render()
        {
            screen.ClearScreen();

            navigation.Render(screen.GetWidth(), screen.GetHeight());

            screen.WriteAt($"Welcome to the Console Game Engine: Action {action}", 15, 30);
        }

        public ConsoleKey AwaitCommand()
        {
            return Console.ReadKey().Key;
        }
    }
}