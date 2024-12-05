using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02337Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02337();
        sut.CanChange("_L__R__R_", "L______RR").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02337();
        sut.CanChange("R_L_", "__LR").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S02337();
        sut.CanChange("_R", "R_").Should().BeFalse();
    }
}
