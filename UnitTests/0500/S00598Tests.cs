using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00598Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00598();
        Assert.That(sut.MaxCount(3, 3, new[] {new[] {2, 2}, new[] {3, 3}}), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00598();
        Assert.That(sut.MaxCount(3, 3,
            new[]
            {
                new[] {2, 2}, new[] {3, 3}, new[] {3, 3}, new[] {2, 2}, new[] {3, 3}, new[] {3, 3}, new[] {3, 3},
                new[] {2, 2}, new[] {3, 3}, new[] {3, 3}, new[] {3, 3}
            }), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S00598();
        Assert.That(sut.MaxCount(3, 3, Array.Empty<int[]>()), Is.EqualTo(9));
    }
}