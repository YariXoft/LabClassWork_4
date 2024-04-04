using Biblioteka_4;//бібліотека до четвертоі пари
using System;
using ParniChyslaNamespace;
using NeParniChyslaNamespace;
using ProsteChyslo;
using FibonacciNumbersGenerator;
using TrykutnykNamespace;
using GameVgadayChyslo;
using PsevdotextGenNameSpace;

namespace ClassWork_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0 перевірка роботи білбіотеки
            CarGenerator carGen = new CarGenerator(); 
            Car randomCar = carGen.GenerateRandomCar();

            Console.WriteLine("0. (testing library)\nСгенерована автiвка:");
            Console.WriteLine($"Номер: {randomCar.Number}");
            Console.WriteLine($"Колiр: {randomCar.Color}\n");
            
            //////////////////////Лабораторна робота////////////////////////

            //1 генерація парного числа 2 - 10
            RandomNumbGen randomNumbGen = new RandomNumbGen();
            int num1 = randomNumbGen.GenParniRandNum();
            Console.WriteLine($"1. Рандомне парне число 2-10: {num1}");

            //1 непарне число: 1 - 9
            NeParniRandomNumbGen neParniRandomNumbGen = new NeParniRandomNumbGen();
            int nepNum = neParniRandomNumbGen.NeParniGenParniRandNum();
            Console.WriteLine($"1. Рандомне непарне число 1-9: {nepNum} ");

            //1 генератор: просте число
            MyRandomProsteChisloGen randomProsteChisloGen = new MyRandomProsteChisloGen();
            int proste = randomProsteChisloGen.GenProsteChislo();
            Console.WriteLine($"1. Генерацiя простого числа вiд 2 до 10_000: {proste}");

            //1 генератор: число Фібоначчі
            MyRandomFibonacci myRandomFibonacci = new MyRandomFibonacci();
            int fib = myRandomFibonacci.GenerateFibonacciNumber();
            Console.WriteLine($"1. Генерацiя числа Фiбоначчi вiд 2 до 10_000: {fib}");

            //////////////////////////////////////////////////////////////////////////////

            //2 Трикутник (вибачте, я тільки трикутник зроблю, дуже медленно просто роблю)

            Trykutnyk trykutnyk = new Trykutnyk(3, 4, 5);

            Console.Write($"\n2. ");
            trykutnyk.DisplayTriangleInfo();

            //////////////////////////////////////////////////////////////////////////////

            //3 гра Вгадай число

            Console.WriteLine("\n3. Введiть дiапазон чисел для гри Вгадай число");
            Console.Write("Мiнiмальне: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Максимальне: ");
            int max = int.Parse(Console.ReadLine());

            Game.StartGame(min, max);

            //4 спевдотекст
            Console.WriteLine("\n4. Генератор псевдотексту");
            Console.WriteLine("Введiть голоснi латинськi символи без пробiлiв:");
            string golosni = Console.ReadLine();

            Console.WriteLine("Введiть приголоснi латинськi символи (без пробiлiв):");
            string prygolosni = Console.ReadLine();

            Console.WriteLine("Введiть максимальну довжину слова:");
            int maxLength = int.Parse(Console.ReadLine());

            PsevdotextGen psevdotextGen = new PsevdotextGen();
            string psevdoText = psevdotextGen.GenPsevdotext(golosni, prygolosni, maxLength);
            Console.WriteLine(psevdoText);


        }
    }
}
