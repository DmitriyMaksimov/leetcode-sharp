using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01884Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01884();
        Assert.That(sut.TwoEggDrop(2), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01884();
        Assert.That(sut.TwoEggDrop(100), Is.EqualTo(14));
    }
}