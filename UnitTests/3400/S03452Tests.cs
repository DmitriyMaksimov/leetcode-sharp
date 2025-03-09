using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03452Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03452();
        Assert.That(sut.SumOfGoodNumbers([1, 3, 2, 1, 5, 4], 2), Is.EqualTo(12));
    }

    [Test]
    public void T2()
    {
        var sut = new S03452();
        Assert.That(sut.SumOfGoodNumbers([2, 1], 1), Is.EqualTo(2));
    }
}
