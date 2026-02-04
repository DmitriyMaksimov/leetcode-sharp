using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03640))]
public class S03640Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03640();
        Assert.That(sut.MaxSumTrionic([0, -2, -1, -3, 0, 2, -1]), Is.EqualTo(-4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03640();
        Assert.That(sut.MaxSumTrionic([1, 4, 2, 7]), Is.EqualTo(14));
    }
}