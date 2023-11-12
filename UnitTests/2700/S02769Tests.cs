using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02769Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02769();
        sut.TheMaximumAchievableX(4, 1).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S02769();
        sut.TheMaximumAchievableX(3, 2).Should().Be(7);
    }
}