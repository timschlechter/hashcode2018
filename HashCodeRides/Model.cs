using System.Diagnostics;
﻿using System;
using System.Collections.Generic;

namespace HashCodeRides
{
    public class InFile
    {
        public World World { get; set; }
        public List<Ride> Rides { get; set; }
    }

    [DebuggerDisplay("World {R}x{C} with {F} vehicles and {N} of rides (bonus {B} and {T} steps)")]
    public class World
    {
        public int R { get; set; }
        public int C { get; set; }
        public int F { get; set; }
        public int N { get; set; }
        public int B { get; set; }
        public int T { get; set; }
    }

    [DebuggerDisplay("Start {a},{b} and end {x},{y} should start {s} and end {f}")]
    public class Ride
    {
        public int RideNumber { get; set; }

        public int a { get; set; }
        public int b { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int s { get; set; }
        public int f { get; set; }

        public bool IsTaken { get; set; }

        public int RideLength()
        {
            int x = Math.Abs(this.a - this.x);
            int y = Math.Abs(this.b - this.y);

            return x + y;
        }
    }

    public class Vehicle
    {
        public int M { get; set; }
        public List<Ride> R { get; set; }

        public Vehicle()
        {
            this.R = new List<Ride>();
        }
    }
}