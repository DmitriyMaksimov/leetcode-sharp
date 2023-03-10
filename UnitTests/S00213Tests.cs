using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00213Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00213();
        sut.Rob(new[] {1, 2, 3, 1}).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00213();
        sut.Rob(new[] {2, 3, 2}).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S00213();
        sut.Rob(new[] {1, 2, 3}).Should().Be(3);
    }

    [Test]
    public void T4()
    {
        var sut = new S00213();
        sut.Rob(new[] {1}).Should().Be(1);
    }

    [Test]
    public void T5()
    {
        var sut = new S00213();
        sut.Rob(new[] {1, 2, 1, 1}).Should().Be(3);
    }
}