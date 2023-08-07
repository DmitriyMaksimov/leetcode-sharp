using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00090Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00090();
        sut.SubsetsWithDup(new[] {1, 2, 2}).Should().BeEquivalentTo(
            new[]
            {
                Array.Empty<int>(),
                new[] {1}, new[] {2}, new[] {1, 2}, new[] {2, 2}, new[] {1, 2, 2}
            });
    }

    [Test]
    public void T2()
    {
        var sut = new S00090();
        sut.SubsetsWithDup(new[] {0}).Should().BeEquivalentTo(new[] {Array.Empty<int>(), new[] {0}});
    }
}