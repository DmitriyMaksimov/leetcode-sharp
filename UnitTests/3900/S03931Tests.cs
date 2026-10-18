using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03931))]
public class S03931Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03931();
        Assert.That(sut.IsAdjacentDiffAtMostTwo("132"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03931();
        Assert.That(sut.IsAdjacentDiffAtMostTwo("129"), Is.False);
    }
}