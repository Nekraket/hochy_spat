namespace ConsoleApp2
{
    internal class Program
    {
        //1.Описать метод int CountBits(int num), производящий подсчет значащих битов в числе.
        //Перевести число в двоичное представление можно с помощью перегруженной версии метода Convert.ToString, посчитать с помощью обычного цикла
        //4 = 100 => 1
        //10 = 1010 => 2
        //1 = 1 => 1
        //32 = 100000 => 1
        public static int CountBits(int num)
        {
            int bit = 0;
            while (num > 0)
            {
                if ((num & 1) == 1)
                {
                    bit++;
                }
                num >>= 1;
            }
            return bit;
        }

        //2.Описать метод int Persistence(int num), который считает мультипликативную стойкость числа.
        //Это то количество раз, сколько все цифры в числе нужно перемножить между собой, чтобы получить однозначное число(для исходно однозначных чисел = 0)
        //39 => 3(3 * 9 = 27; 2 * 7 = 14; 1 * 4 = 4)
        //9 => 0
        //999 => 4(9 * 9 * 9 = 729; 7 * 2 * 9 = 126; 1 * 2 * 6 = 12; 1 * 2 = 2)
        public static int Persistence(int num)
        {
            int count = 0;
            while (num >= 10)
            {
                int AAA = 1;
                while (num > 0)
                {
                    AAA *= num % 10;
                    num /= 10;
                }
                num = AAA;
                count++;
            }
            return count;
        }

        //3.Описать метод int DigitalRoot(int num) для подсчета цифрового корня числа.
        //Цифровой корень -это рекурсивная сумма всех цифр в числе, пока она не станет равна однозначному числу
        //16 => 1 + 6 = 7
        //942 => 9 + 4 + 2 = 15 => 1 + 5 = 6
        public static int DigitalRoot(int num)
        {
            while (num >= 10)
            {
                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                num = sum;
            }
            return num;
        }


        //-------------------------------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            int count = CountBits(num);
            Console.WriteLine($"Количество значащих битов в {num}: {count}");

            int num2 = Int32.Parse(Console.ReadLine());
            int count2 = Persistence(num2);
            Console.WriteLine($"мультипликативную стойкость числа {num2}: {count2}");

            int num3 = Int32.Parse(Console.ReadLine());
            int count3 = DigitalRoot(num3);
            Console.WriteLine($"мультипликативную стойкость числа {num3}: {count3}");
        }
    }
}
