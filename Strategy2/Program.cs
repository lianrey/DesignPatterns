using System;

namespace Strategy2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Transportation trans = new Transportation();
            trans.SetTransportationType(new Car());
            trans.Move();

            trans.SetTransportationType(new Airplane());
            trans.Move();
        }
    }
}
