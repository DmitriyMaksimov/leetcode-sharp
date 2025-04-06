using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03471Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03471();
        Assert.That(sut.LargestInteger([3, 9, 2, 1, 7], 3), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S03471();
        Assert.That(sut.LargestInteger([3, 9, 7, 2, 1, 7], 4), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S03471();
        Assert.That(sut.LargestInteger([0, 0], 1), Is.EqualTo(-1));
    }
}
