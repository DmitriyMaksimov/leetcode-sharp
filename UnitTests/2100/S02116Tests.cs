using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02116Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02116();
        sut.CanBeValid("))()))", "010100").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02116();
        sut.CanBeValid("()()", "0000").Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S02116();
        sut.CanBeValid(")", "0").Should().BeFalse();
    }
}
