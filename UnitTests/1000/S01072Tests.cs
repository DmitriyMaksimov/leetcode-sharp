using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01072Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01072();
        Assert.That(sut.MaxEqualRowsAfterFlips([[0, 1], [1, 1]]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01072();
        Assert.That(sut.MaxEqualRowsAfterFlips([[0, 1], [1, 0]]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01072();
        Assert.That(sut.MaxEqualRowsAfterFlips([[0, 0, 0], [0, 0, 1], [1, 1, 0]]), Is.EqualTo(2));
    }
}
