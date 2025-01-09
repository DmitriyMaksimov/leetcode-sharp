using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02380Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02380();
        sut.SecondsToRemoveOccurrences("0110101").Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02380();
        sut.SecondsToRemoveOccurrences("11100").Should().Be(0);
    }
}
