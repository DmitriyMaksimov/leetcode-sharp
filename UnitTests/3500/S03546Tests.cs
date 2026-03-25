using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03546))]
public class S03546Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03546();
        Assert.That(sut.CanPartitionGrid([[1, 4], [2, 3]]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03546();
        Assert.That(sut.CanPartitionGrid([[1, 3], [2, 4]]), Is.False);
    }
}