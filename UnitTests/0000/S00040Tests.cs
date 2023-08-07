using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00040Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00040();
        sut.CombinationSum2(new[] {10, 1, 2, 7, 6, 1, 5}, 8).Should().BeEquivalentTo(
            new[]
            {
                new[] {1, 1, 6}, new[] {1, 2, 5}, new[] {1, 7}, new[] {2, 6}
            });
    }

    [Test]
    public void T2()
    {
        var sut = new S00040();
        sut.CombinationSum2(new[] {2, 5, 2, 1, 2}, 5).Should()
            .BeEquivalentTo(new[] {new[] {1, 2, 2}, new[] {5}});
    }
}