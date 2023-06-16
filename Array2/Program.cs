namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
           int[] arr = new int[100];

            Console.WriteLine("Enter the number of elements to print");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("Elements ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("All elements are " + arr[i]);
            }

            for (i = n - 1; i >= 0; i--)
            {
                Console.WriteLine("In reverse " + arr[i]);
            }
        }
    }
}