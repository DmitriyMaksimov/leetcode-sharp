using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00202Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00202();
        sut.IsHappy(19).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00202();
        sut.IsHappy(2).Should().BeFalse();
    }
}