using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00526Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00526();
        Assert.That(sut.CountArrangement(2), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00526();
        Assert.That(sut.CountArrangement(1), Is.EqualTo(1));
    }
}
