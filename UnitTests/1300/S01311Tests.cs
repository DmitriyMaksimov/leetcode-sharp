using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01311Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01311();
        Assert.That(sut.WatchedVideosByFriends([["A", "B"], ["C"], ["B", "C"], ["D"]], [[1, 2], [0, 3], [0, 3], [1, 2]], 0, 1), Is.EqualTo(["B", "C"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01311();
        Assert.That(sut.WatchedVideosByFriends([["A", "B"], ["C"], ["B", "C"], ["D"]], [[1, 2], [0, 3], [0, 3], [1, 2]], 0, 2), Is.EqualTo(["D"]));
    }
}
