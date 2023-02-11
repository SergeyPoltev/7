using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Проводник
{
    public class Cursor
    {
        public static int xmarg = 0;
        public static int ymarg = 5;
        public static int change = 1;
        public static ConsoleKeyInfo key;
         public static int Change()
        {
            Console.SetCursorPosition(xmarg, ymarg);
            Console.WriteLine("->");
            while (true)
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(xmarg, ymarg + 1);
                    Console.WriteLine("  ");
                    Console.SetCursorPosition(xmarg, ymarg - 1);
                    Console.WriteLine("  ");
                    Console.SetCursorPosition(xmarg, ymarg);
                    Console.WriteLine("->");

                    ymarg--;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(xmarg, ymarg - 1);
                    Console.WriteLine("  ");
                    Console.SetCursorPosition(xmarg, ymarg + 1);
                    Console.WriteLine("  ");
                    Console.SetCursorPosition(xmarg, ymarg);
                    Console.WriteLine("->");
                    ymarg++;
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }
            return ymarg-6;
        }
    }
}
