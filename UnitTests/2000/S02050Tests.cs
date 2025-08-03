using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02050Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02050();
        Assert.That(sut.MinimumTime(3, [[1, 3], [2, 3]], [3, 2, 5]), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S02050();
        Assert.That(sut.MinimumTime(5, [[1, 5], [2, 5], [3, 5], [3, 4], [4, 5]],
            [1, 2, 3, 4, 5]), Is.EqualTo(12));
    }
}