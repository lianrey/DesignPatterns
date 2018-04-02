using System;

namespace VisitorPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            PlainText plainText = new PlainText();
            Html html = new Html();
            Markdown markdown = new Markdown();

            Text text = new Text("Holaaa");

            Console.WriteLine("Plain Text:" + text.Accept(plainText));
            Console.WriteLine("HTML:" + text.Accept(html));
            Console.WriteLine("Markdown:" + text.Accept(markdown));
        }
    }
}
