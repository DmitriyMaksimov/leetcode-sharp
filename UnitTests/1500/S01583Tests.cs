using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01583Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01583();
        sut.UnhappyFriends(4, [[1, 2, 3], [3, 2, 0], [3, 1, 0], [1, 2, 0]], [[0, 1], [2, 3]]).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01583();
        sut.UnhappyFriends(2, [[1], [0]], [[1, 0]]).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01583();
        sut.UnhappyFriends(4, [[1, 3, 2], [2, 3, 0], [1, 3, 0], [0, 2, 1]], [[1, 3], [0, 2]]).Should().Be(4);
    }
}
