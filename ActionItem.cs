namespace ConsoleGameEngine {
    class ActionItem(string label, string action, bool active = false)
    {
        public string label = label;

        public string action = action;
        public bool active = active;

        public string Activate()
        {
            return action;
        }

        public void SetActive(bool active)
        {
            this.active = active;
        }

        public void Render()
        {
            if (active)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.Write($" {label} ");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write($" {label} ");
            }

        }
    }
}