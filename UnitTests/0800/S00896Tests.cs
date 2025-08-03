using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00896Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00896();
        Assert.That(sut.IsMonotonic([1, 2, 2, 3]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00896();
        Assert.That(sut.IsMonotonic([6, 5, 4, 4]), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S00896();
        Assert.That(sut.IsMonotonic([1, 3, 2]), Is.False);
    }
}
