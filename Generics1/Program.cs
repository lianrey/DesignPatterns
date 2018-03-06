using System;

namespace Generics1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Employee newEmployee = new Employee();
            newEmployee.Id = new Guid();

            Product product = new Product();
            product.Id = 123;

            Store store = new Store();
            store.Id = "Lalala - 12345";

            PrintProp item = new PrintProp();
            item.PrintId(newEmployee.Id);
            item.PrintId(product.Id);
            item.PrintId(store.Id);
        }
    }
}
