namespace Modul_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 4.1.4
            string A = "abc" ;
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

        }
    }
    
}