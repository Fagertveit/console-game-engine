using System;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ConsoleGameEngine
{
    static class ScreenResolutionWin
    {
        public static void Init()
        {
            Console.SetWindowSize(180, 60);
        }
    }

    static class ScreenResolutionUnix
    {
        [DllImport("libc")]
        static extern int system(string exec);
        
        public static void Init()
        {
            system(@"printf '\e[8;60;180t]'");
        }
    }
    class Screen(int width, int height, int windowWidth = 80, int windowHeight = 60)
    {
        private int width = width;
        private int height = height;
        private int windowWidth = windowWidth;
        private int windowHeight = windowHeight;

        public void Init()
        {
            var os = Environment.OSVersion;

            if (os.Platform == PlatformID.Unix)
            {
                ScreenResolutionUnix.Init();
            }
            else
            {
                ScreenResolutionWin.Init();
            }

            this.windowHeight = Console.WindowHeight;
            this.windowWidth = Console.WindowWidth;

            Console.CursorVisible = false;

            Console.Write($"Console window width {this.windowWidth} and height {this.windowHeight}");
        }
        public static void ClearScreen()
        {
            Console.Clear();
        }

        public static void SetColor(ConsoleColor color, ConsoleColor background = ConsoleColor.Black)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = background;
        }
        public static void WriteAt(string text, int top, int left)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(text);
        }

        public static void FillWithChar(char c, int repeat)
        {
            string fill = "";

            for (int i = 0; i < repeat; i++)
            {
                fill += c;
            }

            Console.Write(fill);
        }

        public static void FillWithRune(Rune c, int repeat)
        {
            string fill = "";

            for (int i = 0; i < repeat; i++)
            {
                fill += c;
            }

            Console.Write(fill);
        }

        public static void FillWithString(string c, int repeat)
        {
            string fill = "";

            for (int i = 0; i < repeat; i++)
            {
                fill += c;
            }

            Console.Write(fill);
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