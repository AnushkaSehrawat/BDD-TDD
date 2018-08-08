using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class NoPointSegment
    {
        public string Intersection(int[] seg1, int[] seg2)
        {
            List<int> s1 = new List<int>(seg1);
            List<int> s2 = new List<int>(seg2);
                int x1 = s1[0];
                int y1 = s1[1];
                int x2 = s1[2];
                int y2 = s1[3];
                int x3 = s2[0];
                int y3 = s2[1];
                int x4 = s2[2];
                int y4 = s2[3];
            int A = y2 - y1;
            int B = x1 - x2;
            
    
            
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            string input = Console.ReadLine();
            NoPointSegment solver = new NoPointSegment();
            do
            {
                var segments = input.Split('|');
                var segParts = segments[0].Split(',');
                var seg1 = new int[4] { int.Parse(segParts[0]), int.Parse(segParts[1]), int.Parse(segParts[2]), int.Parse(segParts[3]) };
                segParts = segments[1].Split(',');
                var seg2 = new int[4] { int.Parse(segParts[0]), int.Parse(segParts[1]), int.Parse(segParts[2]), int.Parse(segParts[3]) };
                Console.WriteLine(solver.Intersection(seg1, seg2));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}
