namespace adapter
{
    class B : A, TextMessage
    {
        public void Message()
        {
            this.MessageWrite();
        }
    }
    class Programm
    {
        static void Main()
        {
            A test1 = new A();
            B test2 = new B();
            //test1.Message(); // error
            test2.Message();

        }
    }
}