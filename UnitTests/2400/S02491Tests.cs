using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02491Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02491();
        sut.DividePlayers([3, 2, 5, 1, 3, 4]).Should().Be(22);
    }

    [Test]
    public void T2()
    {
        var sut = new S02491();
        sut.DividePlayers([3, 4]).Should().Be(12);
    }

    [Test]
    public void T3()
    {
        var sut = new S02491();
        sut.DividePlayers([1, 1, 2, 3]).Should().Be(-1);
    }
}
