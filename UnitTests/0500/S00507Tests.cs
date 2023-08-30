using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00507Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00507();
        sut.CheckPerfectNumber(28).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00507();
        sut.CheckPerfectNumber(7).Should().BeFalse();
    }

}