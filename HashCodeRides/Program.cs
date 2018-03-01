using System;
using System.Collections.Generic;
using System.Linq;

namespace HashCodeRides
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Parser.a_example;


            var cars = new List<Vehicle>();
            var sortedRidesByS = x.Rides.OrderBy(a => a.s).ToArray();

            for (int i = 0; i < x.World.F; i++)
            {
                cars.Add(new Vehicle());

            }

            for (int i = 0; i < cars.Count; i++)
            {
                var car = cars[i];

                var openRides = sortedRidesByS.Where(a => !a.IsTaken).ToArray();
                for (int j = 0; j < openRides.Length; j++)
                {
                    var ride = openRides[j];

                    if (ride.s >= car.R.Sum(r => r.RideLength()))
                    {
                        car.R.Add(ride);
                        ride.IsTaken = true;
                    }
                }
            }

        }
    }
}