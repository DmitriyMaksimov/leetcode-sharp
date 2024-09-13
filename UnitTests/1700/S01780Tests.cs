using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01780Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01780();
        sut.CheckPowersOfThree(12).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01780();
        sut.CheckPowersOfThree(91).Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S01780();
        sut.CheckPowersOfThree(21).Should().BeFalse();
    }
}
