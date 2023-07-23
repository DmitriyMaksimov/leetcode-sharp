using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02244Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02244();
        sut.MinimumRounds(new[] {2, 2, 3, 3, 2, 4, 4, 4, 4, 4}).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02244();
        sut.MinimumRounds(new[] {2, 3, 3}).Should().Be(-1);
    }

    [Test]
    public void T3()
    {
        var sut = new S02244();
        sut.MinimumRounds(new[] {2}).Should().Be(-1);
    }

    [Test]
    public void T4()
    {
        var sut = new S02244();
        sut.MinimumRounds(new[] {1, 2, 1}).Should().Be(-1);
    }
}