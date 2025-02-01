using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02395Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02395();
        Assert.That(sut.FindSubarrays(new[] {4, 2, 4}), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02395();
        Assert.That(sut.FindSubarrays(new[] {1, 2, 3, 4, 5}), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S02395();
        Assert.That(sut.FindSubarrays(new[] {0, 0, 0}), Is.True);
    }
}
