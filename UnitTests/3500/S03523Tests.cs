using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03523Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03523();
        Assert.That(sut.MaximumPossibleSize([4, 2, 5, 3, 5]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03523();
        Assert.That(sut.MaximumPossibleSize([1, 2, 3]), Is.EqualTo(3));
    }
}
