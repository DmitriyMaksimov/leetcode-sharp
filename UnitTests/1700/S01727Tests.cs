using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01727Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01727();
        Assert.That(sut.LargestSubmatrix([[0, 0, 1], [1, 1, 1], [1, 0, 1]]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01727();
        Assert.That(sut.LargestSubmatrix([[1, 0, 1, 0, 1]]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01727();
        Assert.That(sut.LargestSubmatrix([[1, 1, 0], [1, 0, 1]]), Is.EqualTo(2));
    }
}