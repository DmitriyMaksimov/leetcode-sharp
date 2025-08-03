using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01578Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01578();
        Assert.That(sut.MinCost("abaac", [1, 2, 3, 4, 5]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01578();
        Assert.That(sut.MinCost("abc", [1, 2, 3]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01578();
        Assert.That(sut.MinCost("aabaa", [1, 2, 3, 4, 1]), Is.EqualTo(2));
    }
}