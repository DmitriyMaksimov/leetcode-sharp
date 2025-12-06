using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03745))]
public class S03745Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03745();
        Assert.That(sut.MaximizeExpressionOfThree([1, 4, 2, 5]), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S03745();
        Assert.That(sut.MaximizeExpressionOfThree([-2, 0, 5, -2, 4]), Is.EqualTo(11));
    }

    [Test]
    public void T3()
    {
        var sut = new S03745();
        Assert.That(sut.MaximizeExpressionOfThree([-4, -8, -10]), Is.EqualTo(-2));
    }
}