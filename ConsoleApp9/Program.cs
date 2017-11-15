using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fac
{

    class fa
    {

        static void Main()
        {
            int num, res = 1, m = 1;
            Console.WriteLine("dame un numero\n");
            num = int.Parse(Console.ReadLine());

            Console.Write("{0}!!=", num);
            while (num > 1)
            {
                Console.Write("{0} ", num);
                if (num != 2)
                    Console.Write("*");
                facto(ref num, out res, m);
                m = res;
            }

            if (num == 1)
                Console.WriteLine("{0}={1}", num, res);
            else
                Console.WriteLine("={0}", res);

            Console.ReadKey();
        }


        public static void facto(ref int num, out int res, int m)
        {
            res = m * num;
            num = num - 2;
        }



    }





}
