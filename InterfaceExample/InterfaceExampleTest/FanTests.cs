using InterfaceExample;

namespace InterfaceExampleTest
{
    public class FanTests
    {
        [Fact]
        public void PowerLowerThanZero_OK()
        {
            var fan = new Fan(new PowerLowerThanZero());
            var expected = "Won't work";

            var acttual=fan.Work();
            Assert.Equal(expected, acttual);
        }

        [Fact]
        public void PowerGreaterThan200_OK()
        {
            var fan = new Fan(new PowerGreaterThan200());
            var expected = "Warning!!!";

            var acttual = fan.Work();
            Assert.Equal(expected, acttual);
        }
    }
    class PowerLowerThanZero : IPower
    {
        public int GetPower()
        {
            return 0;
        }
    }

    class PowerGreaterThan200 : IPower
    {
        public int GetPower()
        {
            return 250;
        }
    }
}