using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02125Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02125();
        sut.NumberOfBeams(new[] {"011001", "000000", "010100", "001000"}).Should().Be(8);
    }

    [Test]
    public void T2()
    {
        var sut = new S02125();
        sut.NumberOfBeams(new[] {"000", "111", "000"}).Should().Be(0);
    }
}