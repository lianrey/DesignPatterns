using System;
namespace Generics1
{
    public abstract class Item <T>
    {
        public T Id
        {
            get;
            set;
        }
    }
}
