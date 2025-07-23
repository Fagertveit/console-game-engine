namespace ConsoleGameEngine
{
    class ActionBar(List<ActionItem> items)
    {
        private List<ActionItem> items = items;
        private ActionItem active = items.First();

        public void Render(int width, int height)
        {
            // Navigationbar needs 3 rows that sits at the bottom of the window
            // Active Item is rendered black on white whilst inactive items are
            // rendered white on black
            // Navigationbar is surrounded by a simple top and bottom border
            Console.Write($"Rendering navigationbar in screen with width {width} and height {height}");

            int posTop = height - 4;
            Console.Write($"Starting at row {posTop}");

            string topBorder = "";

            for (int i = 0; i < width; i++)
            {
                topBorder += RenderBrush.UpperBlock;
            }

            Console.SetCursorPosition(0, posTop);
            Console.WriteLine(topBorder);

            posTop += 1;
            Console.SetCursorPosition(0, posTop);
            Console.Write(RenderBrush.LeftBlock);
            items.ForEach(item => item.Render());

            int filler = width - CalculateTotalWidth() - 2;

            string fillerStr = "";

            for (int i = 0; i < filler; i++)
            {
                fillerStr += " ";
            }

            fillerStr += RenderBrush.RightBlock;
            Console.Write(fillerStr);

            posTop += 1;
            Console.SetCursorPosition(0, posTop);
            string bottomBorder = "";
            for (int i = 0; i < width; i++)
            {
                bottomBorder += RenderBrush.LowerBlock;
            }

            Console.WriteLine(bottomBorder);
        }

        public void NavigateRight()
        {
            int index = items.FindIndex(item => item.active);
            int numberOfItems = items.Count - 1;

            items[index].SetActive(false);

            if (numberOfItems <= index)
            {
                items[0].SetActive(true);
            }
            else
            {
                items[index + 1].SetActive(true);
            }
        }

        public void NavigateLeft()
        {
            int index = items.FindIndex(item => item.active);
            int numberOfItems = items.Count - 1;

            items[index].SetActive(false);

            if (index == 0)
            {
                items[numberOfItems].SetActive(true);
            }
            else
            {
                items[index - 1].SetActive(true);
            }
        }

        public string ActivateAction()
        {
            int index = items.FindIndex(item => item.active);

            return items[index].Activate();
        }

        private int CalculateTotalWidth()
        {
            int width = 0;

            items.ForEach(item =>
            {
                width += (item.label.Length + 2);
            });

            return width;
        }
    }
}