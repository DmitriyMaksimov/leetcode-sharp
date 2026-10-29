using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03841))]
public class S03841Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03841();
        Assert.That(sut.PalindromePath(3, [[0, 1], [1, 2]], "aac", ["query 0 2", "update 1 b", "query 0 2"]), Is.EqualTo([true, false]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03841();
        Assert.That(sut.PalindromePath(4, [[0, 1], [0, 2], [0, 3]], "abca", ["query 1 2", "update 0 b", "query 2 3", "update 3 a", "query 1 3"]), Is.EqualTo([false, false, true]));
    }
}