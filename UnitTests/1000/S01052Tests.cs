using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01052Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01052();
        Assert.That(sut.MaxSatisfied([1, 0, 1, 2, 1, 1, 7, 5], [0, 1, 0, 1, 0, 1, 0, 1], 3), Is.EqualTo(16));
    }

    [Test]
    public void T2()
    {
        var sut = new S01052();
        Assert.That(sut.MaxSatisfied([1], [0], 1), Is.EqualTo(1));
    }
}