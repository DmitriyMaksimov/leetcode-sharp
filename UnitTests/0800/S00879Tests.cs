using leetcode_sharp;

namespace UnitTests;

public class S00879Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00879();
        Assert.That(sut.ProfitableSchemes(5, 3, [2, 2], [2, 3]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00879();
        Assert.That(sut.ProfitableSchemes(10, 5, [2, 3, 5], [6, 7, 8]), Is.EqualTo(7));
    }
}