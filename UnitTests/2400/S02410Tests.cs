using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02410Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02410();
        sut.MatchPlayersAndTrainers([4, 7, 9], [8, 2, 5, 8]).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02410();
        sut.MatchPlayersAndTrainers([1, 1, 1], [10]).Should().Be(1);
    }
}
