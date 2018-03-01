using Xunit;

namespace HashCodeRides.Tests
{
    public class ScoreTests
    {
        [Fact]
        public void ScoreTests()
        {
            var world = new World
            {
                R = 3,
                C = 4,
                F = 2,
                N = 3,
                B = 2,
                T = 10
            };

            var rides = new[]
            {
                new Ride {a = 0, b = 0, x = 1, y = 3, s = 2, f = 9},
                new Ride {a = 1, b = 2, x = 1, y = 0, s = 0, f = 9},
                new Ride {a = 2, b = 0, x = 2, y = 2, s = 0, f = 9}
            };

            var vehicles = new[]
            {
                new VehicleResult {M = 0, R = new[] {0, 1, 2}}
            };

            Assert.Equal(8, Score.Calculate(world, rides, vehicles));
        }
    }
}