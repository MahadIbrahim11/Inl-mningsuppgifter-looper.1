using System;
namespace inl_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10 till 30
            for (int i = 10; i <= 30; i++)
            {
                Console.WriteLine(i);
            }
            
            // 200 till 180
            for (int i = 200; i >= 180; i--)
            {
                Console.WriteLine(i);
            }

            // 1000 till 1400
            for (int i = 1000; i <= 1400; i += 50)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
