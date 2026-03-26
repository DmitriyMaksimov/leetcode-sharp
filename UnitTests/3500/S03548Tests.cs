using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03548))]
public class S03548Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03548();
        Assert.That(sut.CanPartitionGrid([[1, 4], [2, 3]]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03548();
        Assert.That(sut.CanPartitionGrid([[1, 2], [3, 4]]), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S03548();
        Assert.That(sut.CanPartitionGrid([[1, 2, 4], [2, 3, 5]]), Is.False);
    }
}