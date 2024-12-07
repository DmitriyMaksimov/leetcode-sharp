using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03360Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03360();
        sut.CanAliceWin(12).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S03360();
        sut.CanAliceWin(1).Should().BeFalse();
    }
}
