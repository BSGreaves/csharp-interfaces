using System;
using System.Linq;
using System.Collections.Generic;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List <ILandVehicle> landVehicles = new List <ILandVehicle>();
            List <IWaterVehicle> waterVehicles = new List <IWaterVehicle>();
            List <IAirVehicle> airVehicles = new List <IAirVehicle>();
            Car vWBeetle = new Car ();
            Motorcycle Harley = new Motorcycle ();
            landVehicles.Add(vWBeetle);
            landVehicles.Add(Harley);
            Plane Boeing = new Plane ();
            Helicopter Bell = new Helicopter ();
            airVehicles.Add(Boeing);
            airVehicles.Add(Bell);
            Boat Bayliner = new Boat ();
            Jetski SkeDoo = new Jetski ();
            waterVehicles.Add(Bayliner);
            waterVehicles.Add(SkeDoo);
            foreach (ILandVehicle vehicle in landVehicles) {
                vehicle.Drive();
            }
            foreach (IWaterVehicle vehicle in waterVehicles) {
                vehicle.Drive();
            }
            foreach (IAirVehicle vehicle in airVehicles) {
                vehicle.Fly();
            }
        }
        
        public interface IVehicle
        {
            int PassengerCapacity { get; set; }
            double EngineVolume { get; set; }
            void Start();
            void Stop();
        }
        public interface IWaterVehicle
        {
            double MaxWaterSpeed { get; set; }
            void Drive();
        }
        public interface ILandVehicle
        {
            int Wheels { get; set; }
            int Doors { get; set; } 
            string TransmissionType { get; set; }
            double MaxLandSpeed { get; set; }
            void Drive();
        }
        public interface IAirVehicle
        {
            int Wheels { get; set; }
            int Doors { get; set; }
            double MaxAirSpeed { get; set; }
            void Fly();
        }

        public class Jetski : IVehicle, IWaterVehicle
        {
            public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public double MaxWaterSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void Drive()
            {
                Console.WriteLine("The Jetski zips through the waves with the greatest of ease");
            }

            public void Start()
            {
                throw new NotImplementedException();
            }

            public void Stop()
            {
                throw new NotImplementedException();
            }
        }
        public class Boat : IVehicle, IWaterVehicle
        {
            public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public double MaxWaterSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void Drive()
            {
                Console.WriteLine("The Boat floats across the waves");
            }

            public void Start()
            {
                throw new NotImplementedException();
            }

            public void Stop()
            {
                throw new NotImplementedException();
            }
        }
        public class Motorcycle : IVehicle, ILandVehicle
        {
            public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public double MaxLandSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void Drive()
            {
                Console.WriteLine("The Motorcycle flies around curvy bends");
            }

            public void Start()
            {
                throw new NotImplementedException();
            }

            public void Stop()
            {
                throw new NotImplementedException();
            }
        }
        public class Car : IVehicle, ILandVehicle
        {
            public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public double MaxLandSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void Drive()
            {
                Console.WriteLine("The Car drives down the road");
            }

            public void Start()
            {
                throw new NotImplementedException();
            }

            public void Stop()
            {
                throw new NotImplementedException();
            }
        }
        public class Plane : IVehicle, IAirVehicle
        {
            public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public double MaxAirSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void Fly()
            {
                Console.WriteLine("The Plane effortlessly glides through the clouds like a gleaming god of the Sun");
            }

            public void Start()
            {
                throw new NotImplementedException();
            }

            public void Stop()
            {
                throw new NotImplementedException();
            }
        }
        public class Helicopter : IVehicle, IAirVehicle
        {
            public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public double MaxAirSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void Fly()
            {
                Console.WriteLine("The chopper lifts off and quickly disappears over the horizon");
            }

            public void Start()
            {
                throw new NotImplementedException();
            }

            public void Stop()
            {
                throw new NotImplementedException();
            }
        }
    }  
}
