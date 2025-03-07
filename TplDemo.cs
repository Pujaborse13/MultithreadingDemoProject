using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutithreadingProject
{
    public class TplDemo
    {
            public async Task AllTask()
            {
                Task task1 = Task.Run(() => PrintNumbers());
                Task task2 = Task.Run(() => PrintLetters());

                Task task3 =  PrintNumbers();
                Task task4 =  PrintLetters();



            await Task.WhenAll(task1, task2);
            }

            public async Task PrintNumbers()
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"Task {Task.CurrentId} : {i}");
                    await Task.Delay(1000);  
                }
            }


        public async Task PrintLetters()
        {
            for (char c = 'A'; c <= 'E'; c++)
            {
                Console.WriteLine($"Task {Task.CurrentId} : {c}");
                await Task.Delay(1000);
            }
        }






    }

}

