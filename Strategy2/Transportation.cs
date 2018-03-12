using System;
namespace Strategy2
{
    public class Transportation
    {
        ITransports _type;

        public void SetTransportationType(ITransports type){
            _type = type;
        }

        public void Move(){
            _type.Move();
        }
    }
}
