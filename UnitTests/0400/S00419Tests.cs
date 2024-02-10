using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00419Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00419();
        sut.CountBattleships([['X', '.', '.', 'X'], ['.', '.', '.', 'X'], ['.', '.', '.', 'X']]).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00419();
        sut.CountBattleships([['.']]).Should().Be(0);
    }
}