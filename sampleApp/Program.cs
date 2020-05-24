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

            Program p = new Program();

            p.Add(a, b);

        }

        public int Add(int i ,int j)
        {
            return i + j;
        }
    }
}
