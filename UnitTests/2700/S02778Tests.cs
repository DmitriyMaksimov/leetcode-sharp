using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02778Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02778();
        Assert.That(sut.SumOfSquares([1, 2, 3, 4]), Is.EqualTo(21));
    }

    [Test]
    public void T2()
    {
        var sut = new S02778();
        Assert.That(sut.SumOfSquares([2, 7, 1, 19, 18, 3]), Is.EqualTo(63));
    }
}