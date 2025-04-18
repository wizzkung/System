using System.Reflection;

namespace MyReflexing
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Type myType = typeof(Person);
            //Type myInterface = typeof(IPerson);

            //foreach (var item in myType.GetMethods())
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.ReturnType);

            //    var parameters = item.GetParameters();

            //    Console.WriteLine("  Параметры:");
            //    foreach (var param in parameters)
            //    {
            //        Console.WriteLine($"    Имя: {param.Name}, Тип: {param.ParameterType}");
            //    }
            //}

            Type myAbstract = typeof(MyClass);
            foreach (var item in myAbstract.GetMethods())
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.ReturnType);
                var parameters = item.GetParameters();
                Console.WriteLine("  Параметры:");
                foreach (var param in parameters)
                {
                    Console.WriteLine($"    Имя: {param.Name}, Тип: {param.ParameterType}, {param.Attributes}");
                }
            }

            FieldInfo fieldInfo = myAbstract.GetField("connectionString", BindingFlags.NonPublic | BindingFlags.Static);
            string connectionStringValue = (string)fieldInfo.GetValue(null);
            Console.WriteLine($"Значение connectionString: {connectionStringValue}");


        }




        //Console.WriteLine(myType.Assembly);
        //Console.WriteLine(myType.Name);
        //Console.WriteLine(myType.FullName);
        //Console.WriteLine(myType.IsClass);
        //foreach (MemberInfo item in myType.GetConstructors())
        //{
        //    Console.WriteLine(item.Name);
        //    Console.WriteLine(item.MemberType);
        //    foreach (ConstructorInfo constructor in myType.GetConstructors())
        //    {
        //        Console.WriteLine($"Конструктор: {constructor.Name}");
        //        Console.WriteLine($"Тип члена: {constructor.MemberType}");

        //        var parameters = constructor.GetParameters();
        //        if (parameters.Length > 0)
        //        {
        //            Console.WriteLine("Параметры:");
        //            foreach (var param in parameters)
        //            {
        //                Console.WriteLine($"- Имя: {param.Name}, Тип: {param.ParameterType}");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Параметры: отсутствуют");
        //        }

        //        Console.WriteLine();
        //    }



        //    Console.WriteLine(item.get);
        //}

        //foreach(var item in myType.GetMethods())
        //{
        //    Console.WriteLine(item.Name);
        //}

        //foreach (var item in myType.GetProperties())
        //{
        //    Console.WriteLine(item.Name);
        //}



    }
}


public class Person
{
    string name;
    public int Age { get; set; }
    public Person() { }
    public Person(string name, int age)
    {
        this.name = name;
        this.Age = age;
    }
    public void Print() => Console.WriteLine($"Name: {name} Age: {Age}");
}


public interface IPerson
{
    void SayHello(string name);
    string GetHello(string name);
    string GetHello(Person person);
    Person GetHello(int i);
}


public abstract class MyClass
{
    public abstract string MyAbstract(string name);
    public virtual string MyVirtual(string name)
    {
        return $"MyClass: {name}";
    }
    private static string connectionString = "Data Source=localhost;Initial Catalog=MyDatabase;Integrated Security=True";


}