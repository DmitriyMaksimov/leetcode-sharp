using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00978))]
public class S00978Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00978();
        Assert.That(sut.MaxTurbulenceSize([9, 4, 2, 10, 7, 8, 8, 1, 9]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S00978();
        Assert.That(sut.MaxTurbulenceSize([4, 8, 12, 16]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S00978();
        Assert.That(sut.MaxTurbulenceSize([100]), Is.EqualTo(1));
    }
}