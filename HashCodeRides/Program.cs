using System;
using System.Collections.Generic;
using System.Linq;

namespace HashCodeRides
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Parser.a;
            var b = Parser.b;
            var c = Parser.c;
            var d = Parser.d;
            var e = Parser.e;


            var filename = b;




            var cars = new List<Vehicle>();
            var sortedRidesByS = filename.Rides.OrderBy(r => r.s).ToArray();

            for (int i = 0; i < filename.World.F; i++)
            {
                cars.Add(new Vehicle());

            }

            for (int i = 0; i < cars.Count; i++)
            {
                var car = cars[i];

                var openRides = sortedRidesByS.Where(o => !o.IsTaken).ToArray();
                for (int j = 0; j < openRides.Length; j++)
                {
                    var ride = openRides[j];

                    if (!ride.IsImpossible(car.X, car.Y))
                    {
                        Console.WriteLine(ride.RideNumber);
                        // check if startime is >= tha current step of car
                        if (ride.f > Utils.Distance(car.X, car.Y, ride) + ride.RideLength)
                        {
                            car.R.Add(ride);
                            ride.IsTaken = true;
                        }
                        else
                        {
                            break;
                        }

                    }
                }
            }

        }
    }
}