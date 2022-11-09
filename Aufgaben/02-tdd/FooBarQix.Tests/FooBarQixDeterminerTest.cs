using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(13)]
        public void Determin_returnNumber(int number)
        {
            var testee = new FooBarQixDeterminer();
            var result = testee.Determine(number);

            Assert.Equal(number.ToString(), result);
        }
        [Fact]
        public void Determin_returnFoo()
        {
            var number = 3;
            var testee = new FooBarQixDeterminer();
            var result = testee.Determine(number);

            Assert.Equal("Foo", result);
        }
        [Fact]
        public void Determin_returnBar()
        {
            var number = 5;
            var testee = new FooBarQixDeterminer();
            var result = testee.Determine(number);

            Assert.Equal("Bar", result);
        }
        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        public void Determin_returnFooBar(int number)
        {
            var testee = new FooBarQixDeterminer();
            var result = testee.Determine(number);

            Assert.Equal("FooBar", result);
        }
    }
}