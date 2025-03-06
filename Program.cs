using MutithreadingProject;

internal class Program
{
    //public static void Main(string[] args)
    //{
    //    SynchronousDemo ex = new SynchronousDemo();
    //    ex.MyTask();

    //}



    static async Task Main()
    {
        AsynchronousDemo demo = new AsynchronousDemo();
        await demo.MyTask();
    }



}