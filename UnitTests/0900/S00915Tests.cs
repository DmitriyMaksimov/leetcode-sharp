using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00915Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00915();
        Assert.That(sut.PartitionDisjoint([5, 0, 3, 8, 6]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00915();
        Assert.That(sut.PartitionDisjoint([1, 1, 1, 0, 6, 12]), Is.EqualTo(4));
    }
}
