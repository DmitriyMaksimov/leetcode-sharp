using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03867))]
public class S03867Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03867();
        Assert.That(sut.GcdSum([2, 6, 4]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03867();
        Assert.That(sut.GcdSum([3, 6, 2, 8]), Is.EqualTo(5));
    }
}