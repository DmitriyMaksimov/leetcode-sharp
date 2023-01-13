using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00046Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00046();
        sut.Permute(new[] {1, 2, 3}).Should().BeEquivalentTo(new[] {new[] {1, 2, 3}, new[] {1, 3, 2}, new[] {2, 1, 3}, new[] {2, 3, 1}, new[] {3, 1, 2}, new[] {3, 2, 1}});
    }

    [Test]
    public void T2()
    {
        var sut = new S00046();
        sut.Permute(new[] {0, 1}).Should().BeEquivalentTo(new[] {new[] {0, 1}, new[] {1, 0}});
    }

    [Test]
    public void T3()
    {
        var sut = new S00046();
        sut.Permute(new[] {1}).Should().BeEquivalentTo(new[] {new[] {1}});
    }
}