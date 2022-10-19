using System.Globalization;

namespace Journal2._0
{
    internal class Program
    {
        static void Menu()
        {
            Console.WriteLine("Выберите дату:"); //здесь есть недоработки, которые хотелось поправить, возможно они не появились до ночи
            List<string> dates = new List <string> { "  1 октября", "  5 октября", "  7 октября" };
            Console.WriteLine("    Создание заметки"); //для создание новой даты нажать на K
           
            foreach (string date in dates)
            {
                Console.WriteLine(date);
            }
            
        }
        

        static void fisrstOctober(string date, string[] zametki)
        {
            Console.WriteLine(date);
            Console.WriteLine("----------");
            foreach (string dela in zametki)
            {
                Console.WriteLine(dela);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("EжеДневник");

            StrelkaMenu();
        }
        static int Arrow(ConsoleKeyInfo key, int min, int max)
        {
            int position = 1;

            while (key.Key != ConsoleKey.RightArrow)
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position == max)
                    {
                        position--;
                    }

                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;

                    if (position == min)
                    {
                        position++;
                    }
                }
                
                Console.Clear();
                Menu();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                key = Console.ReadKey();
            }
            return position;
        }
        static void StrelkaMenu()
        {
            ConsoleKeyInfo key = Console.ReadKey();

            while (key.Key != ConsoleKey.Escape)
            {
                int position = Arrow(key, 0, 10);


                Console.Clear();
                
                
                if (position == 2) // 1 октября
                {
                    StrelkaOne("Вы выбрали 1 октября");
                }
                if (position == 3) // 5 октября
                {
                    StrelkaOne("Вы выбрали 5 октября");
                }
                if (position == 4) // 7 октября
                {
                    StrelkaOne("Вы выбрали 7 октября");
                }

                key = Console.ReadKey();
            }


        }
        static void StrelkaOne(string selectedDate)
        {
            Console.WriteLine(selectedDate);
            int position = 1;
            ConsoleKeyInfo key = Console.ReadKey();

            while (key.Key != ConsoleKey.LeftArrow)
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                if (position == 0)
                {
                    position++;
                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                Console.Clear();
                fisrstOctober(selectedDate, new string[] { "   Дейлики геншин", "  Практические работы", "  Посмотреть аниме" });
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                key = Console.ReadKey();

            }
            if (key.Key == ConsoleKey.LeftArrow)
            {
                StrelkaMenu();
            }
            if (position == 1)
            {

                Console.Clear();
                Console.WriteLine();
            }
            if (position == 2)
            {
                Console.Clear();
                Console.WriteLine();
            }
            if (position == 3)
            {
                Console.Clear();
                Console.WriteLine();
            }
        }
    }
}
