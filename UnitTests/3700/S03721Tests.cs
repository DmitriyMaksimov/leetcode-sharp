using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03721))]
public class S03721Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03721();
        Assert.That(sut.LongestBalanced([2, 5, 4, 3]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03721();
        Assert.That(sut.LongestBalanced([3, 2, 2, 5, 4]), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S03721();
        Assert.That(sut.LongestBalanced([1, 2, 3, 2]), Is.EqualTo(3));
    }
}