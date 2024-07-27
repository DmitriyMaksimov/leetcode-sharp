using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02976Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02976();
        sut.MinimumCost("abcd", "acbe", ['a', 'b', 'c', 'c', 'e', 'd'], ['b', 'c', 'b', 'e', 'b', 'e'], [2, 5, 5, 1, 2, 20]).Should().Be(28);
    }

    [Test]
    public void T2()
    {
        var sut = new S02976();
        sut.MinimumCost("aaaa", "bbbb", ['a', 'c'], ['c', 'b'], [1, 2]).Should().Be(12);
    }

    [Test]
    public void T3()
    {
        var sut = new S02976();
        sut.MinimumCost("abcd", "abce", ['a'], ['e'], [10000]).Should().Be(-1);
    }
}