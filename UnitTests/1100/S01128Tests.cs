using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01128Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01128();
        sut.NumEquivDominoPairs(new[] {new[] {1, 2}, new[] {2, 1}, new[] {3, 4}, new[] {5, 6}}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01128();
        sut.NumEquivDominoPairs(new[] {new[] {1, 2}, new[] {1, 2}, new[] {1, 1}, new[] {1, 2}, new[] {2, 2}}).Should()
            .Be(3);
    }
}