using System;
namespace VisitorPattern
{
    public class Text: Visitable
    {
        public string _text;

        public Text(string text)
        {
            _text = text;
        }

        public string Accept(Visitor visitor)
        {
            return visitor.Visit(_text);
        }
    }
}
