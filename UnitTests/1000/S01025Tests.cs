using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01025Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01025();
        sut.DivisorGame(2).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01025();
        sut.DivisorGame(3).Should().BeFalse();
    }
}