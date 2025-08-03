using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02106))]
public class S02106Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02106();
        Assert.That(sut.MaxTotalFruits([[2, 8], [6, 3], [8, 6]], 5, 4), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S02106();
        Assert.That(sut.MaxTotalFruits([[0, 9], [4, 1], [5, 7], [6, 2], [7, 4], [10, 9]], 5, 4),
            Is.EqualTo(14));
    }

    [Test]
    public void T3()
    {
        var sut = new S02106();
        Assert.That(sut.MaxTotalFruits([[0, 3], [6, 4], [8, 5]], 3, 2), Is.EqualTo(0));
    }
}