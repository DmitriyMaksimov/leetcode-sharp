using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02016Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02016();
        Assert.That(sut.MaximumDifference([7, 1, 5, 4]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02016();
        Assert.That(sut.MaximumDifference([9, 4, 3, 2]), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02016();
        Assert.That(sut.MaximumDifference([1, 5, 2, 10]), Is.EqualTo(9));
    }
}