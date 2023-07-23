using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01799Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01799();
        sut.MaxScore(new[] {1, 2}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01799();
        sut.MaxScore(new[] {3, 4, 6, 8}).Should().Be(11);
    }

    [Test]
    public void T3()
    {
        var sut = new S01799();
        sut.MaxScore(new[] {1, 2, 3, 4, 5, 6}).Should().Be(14);
    }
}