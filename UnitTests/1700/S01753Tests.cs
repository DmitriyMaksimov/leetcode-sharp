using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01753Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01753();
        sut.MaximumScore(2, 4, 6).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S01753();
        sut.MaximumScore(4, 4, 6).Should().Be(7);
    }

    [Test]
    public void T3()
    {
        var sut = new S01753();
        sut.MaximumScore(1, 8, 8).Should().Be(8);
    }
}
