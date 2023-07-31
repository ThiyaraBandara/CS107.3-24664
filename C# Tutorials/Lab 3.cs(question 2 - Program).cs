using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230523___Lab_Session
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 2, 4, 6};
            int[] y = { 3, 6, 9 };

            int scoreX = 0;
            int scoreY = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (x[i] > y[i])
                {
                    scoreX++;
                } else if (x[i] < y[i])
                {
                    scoreY++;
                }
            }

            Console.WriteLine("Anura's Score: " + scoreX);
            Console.WriteLine("Bhagya's Score: " + scoreY);

            
        }
    }
}
