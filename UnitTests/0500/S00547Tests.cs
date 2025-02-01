using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00547Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00547();
        Assert.That(sut.FindCircleNum(new[] {new[] {1, 1, 0}, new[] {1, 1, 0}, new[] {0, 0, 1}}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00547();
        Assert.That(sut.FindCircleNum(new[] {new[] {1, 0, 0}, new[] {0, 1, 0}, new[] {0, 0, 1}}), Is.EqualTo(3));
    }
}