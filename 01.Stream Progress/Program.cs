using System;

namespace _01.Stream_Progress
{
    public class Program
    {
        public static void Main()
        {
            IStream stream = new Music("Mario", "MyAlbum", 1200, 512);
            StreamProgressInfo info = new StreamProgressInfo(stream);

            Console.WriteLine(info.CalculateCurrentPercent());
        }
    }
}