using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03025))]
public class S03025Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03025();
        Assert.That(sut.NumberOfPairs([[1, 1], [2, 2], [3, 3]]), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S03025();
        Assert.That(sut.NumberOfPairs([[6, 2], [4, 4], [2, 6]]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03025();
        Assert.That(sut.NumberOfPairs([[3, 1], [1, 3], [1, 1]]), Is.EqualTo(2));
    }
}