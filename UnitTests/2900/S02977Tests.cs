using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02977))]
public class S02977Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02977();
        Assert.That(sut.MinimumCost("abcd", "acbe", ["a", "b", "c", "c", "e", "d"], ["b", "c", "b", "e", "b", "e"], [2, 5, 5, 1, 2, 20]), Is.EqualTo(28));
    }

    [Test]
    public void T2()
    {
        var sut = new S02977();
        Assert.That(sut.MinimumCost("abcdefgh", "acdeeghh", ["bcd", "fgh", "thh"], ["cde", "thh", "ghh"], [1, 3, 5]), Is.EqualTo(9));
    }

    [Test]
    public void T3()
    {
        var sut = new S02977();
        Assert.That(sut.MinimumCost("abcdefgh", "addddddd", ["bcd", "defgh"], ["ddd", "ddddd"], [100, 1578]), Is.EqualTo(-1));
    }
}