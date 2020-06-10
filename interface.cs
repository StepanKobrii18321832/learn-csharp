using System;

namespace Writetext 
{
    interface IWriter
    {
        void Write(string text);
    }

    class TextWriter
    {
        public IWriter Writer {get; set;}

        public void WtriteText(string text)
        {
            text += " some";
            Writer.Write(text);
        }
    }

    class Type1 : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
    class Type2 : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine("<" + text + ">");
        }
    }
    class Type3 : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine("{" + text + "}");
        }
    }
    class Progamm 
    {
        static void Main()
        {
            TextWriter TEXT = new TextWriter();

            TEXT.Writer = new Type1();
            TEXT.WtriteText("text");
            TEXT.Writer = new Type2();
            TEXT.WtriteText("text");
            TEXT.Writer = new Type3();
            TEXT.WtriteText("text");
        }
    }
}