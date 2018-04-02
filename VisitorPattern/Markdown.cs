using System;
namespace VisitorPattern
{
    public class Markdown: Visitor
    {
        public Markdown()
        {
        }

        public string Visit(string text)
        {
            return text + "===Markdown";
        }
    }
}
