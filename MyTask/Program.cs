using System.Diagnostics;

namespace MyTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task[] task = new Task[5];
            //for (int i = 0; i < task.Length; i++)
            //{
            //    task[i] = new Task(Test);
            //    task[i].Start();
            //    Console.WriteLine(Task.CurrentId);
            //}

            ////for(int i = 0; i < task.Length; i++)
            ////{
            ////    task[i].Start();
            ////}

            //Task.WaitAll(task);




            string sourceDir = @"C:\Windows\System32";
            string destinationDir = @"C:\Windows\System32Copy";

            Stopwatch stopwatch = Stopwatch.StartNew();
            CopyDirectoryAsync(sourceDir, destinationDir).GetAwaiter().GetResult();
            stopwatch.Stop();

            Console.WriteLine($"Копирование завершено за {stopwatch.Elapsed.TotalSeconds} секунд.");
        }
        
        static void Test()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine($"{i} - {Thread.CurrentThread.ManagedThreadId}");
            }
        }


        static async Task CopyDirectoryAsync(string sourceDir, string destinationDir)
        {
            if (!Directory.Exists(destinationDir))
            {
                Directory.CreateDirectory(destinationDir);
            }

            string[] files = Directory.GetFiles(sourceDir, ".txt");
            string[] directories = Directory.GetDirectories(sourceDir);

            // Копируем файлы в текущей папке
            var fileTasks = files.Select(file => Task.Run(() =>
            {
                string destFile = Path.Combine(destinationDir, Path.GetFileName(file));
                File.Copy(file, destFile, true);
            }));

            // Копируем вложенные папки рекурсивно
            var dirTasks = directories.Select(dir => CopyDirectoryAsync(dir, Path.Combine(destinationDir, Path.GetFileName(dir))));

            await Task.WhenAll(fileTasks.Concat(dirTasks));
        }
    }
}
