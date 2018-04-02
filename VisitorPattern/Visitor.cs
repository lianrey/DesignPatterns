using System;
namespace VisitorPattern
{
    public interface Visitor
    {
        string Visit(string text);
    }
}
