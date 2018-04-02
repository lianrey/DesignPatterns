using System;
namespace VisitorPattern
{
    public class PlainText: Visitor
    {
        public PlainText()
        {
        }

        public string Visit(string text)
        {
            return text;
        }
    }
}
