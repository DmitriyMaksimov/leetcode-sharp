using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00342Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00342();
        sut.IsPowerOfFour(16).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00342();
        sut.IsPowerOfFour(5).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00342();
        sut.IsPowerOfFour(1).Should().BeTrue();
    }
}