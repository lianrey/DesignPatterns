using System;

namespace Strategy1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Sort _sort = new Sort();
            _sort.setTypeSort(new MergeSort());
            _sort.sort();
            _sort.setTypeSort(new QuickSort());
            _sort.sort();
            _sort.setTypeSort(new Timsort());
            _sort.sort();
        }
    }
}
