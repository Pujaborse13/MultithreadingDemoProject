using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutithreadingProject
{
    public class MultithreadingDemo
    {

       public async Task AllTask()
        {
            Thread thread1 = new Thread(PrintNumbers);
            thread1.Start();

            Thread thread2 = new Thread(PrintLetters);
            thread2.Start();



        }

        public static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} :  {i}");
                Thread.Sleep(2000);

            }

        }


        static void PrintLetters()
        {
            for (char c = 'A'; c <= 'E'; c++)
            {
                Console.WriteLine(c);
                Thread.Sleep(2000);
            }
        }



    }
}
