using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03627))]
public class S03627Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03627();
        Assert.That(sut.MaximumMedianSum([2, 1, 3, 2, 1, 3]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03627();
        Assert.That(sut.MaximumMedianSum([1, 1, 10, 10, 10, 10]), Is.EqualTo(20));
    }
}