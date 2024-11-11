using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02601Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02601();
        sut.PrimeSubOperation([4, 9, 6, 10]).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02601();
        sut.PrimeSubOperation([6, 8, 11, 12]).Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S02601();
        sut.PrimeSubOperation([5, 8, 3]).Should().BeFalse();
    }
}
