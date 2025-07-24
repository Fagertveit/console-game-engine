namespace ConsoleGameEngine
{
    class ActionBar(List<ActionItem> items)
    {
        private List<ActionItem> items = items;

        public void Render(int width, int height)
        {
            int posTop = height - 4;
            Console.Write($"Starting at row {posTop}");

            Console.SetCursorPosition(0, posTop);
            Console.Write(RenderBrush.Block);
            Screen.FillWithRune(RenderBrush.UpperBlock, width - 2);
            Console.Write(RenderBrush.Block);

            posTop += 1;
            Console.SetCursorPosition(0, posTop);
            Console.Write(RenderBrush.Block);

            items.ForEach(item => item.Render());

            int filler = width - CalculateTotalWidth() - 2;
            Screen.FillWithString(" ", filler);
            Console.Write(RenderBrush.Block);

            posTop += 1;
            Console.SetCursorPosition(0, posTop);
            Console.Write(RenderBrush.Block);
            Screen.FillWithRune(RenderBrush.LowerBlock, width - 2);
            Console.Write(RenderBrush.Block);
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