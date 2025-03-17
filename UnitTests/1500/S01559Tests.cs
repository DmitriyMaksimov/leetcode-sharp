using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01559Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01559();
        Assert.That(sut.ContainsCycle([['a', 'a', 'a', 'a'], ['a', 'b', 'b', 'a'], ['a', 'b', 'b', 'a'], ['a', 'a', 'a', 'a']]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01559();
        Assert.That(sut.ContainsCycle([['c', 'c', 'c', 'a'], ['c', 'd', 'c', 'c'], ['c', 'c', 'e', 'c'], ['f', 'c', 'c', 'c']]), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S01559();
        Assert.That(sut.ContainsCycle([['a', 'b', 'b'], ['b', 'z', 'b'], ['b', 'b', 'a']]), Is.False);
    }
}
