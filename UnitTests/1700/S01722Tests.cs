using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01722Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01722();
        Assert.That(sut.MinimumHammingDistance([1, 2, 3, 4], [2, 1, 4, 5], [[0, 1], [2, 3]]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01722();
        Assert.That(sut.MinimumHammingDistance([1, 2, 3, 4], [1, 3, 2, 4], []), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01722();
        Assert.That(sut.MinimumHammingDistance([5, 1, 2, 4, 3], [1, 5, 4, 2, 3], [[0, 4], [4, 2], [1, 3], [1, 4]]), Is.EqualTo(0));
    }
}
