namespace Three
{
    internal class Program
    {
        class TemperatureConvert
        {

            static void Main(string[] args)
            {
                Console.WriteLine("Выберите шкалу вводимой температуры:");
                Console.WriteLine("1. Цельсий\r\n" +
                    "2. Кельвин\r\n" +
                    "3. Фаренгейт");
                string answer1 = Console.ReadLine();
                Console.WriteLine("Введите показатель температура (градусы):");
                int answer2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Выберите тип шкалы для конвертации:");
                Console.WriteLine("1. Цельсий\r\n" +
                    "2. Кельвин\r\n" +
                    "3. Фаренгейт");
                string answer3 = Console.ReadLine();
                double result = 0;
                if (answer1 == answer3)
                {
                    result = answer2;
                } else if (answer1 == "1" & answer3 == "2")
                {
                    result = answer2 + 273.15;
                } else if (answer1 == "1" & answer3 == "3")
                {
                    result = answer2 * 9 / 5 + 32;
                } else if (answer1 == "2" & answer3 == "1")
                {
                    result = answer2 - 273.15;
                } else if (answer1 == "2" & answer3 == "3")
                {
                    result = answer2 * 9 / 5 - 459.67;
                } else if (answer1 == "3" & answer3 == "1")
                {
                    result = (answer2 - 32) * 5 / 9;
                } else if (answer1 == "3" & answer3 == "2")
                {
                    result = (answer2 + 459.67) * 5 / 9;
                } else
                {
                    Console.WriteLine("Неыерный выбор шкалы для конвертации");
                }



                    Console.WriteLine("Вы выбрали:" + answer1 + " -> " + answer3);
                Console.WriteLine("Результат конвертации: " + result);
                Console.ReadLine();
            }
        }
    }
}