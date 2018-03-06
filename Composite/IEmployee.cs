using System;
namespace Composite
{
    public interface IEmployee
    {
        void DoWork();
        void Add(IEmployee employee);
    }
}
