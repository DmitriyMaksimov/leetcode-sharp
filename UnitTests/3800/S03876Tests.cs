using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03876))]
public class S03876Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03876();
        Assert.That(sut.UniformArray([1, 4, 7]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03876();
        Assert.That(sut.UniformArray([2, 3]), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S03876();
        Assert.That(sut.UniformArray([4, 6]), Is.True);
    }
}