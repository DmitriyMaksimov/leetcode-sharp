using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00598Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00598();
        sut.MaxCount(3, 3, new[] {new[] {2, 2}, new[] {3, 3}}).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00598();
        sut.MaxCount(3, 3,
            new[]
            {
                new[] {2, 2}, new[] {3, 3}, new[] {3, 3}, new[] {2, 2}, new[] {3, 3}, new[] {3, 3}, new[] {3, 3},
                new[] {2, 2}, new[] {3, 3}, new[] {3, 3}, new[] {3, 3}
            }).Should().Be(4);
    }

    [Test]
    public void T3()
    {
        var sut = new S00598();
        sut.MaxCount(3, 3, Array.Empty<int[]>()).Should().Be(9);
    }
}