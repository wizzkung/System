using System.Diagnostics;

namespace MyTask
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            AsyncAwait.Test();
            stopwatch.Stop();
            Console.WriteLine($"Синхронный расчет завершен за {stopwatch.Elapsed.TotalSeconds} секунд.");

            Stopwatch stopwatch2 = Stopwatch.StartNew();
            await AsyncAwait.Test2();
            stopwatch2.Stop();
            Console.WriteLine($"Асинхронный расчет завершен за {stopwatch2.Elapsed.TotalSeconds} секунд.");
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
