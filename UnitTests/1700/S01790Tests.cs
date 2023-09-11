using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01790Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01790();
        sut.AreAlmostEqual("bank", "kanb").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01790();
        sut.AreAlmostEqual("attack", "defend").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S01790();
        sut.AreAlmostEqual("kelb", "kelb").Should().BeTrue();
    }
}