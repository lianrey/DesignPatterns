using System;

namespace Generics2
{
    public class Convert<T>
    {
        public static T ParseType(Object o)
        {
            return (T)Convert.ChangeType(o, typeof(T));
        }
    }
}
