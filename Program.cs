using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Forest.ForestsCreated);
            Forest f1 = new Forest("Amazon", "Its a big rainforest.");
            Forest f2 = new Forest("Sam Houston National Forest", "The largest forest in Texas.");
            Console.WriteLine(Forest.ForestsCreated);
        }
    }
}
