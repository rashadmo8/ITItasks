namespace day3task
{
    internal class day3Task
    {
        public class calc
        {
            int sum(int x, int y)
            {
                return x + y;
            }
            double sum(double x, double y)
            {
                return x + y;
            }
            double sum(double x, double y, double z,double l)
            {
                return x + y + z+l;
            }
            int sub(int x, int y)
            {
                return x - y;
            }
            double sub(double x, double y)
            {
                return x - y;
            }
            double sub(double x, double y, double z,double l)
            {
                return x - y - z-l;
            }
            int mul(int x, int y)
            {
                return x * y;
            }
            double mul(double x, double y)
            {
                return x * y;
            }
            double mul(double x, double y, double z, double l)
            {
                return x * y * z*l;
            }
            double div(double x, double y)
            {
                return x / y;
            }
            double div(double x, double y, double z, double l)
            {
                return ((x / y) / z)/l;
            }
        }



        public class quistion
        {
            public String header { get; set; }
            public String body{get ;set;}
            public int mark { get; set; }
            void show() 
            {
                Console.WriteLine($"header is {header} /t {mark}mark");
            }
            public quistion() 
            {
                header = "";
                mark = 0;
                body = "";
            }
            public quistion(String h , string b,int m)
            {
                header = h;
                mark = m;
                body = b;
            }
        }
        public class mcqQ 
        {
           public quistion Q1 = new quistion();
           public String[] ans = new string[4];
            public override string ToString()
            {
                return $"header={Q1.header} mark={Q1.mark}\n {ans[0]}   {ans[1]}  {ans[2]}  {ans[3]} ";
            }
        }
        static void Main(string[] args)
        {

            //mcqQ mc = new mcqQ();
            //Console.WriteLine(mc);
            Console.WriteLine("aa");
            mcqQ[] mm = new mcqQ[4];
          
            for (int i = 0; i < 4; i++)
            {
                mm[i] = new mcqQ();
                Console.WriteLine("inter header");
                String h =Console.ReadLine();
                Console.WriteLine("inter body");
                String b =Console.ReadLine();    
                Console.WriteLine("inter mark");
                int m=int.Parse(Console.ReadLine()); 

                mm[i].Q1 = new quistion() {header= h, body= b, mark= m };


                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"inter {j} chooses");
                    mm[i].ans[j] = Console.ReadLine();

                }

            }
            int res = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(mm[i]);
                Console.WriteLine("inter ur anser");
                String A=Console.ReadLine();

                if (A == mm[i].Q1.body)
                {
                    res += mm[i].Q1.mark;
                }
            }
            Console.WriteLine(res);


        }

        
       
    }
}
