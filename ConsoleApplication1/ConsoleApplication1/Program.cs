using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public interface abc
        {
            
            void process(int a, int b);
        }
   
        public class addition:abc
        {
            int x, y;
            public void process(int a, int b)
            {
                x = a;
                y=b;
                Console.Write("The result of addition is:{0}\n", x + y);
            }
        }

        public class subtraction : abc
        {
            int x, y;
            public void process(int a,int b)
            {
                x = a;
                y = b;
                Console.Write ("The result of subtraction is:{0}\n", x - y);
            }
        }

        public class multiplication : abc
        {
            int x, y;
            public void process(int a, int b)
            {
                x = a;
                y = b;
                Console.Write ("The result of multiplication is:{0}\n", x * y);
            }
        }

        public class division : abc
        {
            int x, y;
            public void process(int a, int b)
            {
                x = a;
                y = b;
                Console.Write ("The result of division is:{0}\n", x / y);
            }
        }
        static void Main(string[] args)
        {
            addition a = new addition ();
            subtraction b = new subtraction ();
            multiplication c = new multiplication ();
            division d = new division ();
            int i, j;
            Console.WriteLine ("enter the first integer:");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine ("enter the first integer:");
            j = Convert.ToInt32 (Console.ReadLine());
            a.process (i,j);
            b.process (i,j);
            c.process (i,j);
            d.process (i,j);
            Console.ReadKey ();
        }
    }
}
