using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00219Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00219();
        Assert.That(sut.ContainsNearbyDuplicate([1, 2, 3, 1], 3), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00219();
        Assert.That(sut.ContainsNearbyDuplicate([1, 0, 1, 1], 1), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S00219();
        Assert.That(sut.ContainsNearbyDuplicate([1, 2, 3, 1, 2, 3], 2), Is.False);
    }
}
