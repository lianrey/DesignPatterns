using System;
namespace Decorator
{
    public static class ConsoleDecorator
    {
        public static void Write(string text, int size){
            string newLine = "";
            for (int i = 0; i < size; i++)
            {
                newLine += "\n";
            }
            Console.Write(newLine + text);
        }
    }
}
