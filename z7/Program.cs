namespace z7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пять чисел:");
            string input1 = Console.ReadLine();
            string[] mas1 = input1.Split(' ');
            if (mas1.Length == 5 )
            {
                int[] mas11 = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    mas11[i] = Convert.ToInt32(mas1[i]);
                }
                int max = 0;
                int min = 999999;
                for (int i = 0; i < 5; i++)
                {
                    if (mas11[i] > max)
                    {
                        max = mas11[i];
                    }
                    if (mas11[i] < min)
                    {
                        min = mas11[i];
                    }
                }
                Console.WriteLine("Максимальное число:\r\n" +
                    (max) +
                    "\r\n" +
                    "Минимальное число:\r\n" +
                    (min));
            }
            else
            {
                Console.WriteLine("Ошибка вы ввели не пять чисел, перезапустите программу.");
            }
        }
    }
}