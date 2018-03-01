using System.Diagnostics;
﻿using System;
using System.Collections.Generic;
using System.Linq;

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

        public int RideLength {
            get
            {
                int x = Math.Abs(this.a - this.x);
                int y = Math.Abs(this.b - this.y);

                return x + y;
            }
        }

        public bool IsImpossible(int carX, int carY)
        {
            return Utils.Distance(carX, carY, this) > this.f;
        }
    }

    public class Vehicle
    {
        public int M { get; set; }
        public List<Ride> R { get; set; }

        public int X { get
            {
                if (!R.Any())
                    return 0;
                else
                    return R.Last().x;
            }
        }

        public int Y { get
            {
                if (!R.Any())
                    return 0;
                else
                    return R.Last().y;
            }
        }

        public int CurrentStep
        {
            get
            {
                int step = 0;

                if (R.Count == 0)
                    return step;

                if (R.Count <= 1)
                {
                    step += (R[0].a + R[0].b);
                    step += R[0].RideLength;
                    return step;
                }

                for (int i = 0; i < R.Count; i++)
                {
                    var curRide = R[i];

                    if (i != 0)
                    {
                        var previousRide = R[i - 1];
                        step += Utils.Distance(curRide, previousRide);
                    }
                    step += curRide.RideLength;
                }
                return step;
            }
        }

        public Vehicle()
        {
            this.R = new List<Ride>();
        }
    }
}