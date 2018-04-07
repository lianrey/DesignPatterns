using System;
using System.Collections.Generic;

namespace DataLib2.Interfaces
{
    public interface IInitializer<T> where T : class
    {
        void Initialize();

        IEnumerable<T> Result { get; }
    }
}
