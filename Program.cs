using System;
namespace Test_Work
{
    public interface IMyClass
    {
        string GetMyName();
    }
    public class MyClass    {
        private string _myname;
        
        public string GetMyName(TestDelegate get)
        {
            return string.Format("My Name is {0}",get());
        }

        public delegate string TestDelegate();

    }
    class Program
    {
       static void Main(string[] args)
        {
           var obj = new MyClass();
           Console.WriteLine("Hello World!");
           Console.WriteLine(obj.GetMyName(Console.ReadLine));
        }
    }
}
