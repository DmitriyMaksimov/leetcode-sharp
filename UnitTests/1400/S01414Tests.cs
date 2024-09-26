using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01414Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01414();
        sut.FindMinFibonacciNumbers(7).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01414();
        sut.FindMinFibonacciNumbers(10).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01414();
        sut.FindMinFibonacciNumbers(19).Should().Be(3);
    }
}
