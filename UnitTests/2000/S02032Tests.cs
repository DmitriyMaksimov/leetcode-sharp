using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02032Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02032();
        sut.TwoOutOfThree(new[] {1, 1, 3, 2}, new[] {2, 3}, new[] {3}).Should().BeEquivalentTo(new[] {3, 2});
    }

    [Test]
    public void T2()
    {
        var sut = new S02032();
        sut.TwoOutOfThree(new[] {3, 1}, new[] {2, 3}, new[] {1, 2}).Should().BeEquivalentTo(new[] {2, 3, 1});
    }

    [Test]
    public void T3()
    {
        var sut = new S02032();
        sut.TwoOutOfThree(new[] {1, 2, 2}, new[] {4, 3, 3}, new[] {5}).Should().BeEquivalentTo(Array.Empty<int>());
    }
}