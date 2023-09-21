using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02278Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02278();
        sut.PercentageLetter("foobar", 'o').Should().Be(33);
    }

    [Test]
    public void T2()
    {
        var sut = new S02278();
        sut.PercentageLetter("jjjj", 'k').Should().Be(0);
    }
}