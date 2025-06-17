using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03405))]
public class S03405Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03405();
        Assert.That(sut.CountGoodArrays(3, 2, 1), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03405();
        Assert.That(sut.CountGoodArrays(4, 2, 2), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S03405();
        Assert.That(sut.CountGoodArrays(5, 2, 0), Is.EqualTo(2));
    }
}