using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00152Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00152();
        Assert.That(sut.MaxProduct([2, 3, -2, 4]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S00152();
        Assert.That(sut.MaxProduct([-2, 0, -1]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S00152();
        Assert.That(sut.MaxProduct([-2, 3, -4]), Is.EqualTo(24));
    }
}