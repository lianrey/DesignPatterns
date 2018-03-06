using System;
namespace Generics1
{
    public class PrintProp
    {
        public void PrintId<T>(T input){
            Console.WriteLine(String.Format("Id:T {0}", input.ToString()));
        }
    }
}
