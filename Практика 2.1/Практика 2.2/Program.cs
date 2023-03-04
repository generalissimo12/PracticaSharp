using Практика_2._2;

namespace Практика_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student pat = new Student();

            int res = 0;
            Console.WriteLine("Меню выбора:\n" +
                "1 - Изменить Фамилию\n" +
                "2 - Изменить дату рождения\n" +
                "3 - Изменить группу\n" +
                "4 - Вывод информации\n" +
                "5 - Выход из меню");

            while (res != 5)
            {
                res = Convert.ToInt32(Console.ReadLine());
                if (res == 5) break;

                switch (res)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите фамилию");
                            pat.Surn = Console.ReadLine();
                            Console.WriteLine($"новая фамилия: {pat.Surn}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите дату");
                            pat.Date = Console.ReadLine();
                            Console.WriteLine($"новая дата: {pat.Date}");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите группу");
                            pat.Group = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"новая группа: {pat.Group}");
                            break;
                        }
                    case 4:
                        Console.WriteLine($"Фамилия: {pat.Surn}");
                        Console.WriteLine($"Дата рождения: {pat.Date}");
                        Console.WriteLine($"Группа: {pat.Group}");
                        Console.Write($"Оценки: ");
                        foreach (var num in pat.Mark)
                        {
                            Console.Write($"{num} ");
                        }
                        Console.WriteLine(" ");
                        break;
                }
            }
        }
    }
}