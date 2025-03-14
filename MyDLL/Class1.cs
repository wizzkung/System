namespace MyDLL
{
    public interface ITest
    {
        public void GetValue();
    }

    public class MyClass
    {
        public MyClass(string st)
        {

        }
        public string Name { get; set; }
        private string Title { get; set; }
        string Street;

        public int GetSum(int a, int b)
        {
            return a + b;
        }

        public string SayHello(string name)
        {
            return "Hello " + name;
        }

        public static string SayBye(string name)
        {
            return "Bye " + name;
        }
    }

}
