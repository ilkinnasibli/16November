namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            int num1;
            int sum = 0;
            Console.WriteLine("Arrayin uzunlugunu daxil edin :");
            num1 = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[num1];
            for (int i = 0; i < num1; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    sum = sum + item;


                }
            }
            Console.WriteLine("Cut ededlerin cemi :");
            Console.WriteLine(sum);
        }
    }
}