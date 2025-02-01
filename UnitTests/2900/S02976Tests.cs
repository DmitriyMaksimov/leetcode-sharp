using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02976Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02976();
        Assert.That(sut.MinimumCost("abcd", "acbe", ['a', 'b', 'c', 'c', 'e', 'd'], ['b', 'c', 'b', 'e', 'b', 'e'], [2, 5, 5, 1, 2, 20]), Is.EqualTo(28));
    }

    [Test]
    public void T2()
    {
        var sut = new S02976();
        Assert.That(sut.MinimumCost("aaaa", "bbbb", ['a', 'c'], ['c', 'b'], [1, 2]), Is.EqualTo(12));
    }

    [Test]
    public void T3()
    {
        var sut = new S02976();
        Assert.That(sut.MinimumCost("abcd", "abce", ['a'], ['e'], [10000]), Is.EqualTo(-1));
    }
}