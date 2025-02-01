using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02427Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02427();
        Assert.That(sut.CommonFactors(12, 6), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02427();
        Assert.That(sut.CommonFactors(25, 30), Is.EqualTo(2));
    }
}