using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03618))]
public class S03618Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03618();
        Assert.That(sut.SplitArray([2, 3, 4]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03618();
        Assert.That(sut.SplitArray([-1, 5, 7, 0]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S03618();
        Assert.That(sut.SplitArray([175868717,841457609,-948571070,-747264172]), Is.EqualTo(2713161568));
    }
}