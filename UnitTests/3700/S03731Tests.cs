using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03731))]
public class S03731Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03731();
        Assert.That(sut.FindMissingElements([1, 4, 2, 5]), Is.EqualTo([3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03731();
        Assert.That(sut.FindMissingElements([7, 8, 6, 9]), Is.Empty);
    }

    [Test]
    public void T3()
    {
        var sut = new S03731();
        Assert.That(sut.FindMissingElements([5, 1]), Is.EqualTo([2, 3, 4]));
    }
}