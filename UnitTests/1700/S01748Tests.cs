using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01748Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01748();
        Assert.That(sut.SumOfUnique([1, 2, 3, 2]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01748();
        Assert.That(sut.SumOfUnique([1, 1, 1, 1, 1]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01748();
        Assert.That(sut.SumOfUnique([1, 2, 3, 4, 5]), Is.EqualTo(15));
    }
}