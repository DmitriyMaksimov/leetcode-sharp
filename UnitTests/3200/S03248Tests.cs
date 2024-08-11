using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03248Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03248();
        sut.FinalPositionOfSnake(2, ["RIGHT", "DOWN"]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S03248();
        sut.FinalPositionOfSnake(3, ["DOWN", "RIGHT", "UP"]).Should().Be(1);
    }
}
