using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03131Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03131();
        sut.AddedInteger([2, 6, 4], [9, 7, 5]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S03131();
        sut.AddedInteger([10], [5]).Should().Be(-5);
    }

    [Test]
    public void T3()
    {
        var sut = new S03131();
        sut.AddedInteger([1, 1, 1, 1], [1, 1, 1, 1]).Should().Be(0);
    }
}