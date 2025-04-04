namespace MySync
{
    internal class Program
    {
       static  object locker = new();
        static void Main(string[] args)
        {
            //Test();

            for (int i = 0; i < 3; i++)
            {
                Thread t = new Thread(Test);
                t.Name = "Thread " + i.ToString(); // Назначаем имя потоку
                t.Start();
            }
           
        }


        static void Test()
        {
            lock (locker)
            {

                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(i + " - " + Thread.CurrentThread.Name);
                }
            }
        }
    }
}
