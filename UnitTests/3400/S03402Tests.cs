using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03402Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03402();
        Assert.That(sut.MinimumOperations([[3, 2], [1, 3], [3, 4], [0, 1]]), Is.EqualTo(15));
    }

    [Test]
    public void T2()
    {
        var sut = new S03402();
        Assert.That(sut.MinimumOperations([[3, 2, 1], [2, 1, 0], [1, 2, 3]]), Is.EqualTo(12));
    }
}
