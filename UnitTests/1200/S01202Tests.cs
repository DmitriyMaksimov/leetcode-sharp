using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01202Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01202();
        sut.SmallestStringWithSwaps("dcab", [[0, 3], [1, 2]]).Should().Be("bacd");
    }

    [Test]
    public void T2()
    {
        var sut = new S01202();
        sut.SmallestStringWithSwaps("dcab", [[0, 3], [1, 2], [0, 2]]).Should().Be("abcd");
    }

    [Test]
    public void T3()
    {
        var sut = new S01202();
        sut.SmallestStringWithSwaps("cba", [[0, 1], [1, 2]]).Should().Be("abc");
    }
}
