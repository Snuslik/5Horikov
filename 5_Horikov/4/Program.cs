namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к файлу");
            string path = Console.ReadLine();
            string[] line = path.Split('/');
            string typefile = "0";
            foreach (var item in line)
            {
                foreach (var item1 in item)
                {
                    if (item1 == '.')
                    {
                        string[] file = item.Split('.');
                        typefile = file[1];
                    }
                }
            }
            Console.WriteLine(typefile);
            Console.ReadLine();
        }
    }
}