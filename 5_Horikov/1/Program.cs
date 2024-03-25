namespace Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Напишите первое число");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите второе число");
            int two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите третье число");
            int three = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите четвортое число");
            int four = Convert.ToInt32(Console.ReadLine());
            int sum = one + two + three + four;
            Console.WriteLine(sum/4);
            Console.ReadLine();
        }
    }
}