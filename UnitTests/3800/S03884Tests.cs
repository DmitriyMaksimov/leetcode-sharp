using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03884))]
public class S03884Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03884();
        Assert.That(sut.FirstMatchingIndex("abcacbd"), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03884();
        Assert.That(sut.FirstMatchingIndex("abc"), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03884();
        Assert.That(sut.FirstMatchingIndex("abcdab"), Is.EqualTo(-1));
    }
}