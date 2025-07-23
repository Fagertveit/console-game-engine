using System;

namespace ConsoleGameEngine
{
    class Screen(int width, int height, int windowWidth = 80, int windowHeight = 60)
    {
        private int width = width;
        private int height = height;
        private int windowWidth = windowWidth;
        private int windowHeight = windowHeight;

        public void Init()
        {
            this.windowHeight = Console.WindowHeight;
            this.windowWidth = Console.WindowWidth;

            Console.CursorVisible = false;

            Console.Write($"Console window width {this.windowWidth} and height {this.windowHeight}");
        }
        public void ClearScreen()
        {
            Console.Clear();
        }

        public void SetColor(ConsoleColor color, ConsoleColor background = ConsoleColor.Black)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = background;
        }
        public void WriteAt(string text, int top, int left)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(text);
        }

        public int GetWidth()
        {
            return windowWidth;
        }

        public int GetHeight()
        {
            return windowHeight;
        }
    }
}