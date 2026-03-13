using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03296))]
public class S03296Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03296();
        Assert.That(sut.MinNumberOfSeconds(4, [2, 1, 1]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03296();
        Assert.That(sut.MinNumberOfSeconds(10, [3, 2, 2, 4]), Is.EqualTo(12));
    }

    [Test]
    public void T3()
    {
        var sut = new S03296();
        Assert.That(sut.MinNumberOfSeconds(5, [1]), Is.EqualTo(15));
    }
}