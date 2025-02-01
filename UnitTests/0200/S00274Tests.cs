using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00274Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00274();
        Assert.That(sut.HIndex(new[] {3, 0, 6, 1, 5}), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00274();
        Assert.That(sut.HIndex(new[] {1, 3, 1}), Is.EqualTo(1));
    }
}