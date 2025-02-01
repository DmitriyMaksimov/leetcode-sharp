using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02600Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02600();
        Assert.That(sut.KItemsWithMaximumSum(3, 2, 0, 2), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02600();
        Assert.That(sut.KItemsWithMaximumSum(3, 2, 0, 4), Is.EqualTo(3));
    }
}