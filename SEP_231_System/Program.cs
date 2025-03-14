using System.Diagnostics;

namespace SEP_231_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine("без арг не запускать");
                Console.ReadLine();
                return;
            }
            var arg = args[0];
            if (arg == "null")
            {
                var dt = DateTime.Now.AddDays(-1).Date;
                Console.WriteLine($"{dt}");
            }
            else
                Console.WriteLine($"{arg}");

            Console.WriteLine($"{args[1]}");



            //Console.ReadLine();

            //var p = Process.GetProcesses().OrderBy(z=>z.ProcessName);
            //    //.Where(z => z.ProcessName == "notepad");
            //foreach (var item in p)
            //{
            //    Console.WriteLine($"{item.ProcessName}");
            //    //item.Kill();
            //}

            //var p = from n in Process.GetProcesses()
            //        where n.ProcessName == "notepad"
            //        select n;
            //    .Where(z=>z.ProcessName == "notepad");            

            //var p = Process.GetProcessesByName("notepad");
            //if (p != null && p.Length > 0)
            //{
            //    //Console.WriteLine($"{p[0].StartTime}");
            //    foreach (ProcessModule item in p[0].Modules)
            //    {
            //        Console.WriteLine($"{item.FileName}");                    
            //    }
            //}

            //int[] array = new int[5];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    var p = Process.Start("notepad");
            //    array[i] = p.Id;
            //}


            //for (int i = 0; i < array.Length; i++)
            //{
            //    var p = Process.GetProcessById(array[i]);
            //    if (p != null && p.ProcessName == "notepad")
            //        p.Kill();
            //}

            //var p = Process.Start(@"C:\examples\123.xlsx");

            //var psi = new ProcessStartInfo(@"C:\examples\123.xlsx")
            //{
            //    UseShellExecute = true
            //};

            //Process.Start(psi);

        }
    }
}