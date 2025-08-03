using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02200Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02200();
        Assert.That(sut.FindKDistantIndices([3, 4, 9, 1, 3, 9, 5], 9, 1), Is.EqualTo((int[]) [1, 2, 3, 4, 5, 6]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02200();
        Assert.That(sut.FindKDistantIndices([2, 2, 2, 2, 2], 2, 2), Is.EqualTo((int[]) [0, 1, 2, 3, 4]));
    }
}