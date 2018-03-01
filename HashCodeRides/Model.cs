using System;

namespace HashCodeRides
{
    public class InFile
    {
        public World World { get; set; }
        public Ride[] Rides { get; set; }
    }

    public class World
    {
        public int R { get; set; }
        public int C { get; set; }
        public int F { get; set; }
        public int N { get; set; }
        public int B { get; set; }
        public int T { get; set; }
    }

    public class Ride
    {
        public int RideNumber { get; set; }

        public int a { get; set; }
        public int b { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int s { get; set; }
        public int f { get; set; }
    }

    public class Vehicle
    {
        public int M { get; set; }
        public Ride[] R { get; set; }
    }

    
}
