using System;
using System.Collections.Generic;
using System.Linq;


namespace squaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random random = new Random();

            List<int> randomNumList = new List<int>();
            List<int> sqrdRanNumList = new List<int>();
            
            for (int i = 0; i < 21; i++) {
                randomNumList.Add(random.Next(1, 21));
            }
            foreach (int r in randomNumList) {
                sqrdRanNumList.Add(r*r);
            }
            foreach (int s in sqrdRanNumList.ToList()) {
                if ((s % 2) != 0) {
                    sqrdRanNumList.Remove(s);
                } else {
                    Console.WriteLine(s);
                }
            }

            
        }
    }
}
