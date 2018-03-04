using System;

namespace Builder1
{
    class Program
    {
        static void Main(string[] args)
        {
            var economy = new CarBuilder()
                .Model("Economy")
                .Wheels(4)
                .Upholstery("Cloth")
                .Color("Black")
                .AirConditioning(false)
                .Build();
            Console.WriteLine(economy._model);

        }
    }
}
