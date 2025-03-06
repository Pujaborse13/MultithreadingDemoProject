using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutithreadingProject
{
    public class SynchronousDemo
    {
        public void MyTask()
        {
            Console.WriteLine("Task 1 start....");
            Task1();

            Console.WriteLine("Task 2 start....");
            Task2();

            Console.WriteLine("Task 3 start...");
            Task3();
        }



        public void Task1()
        { 
            Thread.Sleep(4000);
            Console.WriteLine("Task 1 Completed");

        }


        public void Task2()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Task 2 Completed");
            
        
        }

        public void Task3()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Task 3 Completed");


        }



    }
}
