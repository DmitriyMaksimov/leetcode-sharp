using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03723))]
public class S03723Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03723();
        Assert.That(sut.MaxSumOfSquares(2, 3), Is.EqualTo("30"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03723();
        Assert.That(sut.MaxSumOfSquares(2, 17), Is.EqualTo("98"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03723();
        Assert.That(sut.MaxSumOfSquares(1, 10), Is.EqualTo(""));
    }
}