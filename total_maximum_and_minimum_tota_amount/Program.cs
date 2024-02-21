namespace total_maximum_and_minimum_tota_amount
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            float[,] b = new float[3, 4];

            Console.WriteLine("Заполните одномерный массив a:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            Random random = new Random();
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = (float)random.NextDouble() * 100; // Генерация случайного дробного числа от 0 до 100
                }
            }

            Console.Write("Одномерный массив a: ");
            foreach (int element in a)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Двумерный массив b:");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            float maxElement = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > maxElement)
                {
                    maxElement = a[i];
                }
            }
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    if (b[i, j] > maxElement)
                    {
                        maxElement = b[i, j];
                    }
                }
            }
            Console.WriteLine("Общий максимальный элемент: " + maxElement);

            float minElement = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < minElement)
                {
                    minElement = a[i];
                }
            }
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    if (b[i, j] < minElement)
                    {
                        minElement = b[i, j];
                    }
                }
            }
            Console.WriteLine("Общий минимальный элемент: " + minElement);

            float sum = 0;
            foreach (int element in a)
            {
                sum += element;
            }
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    sum += b[i, j];
                }
            }
            Console.WriteLine("Общая сумма всех элементов: " + sum);

            float product = 1;
            foreach (int element in a)
            {
                product *= element;
            }
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    product *= b[i, j];
                }
            }
            Console.WriteLine("Общее произведение всех элементов: " + product);

            int evenSum = 0;
            foreach (int element in a)
            {
                if (element % 2 == 0)
                {
                    evenSum += element;
                }
            }
            Console.WriteLine("Сумма четных элементов массива a: " + evenSum);

            int oddColumnSum = 0;
            for (int j = 0; j < b.GetLength(1); j++)
            {
                if (j % 2 != 0)
                {
                    for (int i = 0; i < b.GetLength(0); i++)
                    {
                        oddColumnSum += (int)b[i, j];
                    }
                }
            }
            Console.WriteLine("Сумма нечетных столбцов массива b: " + oddColumnSum);

            Console.ReadLine();
        }
    }
}
