using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01752Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01752();
        sut.Check(new[] {3, 4, 5, 1, 2}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01752();
        sut.Check(new[] {2, 1, 3, 4}).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S01752();
        sut.Check(new[] {1, 2, 3}).Should().BeTrue();
    }
}