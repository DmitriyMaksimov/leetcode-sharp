using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00045Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00045();
        sut.Jump(new[] {2, 3, 1, 1, 4}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00045();
        sut.Jump(new[] {2, 3, 0, 1, 4}).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S00045();
        sut.Jump(new[] {0}).Should().Be(0);
    }

    [Test]
    public void T4()
    {
        var sut = new S00045();
        sut.Jump(new[] {1, 2, 3}).Should().Be(2);
    }
}