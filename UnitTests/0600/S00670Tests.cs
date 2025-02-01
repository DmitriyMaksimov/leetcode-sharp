using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00670Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00670();
        Assert.That(sut.MaximumSwap(2736), Is.EqualTo(7236));
    }

    [Test]
    public void T2()
    {
        var sut = new S00670();
        Assert.That(sut.MaximumSwap(9973), Is.EqualTo(9973));
    }
}
