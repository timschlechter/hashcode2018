using System.Collections.Generic;
using System.IO;

namespace HashCodeRides
{
    public static class Parser
    {
        public static InFile a
        {
            get
            {
                return Parse("a_example.in");
            }
        }

        public static InFile b
        {
            get
            {
                return Parse("b_should_be_easy.in");
            }
        }

        public static InFile c
        {
            get
            {
                return Parse("c_no_hurry.in");
            }
        }

        public static InFile d
        {
            get
            {
                return Parse("d_metropolis.in");
            }
        }

        public static InFile e
        {
            get
            {
                return Parse("e_high_bonus.in");
            }
        }

        public static InFile Parse(string fileName)
        {
            var lines = File.ReadAllLines(fileName);

            var header = lines[0].Split(' ');

            var world = new World
            {
                R = header[0].AsInt(),
                C = header[1].AsInt(),
                F = header[2].AsInt(),
                N = header[3].AsInt(),
                B = header[4].AsInt(),
                T = header[5].AsInt(),
            };

            var rides = new List<Ride>();

            for (int i = 1; i < lines.Length; i++)
            {
                var data = lines[i].Split(' ');

                rides.Add(new Ride
                {
                    a = data[0].AsInt(),
                    b = data[1].AsInt(),
                    x = data[2].AsInt(),
                    y = data[3].AsInt(),
                    s = data[4].AsInt(),
                    f = data[5].AsInt(),
                    RideNumber = i
                });
            }

            return new InFile
            {
                World = world,
                Rides = rides
            };
        }

        public static int AsInt(this string text)
        {
            return int.Parse(text);
        }
    }
}