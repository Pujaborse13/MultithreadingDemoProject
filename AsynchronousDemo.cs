using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutithreadingProject
{
    internal class AsynchronousDemo
    {
       public async Task MyTask()
        {
            Console.WriteLine("Task 1 start....");
            Task task1 = Task1();

            Console.WriteLine("Task 2 start....");
            Task task2 = Task2();

            Console.WriteLine("Task 3 start...");
            Task task3 = Task3();

            await Task.WhenAll(task1, task2, task3); // Waits for all tasks to finish
            Console.WriteLine("All tasks completed.");
        }

        public async Task Task1()
        {
            await Task.Delay(3000);
            Console.WriteLine("Task 1 Completed");
        }

        public async Task Task2()
        {
            await Task.Delay(1000);
            Console.WriteLine("Task 2 Completed");
        }

        public async Task Task3()
        {
            await Task.Delay(4000);
            Console.WriteLine("Task 3 Completed");
        }

    }
}
