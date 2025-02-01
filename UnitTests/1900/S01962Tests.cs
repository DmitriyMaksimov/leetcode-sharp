using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01962Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01962();
        Assert.That(sut.MinStoneSum(new[] {5, 4, 9}, 2), Is.EqualTo(12));
    }

    [Test]
    public void T2()
    {
        var sut = new S01962();
        Assert.That(sut.MinStoneSum(new[] {4, 3, 6, 7}, 3), Is.EqualTo(12));
    }
}