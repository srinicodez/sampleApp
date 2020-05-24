using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            int s = 0;
            int q= 0;

            Program p = new Program();

           s = p.Add(a, b);
            q = p.subs(a, b);

        }

        public int Add(int i ,int j)
        {
            return i + j;
        }

        public int subs(int i , int j)
        {
            return i - j;
        }
    }
}
