using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00416Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00416();
        Assert.That(sut.CanPartition(new[] {1, 5, 11, 5}), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00416();
        Assert.That(sut.CanPartition(new[] {1, 2, 3, 5}), Is.False);
    }
}
