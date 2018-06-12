using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[52];
            int randomNumber = 0;
            Random rnd = new Random();
            for (int i = 0; i < 52;)
            {
                randomNumber = rnd.Next(1, 53); // generates random number between 1 and 52
                if (!arr.Contains(randomNumber))
                {
                    arr[i] = randomNumber;
                    i++;
                }
            }
        }
    }
}
