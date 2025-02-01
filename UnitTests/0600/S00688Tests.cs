using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00688Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00688();
        Assert.That(sut.KnightProbability(3, 2, 0, 0), Is.EqualTo(0.06250).Within(0.001));
    }

    [Test]
    public void T2()
    {
        var sut = new S00688();
        Assert.That(sut.KnightProbability(1, 0, 0, 0), Is.EqualTo(1).Within(0.001));
    }
}