using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02232Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02232();
        sut.MinimizeResult("247+38").Should().Be("2(47+38)");
    }

    [Test]
    public void T2()
    {
        var sut = new S02232();
        sut.MinimizeResult("12+34").Should().Be("1(2+3)4");
    }

    [Test]
    public void T3()
    {
        var sut = new S02232();
        sut.MinimizeResult("999+999").Should().Be("(999+999)");
    }
}
