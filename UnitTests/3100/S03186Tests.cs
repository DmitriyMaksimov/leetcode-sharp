using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03186))]
public class S03186Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03186();
        Assert.That(sut.MaximumTotalDamage([1, 1, 3, 4]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S03186();
        Assert.That(sut.MaximumTotalDamage([7, 1, 6, 6]), Is.EqualTo(13));
    }
}