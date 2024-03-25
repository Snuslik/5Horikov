namespace Seven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пять чисел:");
            string[] stroka = Console.ReadLine().Split(' ');
            int min = 10000000;
            int max = -10000000;
            foreach (var item in stroka)
            {
                if (Convert.ToInt32(item) > max)
                {
                    max = Convert.ToInt32(item);
                } else if (Convert.ToInt32(item) < min)
                {
                    min = Convert.ToInt32(item);
                }
            }
            Console.WriteLine("Максимальное число: " + max);
            Console.WriteLine("Минимальное число: " + min);
            Console.ReadLine();
        }
    }
}