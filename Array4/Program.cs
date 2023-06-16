namespace Array4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] arr2 = new int[100]; 
            int[] arr = new int[100];
            Console.WriteLine("Enter the number of element to copied : ");
            int n = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i < n; i++)
            {
                Console.Write("Elements are ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                arr2[i] = arr[i];
            }

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Original Array is " + arr[i]);
            }


            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Copied Array is " + arr2[i]);
            }
        }
    }
}