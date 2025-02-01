using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02899Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02899();
        Assert.That(sut.LastVisitedIntegers(new[] {"1", "2", "prev", "prev", "prev"}), Is.EqualTo((int[]) [2, 1, -1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02899();
        Assert.That(sut.LastVisitedIntegers(new[] {"1", "prev", "2", "prev", "prev"}), Is.EqualTo((int[]) [1, 2, 1]));
    }
}