using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02086))]
public class S02086Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02086();
        Assert.That(sut.MinimumBuckets("H..H"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02086();
        Assert.That(sut.MinimumBuckets(".H.H."), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02086();
        Assert.That(sut.MinimumBuckets(".HHH."), Is.EqualTo(-1));
    }
}