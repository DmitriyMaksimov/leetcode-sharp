using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02652Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02652();
        sut.SumOfMultiples(7).Should().Be(21);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02652();
        sut.SumOfMultiples(10).Should().Be(40);
    }

    [Test]
    public void T3()
    {
        var sut = new S02652();
        sut.SumOfMultiples(9).Should().Be(30);
    }
}