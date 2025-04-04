using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace SEP_231_System
{
    public class Processed
    {
        public void OpenChromeProcesses(int numberOfProcesses)
        {
            for (int i = 0; i < numberOfProcesses; i++)
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "chrome.exe",
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Не удалось открыть процесс Chrome: {ex.Message}");
                }
            }
        }


        public void OpenExcel(int numberOfProcesses)
        {
            for (int i = 0; i < numberOfProcesses; i++)
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "Excel.exe",
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Не удалось открыть процесс Chrome: {ex.Message}");
                }
            }
        }

        public void OpenWord(int numberOfProcesses)
        {
            for (int i = 0; i < numberOfProcesses; i++)
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "Word.exe",
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Не удалось открыть процесс Chrome: {ex.Message}");
                }
            }
        }

        public void KillProcesses(string processName, int numberOfProcesses)
        {
            var processes = Process.GetProcessesByName(processName);
            int killedCount = 0;

            foreach (var process in processes)
            {
                if (killedCount >= numberOfProcesses)
                    break;

                try
                {
                    process.Kill();
                    killedCount++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Не удалось завершить процесс {processName}: {ex.Message}");
                }
            }

        }
        }
}

    

