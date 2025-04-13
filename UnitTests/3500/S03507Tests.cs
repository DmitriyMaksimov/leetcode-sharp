using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03507Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03507();
        Assert.That(sut.MinimumPairRemoval([5, 2, 3, 1]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03507();
        Assert.That(sut.MinimumPairRemoval([1, 2, 2]), Is.EqualTo(0));
    }
}
