using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02956Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02956();
        Assert.That(sut.FindIntersectionValues([4, 3, 2, 3, 1], [2, 2, 5, 2, 3, 6]), Is.EqualTo((int[]) [3, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02956();
        Assert.That(sut.FindIntersectionValues([3, 4, 2, 3], [1, 5]), Is.EqualTo((int[]) [0, 0]));
    }
}