using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyThread
{
    internal class Program
    {

        static void Factorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
                Console.WriteLine($"Factorial of {num}  is: {factorial}");
            }

        }

        static void Main(string[] args)
        {
            //Test();
            //    var curT = Thread.CurrentThread;
            //    Console.WriteLine(curT.Name);
            //    Console.WriteLine(curT.ManagedThreadId);
            //    Console.WriteLine(curT.IsAlive);
            //    Console.WriteLine(curT.Priority);

            //    Stopwatch stopwatch = new Stopwatch();
            //    stopwatch.Start();


            //    Thread[] threads = new Thread[10];

            //    // Запускаем 10 потоков
            //    for (int i = 0; i < 10; i++)
            //    {
            //        // Создаем новый поток
            //        Thread t = new Thread(() => Factorial(100));
            //        t.Name = "Fact" + i.ToString(); // Назначаем имя потоку
            //        t.Priority = ThreadPriority.Highest;
            //        threads[i] = t; // Сохраняем ссылку на поток в массив
            //        t.Start(); // Запускаем поток
            //    }

            //    // Дожидаемся завершения всех потоков
            //    foreach (var t in threads)
            //    {
            //        t.Join(); // Ожидаем завершения потока
            //    }


            //    stopwatch.Stop();


            //    Console.WriteLine($"Время выполнения всех потоков: {stopwatch.ElapsedMilliseconds} миллисекунд");
            //}


            Files files = new Files();
            files.SumFiles();
        }
    }
}

//static void Test()
//{
//    for (int i = 0; i < 100; i++) 
//    {
//        Thread.Sleep(100);
//        Console.WriteLine($"{i} = {Thread.CurrentThread.Name}");

//    }
//}





        // Запускаем таймер для измерения времени
   

