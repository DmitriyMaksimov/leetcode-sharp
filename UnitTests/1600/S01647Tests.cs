using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01647Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01647();
        sut.MinDeletions("aab").Should().Be(0);
    }

    [Test]
    public void T2()
    {
        var sut = new S01647();
        sut.MinDeletions("aaabbbcc").Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01647();
        sut.MinDeletions("ceabaacb").Should().Be(2);
    }
}