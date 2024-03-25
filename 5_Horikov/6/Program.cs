namespace Six
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения для первого массива через пробел:");
            string stroka1Input = Console.ReadLine();
            Console.WriteLine("Введите значения для второго массива через пробел:");
            string stroka2Input = Console.ReadLine();
            string[] stroka1 = stroka1Input.Split(' ');
            string[] stroka2 = stroka2Input.Split(' ');
            int[] stroka = new int[stroka1.Length];
            for (int i = 0; i < stroka1.Length; i++)
            {
                stroka[i] = Convert.ToInt32(stroka1[i]) * Convert.ToInt32(stroka2[i]);
            }
            Console.WriteLine("");
            foreach (int item in stroka)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}