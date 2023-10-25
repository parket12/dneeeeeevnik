using System;

namespace DailyPlanner
{
    internal class Program
    {
        static DateTime currentDate = DateTime.Now;
        static string[] tasks = new string[]
        {
            "Прочесть 50 страниц книги",
            "Сделать практику по бд",
            "Сьесть яблоко",
            "Пробежать марафон",
            "Разработать план атаки на Беларусь",
        };

        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                Console.WriteLine("SELECTED DATE: " + currentDate);
                DisplayMenu();
                int position = 1;
                ShowArrow(position);
                DisplayTask(position);
                key = Console.ReadKey();
            } while (key.Key == ConsoleKey.Escape);
        }

        static int ShowArrow(int position)
        {
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if (position == 0)
                    {
                        position = tasks.Length;
                    }
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position > tasks.Length)
                    {
                        position = 1;
                    }

                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                ChangeDate(key);
            } while (key.Key != ConsoleKey.Enter);
            return position;
        }

        static void ChangeDate(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                currentDate = currentDate.AddDays(-1);
                Console.Clear();
                Console.WriteLine("SELECTED DATE: " + currentDate);
                DisplayMenu();

            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                currentDate = currentDate.AddDays(1);
                Console.Clear();
                Console.WriteLine("SELECTED DATE: " + currentDate);
                DisplayMenu();

            }
        }

        static void DisplayMenu()
        {
            if (currentDate.Date == new DateTime(2023, 10, 18))
            {
                Console.WriteLine($"  1. {tasks[0]}");
            }
            else if (currentDate.Date == new DateTime(2023, 10, 24))
            {
                Console.WriteLine($"  1. {tasks[1]}");
            }
            else if (currentDate.Date == new DateTime(2023, 10, 5))
            {
                Console.WriteLine($"  1. {tasks[2]}");
            }
            else if (currentDate.Date == new DateTime(2023, 10, 3))
            {
                Console.WriteLine($"  1. {tasks[3]}");
            }
            else if (currentDate.Date == new DateTime(2023, 10, 29))
            {
                Console.WriteLine($"  1. {tasks[4]}");
            }
        }

        static void DisplayTask(int position)
        {
            int taskIndex = GetTaskIndex(currentDate);
            if (position == 1 && taskIndex == 1)
            {
                Console.Clear();
                Console.WriteLine(tasks[1]);
                Console.WriteLine("----------------");
                Console.WriteLine("Сделать практику по SQL, сдай это до завтра, или не успеешь и придеться сдавать так же как и этот практос))");
                Console.WriteLine("Your date: " + currentDate);
            }
            else if (position == 1 && taskIndex == 2)
            {
                Console.Clear();
                Console.WriteLine(tasks[0]);
                Console.WriteLine("----------------");
                Console.WriteLine("читать надо, чтобы не тупеть. Правда уже поздно, но я все равно постараюсь");
                Console.WriteLine("Your date: " + currentDate);
            }
            else if (position == 1 && taskIndex == 3)
            {
                Console.Clear();
                Console.WriteLine (tasks[2]);
                Console.WriteLine("----------------");
                Console.WriteLine("Яблоки нужны, витамины лишними не будут");
                Console.WriteLine("Your date: " + currentDate);
            }
            else if (position == 1 && taskIndex == 0)
            {
                Console.Clear();
                Console.WriteLine(tasks[3]);
                Console.WriteLine("----------------");
                Console.WriteLine("ну а что, когда марафоны то не бегали");
                Console.WriteLine("Your date: " + currentDate);
            }
            else if (position == 1 && taskIndex == 4)
            {
                Console.Clear();
                Console.WriteLine(tasks[4]);
                Console.WriteLine("----------------");
                Console.WriteLine("меньше вопросов = меньше ответов ");
                Console.WriteLine("Your date: " + currentDate);
            }
        }
        static int GetTaskIndex(DateTime date)
        {
            if (date.Date == new DateTime(2023, 10, 5))
            {
                return 3;
            }
            else if (date.Date == new DateTime(2023, 10, 3))
            {
                return 0;
            }
            else if (date.Date == new DateTime(2023, 10, 18))
            {
                return 2;
            }
            else if (date.Date == new DateTime(2023, 10, 24))
            {
                return 1;
            }
            else if (date.Date == new DateTime(2023, 10, 29))
            {
                return 4;
            }
            return 0;
        }
    }
}