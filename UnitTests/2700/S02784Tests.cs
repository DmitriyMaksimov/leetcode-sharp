using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02784Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02784();
        sut.IsGood(new[] {2, 1, 3}).Should().BeFalse();
    }

    [Test]
    public void T2()
    {
        var sut = new S02784();
        sut.IsGood(new[] {1, 3, 3, 2}).Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S02784();
        sut.IsGood(new[] {1, 1}).Should().BeTrue();
    }

    [Test]
    public void T4()
    {
        var sut = new S02784();
        sut.IsGood(new[] {3, 4, 4, 1, 2, 1}).Should().BeFalse();
    }
}