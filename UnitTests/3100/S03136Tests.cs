using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03136Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03136();
        sut.IsValid("234Adas").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S03136();
        sut.IsValid("b3").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S03136();
        sut.IsValid("a3$e").Should().BeFalse();
    }
}