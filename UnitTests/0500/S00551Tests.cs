using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00551Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00551();
        sut.CheckRecord("PPALLP").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00551();
        sut.CheckRecord("PPALLL").Should().BeFalse();
    }
}