using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02682Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02682();
        Assert.That(sut.CircularGameLosers(5, 2), Is.EqualTo((int[]) [4, 5]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02682();
        Assert.That(sut.CircularGameLosers(4, 4), Is.EqualTo((int[]) [2, 3, 4]));
    }
}