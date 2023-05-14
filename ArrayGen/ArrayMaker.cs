
using System.Diagnostics.CodeAnalysis;

namespace ArrayGen
{
    public class ArrayMaker
    {
        public static int[] Main()
        {
            int[] array = new int[10];
            int sum = 0;
            int count = 0;
            Random rand = new Random();
            Console.WriteLine("Сгенерированный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
                sum += array[i];
                if (array[i] > 0)
                    count++;
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\nСумма всех элементов массива: " + sum);

            Console.WriteLine("Количество положительных элементов: " + count);

            return array;
        }

        public static int Summing(int[] expectedArray)
        {
            int sum = 0;
            for (int i = 0; i < expectedArray.Length; i++)
            {
                sum += expectedArray[i];
            }
            return sum;
        }
    }
}