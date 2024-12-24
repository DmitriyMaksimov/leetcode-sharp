using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02165Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02165();
        sut.SmallestNumber(310).Should().Be(103);
    }

    [Test]
    public void T2()
    {
        var sut = new S02165();
        sut.SmallestNumber(-7605).Should().Be(-7650);
    }
}
