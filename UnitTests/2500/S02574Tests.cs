using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02574Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02574();
        Assert.That(sut.LeftRightDifference([10, 4, 8, 3]), Is.EqualTo((int[]) [15, 1, 11, 22]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02574();
        Assert.That(sut.LeftRightDifference([1]), Is.EqualTo((int[]) [0]));
    }
}