using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02012Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02012();
        Assert.That(sut.SumOfBeauties([1, 2, 3]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02012();
        Assert.That(sut.SumOfBeauties([2, 4, 6, 4]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02012();
        Assert.That(sut.SumOfBeauties([3, 2, 1]), Is.EqualTo(0));
    }
}
