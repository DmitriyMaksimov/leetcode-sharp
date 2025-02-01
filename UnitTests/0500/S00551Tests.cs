using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00551Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00551();
        Assert.That(sut.CheckRecord("PPALLP"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00551();
        Assert.That(sut.CheckRecord("PPALLL"), Is.False);
    }
}
