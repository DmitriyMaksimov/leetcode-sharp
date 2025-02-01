using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01664Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01664();
        Assert.That(sut.WaysToMakeFair([2, 1, 6, 4]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01664();
        Assert.That(sut.WaysToMakeFair([1, 1, 1]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01664();
        Assert.That(sut.WaysToMakeFair([1, 2, 3]), Is.EqualTo(0));
    }
}
