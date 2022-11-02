using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void Determin_returnNumber()
        {
            var number = 4;
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
    }
}