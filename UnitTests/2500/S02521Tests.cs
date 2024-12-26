using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02521Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02521();
        sut.DistinctPrimeFactors([2, 4, 3, 7, 10, 6]).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02521();
        sut.DistinctPrimeFactors([2, 4, 8, 16]).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S02521();
        sut.DistinctPrimeFactors([27]).Should().Be(1);
    }
}
