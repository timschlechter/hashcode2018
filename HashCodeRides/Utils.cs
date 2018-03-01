using System;
using System.Collections.Generic;
using System.Text;

namespace HashCodeRides
{
    public static class Utils
    {
        public static int Distance(Ride ride1, Ride ride2)
        {
            int x = Math.Abs(ride1.x - ride2.a);
            int y = Math.Abs(ride1.y - ride2.b);

            return x + y;
        }

        public static int Distance(int carX, int carY, Ride ride)
        {
            int x = Math.Abs(carX - ride.a);
            int y = Math.Abs(carY - ride.b);

            return x + y;
        }
    }
}
