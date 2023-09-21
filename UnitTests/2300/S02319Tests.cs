using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02319Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02319();
        sut.CheckXMatrix(new[] {new[] {2, 0, 0, 1}, new[] {0, 3, 1, 0}, new[] {0, 5, 2, 0}, new[] {4, 0, 0, 2}})
            .Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02319();
        sut.CheckXMatrix(new[] {new[] {5, 7, 0}, new[] {0, 3, 1}, new[] {0, 5, 0}}).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S02319();
        sut.CheckXMatrix(new[] {new[] {0, 2, 1, 0}, new[] {1, 0, 0, 3}, new[] {4, 0, 0, 5}, new[] {0, 3, 3, 0}})
            .Should().BeFalse();
    }
}