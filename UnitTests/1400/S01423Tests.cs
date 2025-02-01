using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01423Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01423();
        Assert.That(sut.MaxScore([1, 2, 3, 4, 5, 6, 1], 3), Is.EqualTo(12));
    }

    [Test]
    public void T2()
    {
        var sut = new S01423();
        Assert.That(sut.MaxScore([2, 2, 2], 2), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S01423();
        Assert.That(sut.MaxScore([9, 7, 7, 9, 7, 7, 9], 7), Is.EqualTo(55));
    }
}
