using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00934Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00934();
        sut.ShortestBridge(new[] {new[] {0, 1}, new[] {1, 0}}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00934();
        sut.ShortestBridge(new[] {new[] {0, 1, 0}, new[] {0, 0, 0}, new[] {0, 0, 1}}).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S00934();
        sut.ShortestBridge(new[] {new[] {1, 1, 1, 1, 1}, new[] {1, 0, 0, 0, 1}, new[] {1, 0, 1, 0, 1}, new[] {1, 0, 0, 0, 1}, new[] {1, 1, 1, 1, 1}}).Should().Be(1);
    }
}