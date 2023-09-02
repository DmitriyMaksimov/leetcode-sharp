using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00693Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00693();
        sut.HasAlternatingBits(5).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00693();
        sut.HasAlternatingBits(7).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00693();
        sut.HasAlternatingBits(11).Should().BeFalse();
    }
}