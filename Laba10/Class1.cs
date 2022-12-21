using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10
{

    internal class Switch
    {
        public static void Arrow()
        {
            int position = 1;
            while (true)
            {
                Console.WriteLine("\t\tДобро пожаловать в магазин ВСЕ ДЛЯ ВАС");
                Console.WriteLine("   Логин: ");
                Console.WriteLine("   Пороль: ");
                Console.WriteLine("Авторизироваться");

                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    position = 2;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position = position + 1;
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position = position - 1;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position = 2;
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    if (position == 1)
                    {
                        Console.WriteLine("\t\tДобро пожаловать в магазин ВСЕ ДЛЯ ВАС");
                          Console.WriteLine("   Логин: "); Console.SetCursorPosition(10, 1); Console.ReadLine();
                        
                        /*Console.WriteLine(  ); Console.ReadLine(); Console.SetCursorPosition(10, 1);*/
                    }
                    
                }
                Console.WriteLine("   Пороль: ");
                Console.WriteLine("Авторизироваться");
            }
        }
    }
}

