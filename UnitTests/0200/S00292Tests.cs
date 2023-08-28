using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00292Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00292();
        sut.CanWinNim(4).Should().BeFalse();
    }

    [Test]
    public void T2()
    {
        var sut = new S00292();
        sut.CanWinNim(1).Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S00292();
        sut.CanWinNim(2).Should().BeTrue();
    }

}