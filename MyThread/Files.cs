using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThread
{
    public class Files
    {
        public void SumFiles()
        {
            string path = "M:\\Временные файлы\\SEP-231\\001.txt"; // Путь к файлу
            Stopwatch stopwatch = new Stopwatch();
            long sum = 0; // Переменная для хранения суммы

            try
            {
                stopwatch.Start();

                // Читаем файл построчно, не загружая целиком в память
                using (var reader = new StreamReader(path))
                {
                    string line;
                    int lineNumber = 0;

                    while ((line = reader.ReadLine()) != null) // Читаем каждую строку
                    {
                        lineNumber++;

                        // Проходим по каждому символу в строке
                        foreach (char c in line)
                        {
                            // Проверяем, является ли символ цифрой
                            if (char.IsDigit(c))
                            {
                                sum += c - '0'; // Преобразуем символ в число и добавляем к сумме
                            }
                            else
                            {
                                // Если символ не цифра, пропускаем его
                                // Можно добавить логику для обработки, если нужно
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
                return;
            }
            finally
            {
                stopwatch.Stop();
            }

            // Выводим результат
            Console.WriteLine($"Сумма всех цифр в файле: {sum}");
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
        }

    }
}
