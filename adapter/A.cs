using System;

namespace adapter
{
    class A
    {
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public A() {}
        public int a { get; set; }
        public int b { get; set; }
        public int sum()
        {
            return a + b;
        }
        public void MessageWrite()
        {
            Console.WriteLine("message");
        }
    }
}