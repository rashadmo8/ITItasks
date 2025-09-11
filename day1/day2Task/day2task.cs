using System.Xml.Linq;

namespace day2Task
{
    internal class day2task
    {
        static void Main(string[] args)
        {

            Console.WriteLine("inter num of student");
            int x = int.Parse(Console.ReadLine());
            String[] STname = new string[x];
            for (int i = 0; i < STname.Length; i++)
            {
                STname[i] = Console.ReadLine();
            }
            for (int i = 0; i < STname.Length; i++)
            {
                Console.WriteLine(STname[i]);
            }



            Console.WriteLine("inter num of tracks");

            int numTracks = int.Parse(Console.ReadLine());

            int[][] tracksARR = new int[numTracks][];

            for (int i = 0; i < numTracks; i++)
            {
                Console.WriteLine($"inter num of student of {i + 1} track ");
                int y = int.Parse(Console.ReadLine());
                tracksARR[i] = new int[y];

            }
            double AVGage = 0;
            for (int i = 0; i < tracksARR.Length; i++)
            {
                for (int j = 0; j < tracksARR[i].Length; j++)
                {

                    tracksARR[i][j] = int.Parse(Console.ReadLine());
                    AVGage += tracksARR[i][j];

                }
                Console.WriteLine($" AVGage of track {i + 1} {AVGage / tracksARR[i].Length}");
                AVGage = 0;
            }


            TIME T1 = new TIME();
            T1.hours = 2;
            T1.minutes = 3; 
            T1.seconds = 4;
            Console.WriteLine(T1);
          
            

        }
    }
}
