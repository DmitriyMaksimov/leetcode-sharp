using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02745Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02745();
        Assert.That(sut.LongestString(2, 5, 1), Is.EqualTo(12));
    }

    [Test]
    public void T2()
    {
        var sut = new S02745();
        Assert.That(sut.LongestString(3, 2, 2), Is.EqualTo(14));
    }
}
