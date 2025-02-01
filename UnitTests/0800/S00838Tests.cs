using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00838Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00838();
        Assert.That(sut.PushDominoes("RR.L"), Is.EqualTo("RR.L"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00838();
        Assert.That(sut.PushDominoes(".L.R...LR..L.."), Is.EqualTo("LL.RR.LLRRLL.."));
    }
}
