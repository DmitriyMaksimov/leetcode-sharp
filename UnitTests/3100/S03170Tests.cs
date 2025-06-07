using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03170))]
public class S03170Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03170();
        Assert.That(sut.ClearStars("aaba*"), Is.EqualTo("aab"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03170();
        Assert.That(sut.ClearStars("abc"), Is.EqualTo("abc"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03170();
        Assert.That(sut.ClearStars("de*"), Is.EqualTo("e"));
    }
}
