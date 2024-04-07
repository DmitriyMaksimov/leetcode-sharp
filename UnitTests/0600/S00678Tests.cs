using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00678Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00678();
        sut.CheckValidString("()").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00678();
        sut.CheckValidString("(*)").Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S00678();
        sut.CheckValidString("(*))").Should().BeTrue();
    }
}