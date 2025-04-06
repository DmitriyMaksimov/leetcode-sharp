using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03487Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03487();
        Assert.That(sut.MaxSum([1, 2, 3, 4, 5]), Is.EqualTo(15));
    }

    [Test]
    public void T2()
    {
        var sut = new S03487();
        Assert.That(sut.MaxSum([1, 1, 0, 1, 1]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03487();
        Assert.That(sut.MaxSum([1, 2, -1, -2, 1, 0, -1]), Is.EqualTo(3));
    }
}
