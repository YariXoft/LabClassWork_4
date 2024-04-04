using System;

namespace GameVgadayChyslo
{
    class Game
    {
        public static void StartGame(int min, int max)
        {
            Console.WriteLine("Гра Вгадай число");
            Console.WriteLine($"Загадайте число від {min} до {max}");

            Random random = new Random();
            int computerVgadue;
            int user;

            do
            {
                computerVgadue = random.Next(min, max + 1);
                Console.WriteLine($"Це число {computerVgadue} ? (1/0) -> (так - 1, нi - 0)");
                user = int.Parse(Console.ReadLine());

                while (user != 1 && user != 0)//перевірка
                {
                    Console.WriteLine("Ой! введiть 1(так) або 0(нi).");
                    user = int.Parse(Console.ReadLine());
                }

                if (user == 1)
                {
                    Console.WriteLine("Ура, Компiк:) виграв!");
                    break;
                }
                else
                {
                    Console.WriteLine("бiльше - натиснить 1, меньше - натиснить - 0:");
                    user = int.Parse(Console.ReadLine());

                    while (user != 1 && user != 0)
                    {
                        Console.WriteLine("Помилка, введіть 1 або 0.");
                        user = int.Parse(Console.ReadLine());
                    }

                    if (user == 1)
                    {
                        min  = computerVgadue + 1;
                    }
                    else
                    {
                        max = computerVgadue - 1;
                    }
                }
            } while (true);
        }
    }
}
