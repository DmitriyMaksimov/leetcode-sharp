using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03147))]
public class S03147Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03147();
        Assert.That(sut.MaximumEnergy([5, 2, -10, -5, 1], 3), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03147();
        Assert.That(sut.MaximumEnergy([-2, -3, -1], 2), Is.EqualTo(-1));
    }
}