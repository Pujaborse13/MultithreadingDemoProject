using MutithreadingProject;

internal class Program
{
    /*
    //  1. SynchronousDemo Example 
    public static void Main(string[] args)
    {
        SynchronousDemo ex = new SynchronousDemo();
        ex.MyTask();

    }


       //  2. AsynchronousDemo Example 
    static async Task Main()
    {
        AysnchronousDemo demo = new AysnchronousDemo();
        await demo.MyTask();
    }
   

    //  3. MutithreadingDemo Example 
    static void Main(string[] args)  
    {

        MultithreadingDemo demo = new MultithreadingDemo();
        demo.AllTask();

    }

     */

    //TPL Demo Example
    static async Task Main(string[] args)  
    {
        TplDemo tplDemo = new TplDemo();
        await tplDemo.AllTask();

    }










}