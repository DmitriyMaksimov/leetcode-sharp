using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00659Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00659();
        Assert.That(sut.IsPossible([1, 2, 3, 3, 4, 5]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00659();
        Assert.That(sut.IsPossible([1, 2, 3, 3, 4, 4, 5, 5]), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S00659();
        Assert.That(sut.IsPossible([1, 2, 3, 4, 4, 5]), Is.False);
    }
}
