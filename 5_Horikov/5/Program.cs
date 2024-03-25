namespace Five
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string strokaInput = Console.ReadLine();
            string[] stroka = strokaInput.Split(' ');
            string itemOutput = "";
            int k = 0;
            foreach (string item in stroka)
            {
                if (item.Length > k)
                {
                    k = item.Length;
                    itemOutput = item;
                }
            }
            Console.WriteLine(itemOutput);
            Console.ReadLine();
        }
    }
}