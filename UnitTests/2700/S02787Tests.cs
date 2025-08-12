using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02787))]
public class S02787Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02787();
        Assert.That(sut.NumberOfWays(10, 2), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02787();
        Assert.That(sut.NumberOfWays(4, 1), Is.EqualTo(2));
    }
}