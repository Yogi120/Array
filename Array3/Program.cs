using System.Diagnostics.CodeAnalysis;

namespace Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum;
            sum = 0;
            int[] arr = new int[100];
            Console.WriteLine("How many elements do you want sum of : ");
            int n = Convert.ToInt32(Console.ReadLine());
            // arr[i] = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("all elements are ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of all ements are " + sum);
        }
    }
}