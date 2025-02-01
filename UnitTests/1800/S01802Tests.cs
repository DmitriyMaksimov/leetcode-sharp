using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01802Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01802();
        Assert.That(sut.MaxValue(4, 2, 6), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01802();
        Assert.That(sut.MaxValue(6, 1, 10), Is.EqualTo(3));
    }
}