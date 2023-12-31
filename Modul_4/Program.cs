﻿namespace Modul_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 4.1.4
            string A = "abc";
            string B = "123";
            bool C = A != B;

            //Задание 4.1.5
            int AA = 0;
            int BB = 1;
            double X = 0.0;
            double Y = 1.0;
            bool CC = (AA < BB) | (X > Y);

            //Задание 4.1.10
            var inv = true;
            var result = !inv;
            Console.WriteLine(result);

            //Задание 4.1.12
            var a = 6;
            var b = 7;

            if (a != b)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");
            }

            //Задание 4.1.17
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }

            //Задание 4.1.18
            switch (Console.ReadLine())
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

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            //Задание 4.2.11
            Console.WriteLine("Цикл do");
            int t = 0;

            do
            {
                Console.WriteLine(t);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
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

                        Console.WriteLine("Your color is yellow!");
                        break;
                }

                t++;
            } while (t < 3);

            //Задание 4.3.7
            string name2 = "Ilya";
            for (int i = name2.Length - 1; i >= 0; i--)
            {
                Console.Write(name2[i]);
            }


            //Задание 4.3.11
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                    Console.Write(array[i, k] + " ");

                Console.WriteLine();
            }
            //Задание 4.3.12
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach (var item in arr)
            {
                Console.Write(item);
            }

            //Задание 4.3.13
            var arr2 = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int sum = 0;
            foreach (var item in arr2)
            {
                sum += item;
            }
            Console.WriteLine(sum);

            //Задание 4.3.14
            int[][] array2 = new int[3][];

            array2[0] = new int[2] { 1, 2 };
            array2[1] = new int[3] { 1, 2, 3 };
            array2[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var num in array2)
            {
                foreach (var item in num)
                {
                    Console.Write(item + " ");
                }
            }

            //Задание 4.3.15
            int[] array3 = new int[10];
            Random random = new Random();
            sum = 0;
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = random.Next(-100, 100);
            }
            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i]>0) { sum++; }
            }
            Console.WriteLine(sum);


            //Задание 4.3.16
            int[,] arr4 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            sum = 0;
            foreach(var item in arr4)
            {
                if (item > 0)
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);

            //Задание 4.3.17
            int[,] arr5 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            for(int i =0; arr4.GetUpperBound(0) > 0; i++)
            {
                for(int j = 0; arr4.GetUpperBound(1)>0;j++ )
                {
                    for(int k = j+1; k<arr4.GetUpperBound(1); k++)
                    {
                        if (arr4[i, j] > arr4[i,k])                         
                        {
                            sum = arr4[i, k];
                            arr4[i,k] = arr4[i,j];
                            arr4[i, j] = sum;
                        }
                    }
                }
            }

            //Задание 4.4.2
            (string name, int age) anketa;
            

            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

            //Задание 4.4.3
            var (name, age) = ("Евгения", 27);

            Console.WriteLine("Моё имя: {0}", name);
            Console.WriteLine("Мой возраст: {0}", age);

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            //Задание 4.4.5
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.WriteLine("Введите имя питомца");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;

            Console.WriteLine("Введите вид питомца");
            Pet.Type = Console.ReadLine();

            Console.WriteLine("Введите возрас питомца");
            Pet.Age = double.Parse(Console.ReadLine());

            //Задание 4.5.1 - Задание 4.5.6

            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

            for (int k = 0; k < 3; k++)
            {

                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");

                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин");

                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");

                var result2 = Console.ReadLine();

                if (result2 == "Да")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }

                Console.WriteLine("Введите возраст пользователя");

                User.Age = double.Parse(Console.ReadLine());

                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");

                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }
            }
        }
    }
    
}