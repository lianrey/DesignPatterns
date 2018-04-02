using System;
namespace VisitorPattern
{
    public interface Visitable
    {
        string Accept(Visitor visitor);
    }
}
