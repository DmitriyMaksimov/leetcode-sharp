using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03162Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03162();
        Assert.That(sut.NumberOfPairs([1, 3, 4], [1, 3, 4], 1), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03162();
        Assert.That(sut.NumberOfPairs([1, 2, 4, 12], [2, 4], 3), Is.EqualTo(2));
    }
}