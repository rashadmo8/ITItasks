namespace day1
{
    internal class day1Task
    {
        static void Main(string[] args)
        {
           char x=  char.Parse( Console.ReadLine());
            Console.WriteLine((int)x);

            int y = int.Parse( Console.ReadLine());
            if (y % 2 == 0)
                Console.WriteLine("y is even");
            else
                Console.WriteLine("y is odd");


            int z = int.Parse(Console.ReadLine()); ;

            Console.WriteLine(z + y);

            Console.WriteLine(z - y);

            Console.WriteLine(z * y);



            for (int i = 1; i <= 12; i++)
            {
               for (int j = 1; j <= 12; j++)
                {
                    Console.WriteLine(i * j);
                }
            }


            int degree = int.Parse(Console.ReadLine());
            if (degree >= 90)
                Console.WriteLine("A");
            else if (degree >= 75 && degree < 90)
                Console.WriteLine("B");
            else if (degree >= 50 && degree < 75)
                Console.WriteLine("C");
            else
                Console.WriteLine("F");



        }
    }
}
