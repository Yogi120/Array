namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int i;

            for (i=0; i<10; i++)
            {
                Console.Write("Elements {0} - " + i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i=0; i<10; i++)
            {
                Console.Write("All elements are " + a[i]);
            }
        }
    }
}