namespace MyTimer
{
    internal class Program
    {
        static System.Timers.Timer timer;
        static int count = 0;

        static void Main(string[] args)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 2000;
            timer.Elapsed += Print;
            timer.Start();
            Console.ReadLine();


          
        }

        static void Print(object sender, System.Timers.ElapsedEventArgs e)
        {

            Console.WriteLine($"{DateTime.Now.ToString("dd.MM.yyyy HH: mm: ss")} - {count++}");
            if (count > 3)
            {
                //timer.Stop();
                timer.Elapsed -= Print;
            }
        }
    }
}
