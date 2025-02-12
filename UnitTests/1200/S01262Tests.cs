using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01262Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01262();
        Assert.That(sut.MaxSumDivThree([3, 6, 5, 1, 8]), Is.EqualTo(18));
    }

    [Test]
    public void T2()
    {
        var sut = new S01262();
        Assert.That(sut.MaxSumDivThree([4]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01262();
        Assert.That(sut.MaxSumDivThree([1, 2, 3, 4, 4]), Is.EqualTo(12));
    }
}
