using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace MyDLLCall
{
    internal class Program
    {

        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
        static void Main(string[] args)
        {

            //MyClass myClass = new MyClass("");
            //Console.WriteLine(myClass.GetSum(1, 2));
            //Console.WriteLine(myClass.SayHello(""));

            //MyClass.SayBye("");

            //Class1 cl = new Class1("Vasya", 20);
            // cl.PrintStatus();
            // cl.CalcVolume(10, 20, 30);



            ////ПОзднее связывание DLL
            //string dllPath = @"C:\Users\kimle\source\repos\SEP_231_System\MyDLLCall\bin\Debug\net7.0\MyLib.dll";
            //Assembly assembly = Assembly.LoadFrom(dllPath);
            //Type type = assembly.GetType("MyLib.MyClass");
            //object obj = System.Activator.CreateInstance(type, new object[] { "Vasya" });
            //MethodInfo method = type.GetMethod("GetSum");
            //var result = method.Invoke(obj, new object[] { 1, 2 });
            //Console.WriteLine(result);

           MessageBox(IntPtr.Zero, "Hello", "Hello", 0);

        }
    }
}
