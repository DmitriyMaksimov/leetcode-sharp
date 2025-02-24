using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02467Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02467();
        Assert.That(sut.MostProfitablePath([[0, 1], [1, 2], [1, 3], [3, 4]], 3, [-2, 4, 2, -4, 6]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S02467();
        Assert.That(sut.MostProfitablePath([[0, 1]], 1, [-7280, 2350]), Is.EqualTo(-7280));
    }
}
