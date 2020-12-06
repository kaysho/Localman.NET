using Xunit;

namespace Localman.NET.Test
{
    public class StateTest : IntegrationTest
    {

        [Fact]
        public void GetAllStates()
        {
            Assert.True(Localman.GetAllStates().Count == 37);
        }

        [Fact]
        public void GetAllLGAs()
        {
            Assert.True(Localman.GetAllLGAs().Count == 773);
        }

        [Fact]
        public void GetLGAs()
        {
            Assert.True(Localman.GetLGAs(State.LAGOS).Count == 20);
        }

        [Fact]
        public void GetLGAState()
        {
            Assert.True(Localman.GetLGAState("Ikorodu") == "Lagos");
        }

        [Fact]
        public void GetLatitude()
        {
            Assert.True(Localman.GetLatitude(State.LAGOS) != 0.0);
        }

        [Fact]
        public void GetLongitude()
        {
            Assert.True(Localman.GetLongitude(State.LAGOS) != 0.0);
        }

        [Fact]
        public void GetMaxLatitude()
        {
            Assert.True(Localman.GetMaxLatitude(State.LAGOS) != 0.0);
        }

        [Fact]
        public void GetMaxLongitude()
        {
            Assert.True(Localman.GetMaxLongitude(State.LAGOS) != 0.0);
        }

        [Fact]
        public void GetMinLatitude()
        {
            Assert.True(Localman.GetMinLatitude(State.LAGOS) != 0.0);
        }

        [Fact]
        public void GetMinLongitude()
        {
            Assert.True(Localman.GetMinLongitude(State.LAGOS) != 0.0);
        }
    }
}
