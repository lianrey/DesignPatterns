using System;

namespace VisitorPattern
{
    public class Html: Visitor
    {
        public Html()
        {
        }

        public string Visit(string text)
        {
            return "<html>" + text + "</html>";
        }
    }
}
