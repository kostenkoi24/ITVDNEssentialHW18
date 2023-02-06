extern alias MyNamespace;

using System;

namespace Homework18_4_USE_MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {

            MyNamespace.MyNamespace.MyClass myClass = new MyNamespace.MyNamespace.MyClass();

            myClass.MyMethod();

            Console.ReadKey();

            
        }
    }
}
