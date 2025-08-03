using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01848Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01848();
        Assert.That(sut.GetMinDistance([1, 2, 3, 4, 5], 5, 3), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01848();
        Assert.That(sut.GetMinDistance([1], 1, 0), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01848();
        Assert.That(sut.GetMinDistance([1, 1, 1, 1, 1, 1, 1, 1, 1, 1], 1, 0), Is.EqualTo(0));
    }
}