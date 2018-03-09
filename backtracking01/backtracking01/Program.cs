using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backtracking01
{
    public class Backtracking
    {
        // taken from https://www.youtube.com/watch?v=78t_yHuGg-0 choose, explore, unchoose

        public void Accumulate(string s, string chosen)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine(chosen);
                return;
            }
            for (int i = 0; i < s.Length; i++)
            {
                // choose
                char c = s[i];

                // explore
                Accumulate(s.Remove(i, 1), chosen + c);

                // unchoose
            }
        }

        public void Permute(string s)
        {
            Accumulate(s, string.Empty);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = "MARTY";
            Backtracking bt = new Backtracking();
            bt.Permute(input);
            Console.ReadLine();
        }
    }
}