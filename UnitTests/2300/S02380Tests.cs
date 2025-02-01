using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02380Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02380();
        Assert.That(sut.SecondsToRemoveOccurrences("0110101"), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02380();
        Assert.That(sut.SecondsToRemoveOccurrences("11100"), Is.EqualTo(0));
    }
}
