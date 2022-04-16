using System;
using System.Threading;

namespace Pertemuan3_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            WithoutThread();

            Console.WriteLine("\n\n Do Tash With Thread \n\n");

            WithThread();


            Console.ReadLine();
        }

        static void WithThread()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("|| Mulai Melakukan Pekerjaan ||");
            Console.WriteLine("===============================");

            Thread tid1 = new Thread(new ThreadStart(Program.Thread1));
            Thread tid2 = new Thread(new ThreadStart(Program.Thread2));

            tid1.Start();
            tid2.Start();

            //if (!tid1.IsAlive && !tid2.IsAlive)
            //{
            //    Console.WriteLine("===============================");
            //    Console.WriteLine("||          Selseai          ||");
            //    Console.WriteLine("===============================");
            //}
        }

        static void WithoutThread()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("|| Mulai Melakukan Pekerjaan ||");
            Console.WriteLine("===============================");

            cuci();
            setrika();

            Console.WriteLine("===============================");
            Console.WriteLine("||          Selseai          ||");
            Console.WriteLine("===============================");
        }

        static void Thread1()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Cuci Baju ke {0}", i);
                Thread.Sleep(3000);
            }
        }

        static void Thread2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Setrika ke {0}", i);
                Thread.Sleep(3000);
            }
        }

        static void cuci()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Cuci Baju ke {0}", i);
            }
        }

        static void setrika()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Setrika ke {0}", i);
            }
        }
    }
}
