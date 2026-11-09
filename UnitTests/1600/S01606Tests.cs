using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01606))]
public class S01606Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01606();
        Assert.That(sut.BusiestServers(3, [1, 2, 3, 4, 5], [5, 2, 3, 3, 3]), Is.EqualTo([1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01606();
        Assert.That(sut.BusiestServers(3, [1, 2, 3, 4], [1, 2, 1, 2]), Is.EqualTo([0]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01606();
        Assert.That(sut.BusiestServers(3, [1, 2, 3], [10, 12, 11]), Is.EqualTo([0, 1, 2]));
    }
}