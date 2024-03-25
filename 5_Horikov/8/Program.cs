namespace Eight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество ступеней:");
            int k = Convert.ToInt32(Console.ReadLine());
            string stroka = "";
            for (int i = 1; i < k+1; i++)
            {
                stroka += Convert.ToString(i);
                Console.WriteLine(stroka);
            }
            Console.ReadLine();
        }
    }
}