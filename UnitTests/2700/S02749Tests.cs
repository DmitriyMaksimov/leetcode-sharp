using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02749))]
public class S02749Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02749();
        Assert.That(sut.MakeTheIntegerZero(3, -2), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02749();
        Assert.That(sut.MakeTheIntegerZero(5, 7), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02749();
        Assert.That(sut.MakeTheIntegerZero(112577768, -501662198), Is.EqualTo(16));
    }
}