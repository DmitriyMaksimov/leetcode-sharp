using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01395Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01395();
        sut.NumTeams([2, 5, 3, 4, 1]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01395();
        sut.NumTeams([2, 1, 3]).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01395();
        sut.NumTeams([1, 2, 3, 4]).Should().Be(4);
    }
}