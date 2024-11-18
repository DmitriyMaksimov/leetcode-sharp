using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00838Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00838();
        sut.PushDominoes("RR.L").Should().Be("RR.L");
    }

    [Test]
    public void T2()
    {
        var sut = new S00838();
        sut.PushDominoes(".L.R...LR..L..").Should().Be("LL.RR.LLRRLL..");
    }
}
