using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02050Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02050();
        Assert.That(sut.MinimumTime(3, new[] {new[] {1, 3}, new[] {2, 3}}, new[] {3, 2, 5}), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S02050();
        Assert.That(sut.MinimumTime(5, new[] {new[] {1, 5}, new[] {2, 5}, new[] {3, 5}, new[] {3, 4}, new[] {4, 5}},
            new[] {1, 2, 3, 4, 5}), Is.EqualTo(12));
    }
}