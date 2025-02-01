using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01545Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01545();
        Assert.That(sut.FindKthBit(3, 1), Is.EqualTo('0'));
    }

    [Test]
    public void T2()
    {
        var sut = new S01545();
        Assert.That(sut.FindKthBit(4, 11), Is.EqualTo('1'));
    }
}
