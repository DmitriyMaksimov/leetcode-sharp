using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02573))]
public class S02573Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02573();
        Assert.That(sut.FindTheString([[4, 0, 2, 0], [0, 3, 0, 1], [2, 0, 2, 0], [0, 1, 0, 1]]), Is.EqualTo("abab"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02573();
        Assert.That(sut.FindTheString([[4, 3, 2, 1], [3, 3, 2, 1], [2, 2, 2, 1], [1, 1, 1, 1]]), Is.EqualTo("aaaa"));
    }

    [Test]
    public void T3()
    {
        var sut = new S02573();
        Assert.That(sut.FindTheString([[4, 3, 2, 1], [3, 3, 2, 1], [2, 2, 2, 1], [1, 1, 1, 3]]), Is.EqualTo(""));
    }
}