using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03258Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03258();
        sut.CountKConstraintSubstrings("10101", 1).Should().Be(12);
    }

    [Test]
    public void T2()
    {
        var sut = new S03258();
        sut.CountKConstraintSubstrings("1010101", 2).Should().Be(25);
    }

    [Test]
    public void T3()
    {
        var sut = new S03258();
        sut.CountKConstraintSubstrings("11111", 1).Should().Be(15);
    }
}
