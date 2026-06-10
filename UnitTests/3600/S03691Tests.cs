using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03691))]
public class S03691Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03691();
        Assert.That(sut.MaxTotalValue([1, 3, 2], 2), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03691();
        Assert.That(sut.MaxTotalValue([4, 2, 5, 1], 3), Is.EqualTo(12));
    }
}