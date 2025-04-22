using System.Diagnostics;
using System.Net;

namespace MyParallel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started");
            //Parallel.Invoke(() => Console.WriteLine(Task.CurrentId),
            //                () => Console.WriteLine(Task.CurrentId),
            //                () => Method1());


            //Parallel.For(0, 10, i =>
            //{
            //    Thread.Sleep(100);
            //    factorial(i);

            //});
            List<string> links = new List<string>()
            {
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/constitution_rk_rus.pdf",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/labor_code_rus.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-27-12-94-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-1-07-99-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-360-vi-7-7-20-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-235-v-05-07-14-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/zakon_obraz_rk_ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/103-1-07-24-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/103-1-07-24-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/405-v-16-11-15-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/293-27-12-19-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/228-3-07-14-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/403-11-08-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/116-7-02-08-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/326-28-05-19-ru.pdf",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/236-25-08-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/189-27-04-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/563-6-11-23-ru.docx",
                 "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/constitution_rk_rus.pdf",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/labor_code_rus.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-27-12-94-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-1-07-99-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-360-vi-7-7-20-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-235-v-05-07-14-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/zakon_obraz_rk_ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/103-1-07-24-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/103-1-07-24-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/405-v-16-11-15-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/293-27-12-19-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/228-3-07-14-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/403-11-08-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/116-7-02-08-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/326-28-05-19-ru.pdf",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/236-25-08-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/189-27-04-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/563-6-11-23-ru.docx",
                 "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/constitution_rk_rus.pdf",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/labor_code_rus.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-27-12-94-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-1-07-99-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-360-vi-7-7-20-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-235-v-05-07-14-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/zakon_obraz_rk_ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/103-1-07-24-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/103-1-07-24-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/405-v-16-11-15-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/293-27-12-19-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/228-3-07-14-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/403-11-08-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/116-7-02-08-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/326-28-05-19-ru.pdf",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/236-25-08-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/189-27-04-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/563-6-11-23-ru.docx",
                 "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/constitution_rk_rus.pdf",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/labor_code_rus.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-27-12-94-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-1-07-99-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-360-vi-7-7-20-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-235-v-05-07-14-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/zakon_obraz_rk_ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/103-1-07-24-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/103-1-07-24-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/405-v-16-11-15-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/293-27-12-19-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/228-3-07-14-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/403-11-08-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/116-7-02-08-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/326-28-05-19-ru.pdf",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/236-25-08-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/189-27-04-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/563-6-11-23-ru.docx",
                 "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/constitution_rk_rus.pdf",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/labor_code_rus.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-27-12-94-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-1-07-99-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-360-vi-7-7-20-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-235-v-05-07-14-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/zakon_obraz_rk_ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/103-1-07-24-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/103-1-07-24-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/405-v-16-11-15-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/293-27-12-19-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/228-3-07-14-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/403-11-08-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/116-7-02-08-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/326-28-05-19-ru.pdf",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/236-25-08-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/189-27-04-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/563-6-11-23-ru.docx",
                 "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/constitution_rk_rus.pdf",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/labor_code_rus.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-27-12-94-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-1-07-99-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-360-vi-7-7-20-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-235-v-05-07-14-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/zakon_obraz_rk_ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/103-1-07-24-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/103-1-07-24-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/405-v-16-11-15-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/293-27-12-19-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/228-3-07-14-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/403-11-08-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/116-7-02-08-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/326-28-05-19-ru.pdf",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/236-25-08-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/189-27-04-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/563-6-11-23-ru.docx",
                 "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/constitution_rk_rus.pdf",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/labor_code_rus.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-27-12-94-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-1-07-99-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-360-vi-7-7-20-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/code-235-v-05-07-14-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/zakon_obraz_rk_ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/103-1-07-24-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/103-1-07-24-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/405-v-16-11-15-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/293-27-12-19-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/228-3-07-14-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/403-11-08-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/116-7-02-08-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/326-28-05-19-ru.pdf",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/236-25-08-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/189-27-04-23-ru.docx",
                "https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/563-6-11-23-ru.docx"


            };


            //Stopwatch stopwatch = Stopwatch.StartNew();
            //Directory.CreateDirectory("laws2");
            //Parallel.ForEach(links, i =>
            //{

            //    DownloadFile(i);
            //});

            ////foreach(var item in links)
            ////{
            ////    DownloadFile(item);
            ////}
            //Console.WriteLine("Finished");
            //stopwatch.Stop();
            //Console.WriteLine($"Время выполнения: {stopwatch.Elapsed.TotalSeconds} секунд.");



            var nums = Enumerable.Range(1, 1000000000);

            var evenNum = Enumerable.Range(1, 1000000000).AsParallel().Where(x => x % 2 == 0).ToList();
            Console.WriteLine(evenNum);


        }

        static void DownloadFile(string url)
        {

            using (WebClient webClient = new WebClient())
            {
                string fileName = Path.GetFileName(new Uri(url).LocalPath);
                string uniqueFileName = $"{Path.GetFileNameWithoutExtension(fileName)}_{Guid.NewGuid()}{Path.GetExtension(fileName)}";
                string destinationPath = Path.Combine("laws2", uniqueFileName);

                webClient.DownloadFile(url, destinationPath);
                Console.WriteLine($"Файл загружен: {uniqueFileName}");
            }


        }

        //ParallelOptions parallelOptions = new ParallelOptions()
        //{
        //    MaxDegreeOfParallelism = 2
        //};
    }
}
//static void Method1()
//        {
//            Thread.Sleep(1000);
//            Console.WriteLine("Method " + Task.CurrentId);
//        }


//        static void factorial(int n)
//        {

//            int result = 1;
//          for(int i = 1; i <= n; i++)
//            {
//                result *= i;
//            }
//            Console.WriteLine($"Факториал {n} = {result}");
//        }

//        static void Method3(string st)
//        {
//            //Thread.Sleep(1000);
//            Console.WriteLine("Method " + st + " " + Task.CurrentId);
//        }


