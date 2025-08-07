using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03363))]
public class S03363Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03363();
        Assert.That(sut.MaxCollectedFruits([[1, 2, 3, 4], [5, 6, 8, 7], [9, 10, 11, 12], [13, 14, 15, 16]]),
            Is.EqualTo(100));
    }

    [Test]
    public void T2()
    {
        var sut = new S03363();
        Assert.That(sut.MaxCollectedFruits([[1, 1], [1, 1]]), Is.EqualTo(4));
    }
}