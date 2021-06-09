using System;

namespace ExampleInterface
{
    interface IVehicle
    {
        void TransportTime(int time); // toplam taşıma süresi için
        void TotalPassenger(int passenger); // toplam yolcu sayısı için

    }
    interface IAirplane
    {
        void WingLength(int length); // kanat uzunluğu için
        void MaxAltitude(int altitude); // max uçuş yüksekliği

    }
    interface IShip
    {
        void MaxDeepWater(int deep); // max su derinliği için
    }
    interface ICar
    {
        void GearNumber(int gear);// vites sayısı için

    }


    class Airplane : IAirplane,IVehicle
    {
        public void MaxAltitude(int altitude)
        {
            Console.WriteLine("This Airplane maximum altitude : " + altitude + " feet");
        }

        public void WingLength(int length)
        {
            Console.WriteLine("This Airplane wing length is : " + length + " meters");
        }

        public void TotalPassenger(int passenger)
        {
            Console.WriteLine("This Airplane total : " + passenger + " passenger");
        }

        public void TransportTime(int time)
        {
            Console.WriteLine("This Airplane transport time is : " + time + " hours");
        }

    }


    class Ship : IShip, IVehicle
    {
        public void MaxDeepWater(int deep)
        {
            Console.WriteLine("This Ship maximum deep : " + deep + " meters");
        }

        public void TotalPassenger(int passenger)
        {
            Console.WriteLine("This Ship total : " + passenger + " passenger");
        }

        public void TransportTime(int time)
        {
            Console.WriteLine("This Ship transport time is : " + time + " hours");
        }
    }


    class Car : ICar, IVehicle
    {
        public void GearNumber(int gear)
        {
            Console.WriteLine("This Car has : "+gear+" gear");
        }

        public void TotalPassenger(int passenger)
        {
            Console.WriteLine("This Car total : " + passenger + " passenger");
        }

        public void TransportTime(int time)
        {
            Console.WriteLine("This Car transport time is : " + time + " hours");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.GearNumber(5);
            car.TotalPassenger(6);
            car.TransportTime(62);

            Airplane airplane = new Airplane();
            airplane.WingLength(30);
            airplane.TotalPassenger(200);
            airplane.TransportTime(4);
            airplane.MaxAltitude(10000);

            Ship ship = new Ship();
            ship.MaxDeepWater(20);
            ship.TotalPassenger(2000);
            ship.TransportTime(150);


            

        }
    }
}
