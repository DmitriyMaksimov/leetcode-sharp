using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01267Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01267();
        sut.CountServers([[1, 0], [0, 1]]).Should().Be(0);
    }

    [Test]
    public void T2()
    {
        var sut = new S01267();
        sut.CountServers([[1, 0], [1, 1]]).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S01267();
        sut.CountServers([[1, 1, 0, 0], [0, 0, 1, 0], [0, 0, 1, 0], [0, 0, 0, 1]]).Should().Be(4);
    }
}
