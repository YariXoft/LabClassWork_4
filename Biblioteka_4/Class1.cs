using System;

namespace Biblioteka_4
{
    public class Car
    {
        public string Number { get; set; }
        public string Color { get; set; }

        public Car(string number, string color)
        {
            Number = number;
            Color = color;
        }
    }

    public class CarGenerator
    {
        private Random random;

        public CarGenerator()
        {
            random = new Random();
        }

        public Car GenerateRandomCar()
        {
            string number = GenerateRandomCarNumber(); // генеруємо номер авто - XX 0000 XX
            string[] colors = { "Бiрюзова", "Жовта", "Чорна", "Бiла" };
            string color = colors[random.Next(0, colors.Length)];

            return new Car(number, color);
        }

        private string GenerateRandomCarNumber()
        {
            char[] bukvy = "АБВГДЕЄЖЗИIЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ".ToCharArray();
            int[] cifry = { random.Next(0, 10), random.Next(0, 10), random.Next(0, 10), random.Next(0, 10) };           

            string carNumber = 
                $"{bukvy[random.Next(0, bukvy.Length)]}{bukvy[random.Next(0, bukvy.Length)]} " +
                $"{cifry[0]}{cifry[1]}{cifry[2]}{cifry[3]} " +
                $"{bukvy[random.Next(0, bukvy.Length)]}{bukvy[random.Next(0, bukvy.Length)]}";//тут теба код регіона, я спростив

            return carNumber;
        }
    }
}
