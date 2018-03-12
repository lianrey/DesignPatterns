using System;
namespace Strategy1
{
    public class Sort
    {
        ISorts _sortsType;

        public void setTypeSort(ISorts sortsType) => _sortsType = sortsType;

        public void sort(){
            _sortsType.Sort();
        }
    }
}
