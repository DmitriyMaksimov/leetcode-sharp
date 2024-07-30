using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01653Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01653();
        sut.MinimumDeletions("aababbab").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01653();
        sut.MinimumDeletions("bbaaaaabb").Should().Be(2);
    }
}