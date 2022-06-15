using System;
​
namespace ReflectedObject
{
    public class ReflectedClass
    {
        public int ReflectedProperty { get; set; }
        public static void ReflectedMethod()
        {
            Console.WriteLine("Hello from reflected method");
        }
    }
}
