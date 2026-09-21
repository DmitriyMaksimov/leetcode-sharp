using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03524))]
public class S03524Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03524();
        Assert.That(sut.ResultArray([1, 2, 3, 4, 5], 3), Is.EqualTo([9, 2, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03524();
        Assert.That(sut.ResultArray([1, 2, 4, 8, 16, 32], 4), Is.EqualTo([18, 1, 2, 0]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03524();
        Assert.That(sut.ResultArray([1, 1, 2, 1, 1], 2), Is.EqualTo([9, 6]));
    }
}