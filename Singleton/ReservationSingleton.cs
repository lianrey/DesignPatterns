using System;
namespace Singleton
{
    public sealed class ReservationSingleton
    {
        private static volatile ReservationSingleton firstInstance = null;
        private static object syncRoot = new Object();

        private ReservationSingleton() {}

        public static ReservationSingleton GetInstance () {
            
            if(firstInstance == null) {
                lock(syncRoot){
                    if (firstInstance == null)
                    {
                        firstInstance = new ReservationSingleton();
                    }
                }

            }

            return firstInstance;
        }

        public void MakeReservations(){
            Console.WriteLine("Make reservation");
        }
    }
}
