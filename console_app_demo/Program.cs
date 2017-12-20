﻿using System;

namespace console_demo_app
{

    class Program
    {

        static void Main(string[] args)
        {
            var redo = 0;
            var left = Console.BufferWidth / 2;
            var top = 10;

            ConsoleKeyInfo Keyinfo;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write($"top: {top}\nleft:{left}\nbufferHeight: {Console.BufferHeight}\nbufferWidth:{Console.BufferWidth}");
            Console.SetCursorPosition(left, 10);
            Console.Write($"X");

            Console.CursorVisible = false;

            do
            {
                Keyinfo = Console.ReadKey(true);
                //Console.Write("X");
                //Console.Clear();

                switch (Keyinfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        left++;
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.Write($"top: {top}\nleft:{left}");
                        if (left < Console.BufferWidth)
                        {
                            Console.SetCursorPosition(left, top);
                        }
                        else
                        {
                            left = Console.BufferWidth - 1;
                            Console.SetCursorPosition(left, top);
                        }
                        Console.Write($"X");
                        break;
                    case ConsoleKey.LeftArrow:
                        left--;
                        Console.Clear();
                        if (left > 0)
                        {

                            Console.SetCursorPosition(0, 0);
                            Console.Write($"top: {top}\nleft:{left}");
                            Console.SetCursorPosition(left, top);
                        }
                        else
                        {
                            left = 0;
                            Console.SetCursorPosition(0, 0);
                            Console.Write($"top: {top}\nleft:{left}");
                            Console.SetCursorPosition(left, top);
                        }
                        Console.Write($"X");
                        break;
                    case ConsoleKey.UpArrow:
                        top--;
                        Console.Clear();
                        if (top > 0)
                        {
                            Console.SetCursorPosition(0, 0);
                            Console.Write($"top: {top}\nleft:{left}");
                            Console.SetCursorPosition(left, top);
                        }
                        else
                        {
                            top = 0;
                            Console.SetCursorPosition(0, 0);
                            Console.Write($"top: {top}\nleft:{left}");
                            Console.SetCursorPosition(left, top);
                        }
                        Console.SetCursorPosition(left, top);
                        Console.Write($"X");
                        break;
                    case ConsoleKey.DownArrow:
                        top++;
                        Console.Clear();
                        if (top < 17)
                        {
                            Console.SetCursorPosition(0, 0);
                            Console.Write($"top: {top}\nleft:{left}");
                            Console.SetCursorPosition(left, top);
                            Console.Write($"X");
                        }
                        else
                        {
                            top = 17;
                            Console.SetCursorPosition(0, 0);
                            Console.Write($"top: {top}\nleft:{left}");
                            Console.SetCursorPosition(left, top);
                            Console.Write($"X");
                        }

                        break;
                }

            } while (redo == 0);

            Console.ReadLine();
        }


    }
}
