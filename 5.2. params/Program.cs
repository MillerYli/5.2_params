using System;
using System.Drawing;
using System.Xml.Linq;

namespace MainSpase
{
    class Program
    {
        static string GetColor(string username, int userage)
        {
            Console.WriteLine("{0}, {1} лет\nВведите свой любимый цвет на английском, с маленькой буквы", username, userage);

            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("This is your super color!");
                    break;
            }
            return color;
        }
        static void ShowColor(string username, params string[] favecolor)        //массив params для передачи неопр. кол-ва параметров
        {

            Console.WriteLine(username + " ваши любимые цвета: ");
            foreach (var color in favecolor)
            {
                Console.WriteLine(color);
            }
        }

        public static void Main(string[] args)
        {
            var (name, age) = ("Евгений", 27);

            Console.WriteLine("Мое имя: " + name);
            Console.WriteLine("Мой возраст: " + age);

            Console.WriteLine("Введите Ваше имя");
            name = Console.ReadLine();
            Console.WriteLine("Введите Ваш возраст");
            age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ваше имя: " + name);
            //Console.WriteLine("Ваш возраст: " + age);
            var favecolor = new string[3];

            for (int i = 0; i < favecolor.Length; i++)
            {
                favecolor[i] = GetColor(name, age);
            }
            //ShowColor(name, favecolor);      //Вывод только первого и последнего элемента(можно убрать параметры совсем)
            ShowColor(name, "red", "cyan");     //можно указать нужные параметры с помощью литералов
        }
    }
}
