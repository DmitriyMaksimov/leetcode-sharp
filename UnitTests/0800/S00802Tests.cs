using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00802Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00802();
        Assert.That(sut.EventualSafeNodes(
            [[1, 2], [2, 3], [5], [0], [5], [], []]), Is.EqualTo((int[]) [2, 4, 5, 6]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00802();
        Assert.That(sut.EventualSafeNodes([
            [1, 2, 3, 4], [1, 2], [3, 4], [0, 4], []
        ]), Is.EqualTo((int[]) [4]));
    }
}