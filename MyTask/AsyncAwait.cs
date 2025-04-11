using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTask
{
    public static class AsyncAwait
    {
        public static void Test()
        {
            string sourceDir = @"C:\Users\kimle";
            if (!Directory.Exists(sourceDir))
            {
                Directory.CreateDirectory(sourceDir);
            }

            int count = CountDirectories(sourceDir);

            Console.WriteLine($"Количество папок в директории '{sourceDir}' и всех поддиректориях: {count}");
        }

        public static async Task Test2()
        {
            string sourceDir = @"C:\Users\kimle";
            if (!Directory.Exists(sourceDir))
            {
                Directory.CreateDirectory(sourceDir);
            }

            int count = await Task.Run(() => CountDirectoriesParallel(sourceDir));

            Console.WriteLine($"Количество папок в директории '{sourceDir}' и всех поддиректориях: {count}");
        }

        private static int CountDirectories(string path)
        {
            int count = 0;
            try
            {
                string[] directories = Directory.GetDirectories(path);
                count += directories.Length;

                foreach (string directory in directories)
                {
                    count += CountDirectories(directory);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Пропустить директории, к которым нет доступа
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при подсчете директорий: {ex.Message}");
            }

            return count;
        }

        private static int CountDirectoriesParallel(string path)
        {
            var directoriesQueue = new ConcurrentQueue<string>();
            directoriesQueue.Enqueue(path);
            int count = 0;

            Parallel.ForEach(directoriesQueue, (currentDirectory) =>
            {
                try
                {
                    string[] directories = Directory.GetDirectories(currentDirectory);
                    count += directories.Length;

                    foreach (string directory in directories)
                    {
                        directoriesQueue.Enqueue(directory);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    // Пропустить директории, к которым нет доступа
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при подсчете директорий: {ex.Message}");
                }
            });

            return count;
        }
    }
}
