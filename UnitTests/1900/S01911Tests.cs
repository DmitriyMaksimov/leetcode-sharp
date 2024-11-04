using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01911Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01911();
        sut.MaxAlternatingSum([4, 2, 5, 3]).Should().Be(7);
    }

    [Test]
    public void T2()
    {
        var sut = new S01911();
        sut.MaxAlternatingSum([5, 6, 7, 8]).Should().Be(8);
    }

    [Test]
    public void T3()
    {
        var sut = new S01911();
        sut.MaxAlternatingSum([6, 2, 1, 2, 4, 5]).Should().Be(10);
    }
}
