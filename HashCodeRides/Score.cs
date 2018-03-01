namespace HashCodeRides
{
    public class Score
    {
        public static long Calculate(World world, Ride[] rides, VehicleResult[] vehicles)
        {
            var score = 0;

            foreach (var vehicle in vehicles)
            {
                var t = 0;
                foreach (var rideNr in vehicle.R)
                {
                    if (t <= world.T)
                    {
                        var r = rides[rideNr];
                        var rideLength = r.RideLength();
                        var bonus = r.s < t ? 0 : world.B;

                        if (t < r.s)
                        {
                            t = r.s;
                        }

                        t += rideLength;
                        if (t <= r.f)
                        {
                            score += rideLength + bonus;
                        }
                    }
                }
            }

            return score;
        }
    }
}