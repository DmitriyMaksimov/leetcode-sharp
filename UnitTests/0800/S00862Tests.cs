using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00862Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00862();
        Assert.That(sut.ShortestSubarray([1], 1), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00862();
        Assert.That(sut.ShortestSubarray([1, 2], 4), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S00862();
        Assert.That(sut.ShortestSubarray([2, -1, 2], 3), Is.EqualTo(3));
    }
}
