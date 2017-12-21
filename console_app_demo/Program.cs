using System;

namespace console_demo_app
{

    class Program
    {

        static void Main(string[] args)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            // Get rid of the scroll bars by making the buffer the same size as the window
            //Console.Clear();
            //Console.SetWindowSize(65, 33);
            //Console.BufferWidth = 65;
            //Console.BufferHeight = 30;



            var test = @"
            ░░░░░░░░░░░░░░░░░░░░░░░░░░░░
            ░░░░░░░░░░ ░░░░░░░░░░░░▒▒▒▒▒
            ░░░░░░░░░░░░░░░░░░░░░░░░░░░░              
            ";
            Console.WriteLine(test);

            // Set the window size and title
            Console.Title = "Code Page 437: MS-DOS ASCII Characters";


            Console.WriteLine(Console.OutputEncoding);
            Console.WriteLine($"player {'\u263A'}");
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine(Console.OutputEncoding);

            for (byte b = 0; b < byte.MaxValue; b++)
            {
                char c = System.Text.Encoding.GetEncoding(437).GetChars(new byte[] { b })[0];
                switch (b)
                {
                    case 8: // Backspace
                    case 9: // Tab
                    case 10: // Line feed
                    case 13: // Carriage return
                        c = '.';
                        break;
                }

                Console.Write("{0:000} {1}   ", b, c);

                // 7 is a beep -- Console.Beep() also works
                if (b == 7) Console.Write(" ");

                if ((b + 1) % 8 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
            //    Console.OutputEncoding = System.Text.Encoding.UTF8;

            //    var player = '\u263A'; // white smiley face
            //    //var player = "☺";
            //    //var player = (char)2;
            //    var redo = 0;
            //    var left = Console.BufferWidth / 2;
            //    var top = 10;

            //    ConsoleKeyInfo Keyinfo;
            //    Console.Clear();
            //    Console.SetCursorPosition(0, 0);
            //    Console.Write($"top: {top}\nleft:{left}\nbufferHeight: {Console.BufferHeight}\nbufferWidth:{Console.BufferWidth}");
            //    Console.SetCursorPosition(left, 10);
            //    Console.Write(player);

            //    Console.CursorVisible = false;

            //    do
            //    {
            //        Keyinfo = Console.ReadKey(true);
            //        //Console.Write("X");
            //        //Console.Clear();

            //        switch (Keyinfo.Key)
            //        {
            //            case ConsoleKey.RightArrow:
            //                left++;
            //                Console.Clear();
            //                Console.SetCursorPosition(0, 0);
            //                Console.Write($"top: {top}\nleft:{left}");
            //                if (left < Console.BufferWidth)
            //                {
            //                    Console.SetCursorPosition(left, top);
            //                }
            //                else
            //                {
            //                    left = Console.BufferWidth - 1;
            //                    Console.SetCursorPosition(left, top);
            //                }
            //                Console.Write(player);
            //                break;
            //            case ConsoleKey.LeftArrow:
            //                left--;
            //                Console.Clear();
            //                if (left > 0)
            //                {

            //                    Console.SetCursorPosition(0, 0);
            //                    Console.Write($"top: {top}\nleft:{left}");
            //                    Console.SetCursorPosition(left, top);
            //                }
            //                else
            //                {
            //                    left = 0;
            //                    Console.SetCursorPosition(0, 0);
            //                    Console.Write($"top: {top}\nleft:{left}");
            //                    Console.SetCursorPosition(left, top);
            //                }
            //                Console.Write(player);
            //                break;
            //            case ConsoleKey.UpArrow:
            //                top--;
            //                Console.Clear();
            //                if (top > 0)
            //                {
            //                    Console.SetCursorPosition(0, 0);
            //                    Console.Write($"top: {top}\nleft:{left}");
            //                    Console.SetCursorPosition(left, top);
            //                }
            //                else
            //                {
            //                    top = 0;
            //                    Console.SetCursorPosition(0, 0);
            //                    Console.Write($"top: {top}\nleft:{left}");
            //                    Console.SetCursorPosition(left, top);
            //                }
            //                Console.SetCursorPosition(left, top);
            //                Console.Write(player);
            //                break;
            //            case ConsoleKey.DownArrow:
            //                top++;
            //                Console.Clear();
            //                if (top < 17)
            //                {
            //                    Console.SetCursorPosition(0, 0);
            //                    Console.Write($"top: {top}\nleft:{left}");
            //                    Console.SetCursorPosition(left, top);
            //                    Console.Write(player);
            //                }
            //                else
            //                {
            //                    top = 17;
            //                    Console.SetCursorPosition(0, 0);
            //                    Console.Write($"top: {top}\nleft:{left}");
            //                    Console.SetCursorPosition(left, top);
            //                    Console.Write(player);
            //                }

            //                break;
            //        }

            //    } while (redo == 0);

            //    Console.ReadLine();
        }


    }
}
