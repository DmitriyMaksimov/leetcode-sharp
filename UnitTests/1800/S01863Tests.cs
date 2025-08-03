using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01863Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01863();
        Assert.That(sut.SubsetXORSum([1, 3]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S01863();
        Assert.That(sut.SubsetXORSum([5, 1, 6]), Is.EqualTo(28));
    }

    [Test]
    public void T3()
    {
        var sut = new S01863();
        Assert.That(sut.SubsetXORSum([3, 4, 5, 6, 7, 8]), Is.EqualTo(480));
    }
}