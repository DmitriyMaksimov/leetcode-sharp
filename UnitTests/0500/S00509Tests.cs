using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00509Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00509();
        sut.Fib(2).Should().Be(1);
    }
    [Test]
    public void T2()
    {
        var sut = new S00509();
        sut.Fib(3).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S00509();
        sut.Fib(4).Should().Be(3);
    }
}