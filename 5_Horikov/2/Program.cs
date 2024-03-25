namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Два числа через enter");
            int one = Convert.ToInt32(Console.ReadLine());
            int two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Сложение\r\n" +
                "2.Вычитание\r\n" +
                "3.Умножение\r\n" +
                "4.Деление\r\n" +
                "5.Нахождение остатка\r\n");
            string answer =Console.ReadLine();
            if (answer == "1") 
            {
                Console.WriteLine(one + two);
            } else if (answer == "2") 
            {
                Console.WriteLine(one - two);
            } else if (answer == "3") 
            {
                Console.WriteLine(one * two);
            } else if (answer == "4") 
            {
                Console.WriteLine(one / two);
            } else if(answer == "5") 
            {
                Console.WriteLine(one % two);
            }
            Console.ReadLine();
        }
    }
}